using Application.Common.Mapping;
using Application.Orders.Commands.CreateOrder;
using AutoMapper;

namespace WebApi.Models
{
    public class CreationOrderModel:IMapWith<CreateOrderCommand>
    {
        public string? Note { get; set; }
        public string? Address{ get; set; }
        public decimal Price{ get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateOrderCommand, CreationOrderModel>()
                .ForMember(orderModel => orderModel.Note, opt => opt.MapFrom(order => order.Note))
                .ForMember(orderModel => orderModel.Address, opt => opt.MapFrom(order => order.Adress))
                .ForMember(orderModel => orderModel.Price, opt => opt.MapFrom(order => order.Price));
        }
    }
}
