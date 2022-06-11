using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using CommonConfiguration.Core.Data.Data.Common;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Data.ViewModel.Forum;

using BlogAndShop.Services.Services.Mapper;
using CommonConfiguration.Core.Services.Main;
using CommonConfiguration.Core.Services.User.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.Forum
{
    public class ForumCommentService : MainService<ForumComment>, IForumCommentService
    {
        #region Fields

        #endregion
        #region Methods
        public async Task<List<NewNotificationModel>> GetNewComments()
        {
            var newMessages = await Queryable.Where(x => x.MessageStatus == MessageStatus.New).ToListAsync();
            return newMessages.Select(x => new NewNotificationModel
            {
                Id = x.ForumId,
                Date = x.CreateDateTime,
                NewNotificationType = NewNotificationType.Forum,
                Text = x.Text
            }).ToList();
        }

        public async Task<List<ForumComment>> GetCommentsByTitle(int forumTitleId)
        {
            var comments = await Queryable.Where(x => x.ForumId == forumTitleId).ToListAsync();
            return comments;
        }

        public async Task<List<ForumCommentModel>> GetCommentsByTitleInModel(int forumTitleId)
        {
            var comments = await GetCommentsByTitle(forumTitleId);
            return comments.Select(x => x.ToModel()).ToList();
        }

        public async Task<List<ForumCommentModel>> GetAcceptedCommentsByTitleInModel(int forumTitleId,
            ApplicationUserManager userManager)
        {
            var comments = await GetAcceptedCommentsByTitle(forumTitleId);
            return comments.Select(async x => await ToShowModel(x, userManager)).Select(x => x.Result).ToList();
        }



        public async Task<List<ForumComment>> GetAcceptedCommentsByTitle(int forumTitleId)
        {
            var comments = await Queryable.Where(x => x.ForumId == forumTitleId && x.IsAccepted).ToListAsync();
            return comments;
        }

        public async Task<List<ForumCommentModel>> GetRecentComments(ApplicationUserManager applicationUserManager)
        {
            var all = await Queryable.OrderBy(x => x.CreateDateTime).Reverse().Take(2)
                .ToListAsync();
            var result = new List<ForumCommentModel>();
            foreach (var item in all)
            {
                var temp = item.ToModel();
                if (temp.UserId != null)
                    temp.UserName = await applicationUserManager.GetUSerDisplayNameAsync((int)temp.UserId);
                result.Add(temp);
            }

            return result;
        }

        #endregion
        #region Utilities

        private async Task<ForumCommentModel> ToShowModel(ForumComment forumComment,
            ApplicationUserManager applicationUserManager)
        {
            var model = forumComment.ToModel();
            if (forumComment.UserId != null)
                model.UserName = await applicationUserManager.GetUSerDisplayNameAsync((int)forumComment.UserId);
            return model;
        }

        #endregion
        #region Ctor
        public ForumCommentService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}