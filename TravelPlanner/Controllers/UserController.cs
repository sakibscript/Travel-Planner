using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TravelPlanner.Controllers
{
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("api/user/add")]
        public HttpResponseMessage Add (UserDTO u)
        {
            var data = UserService.Add (u);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/user/{id}")]
        public HttpResponseMessage View(int id)
        {
            var data = UserService.View(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/user/all")]
        public HttpResponseMessage View()
        {
            var data = UserService.View();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/user/edit")]
        public HttpResponseMessage Edit(UserDTO u)
        {
            var data = UserService.Edit(u);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/user/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        

    }
}
