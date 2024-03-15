using System.ComponentModel.DataAnnotations;

namespace Linked_API.Models
{
    public class ProblemAModel
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Width value must be more than 0.")]
        public int Width { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Length value must be more than 0.")]
        public int Length { get; set; }
    }
}
