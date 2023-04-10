using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Hosting;
using NudeSolutionAssignment.Models;
using System.Reflection.Emit;

namespace NudeSolutionAssignment.Persistence.Configurations
{
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder) {
            builder.Property(b => b.Name)
            .HasMaxLength(244)
                .IsRequired();
            
            builder.HasData(
                new Category(1, "Electronics"),
                new Category(2, "Clothing"),
                new Category(3, "Kitchen")
            );


        }
    }
}
