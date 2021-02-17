using System;
using System.Collections.Generic;
using System.Text;

namespace VKapp.vk
{
    class VKItemsResponce<T>
    {
        public int count { get; set; }

        public IList<T> items { get; set; }
    }
}
