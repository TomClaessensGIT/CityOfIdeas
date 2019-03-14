using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CID.BL.Domain
{
    public class IdeationComment
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsClientResponse { get; set; }

        [Required]
        public virtual Ideation Ideation { get; set; }


    }
}
