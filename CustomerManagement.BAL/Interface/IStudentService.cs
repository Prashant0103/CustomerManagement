using CustomerManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BAL.Interface
{
    public interface IStudentService
    {
        List<UserModel> GetStudentByID(int id);
    }
}
