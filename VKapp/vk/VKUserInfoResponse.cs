using System;
using System.Collections.Generic;
using System.Text;

namespace VKapp.vk
{
    class VKUserInfoResponse
    {
        public String first_name { get; set; }

        public int id { get; set; }

        public String last_name { get; set; }

        public String photo_max { get; set; }
        public VKUserCounter counters { get; set; }
    }
}
