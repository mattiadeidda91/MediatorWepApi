using AutoMapper;
using MediatorWepApi.Models;
using MediatorWepApi.Models.Requests;

namespace MediatorWepApi.Mapping
{
    public class Mapping : Profile
    {
        public Mapping() 
        {
            _ = CreateMap<Event, AddEventRequest>().ReverseMap();
        }
    }
}
