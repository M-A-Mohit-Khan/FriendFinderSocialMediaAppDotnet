using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class MessageModel
    {
        public int Id { get; set; }
        public string Msg { get; set; }
        public int Sender_id { get; set; }
        public int Receiver_id { get; set; }
    }
}
