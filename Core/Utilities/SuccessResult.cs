using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true,message) //Default olarak true vermiş olduk succes clasını da bu yüzden oluşturduk zaten
        {

        }

        public SuccessResult() : base(true) //mesaj vermek istemiyorsa
        {

        }
    }
}
