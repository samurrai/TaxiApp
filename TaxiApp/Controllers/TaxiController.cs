using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using TaxiApp.DataAccess;
using TaxiApp.Models;

namespace TaxiApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxiController : ControllerBase
    {
        private readonly OrdersContext context;

        public TaxiController(OrdersContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetOrders()
        {
            return new JsonResult(JsonConvert.SerializeObject(context.Orders));
        }

        [HttpPost]
        public IActionResult PostOrder(string name, int cost, double location, State state)
        {
            Client client = new Client();
            client.Name = name;
            Order order = new Order() { 
                Cost = cost,
                Location = location,
                State = state,
                Client = client
            };
            context.Users.Add(client);
            context.Orders.Add(order);
            return Ok();
        }
    }
}