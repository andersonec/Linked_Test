string input;

while ((input = Console.ReadLine()) != null)
{
    string[] dimensions = input.Split();
    int Width = int.Parse(dimensions[0]);
    int Length = int.Parse(dimensions[1]);

    int totalWidth = Width % 2 == 0 ? Width / 2 : (Width + 1) / 2;
    int totalLength = Length % 2 == 0 ? Length / 2 : (Length + 1) / 2;

    Console.WriteLine(totalWidth * totalLength);
}