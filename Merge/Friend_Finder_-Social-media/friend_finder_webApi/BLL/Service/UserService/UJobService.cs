using AutoMapper;
using BEL.Entity.UserEntity;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service.UserService
{
    public class UJobService
    {
        public static List<UJobModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Job, UJobModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<UJobModel>>(DataAccessFactory.UJobDataAccess().Get());
            return data;
        }



        public static UJobModel Details(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Job, UJobModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<UJobModel>(DataAccessFactory.UJobDataAccess().Get(id));

            return data;
        }
    }
}
