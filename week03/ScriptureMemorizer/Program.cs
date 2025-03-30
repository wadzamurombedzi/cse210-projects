using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop 3 World!\n");

        Console.WriteLine("********** Welcome to my Scripture Memorizer App **********");
        Console.WriteLine("             Let us start Memorizing!             ");

        DisplayReference theReference = new(book:"", chapter:1, verse:1);

        Console.Write("Enter the Scripture in the format - (Book, Chapter, Verse(s) separated by ',') : ");
        string[] listRef = Console.ReadLine().Split(",");

        if (listRef.Count() == 4)
        {
            theReference = new DisplayReference(book:listRef[0], chapter:int.Parse(listRef[1]), verse:int.Parse(listRef[2]), verses:int.Parse(listRef[3]));
        }
        if (listRef.Count() == 3)
        {
            theReference = new DisplayReference(book:listRef[0], chapter:int.Parse(listRef[1]), verse:int.Parse(listRef[2]));
            Console.WriteLine("Enter the scripture verse :\n ");
            theReference.SetVerse();

            Scripture scripture = new(theReference);

            string isQuit = "";
            while (isQuit != "quit")
            {
                if(scripture.IsAllWordHidden())
                {
                    break;
                }
                scripture.HideWord(5);
                Console.Clear();
                scripture.DisplayText();

                Console.Write("Press enter to continue and 'Quit' to stop the program: ");
                isQuit = Console.ReadLine().ToLower();
            }
        }
    }
}
    