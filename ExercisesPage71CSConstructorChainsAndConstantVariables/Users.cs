using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage71CSConstructorChainsAndConstantVariables
{
    public class Users
    {
        public Users(string name) : this(name, 18)
        {
        }
            
        public Users(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

}
