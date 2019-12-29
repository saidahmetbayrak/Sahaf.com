using Sahaf.BLL.Abstract;
using Sahaf.DAL.Abstract;
using Sahaf.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahaf.BLL.Concrete
{
    public class MessageService : IMessageService
    {
        IMessageDAL _messageDAL;
        public MessageService(IMessageDAL messageDAL)
        {
            _messageDAL = messageDAL;
        }

        public void Delete(Message entity)
        {
            _messageDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Delete(Get(entityID));
        }

        public Message Get(int entityID)
        {
            return _messageDAL.Get(a => a.ID == entityID);
        }

        public ICollection<Message> GetAll()
        {
            return _messageDAL.GetAll();
        }

        public void Insert(Message entity)
        {
            _messageDAL.Add(entity);
        }

        public void Update(Message entity)
        {
            _messageDAL.Update(entity);
        }
    }
}
