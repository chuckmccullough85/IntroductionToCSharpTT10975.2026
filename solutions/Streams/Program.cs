using StreamReader input = new StreamReader("""
D:\Documents\class\CSharp\Introduction C#\code\solutions\Streams\Program.cs
""");

using StreamWriter output = new StreamWriter(@"Output.txt");

string? line = "";
while ((line = input.ReadLine()) != null)
{
    output.WriteLine(line.ToUpper());
}
