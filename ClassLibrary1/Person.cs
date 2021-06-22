using System;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class Person
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string GivenNames { get; set; }
        public string FamilyName { get; set; }
        public string Spouse { get; set; }
        public List<string> Children { get; set; } 
        public Address Address { get; set; }
    }
}