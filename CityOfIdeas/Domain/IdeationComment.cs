using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CID.BL.Domain
{
    public class IdeationComment : IValidatableObject
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public bool IsClientResponse { get; set; }

        [Required]
        public virtual Ideation Ideation { get; set; }

        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (Date <= Ideation.DateOpened)
            {
                errors.Add(new ValidationResult("Can't be before the date the ticket is created!"
                                                , new string[] { "Date", "Ticket.DateOpened" }));
            }

            return errors;
        }
    }
}
