using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreViewComponent.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreViewComponent.ViewComponents
{
    public class StudentListViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int noOfStudent)
        {
            var students = new List<Student>();
            for (var i = 0; i <= noOfStudent; i++)
            {
                students.Add(new Student { Id = i, Name = "Student " + i.ToString() });
            }
            if (noOfStudent > 4)
            {
                return View("StudentList", students);
            }
            return View(students);
        }
    }
    
}
