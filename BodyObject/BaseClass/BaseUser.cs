using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyObject.BaseClass
{
    public class BaseUser
    {
        string _personfirstname;
        string _personMiddleName;
        string _personLastName;
        string _personContactNumberCSV;
        string _personGender;
        string LoginID_Username;
        string _password;
        string _emailId;

        //Properties

        public string Personfirstname { get => _personfirstname; set => _personfirstname = value; }
        public string PersonMiddleName { get => _personMiddleName; set => _personMiddleName = value; }
        public string PersonLastName { get => _personLastName; set => _personLastName = value; }
        public string PersonContactNumber { get => _personContactNumberCSV; set => _personContactNumberCSV = value; }
        public string PersonGender { get => _personGender; set => _personGender = value; }
        public string LoginId { get => LoginID_Username; set => LoginID_Username = value; }
        public string Password { get => _password; set => _password = value; }
        public string EmailId { get => _emailId; set => _emailId = value; }
    }
}
