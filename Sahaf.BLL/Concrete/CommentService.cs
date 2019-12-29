using Sahaf.BLL.Abstract;
using Sahaf.DAL.Abstract;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.BLL.Concrete
{
    public class CommentService : ICommentService
    {
        ICommentDAL _commentDAL;
        public CommentService(ICommentDAL commentDAL)
        {
            _commentDAL=commentDAL;
        }

        public void Delete(Comment entity)
        {
            _commentDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Comment Get(int entityID)
        {
            return _commentDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Comment> GetAll()
        {
            return _commentDAL.GetAll();
        }

        public void Insert(Comment entity)
        {
            _commentDAL.Add(entity);
        }

        public void Update(Comment entity)
        {
            _commentDAL.Update(entity);
        }
    }
}
