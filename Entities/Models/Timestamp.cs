using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Timestamp
    {
        [Column("TimestampId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Video ID is a required field.")]
        public Guid VideoId { get; set; }

        [Required(ErrorMessage = "Recorded Timestamp is a required field.")]
        public DateTime RecordedTimestamp { get; set; }

        [Required(ErrorMessage = "Timestamp Type is a required field.")]
        public string TimestampType { get; set; }

        [ForeignKey("VideoId")]
        public virtual Video Video { get; set; }
    }

}
