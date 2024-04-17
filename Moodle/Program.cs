string path = @"C:\Users\rists\Desktop\TKTK KMT2023\1-K Programmeerimise algkursus - kevad 2024 - J. Voronetskaja\Week 8";
string fileName = "chuck.txt";
string[] lines = File.ReadAllLines(Path.Combine(path, fileName));

//ShowFileContent(lines);

//static void ShowFileContent(string[] fileContentArray)
//{
//    int i = 1;
//    foreach (string line in fileContentArray)
//    {
//        Console.WriteLine($"{i}. {line}");
//        i++;
//    }
//}

//Console.WriteLine(lines.Length);

Console.WriteLine(GetJoke(lines));

static string GetJoke(string[] jokeArray)
{
    Random rnd = new Random();
    return jokeArray[rnd.Next(0, jokeArray.Length)];
}