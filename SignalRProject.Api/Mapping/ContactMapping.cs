using AutoMapper;
using SignalRProject.DtoLayer.ContactDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.Api.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping() 
        {
            CreateMap<Contact,ResultContactDto>().ReverseMap();
            CreateMap<Contact,CreateContactDto>().ReverseMap();
            CreateMap<Contact,GetContactDto>().ReverseMap();
            CreateMap<Contact,UpdateContactDto>().ReverseMap();
        }
    }
}
