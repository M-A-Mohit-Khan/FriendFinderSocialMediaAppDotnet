﻿using DAL.Database;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class ApplicantRepo : IApplicantRepository<Applicant, int>
    {

        friend_finderEntities db;

        public ApplicantRepo(friend_finderEntities db)
        {
            this.db = db;
        }

        public bool Add(Applicant e)
        {
            var a = new Applicant();
            a.Job_id = e.Job_id;
            a.User_id = e.User_id;
            db.Applicants.Add(a);

            if (db.SaveChanges() != 0)
            {
                return true;
            }
            return false;
        }

        public bool delete(int id)
        {
            var data = (from u in db.Applicants where u.Id == id select u).FirstOrDefault(); ;
            if (data != null)
            {
                db.Applicants.Remove(data);
                db.SaveChanges();
                return true;
            }

            return false;
        }

        /*public List<Applicant> Get(int id)
        {
            var data = (from a in db.Applicants where a.Job_id == id select a).ToList();
            return data;
        }*/


    }

}
