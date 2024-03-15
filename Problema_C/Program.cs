int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    string row = Console.ReadLine();

    int vowels = 0;
    int consonants = 0;

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

    Console.WriteLine($"{vowels} {consonants}");
}