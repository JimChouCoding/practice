using CRUD.Models;
using CRUD.Models.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace CRUD.Controllers
{
    public class OrdersDataController : Controller
    {
        private readonly NorthwindContext _northwindContext;

        public OrdersDataController(NorthwindContext northwindContext)
        {
            _northwindContext = northwindContext;
        }
        //Post: OrdersData/List
        [HttpPost]
        public async Task<string> List()
        {
            var orderlist = await _northwindContext.Orders.ToListAsync();
            return JsonConvert.SerializeObject(orderlist);
        }

        //POST: /OrdersData/Update/10253
        [HttpPost]
        public async Task<string> UpdateOrders(int id, [FromBody] OrderUpdateDto orderUpdateDto)
        {
            if (orderUpdateDto == null) return "false";

            var orders = await _northwindContext.Orders.FirstOrDefaultAsync(o => o.OrderId == id);

            if (orders == null) return "false";
            
            //只更新出貨資訊
            orders.ShipName = orderUpdateDto.ShipName;
            orders.ShipAddress = orderUpdateDto.ShipAddress;
            orders.ShipCity = orderUpdateDto.ShipCity;
            orders.ShipRegion = orderUpdateDto.ShipRegion;
            orders.ShipPostalCode = orderUpdateDto.ShipPostalCode;
            orders.ShipCountry = orderUpdateDto.ShipCountry;
            orders.ShipVia = orderUpdateDto.ShipVia;
            orders.Freight = orderUpdateDto.Freight;
            orders.RequiredDate = orderUpdateDto.RequiredDate;
            orders.ShippedDate = orderUpdateDto.ShippedDate;

            await _northwindContext.SaveChangesAsync();
            return "true";
        }



        //POST: /OrdersData/Update/10253
        [HttpPost]
        public string CreateOrders(int id, [FromBody] OrderUpdateDto orderUpdateDto)
        {

            return "true";
        }

        //POST: /OrdersData/Update/10253
        [HttpPost]
        public string DeleteOrders(int id, [FromBody] OrderUpdateDto orderUpdateDto)
        {

            return "true";
        }
    }
}



