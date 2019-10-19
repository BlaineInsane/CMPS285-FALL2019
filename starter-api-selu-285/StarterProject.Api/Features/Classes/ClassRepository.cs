using StarterProject.Api.Data;
using StarterProject.Api.Features.Classes.Dtos;
using StarterProject.Api.Features.Users;
using System.Collections.Generic;
using System.Linq;

namespace StarterProject.Api.Features.Classes
{
    public interface IClassRepository
    {
        ClassGetDto CreateClass(ClassCreateDto classCreateDto);
        ClassGetDto GetClass(int classId);
        List<ClassGetDto> GetAllClasses();
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
            var classMe = new Class
            {
                ClassName = classCreateDto.ClassName,
                ClassDescription = classCreateDto.ClassDescription,
                CreditHours = classCreateDto.CreditHours,
                Prerequisite = classCreateDto.Prerequisite
            };

            _context.Set<Class>().Add(classMe);
            _context.SaveChanges();

            var classGetDto = new ClassGetDto
            {
                Id = classMe.Id,
                ClassName = classMe.ClassName,
                ClassDescription = classMe.ClassDescription,
                CreditHours = classMe.CreditHours,
                Prerequisite = classMe.Prerequisite
            };

            return classGetDto;
        }

        public ClassGetDto GetClass(int classId)
        {
            return _context
                .Set<Class>()
                .Select(x => new ClassGetDto
                {
                    Id = x.Id,
                    ClassName = x.ClassName,
                    ClassDescription = x.ClassDescription,
                    CreditHours = x.CreditHours,
                    Prerequisite = x.Prerequisite
                })
                .FirstOrDefault(x => x.Id == classId);
        }

        public List<ClassGetDto> GetAllClasses()
        {
            return _context
                .Set<Class>()
                .Select(x => new ClassGetDto
                {
                    Id = x.Id,
                    ClassName = x.ClassName,
                    ClassDescription = x.ClassDescription,
                    CreditHours = x.CreditHours,
                    Prerequisite = x.Prerequisite
                })
                .ToList();
        }

        public ClassGetDto EditClass(int classId, ClassEditDto classEditDto)
        {
            var classMe = _context.Set<Class>().Find(classId);

            classMe.ClassName = classEditDto.ClassName;
            classMe.ClassDescription = classEditDto.ClassDescription;
            classMe.CreditHours = classEditDto.CreditHours;
            classMe.Prerequisite = classEditDto.Prerequisite;
            _context.SaveChanges();

            var classGetDto = new ClassGetDto
            {
                Id = classMe.Id,
                ClassName = classMe.ClassName,
                ClassDescription = classMe.ClassDescription,
                CreditHours = classMe.CreditHours,
                Prerequisite = classMe.Prerequisite
            };

            classGetDto.Id = classMe.Id;

            return classGetDto;
        }

        public void DeleteClass(int classId)
        {
            var classMe = _context.Set<Class>().Find(classId);
            _context.Set<Class>().Remove(classMe);
            _context.SaveChanges();
        }
    }
}
