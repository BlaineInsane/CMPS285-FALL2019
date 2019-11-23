using StarterProject.Api.Data;
using StarterProject.Api.Features.UsersClasses.Dtos;
using StarterProject.Api.Features.UsersClasses;
using System.Collections.Generic;
using System.Linq;
using StarterProject.Api.Features.Users;

namespace StarterProject.Api.Features.UsersClasses
{
    public interface IUserClassRepository
    {
        UserClassGetDto CreateUserClass(UserClassCreateDto userClassCreateDto);
        UserClassGetDto GetUserClass(int userClassId);
        List<UserClassGetDto> GetAllUsersClasses();
        void DeleteUserClass(int userClassId);
        UserClassGetDto EditUserClass(int id, UserClassEditDto userClassUpdateDto);
    }

    public class UserClassRepository : IUserClassRepository
    {
        private readonly DataContext _context;

        public UserClassRepository(DataContext context)
        {
            _context = context;
        }

        public UserClassGetDto CreateUserClass(UserClassCreateDto userClassCreateDto)
        {
            var userClass = new UserClass
            {
                Grade = userClassCreateDto.Grade,
                ClassCompleted = userClassCreateDto.ClassCompleted,
                UserId = userClassCreateDto.UserId,
                ClassId = userClassCreateDto.ClassId
            };

            _context.Set<UserClass>().Add(userClass);
            _context.SaveChanges();

            var userClassGetDto = new UserClassGetDto
            {
                Id = userClass.Id,
                Grade = userClass.Grade,
                ClassCompleted = userClass.ClassCompleted,
                UserId = userClass.UserId,
                ClassId = userClass.ClassId
            };

            return userClassGetDto;
        }

        public UserClassGetDto GetUserClass(int userClassId)
        {
            return _context
                .Set<UserClass>()
                .Select(x => new UserClassGetDto
                {
                    Id = x.Id,
                    Grade = x.Grade,
                    ClassCompleted = x.ClassCompleted,
                    UserId = x.UserId,
                    ClassId = x.ClassId
                })
                .FirstOrDefault(x => x.Id == userClassId);
        }

        public List<UserClassGetDto> GetAllUsersClasses()
        {
            return _context
                .Set<UserClass>()
                .Select(x => new UserClassGetDto
                {
                    Id = x.Id,
                    Grade = x.Grade,
                    ClassCompleted = x.ClassCompleted,
                    UserId = x.UserId,
                    ClassId = x.ClassId
                })
                .ToList();
        }

        public UserClassGetDto EditUserClass(int Id, UserClassEditDto userClassEditDto)
        {
            var userClass = _context.Set<UserClass>().Find(Id);


            userClass.Grade = userClassEditDto.Grade;
            userClass.ClassCompleted = userClassEditDto.ClassCompleted;
            userClass.UserId = userClassEditDto.UserId;
            userClass.UserId = userClassEditDto.UserId;
            _context.SaveChanges();

            var userClassGetDto = new UserClassGetDto
            {
                Id = userClass.Id,
                Grade = userClass.Grade,
                ClassCompleted = userClass.ClassCompleted,
                UserId = userClass.UserId,
                ClassId = userClass.ClassId
            };

            userClassGetDto.Id = userClass.Id;

            return userClassGetDto;
        }

        public void DeleteUserClass(int userClassId)
        {
            var userClass = _context.Set<UserClass>().Find(userClassId);
            _context.Set<UserClass>().Remove(userClass);
            _context.SaveChanges();
        }
    }
}
