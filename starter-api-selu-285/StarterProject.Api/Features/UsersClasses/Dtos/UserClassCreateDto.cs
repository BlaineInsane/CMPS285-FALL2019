﻿
namespace StarterProject.Api.Features.UsersClasses.Dtos
{
    public class UserClassCreateDto
    {
        public int Grade { get; set; }
        public bool ClassCompleted { get; set; }
        public int UserId { get; set; } // FK to Users table
        public int ClassId { get; set; } // FK to Classes table
    }
}
