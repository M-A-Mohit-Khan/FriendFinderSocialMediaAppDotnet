using AutoMapper;
using BEL.Entity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class MessageService
    {

        public static bool Create(MessageModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MessageModel, Message>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Message>(n);
            var result = DataAccessFactory.MessageDataAccess().Add(data);
            return result;
        }


        public static List<MessageModel> Get(int id1,int id2)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Message, MessageModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<MessageModel>>(DataAccessFactory.MessageDataAccess().Get(id1,id2));
            return data;
        }
    }
}
