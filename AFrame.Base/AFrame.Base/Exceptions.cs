using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class UnsupportedOperationException : Exception
    {
        private const string MessageTemplate = "{0}{1} Operation is unsupported in this context. {2}";
        private const string typenameMessageTemplate = "Type: {0} ";
        private const string methodNameMessageTemplate = "Method: {0} ";
        private const string addendumMessageTemplate = "Addendum: {0}";

        private readonly string _message;
        public UnsupportedOperationException(string typename = "", 
                                             string methodname = "",
                                             string addendum = "")
        {
            this._message = string.Format(MessageTemplate,
                                          string.IsNullOrEmpty(typename) ? typename : string.Format(typenameMessageTemplate, typename),
                                          string.IsNullOrEmpty(methodname) ? methodname : string.Format(methodNameMessageTemplate, methodname),
                                          string.IsNullOrEmpty(addendum) ? addendum : string.Format(addendumMessageTemplate, addendum));
        }
        public override string Message => this._message;
    }
}
