using System;
using System.Collections.Generic;
using System.Text;

namespace Bit.Tae21.TestApp.Objects
{
    public class ContactPerson
    {
        #region Properties

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();

        #endregion
    }
}
