using SPG.Parsable.Demo;

int i = int.Parse("1234");
Console.WriteLine(i);

int j= 0;

if(int.TryParse("1234", out j))
{
    Console.WriteLine("Nope!");
}

int wordCount = "Hello World! Lorem Ipsum whatever".CountWords();

Person p = "V, W, 8.2.1996".Parse<Person>();//string muss lernen dass er parsen kann mit ExtensionMethode
Console.Read();