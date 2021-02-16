using System;
using System.Collections.Generic;
using System.Text;

namespace VKapp
{
    class VKGroup
    {
        public int id { get; set; }
        public String name { get; set; }
        public String screen_name { get; set; }
        public int is_closed { get; set; }
        public String type { get; set; }
        public int is_admin { get; set; }
        public int is_member { get; set; }
        public int is_advertiser { get; set; }
        public String photo_50 { get; set; }
        public String photo_100 { get; set; }
        public String photo_200 { get; set; }

        public override string ToString()
        {
            return $@"
id = {id} 
name = {name}
screen_name = {screen_name}
photo_200 = {photo_200}


";
        }
    }
}
