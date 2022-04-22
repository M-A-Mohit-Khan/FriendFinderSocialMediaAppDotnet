using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace FriendFinder.Controllers
{
    public class JobController: ApiController
    {
        [Route("api/Job/All")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var job = JobService.Get();
            if(job.Count()==0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "No job found");
            }
            return Request.CreateResponse(HttpStatusCode.OK, job);
        }

        [Route("api/Job/Details/{id}")]
        [HttpGet]
        public HttpResponseMessage Details(int id)
        {
            var job = JobService.Details(id);
            if (job == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
            return Request.CreateResponse(HttpStatusCode.OK, job);

        }
    }
}