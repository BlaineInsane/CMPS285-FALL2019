using StarterProject.Api.Data;
using StarterProject.Api.Features.Majors.Dtos;
using StarterProject.Api.Features.Users;
using System.Collections.Generic;
using System.Linq;

namespace StarterProject.Api.Features.Majors
{
    public interface IMajorRepository
    {
        MajorGetDto CreateMajor(MajorCreateDto majorCreateDto);
        MajorGetDto GetMajor(int majorId);
        List<MajorGetDto> GetAllMajors();
        void DeleteMajor(int majorId);
        MajorGetDto EditMajor(int id, MajorEditDto majorUpdateDto);
    }

    public class MajorRepository : IMajorRepository
    {
        private readonly DataContext _context;

        public MajorRepository(DataContext context)
        {
            _context = context;
        }

        public MajorGetDto CreateMajor(MajorCreateDto majorCreateDto)
        {
            var major = new Major
            {
                MajorName = majorCreateDto.MajorName
            };

            _context.Set<Major>().Add(major);
            _context.SaveChanges();

            var majorGetDto = new MajorGetDto
            {
                Id = major.Id,
                MajorName = major.MajorName
            };

            return majorGetDto;
        }

        public MajorGetDto GetMajor(int majorId)
        {
            return _context
                .Set<Major>()
                .Select(x => new MajorGetDto
                {
                    Id = x.Id,
                    MajorName = x.MajorName
                })
                .FirstOrDefault(x => x.Id == majorId);
        }

        public List<MajorGetDto> GetAllMajors()
        {
            return _context
                .Set<Major>()
                .Select(x => new MajorGetDto
                {
                    Id = x.Id,
                    MajorName = x.MajorName
                })
                .ToList();
        }

        public MajorGetDto EditMajor(int Id, MajorEditDto majorEditDto)
        {
            var major = _context.Set<Major>().Find(Id);


            major.MajorName = majorEditDto.MajorName;
            _context.SaveChanges();

            var majorGetDto = new MajorGetDto
            {
                Id = major.Id,
                MajorName = major.MajorName,
            };

            majorGetDto.Id = major.Id;

            return majorGetDto;
        }

        public void DeleteMajor(int majorId)
        {
            var major = _context.Set<Major>().Find(majorId);
            _context.Set<Major>().Remove(major);
            _context.SaveChanges();
    
        }
    }
}
