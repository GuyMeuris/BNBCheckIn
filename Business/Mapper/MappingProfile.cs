using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Data;
using ModelsDTO;

namespace Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BnBDTO, BnB>().ReverseMap();
            CreateMap<CreateBnBDTO, BnB>().ReverseMap();
            CreateMap<RoomDTO, Room>().ReverseMap();
            CreateMap<CreateRoomDTO, Room>().ReverseMap();
            CreateMap<ContactDTO, Contact>().ReverseMap();
            CreateMap<AmenityDTO, Amenity>().ReverseMap();
            CreateMap<CreateAmenityDTO, Amenity>().ReverseMap();
            CreateMap<Amenity, AmenityDTO>().ForMember(x => x.BnBs, opt => opt.MapFrom(c => c.BnBs));
            CreateMap<Amenity, AmenityDTO>().ForMember(x => x.Rooms, opt => opt.MapFrom(c => c.Rooms));
            CreateMap<RoomImageDTO, RoomImage>().ReverseMap();
            CreateMap<BnBImageDTO, BnBImage>().ReverseMap();
            CreateMap<RoomOrderDetailsDTO, RoomOrderDetails>().ReverseMap();
            CreateMap<RoomOrderDetails, RoomOrderDetailsDTO>().ForMember(x => x.BnBRoomDTO, opt => opt.MapFrom(c => c.BnBRoom));
            CreateMap<RoomOrderDetailsDTO, RoomOrderDetails>();
        }
    }
}
