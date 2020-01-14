using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesla.Data.Entities;
using Tesla.Models;

namespace Tesla.MappingConfigurations
{
    public class ReviewProfile : Profile 
    {
        public ReviewProfile()
        {
            // Default mapping when property names are same
            CreateMap<Review, ReviewModel>();

            // Mapping when property names are different
            //CreateMap<User, UserViewModel>()
            //    .ForMember(dest =>
            //    dest.FName,
            //    opt => opt.MapFrom(src => src.FirstName))
            //    .ForMember(dest =>
            //    dest.LName,
            //    opt => opt.MapFrom(src => src.LastName));
        }
    }
}
