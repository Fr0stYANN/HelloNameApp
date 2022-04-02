using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloNameApp.Models
{
    public static class Repository
    {
        private static List<Name> names = new List<Name>();
        public static IEnumerable<Name> Names
        {
            get
            {
                return names;
            }
        }
        public static void AddName(Name name)
        {
            names.Add(name);
        }
    }
}

