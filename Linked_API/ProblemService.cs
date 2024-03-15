using Microsoft.VisualBasic;

namespace Linked_API
{
    public class ProblemService
    {
        public ProblemService()
        {

        }

        public int ProblemA(int Width, int Length)
        {
            int totalWidth = Width % 2 == 0 ? Width / 2 : (Width + 1) / 2;
            int totalLength = Length % 2 == 0 ? Length / 2 : (Length + 1) / 2;

            return totalWidth * totalLength;
        }

        public int ProblemB(int N, int H, List<int> input)
        {
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                if (H >= input[i])
                    count++;
            }

            return count;
        }

        public List<string> ProblemC(int N, List<string> rows)
        {
            List<string> result = new List<string>();
            int vowels = 0;
            int consonants = 0;

            foreach (string row in rows)
            {
                foreach (char C in row)
                {
                    if (char.IsLetter(C))
                    {
                        var lowerC = char.ToLower(C);

                        if (lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u' ||
                            lowerC == 'á' || lowerC == 'é' || lowerC == 'í' || lowerC == 'ó' || lowerC == 'ú' ||
                            lowerC == 'à' || lowerC == 'è' || lowerC == 'ì' || lowerC == 'ò' || lowerC == 'ù' ||
                            lowerC == 'ã' || lowerC == 'õ' ||
                            lowerC == 'â' || lowerC == 'ê' || lowerC == 'î' || lowerC == 'ô' || lowerC == 'û')
                            vowels++;
                        else
                            consonants++;
                    }
                }

                result.Add($"{vowels} {consonants}");
                vowels = 0;
                consonants = 0;
            }

            return result;
        }

        public int ProblemD(int N, List<int> start, List<int> arrival)
        {
            int overtaking = 0;

            for (int i = 0; i < N; i++)
            {
                if (start[i] != arrival[i])
                {
                    overtaking++;
                }
            }

            return overtaking;
        }

        public int ProblemE(int N)
        {
            for (int i = 1; i <= N; i++)
            {
                string N_string = i.ToString();

                if (N_string.Contains("4") || N_string.Contains("13"))
                {
                    N++;
                }
            }

            return N;
        }
    }
}
