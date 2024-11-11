using Application.Orders.Commands.DeleteOrder;
using Application.Orders.Queries.GetOrderList;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class OrderController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<OrderListViewModel>> GetAll()
        {
            var query = new GetOrderListQuery
            {
                UserId = _userId
            };
            var vm = await Mediator.Send(query);
            return Ok(vm);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteOrderCommand
            {
                Id = id
            };
            await Mediator.Send(command);
            return Ok();
        }
    }
}
