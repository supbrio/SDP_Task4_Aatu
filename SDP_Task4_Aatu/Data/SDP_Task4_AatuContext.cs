using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SDP_Task4_Aatu.Models;

namespace SDP_Task4_Aatu.Data
{
    public class SDP_Task4_AatuContext : DbContext
    {
        public SDP_Task4_AatuContext (DbContextOptions<SDP_Task4_AatuContext> options)
            : base(options)
        {
        }

        public DbSet<SDP_Task4_Aatu.Models.Names> Names { get; set; }
    }
}
