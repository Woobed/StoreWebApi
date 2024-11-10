using Application.Common.Mapping;
using AutoMapper;
using Domain;

namespace Application.Orders.Queries.GetOrderList
{
    public class OrderViewModel : IMapWith<Order>
    {
        public Guid Id { get; set; }

        public string Adress { get; set; }
        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Order, OrderViewModel>()
                .ForMember(orderVm => orderVm.Id, opt => opt.MapFrom(order => order.Id))
                .ForMember(orderVm => orderVm. Adress, opt => opt.MapFrom(order=>order.Adress))
                .ForMember(orderVm => orderVm.Price, opt => opt.MapFrom(order => order.Price));
        }
    }
}
