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
    public class MessageController:ApiController
    {
        [Route("api/Message/")]
        [HttpPost]
        public HttpResponseMessage Add(MessageModel p)
        {
            var result = MessageService.Create(p);
            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Message sent");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Failed");
            }

        }


        [Route("api/Message/Get/{id1}/{id2}")]
        [HttpGet]
        public HttpResponseMessage Get(int id1,int id2)
        {
            var msg = MessageService.Get(id1,id2);
            if (msg == null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "No msg found");
            }
            return Request.CreateResponse(HttpStatusCode.OK, msg);

        }

    }
}