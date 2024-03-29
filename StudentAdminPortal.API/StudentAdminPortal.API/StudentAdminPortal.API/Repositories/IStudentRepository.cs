﻿
using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetStudentsAsync();
        Task<Student> GetStudentAsync(Guid studentId);

        //This gender will be the data model, not domain model.
        Task<List<Gender>> GetGendersAsync();

        // To check if the student exists or not.
        Task<bool> Exists(Guid studentId);

        // To Update the student.
        Task<Student> UpdateStudent(Guid studentId, Student request);
        // To delete student.
        Task<Student> DeleteStudent(Guid studentId);

        // To delete student.
        Task<Student> AddStudent(Student request);
    }
}

//Task<bool> UpdateProfileImage(Guid studentId, string profileImageUrl);