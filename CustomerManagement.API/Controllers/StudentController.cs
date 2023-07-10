using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CustomerManagement.BAL.Interface;
using CustomerManagement.BAL.UOW;
using CustomerManagement.Model;

namespace CustomerManagement.API.Controllers
{
    public class StudentController : BaseController
    {
        private IStudentService _iStudentService;
        public StudentController()
        {
            _iStudentService = UnitOfWorks.StudentService;
        }

        //[HttpGet]
        //public List<UserModel> GetStudentList()
        //{
        //    return _iStudentService.GetStudentList();

        //}

        [HttpGet]
        public UserModel GetItemById(int id)
        {
            return _iStudentService.GetStudentByID(id);
        }

    }

    
}
