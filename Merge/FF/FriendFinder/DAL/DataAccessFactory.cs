using DAL.Database;
using DAL.Interface;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static friend_finderEntities db;
        static DataAccessFactory()
        {
            db = new friend_finderEntities();
        }

        /*Post*/
        public static IPostRepository<Post, int> PostDataAccess()
        {
            return new PostRepo(db);
        }

        /*Message*/
        public static IMessageRepository<Message, int, int> MessageDataAccess()
        {
            return new MessageRepo(db);
        }

        /*Comment*/
        public static ICommentReplyRepository<Comment, int> CommentDataAccess()
        {
            return new CommentRepo(db);
        }

        /*React*/
        public static IReactRepository<React> ReactDataAccess()
        {
            return new ReactRepo(db);
        }

        /*Reply*/
        public static ICommentReplyRepository<Reply, int> ReplyDataAccess()
        {
            return new ReplyRepo(db);
        }

        /*Job*/
        public static IJobRepository<Job, int> JobDataAccess()
        {
            return new JobRepo(db);
        }

        /*Applicant*/
        public static IApplicantRepository<Applicant, int> ApplicantDataAccess()
        {
            return new ApplicantRepo(db);
        }
    }
}
