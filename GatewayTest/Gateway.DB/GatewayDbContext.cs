﻿using Microsoft.EntityFrameworkCore;

namespace Gateway.DB
{
    public class GatewayDbContext : DbContext
    {
        public GatewayDbContext(DbContextOptions<GatewayDbContext> options) : base(options) {

        }

        public DbSet<Payment> Payments { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<BankResponse> BankResponses {get;set;}

        public DbSet<IdempotencyRecord> IdempotencyRecords { get; set; }
    }
}
