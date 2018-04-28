using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyObject.BaseClass
{
    class BaseUser
    {
        string _personfirstname;
        string _personMiddleName;
        string _personLastName;
        string _personContactNumberCSV;
        string _personGender;

        
        public string Personfirstname { get => _personfirstname; set => _personfirstname = value; }
        public string PersonMiddleName { get => _personMiddleName; set => _personMiddleName = value; }
        public string PersonLastName { get => _personLastName; set => _personLastName = value; }
        public string PersonContactNumber { get => _personContactNumberCSV; set => _personContactNumberCSV = value; }
        public string PersonGender { get => _personGender; set => _personGender = value; }
        
    }
}
