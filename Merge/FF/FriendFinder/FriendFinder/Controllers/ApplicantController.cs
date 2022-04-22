using BEL.Entity;
using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FriendFinder.Controllers
{
    public class ApplicantController: ApiController
    {

        [Route("api/Applicant/")]
        [HttpPost]
        public HttpResponseMessage Add(ApplicantModel p)
        {
            var result = UserService.Create(p);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Added successfully");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Added");
            }

        }

        [Route("api/Applicants/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            var result = UserService.Delete(id);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Not Deleted");
            }
        }
    }
}