using Microsoft.EntityFrameworkCore;
using Module.Account.Core.Abstractions;
using Shared.Infrastucture.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Account.Infrastucture.Persistance
{
    public class AccountDbContext : ModuleDbContext, IAccountDbContext
    {
        protected override string Schema => "Account";
        public AccountDbContext(DbContextOptions<AccountDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}