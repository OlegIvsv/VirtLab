﻿using Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal sealed class StudentService: IStudentService
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;

        public StudentService(IRepositoryManager repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }
    }
}
