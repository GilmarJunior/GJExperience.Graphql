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
                new Jedi { Id = 1, Name = "Luke", Side= "Light", IdForceLevel = 2 },
                new Jedi { Id = 2, Name = "Yoda", Side= "Light", IdForceLevel = 3 },
                new Jedi { Id = 3, Name = "Darth Vader", Side= "Light", IdForceLevel = 3 },
                new Jedi { Id = 4, Name = "Kylo Ren", Side= "Light/Dark?", IdForceLevel = 1 },
                new Jedi { Id = 5, Name = "Darth Sidious", Side= "Dark", IdForceLevel = 3 }
            };
        }

        public static List<ForceLevel> GetForceLevels()
        {
            return new List<ForceLevel>
            {
                new ForceLevel { Id = 1, Description = "Low" },
                new ForceLevel { Id = 2, Description = "Medium" },
                new ForceLevel { Id = 3, Description = "High" }
            };
        }
    }
}
