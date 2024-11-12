using Application.Common.Mapping;
using AutoMapper;
using Domain;

namespace Application.Orders.Queries.GetOrder
{
    public class OrderDetailsViewModel :IMapWith<Order>
    {
        public Guid Id { get; set; }
        public string? Adress { get; set; }
        public string? Created { get; set; }
        public string? Note { get; set; }

        public decimal Price { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Order, OrderDetailsViewModel>()
                .ForMember(orderVm => orderVm.Id, opt => opt.MapFrom(order => order.Id))
                .ForMember(orderVm => orderVm.Adress, opt => opt.MapFrom(order => order.Adress))
                .ForMember(orderVm => orderVm.Price, opt => opt.MapFrom(order => order.Price))
                .ForMember(orderVm => orderVm.Created, opt => opt.MapFrom(order => order.Created))
                .ForMember(orderVm => orderVm.Note, opt => opt.MapFrom(order => order.Note));
                
        }
    }
}
