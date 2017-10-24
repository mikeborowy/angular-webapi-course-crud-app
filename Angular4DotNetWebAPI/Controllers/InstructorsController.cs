using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Angular4DotNetWebAPI.Models.Registration;
using System.Web.Http;
using Angular4DotNetWebAPI.Models.Instructors;

namespace Angular4DotNetWebAPI.Controllers
{
    public class InstructorsController : ApiController
    {
        private RegistrationVmBuilder _registrationVmBuilder = new RegistrationVmBuilder();

        public InstructorVm[] Get()
        {
            return _registrationVmBuilder.GetInstructorsVms();
        }
    }
}