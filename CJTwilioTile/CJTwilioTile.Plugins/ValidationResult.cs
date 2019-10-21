using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJTwilioTile.Plugins
{
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ValidationResult
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] PartValidationResults;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Result;
    }
}
