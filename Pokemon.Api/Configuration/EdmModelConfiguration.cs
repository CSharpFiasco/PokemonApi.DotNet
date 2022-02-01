using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using Pokemon.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Api.Configuration
{
    public static class EdmModelConfiguration
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Domain.Models.Pokemon>("Pokemon");
            builder.EntitySet<Move>("Move");
            builder.EntitySet<MoveMethod>("MoveMethod");
            builder.EntitySet<DamageClass>("DamageClass");
            builder.EntitySet<Domain.Models.Type>("Type");
            builder.EntitySet<PokemonMove>("PokemonMove");

            return builder.GetEdmModel();
        }
    }
}
