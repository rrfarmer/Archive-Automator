using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Video
    {
        [Column("VideoId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Video Title is a required field.")]
        [MaxLength(100, ErrorMessage = "Video Title cannot exceed 100 characters.")]
        public string VideoTitle { get; set; }

        [Required(ErrorMessage = "File Path is a required field.")]
        public string FilePath { get; set; }

        public string YouTubeUrl { get; set; }

        [MaxLength(5000, ErrorMessage = "Transcription cannot exceed 5000 characters.")]
        public string Transcription { get; set; }

        [Required(ErrorMessage = "Modified Date is a required field.")]
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<Summary> Summaries { get; set; }
        public virtual ICollection<Timestamp> Timestamps { get; set; }
    }
}
