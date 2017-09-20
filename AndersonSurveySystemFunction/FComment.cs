using AndersonSurveySystemData;
using AndersonSurveySystemEntity;
using AndersonSurveySystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndersonSurveySystemFunction
{
    public class FComment : IFComment
    {
        private IDComment _iDComment;

        public FComment()
        {
            _iDComment = new DComment();
        }

        #region CREATE
        public Comment Create(Comment comment)
        {
            EComment eComment = EComment(comment);
            eComment = _iDComment.Create(eComment);
            return (Comment(eComment));
        }
        #endregion

        #region READ
        public Comment Read(int CommentId)
        {
            EComment eComment = _iDComment.Read<EComment>(a => a.CommentId == CommentId);
            return Comment(eComment);
        }

        public List<Comment> List()
        {
            List<EComment> eComment = _iDComment.List<EComment>(a => true);
            return Comments(eComment);
        }

        #endregion

        #region UPDATE
        public Comment Update(Comment comment)
        {
            var eComment = _iDComment.Update(EComment(comment));
            return (Comment(eComment));
        }
        #endregion

        #region DELETE
        public void Delete(Comment comment)
        {
            _iDComment.Delete(EComment(comment));
        }
        #endregion
        #region OTHER FUNCTION
        private List<Comment> Comments(List<EComment> eComments)
        {
            var returnComments = eComments.Select(a => new Comment
            {
                CommentId = a.CommentId,
                Comments = a.Comments,


            });

            return returnComments.ToList();
        }

        private EComment EComment(Comment comment)
        {
            EComment returnEComment = new EComment
            {
                CommentId = comment.CommentId,
                Comments = comment.Comments,


            };
            return returnEComment;
        }

        private Comment Comment(EComment eComment)
        {
            Comment returnComment = new Comment
            {
                CommentId = eComment.CommentId,
                Comments = eComment.Comments,


            };
            return returnComment;
        }

        public bool IsMethodAccessible(string username, List<string> list)
        {
            throw new NotImplementedException();
        }

        public object ReadUser(string username)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}