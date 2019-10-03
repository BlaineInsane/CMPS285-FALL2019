using StarterProject.Api.Data;
using StarterProject.Api.Features.Majors.Dtos;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Features.Majors
{
    public interface IMajorRepository
    {
        MajorGetDto CreateMajor(MajorCreateDto MajorCreateDto);
    }

    public class MajorRepository : IMajorRepository
    {
        private readonly DataContext _context;

        public MajorRepository(DataContext context)
        {
            _context = context;
        }

        public MajorGetDto CreateMajor(MajorCreateDto MajorCreateDto)
        {
            var major = new Major
            {
                MajorName = MajorCreateDto.MajorName
            };

            _context.Set<Major>().Add(major);
            _context.SaveChanges();

            var MajorGetDto = new MajorGetDto
            {
                Id = major.Id,
                MajorName = major.MajorName
            };

            return MajorGetDto;
        }
    }
}
