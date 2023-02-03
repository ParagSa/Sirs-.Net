using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            List<Employee> lstEmps = new List<Employee>();
            lstEmps.Add(new Employee { EmpNo = 1, Name = "Vikram", Basic = 12345, DeptNo = 10 });
            lstEmps.Add(new Employee { EmpNo = 2, Name = "Shweta", Basic = 22345, DeptNo = 10 });
            lstEmps.Add(new Employee { EmpNo = 3, Name = "Harsh", Basic = 32345, DeptNo = 10 });
            lstEmps.Add(new Employee { EmpNo = 4, Name = "Ananya", Basic = 42345, DeptNo = 10 });
            return View(lstEmps);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id=0)
        {
            Employee obj = new Employee();
            obj.EmpNo = id;
            obj.Name = "Vikram";
            obj.DeptNo = 10;
            obj.Basic = 12345;
            return View(obj);
        }

        // GET: EmployeesController/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,Employee obj)
        {
            try
            {
                //to do - obj to inserted into db

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        string name = collection["Name"];
        //        string empno = collection["EmpNo"];
        //        string basic = collection["Basic"];
        //        string deptno = collection["DeptNo"];


        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id=0)
        {
            Employee obj = new Employee();
            obj.EmpNo = id;
            obj.Name = "Vikram";
            obj.DeptNo = 10;
            obj.Basic = 12345;
            return View(obj);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee obj)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee obj = new Employee();
            obj.EmpNo = id;
            obj.Name = "Vikram";
            obj.DeptNo = 10;
            obj.Basic = 12345;
            return View(obj);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
