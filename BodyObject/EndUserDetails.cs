using BodyObject.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyObject
{
    public class EndUserDetails:BaseUser
    {
        string _userType;
        AddressEntity addressEntity;

        public string UserType { get => _userType; set => _userType = value; }
        public AddressEntity AddressEntity { get => addressEntity; set => addressEntity = value; }
    }
}
