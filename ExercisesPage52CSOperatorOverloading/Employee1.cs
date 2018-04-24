using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesPage52CSOperatorOverloading
{
    public class Employee1
    {

        public static bool operator ==(Employee1 employeeId1, Employee2 employeeId2)
        {
            return (employeeId1 == employeeId2);
        }

        public static bool operator !=(Employee1 employeeId1, Employee2 employeeId2)
        {
            return (employeeId1 != employeeId2);
        }

        public int Id { get; set; }
    }
}


