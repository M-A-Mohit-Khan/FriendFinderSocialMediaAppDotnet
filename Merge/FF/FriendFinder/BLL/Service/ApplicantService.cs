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
    public class UserService
    {

        public static bool Create(ApplicantModel n)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ApplicantModel, Applicant>();
            }
            );
            var mapper = new Mapper(config);
            var data = mapper.Map<Applicant>(n);
            var result = DataAccessFactory.ApplicantDataAccess().Add(data);
            return result;
        }



        public static bool Delete(int id)
        {
            var data = DataAccessFactory.ApplicantDataAccess().delete(id);
            return data;
        }
    }
}
