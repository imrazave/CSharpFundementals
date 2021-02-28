using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_Inheritance
{
    [TestClass]
    public class InheritanceTests
    {
        [TestMethod]
        public void PersonExamples()
        {
            //var person = new Person();
            //person.FirstName = "Joshua";
            //person.ToString();

            var customer = new Customer(true, "Imran", "Zaveri", "12345678910", "imran.zaveri1@gmail.com");
            customer.PhoneNumber = "";
            customer.FirstName = "Lawrence";
            customer.IsPremium = true;

            var employee = new Employee();
            employee.FirstName = "Luke";
            employee.HireDate = DateTime.Today;

            var hourlyEmployee = new HourlyEmployee();
            hourlyEmployee.FirstName = "Charles";

            List<Person> people = new List<Person>();
            //people.Add(person);
            people.Add(customer);
            people.Add(employee);
            people.Add(hourlyEmployee);
        }
    }
}
