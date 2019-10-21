using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CJTwilioTile.Plugins
{
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MessagePreview
    {

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Subject;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FromExpression;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ReplyToExpression;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ToExpression;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TextPart;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HtmlPart;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StatusCode;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageId;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MessageDesignation;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ContentType;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Name;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public object ModifiedOn;
    }
}
