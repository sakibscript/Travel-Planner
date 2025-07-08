using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TravelPlanner.Controllers
{
    public class PackingController : ApiController
    {
        [HttpGet]
        [Route("api/trip/packing/add")]
        public HttpResponseMessage Add(PackingDTO p)
        {
            try
            {
                var data = PackingService.Add(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/packing/{id}")]
        public HttpResponseMessage View(int id)
        {
            try
            {
                var data = PackingService.View(id);
                if (data == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Packing item not found.");
                }
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/packing/all")]
        public HttpResponseMessage View()
        {
            try
            {
                var data = PackingService.View();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/trip/packing/edit")]
        public HttpResponseMessage Edit(PackingDTO p)
        {
            try
            {
                var data = PackingService.Edit(p);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/trip/packing/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = PackingService.Delete(id);
                if (!data)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Packing item not found.");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Packing item deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/packing/getPackingHistory/{userId}")]
        public HttpResponseMessage GetPackingHistory(int userId)
        {
            try
            {
                var data = PackingService.GetPackingHistory(userId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/packing/duplicatePackingList/{sourceTripId}/{destinationTripId}")]
        public HttpResponseMessage DuplicatePackingList(int sourceTripId, int destinationTripId)
        {
            try
            {
                var data = PackingService.DuplicatePackingList(sourceTripId, destinationTripId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
