using Microsoft.AspNetCore.Mvc;
namespace MVCWebApplication1.Models { 
namespace MVCWebApplication1.Controllers
{
        [Route("[controller]")]
        public class StudentListController : Controller
        {
            [Route("AddStudents")]
            public IActionResult AddStudent()
            {
                return View();
            }


            [Route("GetStudents")]
            public IActionResult Students(StudentData input)
            {
                List<StudentData> students = getStudent(input);
                return View(students);

            }
            
            
            private List<StudentData> getStudent(StudentData input)
            {


                List < StudentData> students = new List<StudentData>();
                var student1 = new StudentData();
                student1.Id = 1;
                student1.FirstName = "Sam";
                student1.LastName = "John";
                student1.Age = 21;
                student1.City = "Chennai";
                students.Add(student1);
                var student2 = new StudentData();
                student2.Id = 2;
                student2.FirstName = "Daniel";
                student2.LastName = "Paul";
                student2.Age = 20;
                student2.City = "Chennai";
                students.Add(student2);
                var student3 = new StudentData();
                student3.Id = 3;
                student3.FirstName = "Smith";
                student3.LastName = "Josh";
                student3.Age = 21;
                student3.City = "Chennai";
                students.Add(student3);
                if(input != null && input.Id!=0 && input.Age!=0)
                {
                    students.Add(input);
                }

                    return students;


            }
        }

    }
}

