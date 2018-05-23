using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantUISLibrary.Models
{
    class Employee
    {
        /// <summary>
        /// Sets the Id of the employee
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Social Security Number
        /// </summary>
        public string SocialSecurityNumber { get; set; }  
        
        /// <summary>
        /// Employee First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Employee Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Employee Address
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Employee City
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Employee State
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Employee Zipcode
        /// </summary>
        public string ZipCode { get; set; }

        public JobDescriptions JobDescriptions { get; set; }



    }
}
