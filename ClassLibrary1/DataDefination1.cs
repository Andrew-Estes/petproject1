using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/* Copyright (C) 2017 Andrew C. Estes - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the General Public License.  I, Andrew C. Estes 
 * will retrain all rights where written permission or royalties
 * have not been sought.
 *
 * You should have received a copy of the General Public License with
 * this project. 
 */

namespace ClassLibrary1
{
    /// <summary>
    /// State Postal Code eNum
    /// </summary>
    public enum StatePostalCode { AL, AK, AZ, AR, CA, CO, CT, DE, FL, GA, HI, ID, IL, IN, IA, KS, KY, LA, ME,
        MD, MA, MI, MN, MS, MO, MT, NE, NV, NH, NJ, NM, NY, NC, ND, OH, OK, OR, PA, RI, SC, SD, TN, TX, UT, VT,
        VA, WA, WV, WI, WY, AS, DC, FM, GU, MH, MP, PW, PR, VI };

    /// <summary>
    /// Sub class object of people to hold address information
    /// </summary>
    public class Address
    {
        public Address()
        {
            addressID = 0;
            aType = addressType.home;
            address1 = string.Empty;
            address2 = string.Empty;
            city = string.Empty;
            state = StatePostalCode.MO.ToString(); 
            zip = string.Empty;

        }

        public enum addressType { home, work, home_cell, work_cell, other };
        public Int32 addressID = 0;
        public addressType aType;
        public string address1;
        public string address2;
        public string city;
        public string state;
        public string zip;
        /// <summary>
        /// Validates a zip code string 12345 or 12345-1234
        /// format borrowed from blog-platformular.com
        /// </summary>
        /// <param name="zipcd"></param>
        /// <returns>bool</returns>
        public bool IsZipCode(string zipcd)
        {
            // pattern for 12345 or 12345-1234
            string pattern = @"^\d{5}(\-\d{4})?$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(zipcd);
         }
    }
    /// <summary>
    /// Sub Class object of people - holds phone information
    /// </summary>
    public class Phone
    {
        public Phone()
        {
            pType = phoneType.home;
            phone_number = string.Empty;
        }
        public enum phoneType { home, work, home_cell, work_cell, other };
        public phoneType pType;
        public string phone_number;
        /// <summary>
        /// Validates a phone number string XXX-XX-XXXX
        /// borrowed from RegExLib.com
        /// </summary>
        /// <param name="phoneno"></param>
        /// <returns>bool</returns>
        public bool IsPhoneNumber(string phoneno)
        {
            // pattern for 12345 or 12345-1234
            string pattern = @"^[2-9]\d{2}-\d{3}-\d{4}$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(phoneno);
        }
    }
    /// <summary>
    /// Sub Class object of people - holds eMail information
    /// </summary>
    public class EMail
    {
        public EMail()
        {
            eType = emailType.home;
            email_address = string.Empty;
        }
        public enum emailType { home, work, home_cell, work_cell, other };
        public emailType eType;
        public string email_address;
        /// <summary>
        /// Validates a email address string 
        /// borrowed from RegExLib.com
        /// </summary>
        /// <param name="estring"></param>
        /// <returns>bool</returns>
        public bool IsEmailAddress(string estring)
        {
            // pattern for 12345 or 12345-1234
            string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
;            Regex regex = new Regex(pattern);

            return regex.IsMatch(estring);
        }
    }
    /// <summary>
    /// Base Class object of people
    /// </summary>
    public class People
    {
        private Int32 _peopleID;
        public Int32 peopleID
        {
            get
            {
                return _peopleID;
            }
            set
            {
                _peopleID = value;
            }

        }
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public Address address = new Address();
        public Phone phone = new Phone();
        public EMail email = new EMail();

        public People()
        {
            peopleID = 0;
            FirstName = string.Empty;
            MiddleName = string.Empty;
            LastName = string.Empty;
        }


        //TODO: Customer Index Functionality
        /// <summary>
        /// Customer Index List
        /// </summary>
    }
}
