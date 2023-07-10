using CustomerManagement.BAL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagement.BAL.UOW
{
    public class UnitOfWork
    {
        private UserService _customerService;
        public UserService CustomerService
        {
            get { return _customerService ?? (_customerService = new UserService()); }
        }
    }
}
