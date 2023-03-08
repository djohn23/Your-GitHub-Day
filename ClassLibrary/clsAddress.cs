using System;

namespace ClassLibrary
{
    public class clsAddress
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public DateTime DOB { get; set; }
        public bool Over18 { get; set; }
    }
}