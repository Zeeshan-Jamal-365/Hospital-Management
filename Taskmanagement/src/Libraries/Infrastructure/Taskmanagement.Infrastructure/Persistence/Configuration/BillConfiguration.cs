using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Taskmanagement.Model;

namespace Taskmanagement.Infrastructure.Persistence.Configuration;
public class BillConfiguration : IEntityTypeConfiguration<Bill>
{
    public void Configure(EntityTypeBuilder<Bill> builder)
    {
        builder.ToTable("Bill");
        builder.HasKey(x => x.Id);
    }
}
