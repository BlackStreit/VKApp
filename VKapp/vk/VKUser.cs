using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace VKapp.vk
{
    class VKUser
    {
        [DisplayName("Имя")]
        public String first_name { get; set; }
        [DisplayName("Фамилия")]
        public String last_name { get; set; }
        [DisplayName("Фото")]
        public String photo_100 { get; set; }
        [DisplayName("Id")]
        public int id{ get; set; }
    }
}
