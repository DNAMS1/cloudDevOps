using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ThreeAmigos.Domain.Entities;

namespace ThreeAmigos.Persistance.Configurations
{
    public class ProductStoreEntityTypeConfiguration : IEntityTypeConfiguration<ProductStore>
    {
        public void Configure(EntityTypeBuilder<ProductStore> builder)
        {
            builder.HasKey(es => es.IdProductStore);
            /*
            builder.HasOne(es => es.Student)
                   .WithMany(s => s.StudentEnrolled)
                   .HasForeignKey(es => es.IdStudent);

            builder.HasOne(es => es.Studies)
                   .WithMany(s => s.StudentsEnrolled)
                   .HasForeignKey(es => es.IdStudies);
            */
        }
    }
}
