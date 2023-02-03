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
            List<Employee> employees = Employee.GetAllEmployees();
            return View(employees);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id)
        {
            Employee emp = Employee.GetSingleEmployee(id);
            //if(emp== null)  
            return View(emp);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        string Name = collection["Name"];
        //        string EmpNo = collection["EmpNo"];
        //        string Basic = collection["Basic"];
        //        string DeptNo = collection["DeptNo"];


        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Create(Employee emp)
        {
            try
            {
                Employee.InsertEmployee(emp);
                ViewBag.message = "Inserted successfully";
                return View();
                //return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.message = ex.Message;
                return View();
            }
        }
        //public ActionResult Create(Employee emp)
        //{
        //    try
        //    {
        //        Employee.InsertEmployee(emp);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch(Exception ex)
        //    {
        //        ViewBag.message = ex.Message;
        //        return View();
        //    }
        //}



        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id=1)
        {
            Employee emp = Employee.GetSingleEmployee(id);
            //if(emp== null)  
            return View(emp);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
       // public ActionResult Edit(int id, IFormCollection collection)
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {
                Employee.UpdateEmployee(emp);   
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id=1)
        {
            Employee emp = Employee.GetSingleEmployee(id);
            //if(emp== null)  
            return View(emp);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete( Employee emp, int id )
        {
            try
            {
                Employee.DeleteEmployee(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
