using System.Diagnostics;
using academic_assignment_and_recording_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace academic_assignment_and_recording_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LabDBContext _context;

        public HomeController(ILogger<HomeController> logger, LabDBContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult LogIn(string email,string password) { 
            var user = _context.Users.FirstOrDefault(x => x.Email == email);

            if (user != null) {

                if (user.Password == password)
                {
                    if (user.AcademicRole.Equals("admin"))
                    {

                        HttpContext.Session.SetString("userId", user.UserId.ToString());
                        HttpContext.Session.SetString("userName", user.Name);
                        HttpContext.Session.SetString("userSurname", user.Surname);
                        HttpContext.Session.SetString("userRole", user.AcademicRole);
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (user.AcademicRole.Equals("teacher"))
                    {
                        var teacher = _context.Teachers.FirstOrDefault(u => u.TeacherId == user.UserId);

                        if (teacher != null)
                        {
                            if (teacher.Banned!=null)
                            {
                                if (teacher.Banned == false)
                                {

                                    HttpContext.Session.SetString("userId", user.UserId.ToString());
                                    HttpContext.Session.SetString("userName", user.Name);
                                    HttpContext.Session.SetString("userSurname", user.Surname);
                                    HttpContext.Session.SetString("userRole", user.AcademicRole);
                                    return RedirectToAction("Index", "Teacher");
                                }
                                else
                                {
                                    return View("LogInError");
                                }
                                
                            }
                        }
                        
                    }
                    else
                    {
                        var students = _context.Students.FirstOrDefault(u => u.StudentId == user.UserId);

                        if (students != null)
                        {
                            if (students.Banned != null)
                            {
                                if (students.Banned == false)
                                {

                                    HttpContext.Session.SetString("userId", user.UserId.ToString());
                                    HttpContext.Session.SetString("userName", user.Name);
                                    HttpContext.Session.SetString("userSurname", user.Surname);
                                    HttpContext.Session.SetString("userRole", user.AcademicRole);
                                    return RedirectToAction("Index", "Student");
                                }
                                else
                                {
                                    return View("LogInError");
                                }
                              
                            }
                        }
                    }
                }
            
            }

            return View("LogInAgain");
        }

        public IActionResult Signout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
