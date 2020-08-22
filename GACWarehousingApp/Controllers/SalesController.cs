using GACWarehousingApp.Models;
using GACWarehousingApp.Models.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace GACWarehousingApp.Controllers
{
    [Route("api/salesOrder")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private readonly IDataRepository<SalesOrder> _dataRepository;

        public SalesController(IDataRepository<SalesOrder> dataRepository)
        {
            _dataRepository = dataRepository;
        }

        

        /// <summary>
        /// Insert Order By Id
        /// </summary>
        /// <param name="salesOrders"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post([FromBody] SalesOrder salesOrders)
        {

            try
            {
                if (salesOrders == null)
                {
                    return BadRequest("Sale Order is null.");
                }

                _dataRepository.Add(salesOrders);
                //return CreatedAtRoute(
                //      "Get",
                //      new { Id = salesOrders.OrderID },
                //      salesOrders);
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest("Error Occurred");
            }
            
        }

    }
}
