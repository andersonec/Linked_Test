int N = int.Parse(Console.ReadLine());

for (int i = 1;  i <= N; i++)
{
    string N_string = i.ToString();

    if (N_string.Contains("4") || N_string.Contains("13"))
    {
        N++;
    }
}

Console.WriteLine(N);