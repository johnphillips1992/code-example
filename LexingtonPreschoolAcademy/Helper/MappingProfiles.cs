using AutoMapper;
using LexingtonPreschoolAcademy.Dto;
using LexingtonPreschoolAcademy.Models;

namespace LexingtonPreschoolAcademy.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Class, ClassDto>();
            CreateMap<StudentClass, StudentClassDto>();
        }
    }
}
