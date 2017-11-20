using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    
    public class MileageItem
    {
        //TODO: Mileage Initialization
        public MileageItem()
        {
        }
        public DateTime datelogged;
        public string mileage;
    }

    /// <summary>
    /// Base Class object of vehicles - holds vehicle information
    /// </summary>
    public class Vehicle
    {
        //TODO: Initialize Vehicle
        public Vehicle()
        {
        }
        public Int64 vehicleID;
        public Int32 vehicleOwnerID;
        public string year { get; set; }
        public string model { get; set; }
        public string make { get; set; }
        public string vin { get; set; }
        public string engine { get; set; }
        public string trans { get; set; }
        public string differencial { get; set; }
        public string color { get; set; }
        public string license { get; set; }
        public string tiremake { get; set; }
        public string tiresize { get; set; }
        public string comments { get; set; }
        List<MileageItem> mileageItem = new List<MileageItem>();
    }
        /// <summary>
        /// Base Class object of Inventory 
        /// </summary>
        public class Inventory
    {
        public Inventory()
        {
                productID = 0;
                iTypes = productTypes.Products;
        }
            public enum productTypes { Products, Services, Labor, Shop_Supplies };
            public Int64 productID;
            productTypes iTypes;
            
    }
}
