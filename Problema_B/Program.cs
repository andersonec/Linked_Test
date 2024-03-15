string[] input = Console.ReadLine().Split();
int N = int.Parse(input[0]);
int H = int.Parse(input[1]);

input = Console.ReadLine().Split();

int count = 0;
for (int i = 0; i < N; i++)
{
    int minimumHeigth = int.Parse(input[i]);
    if (H >= minimumHeigth)
    {
        count++;
    }
}

Console.WriteLine(count);