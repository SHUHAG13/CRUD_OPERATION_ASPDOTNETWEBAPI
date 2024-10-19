using CollegeApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CollegeApp.Config
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
           
            builder.ToTable(nameof(Student));

           
            builder.HasKey(x => x.StdId);

            
            builder.Property(x => x.StdName)
                .HasColumnType("varchar(100)")  
                .IsRequired();                  

            builder.Property(x => x.StdAge)
                .IsRequired();                  

            builder.Property(x => x.StdEmail)
                .HasColumnType("varchar(150)")  
                .IsRequired();                  

            builder.Property(x => x.StdAddress)
                .HasColumnType("varchar(250)"); 
        }
    }
}
