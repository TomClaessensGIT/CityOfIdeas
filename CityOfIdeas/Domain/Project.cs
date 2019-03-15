using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CID.BL.Domain
{
    public class Project
    {
        public string ID { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Inleiding")]
        public string Preface
        { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }

        public string Image { get; set; }

        public int AantalStemmen { get; set; }

        [StringLength(100)]
        [Display(Name = "Vraag")]
        public string IdeationVraag { get; set; }

        public ICollection<Ideation> Ideations { get; set; }

        //public byte[] Img { get; set; }

    }
}
