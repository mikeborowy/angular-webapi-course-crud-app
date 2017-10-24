using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetWebAPI.Models.Students;
using System.Web.Http;
using System.Net.Http;

namespace Angular4DotNetWebAPI.Controllers
{
    public class AccountController : ApiController
    {
        public HttpResponseMessage Post(HttpRequestMessage request, StudentVm student)
        {
            //_studentregistrationService.Register(student);
            //return new HttpResponseMessage(HttpStatusCode.InternalServerError);

            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            return request.CreateResponse(HttpStatusCode.BadRequest, GetErrorMessage());
        }

        private IEnumerable<string> GetErrorMessage (){
            return ModelState.Values.SelectMany(x => x.Errors.Select( e => e.ErrorMessage) );
        }
    }
}