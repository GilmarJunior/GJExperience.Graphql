using GJExperience.Graphql.Data;
using GJExperience.Graphql.Model;
using GraphQL;
using System.Collections.Generic;
using System.Linq;

namespace GJExperience.Graphql.BaseQuery
{
    public class Query
    {
        #region Example 2
        [GraphQLMetadata("jedis")]
        public IEnumerable<Jedi> GetJedis()
        {
            return JediData.GetJedis();
        }

        [GraphQLMetadata("defaultMessage")]
        public string GetHello()
        {
            return "Terminator!";
        }
        #endregion

        #region Example 3

        [GraphQLMetadata("jedi")]
        public Jedi GetJedi(int id)
        {
            return JediData.GetJedis().SingleOrDefault(j => j.Id == id);
        }

        #endregion

        #region Example 4

        [GraphQLMetadata("forceLevel")]
        public ForceLevel GetForceLevel(Jedi jedi)
        {
            return JediData.GetForceLevels().SingleOrDefault(f => f.Id == jedi.IdForceLevel);
        }

        #endregion
    }
}
