using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewOfTwoModels.Models;

namespace ViewOfTwoModels.ViewModel
{
    public class EmployeeDepartmentVM
    {
        Employee myVar = new Employee();

        public string FirstName
        {

            get { return myVar.FirstName; }
            set { myVar.FirstName = value; }
        }
      
        public string LastName
        {
            get { return myVar.LastName; }
            set { myVar.LastName = value; }
        }

        Department var = new Department();

        public int DeptId
        {
            get { return var.DeptId; }
            set { var.DeptId = value; }
        }       

        public string DeptName
        {
            get { return var.DeptName; }
            set { var.DeptName = value; }
        }
        
    }
}