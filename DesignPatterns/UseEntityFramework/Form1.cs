using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseEntityFramework
{
    public partial class Form1 : Form
    {
        private AdventureWorksEntities db;
        
        public Form1()
        {
            db = new AdventureWorksEntities();
            InitializeComponent();
            GetPredisentName();
        }

        private void GetPredisentName()
        {
            var p = db.Employee
                .Where (o => o.ManagerID == null);

            foreach (var emp in p)
            {
                AddEmployeeToHierarchy((int)emp.EmployeeID, treeView.Nodes.Add(emp.Contact.FirstName + " " + emp.Contact.LastName));
            }

        }

        private void MakeHierarchy()
        {
                        
        }

        public void AddEmployeeToHierarchy(int EmpID, TreeNode node)
        {
            System.Data.Objects.ObjectResult<uspGetManagerEmployees_Result> res = db.uspGetManagerEmployees(EmpID);

            foreach (var emp in res)
            {
                AddEmployeeToHierarchy((int)emp.EmployeeID, node.Nodes.Add(emp.FirstName + " " + emp.LastName));
            }

        }

    }
}
