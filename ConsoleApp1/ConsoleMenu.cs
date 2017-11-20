using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

/* Copyright (C) 2017 Andrew C. Estes - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the General Public License.  I, Andrew C. Estes 
 * will retrain all rights where written permission or royalties
 * have not been sought.
 *
 * You should have received a copy of the General Public License with
 * this project. 
 */

namespace ConsoleApp1
{
    /// <summary>
    /// Console App Main Menu Functionality
    /// </summary>
    public class ConsoleMainMenu
    {
        People Customer = new People();
        List<People> CustomerIndex = new List<People>();

      
        /// <summary>
        /// Console startup menu
        /// </summary>
        public void MainMenu()
        {

            string choice = string.Empty;

            do
            {
                Console.WriteLine("1. New Customer");
                Console.WriteLine("2. Edit Customer");
                Console.WriteLine("3. List Customers");
                Console.WriteLine("4. Choose Customer");
                Console.WriteLine("0. Exit");
                Console.WriteLine("");
                Console.WriteLine("--Current Customer Selected--");
                Console.WriteLine("{0} {1} from {2},{3} {4}",
                Customer.FirstName,
                Customer.LastName,
                Customer.address.city,
                Customer.address.state,
                Customer.address.zip);
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": // New CustomerS
                        BuildNewCustomer();
                        break;
                    case "2": // Edit Customers
                        //TODO: Edit Current Customer
                        break;
                    case "3":
                        //TODO: List Customers
                        break;
                    case "4":
                        //TODO: Choose Customer
                        break;
                }
            } while (choice != "0");
        }
        /// <summary>
        /// Console driven dialog/input to build Customer object
        /// </summary>
        public void BuildNewCustomer()
        {

            string choice = string.Empty;

            do
            {
                Console.WriteLine("First Name");
                choice = Console.ReadLine();
                Customer.FirstName = choice.ToString();
                Console.WriteLine("You entered {0}, it this ok Y/N?",
                    Customer.FirstName);
                choice = Console.ReadLine();
            } while (choice.ToUpper() != "Y");
            do
            {
                Console.WriteLine("Middle Name");
                choice = Console.ReadLine();
                Customer.MiddleName = choice.ToString();
                Console.WriteLine("You entered {0}, it this ok Y/N?",
                    Customer.MiddleName);
                choice = Console.ReadLine();
            } while (choice.ToUpper() != "Y");
            do
            {
                Console.WriteLine("Last Name");
                choice = Console.ReadLine();
                Customer.LastName = choice.ToString();
                Console.WriteLine("You entered {0}, it this ok Y/N?",
                    Customer.LastName);
                choice = Console.ReadLine();
            } while (choice.ToUpper() != "Y");
            // 
            // Address
            //
            do
            {
                Console.WriteLine("Address line 1");
                choice = Console.ReadLine();
                Customer.address.address1 = choice.ToString();
                Console.WriteLine("Address line 2");
                choice = Console.ReadLine();
                Customer.address.address2 = choice.ToString();
                Console.WriteLine("You entered {0} \n {1} \n is this ok Y/N?",
                    Customer.address.address1, Customer.address.address2);
                choice = Console.ReadLine();
            } while (choice.ToUpper() != "Y");
            //Customer.address.city;
            do
            {
                Console.WriteLine("City");
                choice = Console.ReadLine();
                Customer.address.city = choice.ToString();
                Console.WriteLine("You entered {0}, it this ok Y/N?",
                    Customer.address.city);
                choice = Console.ReadLine();
            } while (choice.ToUpper() != "Y");
            //Customer.address.state;
            do
            {
                Console.WriteLine("State \n [Must be state postal code]");
                choice = Console.ReadLine();
                Customer.address.state = choice.ToString();
                Console.WriteLine("You entered {0}, it this ok Y/N?",
                    Customer.address.state);
                choice = Console.ReadLine();
            } while (choice.ToUpper() != "Y");
            //Customer.address.zip;
            do
            {
                Console.WriteLine("Zip Code");
                choice = Console.ReadLine();
                Customer.address.zip = choice.ToString();
                if (Customer.address.IsZipCode(Customer.address.zip))
                {
                    Console.WriteLine("You entered {0}, it this ok Y/N?",
                        Customer.address.zip);
                    choice = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your zip isn't a valid format");
                }
            } while (choice.ToUpper() != "Y");

            // 
            // eMail
            //
            do
            {
                Console.WriteLine("eMailAddress");
                choice = Console.ReadLine();
                Customer.email.email_address = choice.ToString();
                if (Customer.email.IsEmailAddress(Customer.email.email_address))
                {
                    Console.WriteLine("You entered {0}, it this ok Y/N?",
                        Customer.email.email_address);
                    choice = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your email address isn't a valid format");
                }
            } while (choice.ToUpper() != "Y");

            CustomerIndex.Add(Customer);
            return;
        }
    }
}
