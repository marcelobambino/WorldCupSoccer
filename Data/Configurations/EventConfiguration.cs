using WorldCupSoccer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WorldCupSoccer.Data.Configurations 
{
    public class EventConfiguration : IEntityTypeConfiguration<Event> 
    {
        // Here we configure the relationship between Attribute x Column Name
        public void Configure(EntityTypeBuilder<Event> builder) {
            builder.Property(p => p.id).HasColumnName("Id");
            builder.Property(p => p.year).HasColumnName("Year");
            builder.Property(p => p.hostCountry).HasColumnName("HostCountry");
            builder.Property(p => p.firstPlace).HasColumnName("FirstPlace");
            builder.Property(p => p.secondPlace).HasColumnName("SecondPlace");
            builder.Property(p => p.thirdPlace).HasColumnName("ThirdPlace");
            builder.Property(p => p.firstImageName).HasColumnName("FirstImageName");
            builder.Property(p => p.secondImageName).HasColumnName("SecondImageName");
            builder.Property(p => p.thirdImageName).HasColumnName("ThirdImageName");
        }
    }
}