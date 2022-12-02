Console.Clear();

string[] ArrayMaxTextThreeLength = { "Всё", "будет", "не", "надо", "спешить", "так", "!"};
string str = string.Join(", ", ArrayMaxTextThreeLength);
Console.WriteLine($"[{str}] -> ");

for (int i = 0; i < ArrayMaxTextThreeLength.Length; i++)

{
    if (ArrayMaxTextThreeLength[i].Length <= 3)
    {
        if (i != ArrayMaxTextThreeLength.Length - 1)
            Console.Write($"{ArrayMaxTextThreeLength[i]} ");

        else
            Console.Write($"{ArrayMaxTextThreeLength[i]}");
    }
}

