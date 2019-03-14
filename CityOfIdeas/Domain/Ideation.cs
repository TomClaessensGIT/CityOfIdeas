using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CID.BL.Domain
{
   public class Ideation 
    {
        public string ID { get; set; }


        [Required]
        [StringLength(100)]
        [Display(Name = "Titel")]
        public string Title { get; set; }

        [Display(Name = "Text")]
        public string Text { get; set; }

        public string Image { get; set; }

        //public DateTime DateOpened { get; set; }

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<IdeationComment> Comments { get; set; }


        [Required]
        public virtual Project Project { get; set; }

        public Ideation()
        {
            Tags = new List<Tag>();
        }

    }
}
