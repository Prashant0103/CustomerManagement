using CustomerManagement.BAL.Interface;
using CustomerManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BAL.Service
{
    public class StudentService:BaseService,IStudentService
    {
        public List<UserModel> GetUserList(int id)
        {
            List<UserModel> listOfCustomers = new List<UserModel>();
            UserModel model1 = new UserModel();
            model1.CustomerId = 1;
            model1.CustomerName = "Suraj Gore";
            model1.CustomerMobile = "8946156456";
            listOfCustomers.Add(model1);
            UserModel model2 = new UserModel();
            model2.CustomerId = 2;
            model2.CustomerName = "Akash Jadhao";
            model2.CustomerMobile = "96642121521";
            listOfCustomers.Add(model2);
            UserModel model3 = new UserModel();
            model3.CustomerId = 3;
            model3.CustomerName = "Raju Kharat";
            model3.CustomerMobile = "9894564564";
            listOfCustomers.Add(model3);

            return listOfCustomers;

        }
    }
}
