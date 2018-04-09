﻿using System;

namespace DI.Coupled.Concrete
{
    public class Customer
    {
        public void UpdateCustomerOrder(string customer, string product)
        {
            //update customer record with purchase
            Console.WriteLine(String.Format("Customer record for '{0}' updated with purchase the product '{1}'", customer, product));
        }
    }
}
