using Microsoft.AspNetCore.Mvc;
using MVCAssignment2.Context;
using MVCAssignment2.Models;

namespace MVCAssignment2.Controllers
{
    public class UserController : Controller
    {
        EmpDbContext _context;
        public UserController(EmpDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Details(int id)
        {
            return View(_context.Users.FirstOrDefault(

                c => c.Id == id));
        }

        public IActionResult Edit(int id)
        {
            return View(_context.Users.FirstOrDefault(

                c => c.Id == id));

        }
        [HttpPost]
        public IActionResult Edit(int id, User user)
        {
            foreach (var item in _context.Users)
            {
                if (item.Id == id)
                {
                    item.Name = user.Name;
                    item.DOB = user.DOB;
                    item.Doj = user.Doj;
                    item.Dept = user.Dept;
                    item.Salary = user.Salary;
                    break;
                }
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(_context.Users.FirstOrDefault(

                c => c.Id == id));

        }
        [HttpPost]
        public IActionResult Delete(int id, User user)
        {
            foreach (var item in _context.Users)
            {
                if (item.Id == id)
                {
                    _context.Users.Remove(item);
                    break;
                }
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
