using Application.Common.Mapping;
using Application.Orders.Commands.UpdateOrder;
using AutoMapper;

namespace WebApi.Models
{
    public class UpdateOrderModel : IMapWith<UpdateOrderCommand>
    {
        public string? Note { get; set; }
        public string? Adress { get; set; }
        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateOrderCommand, UpdateOrderModel>()
                .ForMember(orderModel => orderModel.Adress, opt => opt.MapFrom(order => order.Adress))
                .ForMember(orderModel => orderModel.Price, opt => opt.MapFrom(order => order.Price))
                .ForMember(orderModel => orderModel.Note, opt => opt.MapFrom(order => order.Note));
        }
    }
}
