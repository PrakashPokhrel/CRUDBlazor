using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CRUDBlazor.Data
{
    public class CustomerService
    {
        CustomerDataAccessLayer objCustomerDAL = new CustomerDataAccessLayer();

        public List<CustomerInfo> GetCustomer()
        {
            List<CustomerInfo> customers = objCustomerDAL.GetAllCustomers().ToList();
            return customers;
        }
        public string Create(CustomerInfo objCustomer)
        {
            objCustomerDAL.AddCustomer(objCustomer);
            return "Added Successfully";
        }

        public CustomerInfo GetCustomerByID(int id)
        {
            CustomerInfo customer = objCustomerDAL.GetCustomerData(id);
            return customer;
        }
        public string UpdateCustomer(CustomerInfo objcustomer)
        {
            objCustomerDAL.UpdateCustomer(objcustomer);
            return "Update Successfully";
        }
        public string DeleteCustomer(CustomerInfo objcustomer)
        {
            objCustomerDAL.DeleteCustomer(objcustomer.CustomerId);
            return "Delete Successfully";
        }
    }
}