using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CID.BL.Domain
{
    public enum TagEnum
    {
        [Display(Name = "Natuur")]
        Natuur,
        [Display(Name = "Plein")]
        Plein,
        [Display(Name = "Antwerpen")]
        Antwerpen,
        [Display(Name = "Deurne")]
        Deurne,
        [Display(Name = "Kinderen")]
        Kinderen,
        [Display(Name = "Verkeer")]
        Verkeer
    }
}
