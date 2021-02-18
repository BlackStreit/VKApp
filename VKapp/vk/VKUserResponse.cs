using System;
using System.Collections.Generic;
using System.Text;

namespace VKapp.vk
{
    class VKUserResponse<T>
    {
        public IList<T> response { get; set; }
    }
}
