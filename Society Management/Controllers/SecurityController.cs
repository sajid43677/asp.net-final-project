using bll.DTOs;
using bll.Services;
using BLL.DTOs;
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


        [HttpPost]
        [Route("api/security/add")]

        public HttpResponseMessage Create(SecSecurityDTO security)
        {
            try
            {
                var data = SecurityService.AddSecurity(security);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/security/update")]

        public HttpResponseMessage UpdateSecurity(SecSecurityDTO security)
        {
            try
            {
                var data = SecurityService.Update(security);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/security/delete/{id}")]
        public HttpResponseMessage DeleteRepair(int id)
        {
            try
            {
                var data = SecurityService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        /// Shift start


        [HttpGet]
        [Route("api/shift")]
        public HttpResponseMessage ShiftList()
        {
            try
            {
                var data = SecShiftService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/shift/{id}")]
        public HttpResponseMessage shiftwithId(int id)
        {
            try
            {
                var data = SecShiftService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        

        [HttpPost]
        [Route("api/shift/add")]
        public HttpResponseMessage AddShift(SecShiftDTO shift)
        {
            try
            {
                var data = SecShiftService.AddShift(shift);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/shift/update")]
        public HttpResponseMessage UpdateShift(SecShiftDTO shift)
        {
            try
            {
                var data = SecShiftService.Update(shift);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/shift/delete/{id}")]
        public HttpResponseMessage DeleteShift(int id)
        {
            try
            {
                var data = SecShiftService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
