using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace TravelPlanner.Controllers
{
    public class TripController : ApiController
    {
        [HttpPost]
        [Route("api/trip/add")]
        public HttpResponseMessage Add(TripDTO t)
        {
            var data = TripService.Add(t);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/trip/{id}")]
        public HttpResponseMessage View(int id)
        {
            var data = TripService.View(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpGet]
        [Route("api/trip/all")]
        public HttpResponseMessage View()
        {
            var data = TripService.View();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpPost]
        [Route("api/trip/edit")]
        public HttpResponseMessage Edit(TripDTO t)
        {
            var data = TripService.Edit(t);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [HttpDelete]
        [Route("api/trip/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var data = TripService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpPost]
        [Route("api/trip/search/{name}")]
        public HttpResponseMessage SearchByName(string name)
        {
            var data = TripService.SearchByName(name);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/trip/duration/{id}")]
        public HttpResponseMessage Duration(int id)
        {
            var data = TripService.Duration(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/trip/upcomingtrip")]
        public HttpResponseMessage UpcomingTrip()
        {
            var data = TripService.UpcomingTrip();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/trip/summary/{year}/{month}")]
        public HttpResponseMessage GetTripsAndTotals(int year, int month)
        {
            var data = TripService.GetTripsAndTotals(year, month);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/trip/getTripItineraryPdf/{tripId}")]
        public HttpResponseMessage GenerateTripPdf(int tripId)
        {
            try
            {
                var pdfData = TripService.GenerateTripItineraryPdf(tripId);

                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(pdfData)
                };

                response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/pdf");
                response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
                {
                    FileName = $"Trip_{tripId}_Itinerary.pdf"
                };

                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, $"Error generating PDF: {ex.Message}");
            }
        }

        [HttpGet]
            [Route("api/trip/getRatingDistribution")]
            public HttpResponseMessage GetRatingDistribution()
            {
                var data = TripService.GetRatingDistribution();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
        [HttpGet]
        [Route("api/trip/sort/{sortBy}/{order}")]
        public HttpResponseMessage SortBy(string sortBy, string order)
        {

            var data = TripService.SortBy(sortBy, order);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [HttpGet]
        [Route("api/trip/page/{page}/{pageSize}")]
        public HttpResponseMessage DisplayByPage(int page, int pageSize)
        {

            var data = TripService.DisplayByPage(page, pageSize);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

    }
}
