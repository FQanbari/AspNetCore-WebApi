﻿using AspNetCore_WebApi.Common;
using AspNetCore_WebApi.Common.Utilities;
using AspNetCore_WebApi.Data.Contracts;
using AspNetCore_WebApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AspNetCore_WebApi.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext)
            : base(dbContext)
        {
        }

        public Task AddAsync(User user, string password, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByUserAndPass(string username, string password, CancellationToken cancellationToken)
        {
            var passwordHash = SecurityHelper.GetSha256Hash(password);
            return Table.Where(p => p.UserName == username && p.PasswordHash == passwordHash).SingleOrDefaultAsync(cancellationToken);
        }

        public Task UpdateLastLoginDateAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSecuirtyStampAsync(User user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}