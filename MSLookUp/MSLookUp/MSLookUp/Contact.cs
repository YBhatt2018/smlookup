using System;
namespace MSLookUp
{
    public class Contact
    {

        public String lastName { get; set; }
        public String firstName { get; set; }
        public Int32 studentNumber { get; set; }
        public override string ToString()
        {
            return lastName;
        }

      
    }
}
