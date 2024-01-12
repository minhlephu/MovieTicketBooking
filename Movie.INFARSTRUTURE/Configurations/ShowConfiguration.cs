using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Movie.INFARSTRUTURE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.INFARSTRUTURE.Configurations
{
    public class ShowConfiguration : IEntityTypeConfiguration<Show>
    {      
        public void Configure(EntityTypeBuilder<Show> builder)
        {
            throw new NotImplementedException();
        }
    }
}
