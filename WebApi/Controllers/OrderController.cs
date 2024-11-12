using Application.Common.Exceprions;
using Application.Orders.Commands.CreateOrder;
using Application.Orders.Commands.DeleteOrder;
using Application.Orders.Commands.UpdateOrder;
using Application.Orders.Queries.GetOrder;
using Application.Orders.Queries.GetOrderList;
using AutoMapper;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : BaseController
    {
        private IMapper _mapper;

        public OrderController(IMapper mapper, IMediator mediator):base(mediator)
        {
            _mapper = mapper;

            if (Mediator == null)
            {
                throw new MediatorNotInitializedException(nameof(Mediator));
            }
        }
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
        [HttpGet("id")]
        public async Task<ActionResult<OrderDetailsViewModel>> Get(Guid id)
        {
            var query = new GetOrderDetailsQuery
            {
                UserId = _userId,
                Id = id
            };
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreationOrderModel model)
        {
            var command = _mapper.Map<CreateOrderCommand>(model);
            command.UserId = _userId;
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpPut]
        public async Task<ActionResult<Guid>> Update([FromBody] UpdateOrderModel model)
        {
            var command = _mapper.Map<UpdateOrderCommand>(model);
            command.UserId = _userId;
            var result = await Mediator.Send(command);
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteOrderCommand
            {
                Id = id,
                UserId = _userId
            };
            await Mediator.Send(command);
            return NoContent();
        }
    }
}
