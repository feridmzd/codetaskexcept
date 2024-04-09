using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleAppreflection
//{
//    public  class Department
//    {
//        public int EmployeLimit;
//        public string Name { get; set; }
//        Employe[] Employes;
//        public Department() 
//        { 
//            Employes=new Employe[0];
//        }
//        public void AddEmploye(Employe employe)
//        {
            
//            Array.Resize(ref Employes,Employes.Length+1);
//            Employes[Employes.Length-1] = employe;

//        }
//        public Department(int employeeLimit)
//        {

//            if (employeeLimit <= 0)
//                throw new CapacityLimitException("Employe limit asildi", nameof(employeeLimit));

           
//            EmployeLimit = employeeLimit;
//            Employe[] employes = new Employe[EmployeLimit];
//            Employes = employes;
////        }
//    }
//}
