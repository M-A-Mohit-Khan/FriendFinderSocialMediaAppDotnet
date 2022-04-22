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
    public class JobService
    {
        public static List<JobModel> Get()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Job, JobModel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<List<JobModel>>(DataAccessFactory.JobDataAccess().Get());
            return data;
        }


        public static JobModel Details(int id)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Job, JobModel>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<JobModel>(DataAccessFactory.JobDataAccess().Get(id));

            return data;
        }
    }
}
