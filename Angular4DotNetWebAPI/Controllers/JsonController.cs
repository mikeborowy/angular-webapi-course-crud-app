using System;
using System.Web;
using System.Net;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Angular4DotNetWebAPI.Controllers
{
    public class JsonController : Controller
    {
        protected ActionResult Json(object data, JsonRequestBehavior behavior = JsonRequestBehavior.DenyGet)
        {
            JsonSerializerSettings jsonSerializedSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            if (Request.RequestType == WebRequestMethods.Http.Get && behavior == JsonRequestBehavior.DenyGet)
                throw new InvalidOperationException("GET is not permitted for this operation");

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(data, jsonSerializedSettings),
                ContentType = "application/json"
            };

            return jsonResult;
        }
    }
}