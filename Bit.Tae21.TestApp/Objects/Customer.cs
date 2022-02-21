using System;
using System.Collections.Generic;
using System.Text;

namespace Bit.Tae21.TestApp.Objects
{
    public class Customer
    {
        #region Constructors

        public Customer()
        {
            ContactPersons = new List<ContactPerson>();
        }

        #endregion

        #region Properties

        public int Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public List<ContactPerson> ContactPersons { get; set; }

        #endregion
    }
}
