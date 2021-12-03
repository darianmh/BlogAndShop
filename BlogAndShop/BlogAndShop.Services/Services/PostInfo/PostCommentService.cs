using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogAndShop.Data.Context;
using BlogAndShop.Data.Data.PostInfo;
using BlogAndShop.Data.ViewModel.PostInfo;
using BlogAndShop.Services.Services.Main;
using BlogAndShop.Services.Services.User.Identity;
using Microsoft.EntityFrameworkCore;

namespace BlogAndShop.Services.Services.PostInfo
{
    public class PostCommentService : MainService<PostComment>, IPostCommentService
    {
        #region Fields

        private readonly ApplicationUserManager _applicationUserManager;
        #endregion
        #region Methods

        public async Task<List<PostComment>> GetPostComments(int postId)
        {
            return await Queryable.Where(x => x.PostId == postId).ToListAsync();
        }

        public async Task<List<CommentModel>> GetPostCommentsModel(int postId)
        {
            var comments = await GetPostComments(postId);
            return await CreateCommentsModel(comments);
        }


        #endregion
        #region Utilities


        private async Task<List<CommentModel>> CreateCommentsModel(List<PostComment> comments)
        {
            //نظرات تایید شده
            comments = comments.Where(x => x.IsAccepted).ToList();
            var parents = comments.Where(x => x.ParentId == null).ToList();
            var children = comments.Where(x => x.ParentId != null).ToList();
            var result = new List<CommentModel>();
            foreach (var parent in parents)
            {
                var tempChildren = await GetChildrenComments(parent, children);
                var temp = new CommentModel()
                {
                    Id = parent.Id,
                    ChildrenComments = tempChildren,
                    DateTime = parent.CreateDateTime,
                    OwnerName = await _applicationUserManager.GetUSerDisplayNameAsync(parent.OwnerId.ToString()),
                    Text = parent.Text
                };
                result.Add(temp);
            }
            return result;
        }
        /// <summary>
        /// پیدا کردن تمام زیر مجموعه های یک کامنت
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="children"></param>
        /// <returns></returns>
        private async Task<List<CommentModel>> GetChildrenComments(PostComment parent, List<PostComment> children)
        {
            var result = new List<CommentModel>();
            foreach (var postComment in children)
            {
                if (postComment.ParentId == parent.Id)
                {
                    var model = new CommentModel
                    {
                        Id = postComment.Id,
                        DateTime = postComment.CreateDateTime,
                        OwnerName = await _applicationUserManager.GetUSerDisplayNameAsync(
                            user: postComment.OwnerId.ToString()),
                        Text = postComment.Text
                    };
                    result.Add(model);
                    var temp = await GetChildrenComments(postComment, children);
                    result.AddRange(temp);
                }
            }
            return result;
        }
        #endregion
        #region Ctor
        public PostCommentService(ApplicationDbContext db, ApplicationUserManager applicationUserManager) : base(db)
        {
            _applicationUserManager = applicationUserManager;
        }
        #endregion


    }
}