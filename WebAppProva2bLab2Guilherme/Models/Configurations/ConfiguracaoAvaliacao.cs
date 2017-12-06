using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebAppProva2bLab2Guilherme.Models.Configurations
{
    public class ConfiguracaoAvaliacao : EntityTypeConfiguration<Avaliacao>
    {
        {
            public ConfiguracaoAvaliacao ()
            {
                //Configura associação many-to-many (muitos-para-muitos)
                HasMany(a => a.Trabalhos)
                     .WithMany(f => f.Avaliacaos)
                     .Map(af =>
                     {
                         af.MapLeftKey("codFilme");
                         af.MapRightKey("codAtor");
                         af.ToTable("FilmeAtor");
                     }
                     );
            }
 
        }
    }
}