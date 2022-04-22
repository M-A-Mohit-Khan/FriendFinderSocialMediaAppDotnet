using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class MessageRepo : IMessageRepository<Message, int, int>
    {
        friend_finderEntities db;

        public MessageRepo(friend_finderEntities db)
        {
            this.db = db;
        }
        public bool Add(Message e)
        {
            var m = new Message();
            m.Msg = e.Msg;
            m.Sender_id = e.Sender_id;
            m.Receiver_id = e.Receiver_id;
            
            db.Messages.Add(m);

            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public List<Message> Get(int id1, int id2)
        {
            var data = (from u in db.Messages where (u.Sender_id == id1||u.Sender_id==id2)&& (u.Receiver_id == id1 || u.Receiver_id == id2) select u).ToList();
            return data;
        }
    }
}
