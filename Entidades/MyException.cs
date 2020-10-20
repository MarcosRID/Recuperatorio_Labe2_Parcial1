using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class MyException : Exception
    {
        public MyException()
        {
        }

        public MyException(string mensaje) : base(mensaje)
        {
        }

        public MyException(string mensaje, Exception ex) : base(mensaje, ex)
        {
        }
    }



    public class AValueIsMissingException : Exception
    {
        public AValueIsMissingException()
        {
        }

        public AValueIsMissingException(string mensaje) : base(mensaje)
        {
        }

        public AValueIsMissingException(string mensaje, Exception ex) : base(mensaje, ex)
        {
        }


    }


}
