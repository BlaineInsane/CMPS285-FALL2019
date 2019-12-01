using StarterProject.Api.Data;
using StarterProject.Api.Features.ClassesConcentrations.Dtos;
using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Security;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Features.ClassesConcentrations
{
    public interface IClassConcentrationRepository
    {
        ClassConcentrationGetDto CreateClassConcentration(ClassConcentrationCreateDto classConcentrationCreateDto);
        ClassConcentrationGetDto GetClassConcentration(int classConcentrationId);
        List<ClassConcentrationGetDto> GetAllClassesConcentrations();
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
                Id = classConcentration.Id,
                ClassId = classConcentration.ClassId,
                ConcentrationId = classConcentration.ConcentrationId
            };

            return classConcentrationGetDto;
        }
        public ClassConcentrationGetDto GetClassConcentration(int classConcentrationId)
        {
            return _context
                .Set<ClassConcentration>()
                .Select(x => new ClassConcentrationGetDto
                {
                    Id = x.Id,
                    ClassId = x.ClassId,
                    ConcentrationId = x.ConcentrationId
                })
                .FirstOrDefault(x => x.Id == classConcentrationId);
        }

        public List<ClassConcentrationGetDto> GetAllClassesConcentrations()
        {
            return _context
                .Set<ClassConcentration>()
                .Select(x => new ClassConcentrationGetDto
                {
                    Id = x.Id,
                    ClassId = x.ClassId,
                    ConcentrationId = x.ConcentrationId
                })
                .ToList();
        }
    }
}
