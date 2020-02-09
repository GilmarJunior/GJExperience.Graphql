using GJExperience.Graphql.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GJExperience.Graphql.Data
{
    public class JediData
    {
        public static List<Jedi> GetJedis()
        {
            return new List<Jedi>
            {
                new Jedi { Id = 1, Name = "Luke", Side= "Light" },
                new Jedi { Id = 2, Name = "Yoda", Side= "Light" },
                new Jedi { Id = 3, Name = "Darth Vader", Side= "Light" },
                new Jedi { Id = 4, Name = "Kylo Ren", Side= "Light/Dark?" },
                new Jedi { Id = 5, Name = "Darth Sidious", Side= "Dark" }
            };
        }
    }
}
