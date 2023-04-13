namespace NudeSolutionAssignment.Persistence;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NudeSolutionAssignment.Modules.Insurance.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class InsuranceContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    public DbSet<Category> Categories { get; set; }

    public string DbPath { get; }

    public InsuranceContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "insurance.db");
    }


    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}