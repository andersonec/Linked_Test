using Linked_API.Helpers;
using System.ComponentModel.DataAnnotations;

namespace Linked_API.Models
{
    public class ProblemDModel
    {
        [Required]
        [Range(2, 36, ErrorMessage = "N must be in range 2 to 36.")]
        public int N { get; set; }

        [Required]
        [ListValidationsHelper(nameof(N), ErrorMessage = "Start list must have exactly N items.")]
        public List<int> Start { get; set; }

        [Required]
        [ListValidationsHelper(nameof(N), ErrorMessage = "Arrival list must have exactly N items.")]
        public List<int> Arrival { get; set; }
    }
}
