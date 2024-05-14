﻿using Microsoft.EntityFrameworkCore;

namespace Persistance;

public class ApplicationDbContext: DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }

}
