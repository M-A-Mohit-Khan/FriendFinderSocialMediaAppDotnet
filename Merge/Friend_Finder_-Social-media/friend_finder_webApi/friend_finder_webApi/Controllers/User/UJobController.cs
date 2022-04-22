using BLL.Service.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace friend_finder_webApi.Controllers.User
{
    public class UJobController : ApiController
    {
        [Route("api/User/Job/All")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            var job = UJobService.Get();
            if (job.Count() == 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "No job available right now");
            }
            return Request.CreateResponse(HttpStatusCode.OK, job);
        }

        [Route("api/Job/Details/{id}")]
        [HttpGet]
        public HttpResponseMessage Details(int id)
        {
            var job = UJobService.Details(id);
            if (job == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }
            return Request.CreateResponse(HttpStatusCode.OK, job);

        }
        
    }
}