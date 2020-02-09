using GJExperience.Graphql.Data;
using GJExperience.Graphql.Model;
using GraphQL;
using GraphQL.Types;
using System.Linq;

namespace GJExperience.Graphql.Type
{
    [GraphQLMetadata("Jedi", IsTypeOf = typeof(Jedi))]
    public class JediType
    {
        public int Id(Jedi jedi) => jedi.Id;
        public string Name(Jedi jedi) => jedi.Name;
        public string Side(Jedi jedi) => jedi.Side;
        public int IdForceLevel(Jedi jedi) => jedi.IdForceLevel;

        public ForceLevel ForceLevel(ResolveFieldContext context, Jedi source)
        {
            return JediData.GetForceLevels().SingleOrDefault(f => f.Id == source.IdForceLevel);
        }
    }

}
