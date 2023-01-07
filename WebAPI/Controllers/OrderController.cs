using Business.Abstract;
using Entities.Concrete.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _orderService.GetAll();
            if(result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("GetOrderDetail")]
        public IActionResult GetOrderDetail()
        {
            var result = _orderService.GetOrderDetails();
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
       

        [HttpPost("Add")]
        public IActionResult Add(Order order)
        {
            var result = _orderService.Add(order);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("Update")]
        public IActionResult Update(Order order)
        {
            var result = _orderService.Update(order);
            if (result.Succes)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
