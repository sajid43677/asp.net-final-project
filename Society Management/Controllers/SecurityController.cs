using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SocietyManApp.Controllers
{
    public class SecurityController : ApiController
    {
        [HttpGet]
        [Route("api/security")]

        public HttpResponseMessage Securitys()
        {
            try
            {
                var data = SecurityService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/security/{id}")]

        public HttpResponseMessage SecuritywithId(int id)
        {
            try
            {
                var data = SecurityService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/security/{id}/reports")]

        public HttpResponseMessage ReportswithId(int id)
        {
            try
            {
                var data = SecurityService.GetwithReport(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
