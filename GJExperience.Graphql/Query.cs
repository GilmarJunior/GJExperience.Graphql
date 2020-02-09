using GJExperience.Graphql.Data;
using GJExperience.Graphql.Model;
using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GJExperience.Graphql
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
    }
}
