//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using FoodStore.Models.DTO;

//namespace FoodStore.Models
//{
//    public class CommentsRepo
//    {
//        FoodStoreEntities context = new FoodStoreEntities();

//        public IQueryable<Comment> GetAll(int? productid)
//        {

//            return context.Comments.OrderBy(x => x.CustomerId).Where(x => x.ProductId == productid);
//        }

//        public commentViewModel AddComment(commentDTO comment)
//        {
//            var _comment = new Comment()
//            {
//                ParentID = comment.parentId,
//                CommentMsg = comment.commentText,
//                UserName = comment.username,
//                Cre = DateTime.Now,
//                ProductId = comment.productId,
//            };

//            context.Comments.Add(_comment);
//            context.SaveChanges();
//            return context.Comments.Where(x => x.CommentId == _comment.CommentId)
//                    .Select(x => new commentViewModel
//                    {
//                        commentId = x.CommentId,
//                        commentText = x.CommentText,
//                        parentId = (int)x.ParentId,
//                        createdDate = (DateTime)x.CreateDate,
//                        username = x.UserName,
//                        productId = (int)x.ProductId

//                    }).FirstOrDefault();
//        }
//    }
//}