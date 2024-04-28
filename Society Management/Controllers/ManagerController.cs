using bll.DTOs;
using bll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Society_Management.Controllers
{
    public class ManagerController : ApiController
    {
        [HttpGet]
        [Route("api/repair")]

        public HttpResponseMessage Repairs()
        {
            try
            {
                var data = manRepairService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/repair/{id}")]
        public HttpResponseMessage RepairwithId(int id)
        {
            try
            {
                var data = manRepairService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/repair/add")]

        public HttpResponseMessage AddRepair(manRepairDTO repair)
        {
            try
            {
                var data = manRepairService.Create(repair);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/repair/update")]

        public HttpResponseMessage UpdateRepair(manRepairDTO repair)
        {
            try
            {
                var data = manRepairService.Update(repair);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/repair/delete/{id}")]
        public HttpResponseMessage DeleteRepair(int id)
        {
            try
            {
                var data = manRepairService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
