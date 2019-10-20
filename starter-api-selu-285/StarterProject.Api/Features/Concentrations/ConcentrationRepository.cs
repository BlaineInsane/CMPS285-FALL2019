using StarterProject.Api.Data;
using StarterProject.Api.Features.Concentrations.Dtos;
using StarterProject.Api.Features.Users;
using System.Collections.Generic;
using System.Linq;

namespace StarterProject.Api.Features.Concentrations
{
    public interface IConcentrationRepository
    {
        ConcentrationGetDto CreateConcentration(ConcentrationCreateDto concentrationCreateDto);
        ConcentrationGetDto GetConcentration(int concentrationId);
        List<ConcentrationGetDto> GetAllConcentrations();
        void DeleteConcentration(int ConcentrationId);
        ConcentrationGetDto EditConcentration(int id, ConcentrationEditDto concentrationUpdateDto);
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

        public ConcentrationGetDto GetConcentration(int concentrationId)
        {
            return _context
                .Set<Concentration>()
                .Select(x => new ConcentrationGetDto
                {
                    Id = x.Id,
                    ConcentrationName = x.ConcentrationName,
                    MajorId = x.MajorId
                })
                .FirstOrDefault(x => x.Id == concentrationId);
        }

        public List<ConcentrationGetDto> GetAllConcentrations()
        {
            return _context
                .Set<Concentration> ()
                .Select(x => new ConcentrationGetDto
                {
                    Id = x.Id,
                    ConcentrationName = x.ConcentrationName,
                    MajorId = x.MajorId
                })
                .ToList();
        }

        public ConcentrationGetDto EditConcentration(int Id, ConcentrationEditDto concentrationEditDto)
        {
            var concentration = _context.Set<Concentration>().Find(Id);


            concentration.ConcentrationName = concentrationEditDto.ConcentrationName;
            _context.SaveChanges();

            var concentrationGetDto = new ConcentrationGetDto
            {
                Id = concentration.Id,
                ConcentrationName = concentration.ConcentrationName,
                MajorId = concentration.MajorId
            };

            concentrationGetDto.Id = concentration.Id;

            return concentrationGetDto;
        }

        public void DeleteConcentration(int concentrationId)
        {
            var concentration = _context.Set<Concentration>().Find(concentrationId);
            _context.Set<Concentration>().Remove(concentration);
            _context.SaveChanges();
        }
    }
}
