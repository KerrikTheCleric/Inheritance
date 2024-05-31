using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Errors
{
    internal class FileError : UserError
    {

        public override string UEMessage()
        {
            return "File is of unknown format. This fired an error!";
        }
    }
}
