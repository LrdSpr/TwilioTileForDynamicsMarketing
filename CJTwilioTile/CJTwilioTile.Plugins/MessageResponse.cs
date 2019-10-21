using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJTwilioTile.Plugins
{
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MessageResponse
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MessagePreview MessagePreview;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public ValidationResult ValidationResult;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Error;
    }
}
