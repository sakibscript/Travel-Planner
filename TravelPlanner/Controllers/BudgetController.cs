using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TravelPlanner.Controllers
{
    public class BudgetController : ApiController
    {
        [HttpPost]
        [Route("api/trip/budget/add")]
        public HttpResponseMessage Add(BudgetDTO b)
        {
            try
            {
                var data = BudgetService.Add(b);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/budget/{id}")]
        public HttpResponseMessage View(int id)
        {
            try
            {
                var data = BudgetService.View(id);
                if (data == null)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Budget not found.");
                }
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/budget/all")]
        public HttpResponseMessage View()
        {
            try
            {
                var data = BudgetService.View();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/trip/budget/edit")]
        public HttpResponseMessage Edit(BudgetDTO b)
        {
            try
            {
                var data = BudgetService.Edit(b);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/trip/budget/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = BudgetService.Delete(id);
                if (!data)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Budget not found.");
                }
                return Request.CreateResponse(HttpStatusCode.OK, "Budget deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/budget/totalBudget/{tripId}")]
        public HttpResponseMessage GetTotalBudget(int tripId)
        {
            try
            {
                var data = BudgetService.GetTotalBudget(tripId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/budget/getOverBudgetTrips")]
        public HttpResponseMessage GetOverBudgetTrips()
        {
            try
            {
                var data = BudgetService.GetOverBudgetTrips();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/trip/budget/getAverageBudgetPerTraveler/{tripId}")]
        public HttpResponseMessage GetAverageBudgetPerTraveler(int tripId)
        {
            try
            {
                var data = BudgetService.GetAverageBudgetPerTraveler(tripId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
