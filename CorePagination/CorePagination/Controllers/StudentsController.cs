using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CorePagination.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index(int? page)
        {
            var pageNumber = page ?? 1;
            int pageSize = 25; 
            var onePageOfStudents = Data.StudentContext.StudentList.ToPagedList(pageNumber, pageSize);
            return View(onePageOfStudents); 
        }


    }
}
