using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Reading.Models
{
    public class CreateModel
    {
        [Key]
        public int EventId { get; set; }

        public string MailId { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }


        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Date is required.")]
        public DateTime Date { get; set; }


        [Required(ErrorMessage = "Location is required.")]
        public string Location { get; set; }


        [Display(Name = "Start Time")]
        [DataType(DataType.Time)]
        [Required(ErrorMessage = "Start Time is required.")]
        public DateTime StartTime { get; set; }

        public string Type { get; set; }


        [Display(Name = "Duration In Hours")]
        [Required(ErrorMessage = "Duration is required with atmost 4 digit.")]
        public int DurationInHours { get; set; }


        [Required(ErrorMessage = "Description is required with atmost 50 characters."), MaxLength(50)]
        public string Description { get; set; }


        [Required(ErrorMessage = "Other Details is required with atmost 500 characters."), MaxLength(500)]
        [Display(Name = "Other Details")]
        public string OtherDetails { get; set; }


        [Display(Name = "Invite By Email")]
        [Required(ErrorMessage = "Invite Email is required.")]
        public string InviteByEmail { get; set; }
    }
}
