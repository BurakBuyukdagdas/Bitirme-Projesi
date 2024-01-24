using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Certificate
    {
        [Key]
        public int CertificateID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Status { get; set; } //Durumu
        public string Value { get; set; } //Tamamlama Oranı
        public string Paltform { get; set; } //Gelecek Küçük Resim
       
    }
}
