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
            CreateMap<RoomImageDTO, RoomImage>().ReverseMap();
            CreateMap<BnBImageDTO, BnBImage>().ReverseMap();
        }
    }
}
