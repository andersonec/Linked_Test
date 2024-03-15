using Linked_API.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Linked_API.Models
{
    public class ProblemBModel
    {
        [Required]
        [Range(90, 200, ErrorMessage = "H must be in range 90 to 200.")]
        public int H { get; set; }

        [Required]
        [Range(1, 6, ErrorMessage = "N must be in range 1 to 6.")]
        public int N { get; set; }

        [Required]
        [ListValidationsHelper(nameof(N), ErrorMessage = "The list must have exactly N items.")]
        public List<int> Input { get; set; }
    }
}
