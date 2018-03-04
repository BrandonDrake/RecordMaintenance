using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordMaintenance.Personnel
{
    public class Person
    {
        #region Constructors
        public Person(){ }

        public Person(string firstName, string lastName, PersonType type, string street, string city, string state, string zip)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{LastName}, {FirstName}";
            PersonType = type;
            Address = new AddressInfo()
            { 
                Street = street,
                City = city,
                State = state,
                Zip = zip
            };
        }
        
        #endregion


        #region Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public AddressInfo Address { get; set; }
        public PersonType PersonType { get; set; }

        #endregion
    }
}
