using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SnakeForms.Logging
{
    class Loger : ILoger
    {
        public void Log(string content)
        {
            Debug.WriteLine(content);
        }
    }
}
