using StarterProject.Api.Data;
using StarterProject.Api.Features.ClassesConcentrations.Dtos;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Features.ClassesConcentrations
{
    public interface IClassConcentrationRepository
    {
        ClassConcentrationGetDto CreateClassConcentration(ClassConcentrationCreateDto classConcentrationCreateDto);
    }
    
    public class ClassConcentrationRepository : IClassConcentrationRepository
    {
        private readonly DataContext _context;

        public ClassConcentrationRepository(DataContext context)
        {
            _context = context;
        }

        public ClassConcentrationGetDto CreateClassConcentration(ClassConcentrationCreateDto classConcentrationCreateDto)
        {
            var classConcentration = new ClassConcentration
            {
                ClassId = classConcentrationCreateDto.ClassId,
                ConcentrationId = classConcentrationCreateDto.ConcentrationId
            };

            _context.Set<ClassConcentration>().Add(classConcentration);
            _context.SaveChanges();

            var classConcentrationGetDto = new ClassConcentrationGetDto
            {
                ClassConcentrationId = classConcentration.ClassConcentrationId,
                ClassId = classConcentration.ClassId,
                ConcentrationId = classConcentration.ConcentrationId
            };

            return classConcentrationGetDto;
        }
    }
}
