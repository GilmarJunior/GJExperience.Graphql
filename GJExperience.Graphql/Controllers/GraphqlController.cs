using System;
using System.Collections.Generic;
using GJExperience.Graphql.Model;
using GraphQL;
using GraphQL.Types;
using GraphQLParser;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GJExperience.Graphql.Controllers
{
    [Route("graphql")]
    [ApiController]
    public class GraphqlController : ControllerBase
    {
        #region Example 1 
        //Example 1
        //[HttpPost]
        //public object Post([FromBody]GraphQLQuery graphQLQuery)
        //{
        //    var inputs = graphQLQuery.Variables.ToInputs();

        //    var schema = Schema.For(@"
        //        type Query {
        //            defaultMessage: String
        //        }
        //    ");

        //    var root = new { DefaultMessage = "Hello World!" };
        //    var json = schema.Execute(_ =>
        //    {
        //        _.Query = graphQLQuery.Query;
        //        _.Root = root;
        //    });
        //    return json; 
        //}

        #endregion

        #region Example 2
        //Example 2
        //[HttpPost]
        //public object Post([FromBody]GraphQLQuery graphQLQuery)
        //{
        //    var inputs = graphQLQuery.Variables.ToInputs();

        //    var schema = Schema.For(@"
        //        type Jedi {
        //            name: String,
        //            side: String
        //        }

        //        type Query {
        //            defaultMessage: String,
        //            jedis: [Jedi]
        //        }
        //    ", _ =>
        //    {
        //        _.Types.Include<Query>();
        //    });

        //    var json = schema.Execute(_ =>
        //    {
        //        _.Query = graphQLQuery.Query;
        //    });

        //    return json;
        //}
        #endregion

        #region Example 3
        //Example3
        [HttpPost]
        public object Post([FromBody]GraphQLQuery graphQLQuery)
        {
            var inputs = graphQLQuery.Variables.ToInputs();

            var schema = Schema.For(@"
                type Jedi {
                    id: ID,
                    name: String,
                    side: String
                }

                type Query {
                    defaultMessage: String,
                    jedis: [Jedi],
                    jedi(id: ID): Jedi
                }
            ", _ =>
            {
                _.Types.Include<Query>();
            });

            var json = schema.Execute(_ =>
            {
                _.Query = graphQLQuery.Query;
            });

            return json;
        }

        #endregion
    }
}