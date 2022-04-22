using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class JobRepo : IJobRepository<Job, int>
    {
        friend_finderEntities db;

        public JobRepo(friend_finderEntities db)
        {
            this.db = db;
        }


        public List<Job> Get()
        {
            var data = db.Jobs.ToList();
            return data;
        }

        public Job Get(int id)
        {
            var data = (from u in db.Jobs where u.Id == id select u).FirstOrDefault();
            return data;
        }
    }
}
