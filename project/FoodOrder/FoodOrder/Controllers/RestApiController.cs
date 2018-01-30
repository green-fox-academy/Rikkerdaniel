using FoodOrder.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOrder.Controllers
{
    [Route("rest")]
    public class RestApiController :Controller
    {
        public RestApiController(OrderFoodService orderFoodService)
        {
            OrderFoodService = orderFoodService;
        }

        public OrderFoodService OrderFoodService { get; set; }

        [HttpGet("")]
        public IActionResult RestThing()
        {
            return Json(OrderFoodService.OrderFoodRepository.ListOfOrders());
        }
    }
}
