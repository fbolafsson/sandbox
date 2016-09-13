using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FriendlyNeighborhoodApi.Models;

namespace FriendlyNeighborhoodApi.Controllers
{
    public class NeighborhoodController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var message = new GreatModel { Id = 1, Message = "Well, well, well!"};
            return Request.CreateResponse(HttpStatusCode.OK, message);
        }
    }
}
