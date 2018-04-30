using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyObject.BaseClasses
{
    public class AddressEntity
    {
        string _flat_House_Number;
        string _locality_Street;
        string _city;
        string _cityId;
        string _locality;
        string _localityId;
        string _landMark;
        string _zipcode;
        string _state;
        string _stateId;
        string _country;
        string _gender;
        string _emailId;

        public string Flat_House_Number { get => _flat_House_Number; set => _flat_House_Number = value; }
        public string Locality_Street { get => _locality_Street; set => _locality_Street = value; }
        public string City { get => _city; set => _city = value; }
        public string CityId { get => _cityId; set => _cityId = value; }
        public string Locality { get => _locality; set => _locality = value; }
        public string LocalityId { get => _localityId; set => _localityId = value; }
        public string LandMark { get => _landMark; set => _landMark = value; }
        public string Zipcode { get => _zipcode; set => _zipcode = value; }
        public string State { get => _state; set => _state = value; }
        public string StateId { get => _stateId; set => _stateId = value; }
        public string Country { get => _country; set => _country = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string EmailId { get => _emailId; set => _emailId = value; }
    }
}
