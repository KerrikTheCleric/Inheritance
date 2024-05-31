using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance {
    internal class TransferProtocolError : UserError {

        public override string UEMessage() {
            return "Transfer protocol broken. This fired an error!";
        }
    }
}
