using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ErmitanoJF.DataAccess;
using System.Data;

namespace ErmitanoJF
{
    namespace BusinessLogic
    {
        class BLL
        {
            #region Values
            private string phoneid;
            public string PhoneID
            {
                get { return phoneid; }
                set { phoneid = value; }
            }
            private string phonename;
            public string PhoneName
            {
                get { return PhoneName; }
                set { phonename = value; }
            }
            private string manufacturer;
            public string Manufacturer
            {
                get { return manufacturer; }
                set { manufacturer = value; }
            }
            private string price;
            public string Price
            {
                get { return price; }
                set { price = value; }
            }
            private string capacity;
            public string StorageCapacity
            {
                get { return capacity; }
                set { capacity = value; }
            }
            private string os;
            public string OperatingSystem
            {
                get { return os; }
                set { os = value; }
            }
            private int year;
            public int YearReleased
            {
                get { return year; }
                set
                {
                    //if (year < 1973 || year > 2013)
                    //{
                    //    Exception e = new Exception("Year cannot be less than 1973 or greater than 2013");
                    //    e.Source = "BLL:YearReleased";
                    //    throw e;
                    //}
                    year = value;
                    //add exception must be a number
                }
            }
#endregion
            #region VADU
            public DataTable View()
            {
                return DAL.GetData("SELECT * FROM Phone");
            }
            public void Add()
            {
                DAL.Execute("INSERT INTO Phone VALUES ('" + phoneid +
                "','" + phonename + "','" + manufacturer + "','" + price +
                "','" + capacity + "','" + os + "','" + year + "')");
            }
            public void Update()
            {
                DAL.Execute("UPDATE Phone SET PhoneName = '" + phonename +
                "', Manufacturer = '" + manufacturer + "', Price = '" + price +
                "', StorageCapacity = '" + capacity + "', OperatingSystem = '" + os +
                "', YearReleased = '" + year + "' WHERE PhoneID = '" + phoneid + "'");
            }
            public void Delete()
            {
                DAL.Execute("DELETE FROM Phone WHERE PhoneID = '" + phoneid + "'");
            }
            #endregion
        }
    }
}
