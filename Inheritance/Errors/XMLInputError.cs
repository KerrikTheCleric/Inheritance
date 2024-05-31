using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Errors
{
    internal class XMLInputError : UserError
    {

        public override string UEMessage()
        {
            return "You tried to send in raw XML. This fired an error!";
        }
    }
}
