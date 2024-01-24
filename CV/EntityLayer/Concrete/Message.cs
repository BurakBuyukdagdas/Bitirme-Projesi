using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Message
    {
        [Key]
        public int MessageID { get; set; }
        public string Name { get; set; }        //Mesaj atanının adı
        public string Mail { get; set; }        //Mesaj atanının Mail
        public string Phone { get; set; }        //Mesaj atanının telefonu
        public string Content { get; set; }     //Mesajı
        public DateTime Date { get; set; }      //Tarih
        public bool Status { get; set; }        // Okundu Okunmadı Durumu
    }
}
