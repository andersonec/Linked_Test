int N = int.Parse(Console.ReadLine());

char[] start = Console.ReadLine().ToArray();

char[] arrival = Console.ReadLine().ToArray();

int overtaking = 0;

for (int i = 0; i < N; i++)
{
    if (start[i] != arrival[i])
    {
        overtaking++;
    }
}

Console.WriteLine(overtaking);