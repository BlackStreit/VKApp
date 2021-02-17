using System;
using System.Collections.Generic;
using System.Text;

namespace VKapp.vk
{

    class VKGRoupCoverImage
    {
        public int wight { get; set; }
        public int heigth { get; set; }
        public String url { get; set; }
    }

    class VKGroupCover
    {
        public int enabled { get; set; }
        public IList<VKGRoupCoverImage> images { get; set; }
    }
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

        public VKGroupCover cover { get; set; }
        public override string ToString()
        {
            return $@"id = {id} 
name = {name}
screen_name = {screen_name}
photo_200 = {photo_200}
";
        }
    }
}
