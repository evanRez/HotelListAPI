﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data.Entity.ModelConfiguration;

namespace HotelListingAPI.Data.Configurations
{
    public class RoleConfiguration : EntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(

                    new IdentityRole
                    {
                        Name = "Administrator",
                        //NormalizedName = "ADMINISTRATOR"
                    },
                    new IdentityRole
                    {
                        Name = "User",
                        //NormalizedName = "USER"
                    }

           );
        }
    }
}
