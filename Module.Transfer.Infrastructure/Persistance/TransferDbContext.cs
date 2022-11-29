using Microsoft.EntityFrameworkCore;
using Module.Transfer.Core.Abstractions;
using Shared.Infrastucture.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Module.Transfer.Infrastructure.Persistance
{
    internal class TransferDbContext : ModuleDbContext, ITransferDbContext
    {
        protected override string Schema => "Transfer";
        public TransferDbContext(DbContextOptions<TransferDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
