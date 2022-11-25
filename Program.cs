using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_PolyMorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Understanding Method Overriding - Run time Polymorhism");
            Employee[] batchof2022 = new Employee[3];//Array of Objects with 3 elements 
            batchof2022[0] = new Employee();
            batchof2022[1] = new Intern();
            batchof2022[2] = new ContractualEmp();
            foreach (Employee e  in batchof2022)
            {
                e.DisplayFullName();
            }
        }
    }

    class Employee
    {
        public string FName;
        public string LName;
        public virtual void DisplayFullName() {// This might get new implementation in child class 
            Console.WriteLine(FName +" - "+LName +" Is Employee with us");
        }
    }
    class Intern : Employee
    {
        public override void DisplayFullName()//There is a Similar method coming from base class 
        {
            Console.WriteLine(FName + "-" + LName + " is a Intern with Us");
        }
    }
    class ContractualEmp : Employee
    {
        public override void DisplayFullName()
        {
           // base.DisplayFullName();//Use for calling base class Virtual Method
            Console.WriteLine(FName + "-" + LName + "  is a Contractual Employee with us");
        }
    }
}
