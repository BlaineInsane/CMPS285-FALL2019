using StarterProject.Api.Data;
using StarterProject.Api.Features.Concentrations.Dtos;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Features.Concentrations
{
    public interface IConcentrationRepository
    {
        ConcentrationGetDto CreateConcentration(ConcentrationCreateDto concentrationCreateDto);
    }
    
    public class ConcentrationRepository : IConcentrationRepository
    {
        private readonly DataContext _context;

        public ConcentrationRepository(DataContext context)
        {
            _context = context;
        }

        public ConcentrationGetDto CreateConcentration(ConcentrationCreateDto concentrationCreateDto)
        {
            var concentration = new Concentration
            {
                ConcentrationName = concentrationCreateDto.ConcentrationName,
                MajorId = concentrationCreateDto.MajorId
            };

            _context.Set<Concentration>().Add(concentration);
            _context.SaveChanges();

            var concentrationGetDto = new ConcentrationGetDto
            {
                Id = concentration.Id,
                ConcentrationName = concentration.ConcentrationName,
                MajorId = concentration.MajorId
            };

            return concentrationGetDto;
        }
    }
}
