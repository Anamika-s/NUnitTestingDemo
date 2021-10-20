using System;
using System.Collections.Generic;
using System.Text;

namespace Functions
{
    public class Customer
    {
        public virtual bool AddCustomer(Email email)
        {
            //Email obj = new Email();
            email.sendMail();
            // Some code of ADO.Net will go here
            return true;
        }

    }
}
