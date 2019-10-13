using StarterProject.Api.Data;
using StarterProject.Api.Features.Classes.Dtos;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Features.Classes
{
    public interface IClassRepository
    {
        ClassGetDto CreateClass(ClassCreateDto classCreateDto);
        ClassGetDto GetClass(int classId);
        ClassGetDto EditClass(int classId, ClassEditDto classEditDto);
        void DeleteClass(int classId);
    }

    public class ClassRepository : IClassRepository
    {
        public readonly DataContext _context;
        public ClassRepository(DataContext context)
        {
            _context = context;
        }

        public ClassGetDto CreateClass(ClassCreateDto classCreateDto)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteClass(int classId)
        {
            throw new System.NotImplementedException();
        }

        public ClassGetDto EditClass(int classId, ClassEditDto classEditDto)
        {
            throw new System.NotImplementedException();
        }

        public ClassGetDto GetClass(int classId)
        {
            throw new System.NotImplementedException();
        }
    }
}
