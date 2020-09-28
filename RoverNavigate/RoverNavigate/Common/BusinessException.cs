using System;
using System.Collections.Generic;
using System.Text;

namespace RoverNavigate.Common
{
    [Serializable]
    public class BusinessException : Exception
    {
        public BusinessException(string massege) : base(massege)
        {

        }
        public BusinessException(string massege, Exception inner) : base(massege, inner)
        {

        }
    }
}
