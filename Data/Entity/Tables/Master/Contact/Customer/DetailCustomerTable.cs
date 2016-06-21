using System;

namespace Entity.Tables.Master.Contact.Customer
{
    public class DetailCustomerTable : ContactTable
    {
        //Field

        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }


        public string Village { get; set; }
        public string Commune { get; set; }
        public string District { get; set; }
        public string Province { get; set; }


        //FK

        //C-FK
    }
}
