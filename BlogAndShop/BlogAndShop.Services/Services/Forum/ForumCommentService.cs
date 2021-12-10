using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.Common;
using BlogAndShop.Data.Data.Forum;
using BlogAndShop.Data.ViewModel.Admin;
using BlogAndShop.Services.Services.Main;
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

        #endregion
        #region Utilities


        #endregion
        #region Ctor
        public ForumCommentService(ApplicationDbContext db) : base(db)
        {
        }
        #endregion


    }
}