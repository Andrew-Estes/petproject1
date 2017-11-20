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
    class DataDefination3
    {
        public class Products
        {

            //TODO: Initialize Products
            public enum productType {Inventory, Service, Labor, Supplies };
            public Int64 productID;
            public productType iType;
            public string make;
            public string identifier;
            public string description;
            public string unit;
            public string retailPrice;
            public string costPrice;
            public Int16 sales;
            public Int16 mtd;
            public Int16 ytd;
            public Int16 otd;
            public string comments;
            public bool taxable;
            public string vendor;
            public Int16 vendorID;

        }

    }
}
