using StarterProject.Api.Data;
using StarterProject.Api.Features.Majors.Dtos;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Features.Majors
{
    public interface IMajorRepository
    {
        MajorGetDto CreateMajor(MajorCreateDto majorCreateDto);
        void DeleteMajor(int majorId);
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

        public void DeleteMajor(int majorId)
        {
            var major = _context.Set<Major>().Find(majorId);
            _context.Set<Major>().Remove(major);
            _context.SaveChanges();
        }
    }
}
