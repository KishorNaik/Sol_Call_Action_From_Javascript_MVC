using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Sol_Call_Action_Javascript.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember(EmitDefaultValue =false)]
        public String firstName { get; set; }

        [DataMember(EmitDefaultValue =false)]
        public String lastName { get; set; }
    }
}
