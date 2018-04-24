using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadJsonAGL.Helpers
{
    public class OwnersandPets
    {
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public List<Pet> pets { get; set; }
    }

    public class Pet
    {
        public string petname { get; set; }
        public string pettype { get; set; }
    }
}