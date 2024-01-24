using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        public string Title { get; set; }   //Proje Başlık
        public string Description { get; set; }     //Proje Açıklama
        public string ProjectURL { get; set; }     //Proje URL
        public string Image { get; set; }       //Proje Resim
    }
}
