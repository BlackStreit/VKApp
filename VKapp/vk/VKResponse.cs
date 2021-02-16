using System;
using System.Collections.Generic;
using System.Text;

namespace VKapp
{
    class VKResponse<T>
    {
        public IList<T> response { get; set; }

    }
}
