using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetWebAPI.Models.Courses;
using Angular4DotNetWebAPI.Models.Registration;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Web.Http;

namespace Angular4DotNetWebAPI.Controllers
{
    public class CoursesController : ApiController
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public CoursesVm[] Get()
        {
            return _registrationVmBuilder.GetCoursesVms();
        }
    }
}