/*
    Hello Denizens of the future world! This is my first non-gamemaker program! I know it's technically still... a game of sorts
    but I am proud of it nonetheless. This is the start of what I hope to be a future bright and shiny with many opportunities
    and adventures. And maybe a bit more money for my family. That would be nice. 
*/


internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Skynet";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WindowHeight = 40;

        Console.WriteLine("Hello! This is my Madlibs Implementation. \nIt is quite a simple one, so please be gentle.");
        Console.WriteLine("First, we will need a Plural Noun");
        string? userentry1 = Console.ReadLine();
        Console.WriteLine("Next, we will need another Plural Noun");
        string? userentry2 = Console.ReadLine();
        Console.WriteLine("Then an Adjective.");
        string? userentry3 = Console.ReadLine();
        Console.WriteLine("Now a Type of Liquid");
        string? userentry4 = Console.ReadLine();
        Console.WriteLine("Animal (Plural)");
        string? userentry5 = Console.ReadLine();
        Console.WriteLine("An Adjective");
        string? userentry6 = Console.ReadLine();
        Console.WriteLine("A Funny Noise");
        string? userentry7 = Console.ReadLine();
        Console.WriteLine("Another Funny Noise");
        string? userentry8 = Console.ReadLine();
        Console.WriteLine("An Adjective");
        string? userentry9 = Console.ReadLine();
        Console.WriteLine("A Plural Noun.");
        string? userentry10 = Console.ReadLine();
        Console.WriteLine("An Animal");
        string? userentry11 = Console.ReadLine();
        Console.WriteLine("Another Animal");
        string? userentry12 = Console.ReadLine();
        Console.WriteLine("Part of the Body");
        string? userentry13 = Console.ReadLine();
        Console.WriteLine("Plural Noun");
        string? userentry14 = Console.ReadLine();
        Console.WriteLine("Adjective.");
        string? userentry15 = Console.ReadLine();
        Console.WriteLine("Okay! Getting the story now...");
        Console.WriteLine("Done!"); 
        Console.WriteLine("[Press Enter to Start]");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("");
        Console.WriteLine("----A Visit to the Zoo----");
        WriteLinePrompt("");
        WriteLinePrompt("Zoos are places where wild " + userentry1 + " are kept in pens or cages so that " +userentry2 + " can come and look at them.");
        WriteLinePrompt("There are two zoos in New York, one in the Breonx and one in " + userentry3 + " Park.");
        WriteLinePrompt("The Park zoo is built around a large pond filled with clear sparkling " +userentry4 + ".");
        WriteLinePrompt("You will see several " +userentry5 + " swimming in the pond and eating fish.");
        WriteLinePrompt("When it is feeding time, all of the animals make " + userentry6 + " noises");
        WriteLinePrompt("The elephant goes " + userentry7 + " and the turtledoves go " + userentry8 + ".");
        WriteLinePrompt("In one part of the zoo, there are " +userentry9 + " gorillas who love to eat " +userentry10 + ".");
        WriteLinePrompt("In another building, there is a spotted African " + userentry11 + " that is so fast it can outrun a/an " +userentry12 + ".");
        WriteLinePrompt("But my favorite animal is the hippopotomaus. ");
        WriteLinePrompt("It has a huge " +userentry13 + " and eats fifty pounds of " +userentry14 + " a day. ");
        WriteLinePrompt("You would never know that, technically, it's nothing but an oversized " +userentry15 + " pig."); 
        WriteLinePrompt("");
        WriteLinePrompt("The End!");
        WriteLinePrompt("Madlib text from GOOFY MAD LIBS® copyright © 2001, 1998 by Price Stern Sloan, a division of Penguin Putnam Books for Young Readers, New York. ");
        Console.WriteLine("Press any Key to Exit Application.");        
        Console.ReadKey();
    }

    public static void WriteDisappearingLine(string _string){
            //Writes a line to the console that disappears when Enter is pressed.
            //Example: WriteDisappearingLine("[Press Enter To Continue"]);

            Console.WriteLine(_string);
            Console.ReadKey();
            Console.SetCursorPosition(0 ,Console.CursorTop-1);
            ClearCurrentConsoleLine(); 
    }
    public static void WriteLinePrompt(string _line, string _prompt = "Press Enter To Continue"){
        Console.WriteLine(_line);
        WriteDisappearingLine(_prompt);
    }
    public static void ClearCurrentConsoleLine(){
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth)); 
        Console.SetCursorPosition(0, currentLineCursor);
    }
}