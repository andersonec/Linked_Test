namespace Linked_API.Models
{
    public class ProblemCModel
    {
        //if (N < 1 && N > 1000)
        //    return BadRequest("N must be in range 1 to 1000.");

        //if (rows.Count != N)
        //    return BadRequest("Input must contain N rows.");
        //else
        //{
        //    if (rows.Any(x => x.Length > 80 || x.Length < 1))
        //    {
        //        return BadRequest("Each row must be in range 1 to 80.");
        //    }
        //}


        public int N { get; set; }
        public List<string> rows { get; set; }
    }
}
