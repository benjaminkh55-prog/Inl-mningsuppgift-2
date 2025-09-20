using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inlämningsuppgift_2
{
    public abstract class Person
    {
        
            public string Namn { get; set; }
            public string Epost { get; set; }

            protected Person(string namn, string epost)
            {
                Namn = namn;
                Epost = epost;
            }
        }
    }

