using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TourAndTravel.Models;

namespace TourAndTravel.Controllers
{

    public class CustomersController : ApiController
    {
        [HttpGet]
        [Route ("customer/all/TourPackage")]
        public HttpResponseMessage Customers()
        {
            try
            {
                var data = TourPackageService.GetAllTourPackages();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("customer/all/CustomerList")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CustomerService.GetCustomerList();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("Customer/{id}")]
        public HttpResponseMessage CustomerList(int CustomerId)
        {
            try
            {
                var data = CustomerService.Get(CustomerId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/Travelar/Login")]
        public HttpResponseMessage Login(LoginModel loginModel)
        {
            try
            {
                bool isAuthenticated = AuthService.Authenticate(loginModel.Username, loginModel.Password);

                if (isAuthenticated)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Login successful");
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, "Invalid credentials");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }



    }

}

