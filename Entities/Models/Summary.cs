using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Summary
    {
        [Column("SummaryId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Video ID is a required field.")]
        public Guid VideoId { get; set; }

        [MaxLength(5000, ErrorMessage = "Summary Text cannot exceed 5000 characters.")]
        public string SummaryText { get; set; }

        [Required(ErrorMessage = "Sequence Number is a required field.")]
        public int SequenceNumber { get; set; }

        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }

        public bool IsSelectedSummary { get; set; } // New property
    }
}
