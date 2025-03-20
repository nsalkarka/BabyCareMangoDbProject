using AutoMapper;
using BabyCareMangoDbProject.DataAccess.Entities;
using BabyCareMangoDbProject.Dtos.InstructorDtos;

namespace BabyCareMangoDbProject.Mappings
{
    public class InstructorMapping:Profile
    {
        public InstructorMapping()
        {
            CreateMap<ResultInstructorDto, Instructor>().ReverseMap();
            CreateMap<CreateInstructorDto, Instructor>().ReverseMap();
            CreateMap<UpdateInstructorDto, Instructor>().ReverseMap();
        }
        
      
    }
}
