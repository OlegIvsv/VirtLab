﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents(bool trackChanges);
        Student GetStudent(Guid studentId, bool trackChanges);
        void CreateStudent(Student student);
    }
}
