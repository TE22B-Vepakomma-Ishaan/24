

Console.WriteLine("Announcer: Welcome to Big Lotto's Fun-tastic Fighting Function for Foolish Fiends!");
System.Console.WriteLine("Our annual tournament is currently ongoing, deadline for application is in 1H 28min, would you like to apply for a position?");


Console.WriteLine("what is your name?");
string playerName;


do
{
    System.Console.WriteLine("input your name here down below: ");
    playerName = Console.ReadLine();

    if (playerName == "")
    {
        System.Console.WriteLine("Announcer: If you continue to joke, security will be called. Big Lotto's establishment will not be sullied.");
        System.Console.WriteLine("");
        System.Console.WriteLine("System: Current security on duty: Vannessa.");
        System.Console.WriteLine("Time employed: 2years 7months 13days");
        System.Console.WriteLine("Preferred method of dispatch: Castration.");
        System.Console.WriteLine("Average customer rating: 2/5");
        System.Console.WriteLine("Latest review: User Bootlicker23_2 gave a 1/5");
        System.Console.WriteLine("    Review Comment: \"Dear god is she scary i almost pissed myself! And this wench had the gall to laugh at me, said i was 'too tiny to enjoy tormenting' or some bullshit. Never have i been so humiliatedd in my life i hope this Vanessa hag gets fired!! However, her domineering tone did remind me of my ex-wife. I plan on returning once she's learnt some manners to see if she would like to go on a date.\"");
        System.Console.WriteLine("");
        System.Console.WriteLine("      VannyFanny replies: \"HA u pig i'll crush you if i see your tiny ass here again!\"");
        System.Console.WriteLine("");
    }

    if (playerName.Length > 8)
    {
        System.Console.WriteLine("Announcer: Your mother truly gave you an unfortunate name, one too foolish even for our enterprise. Please consider using a nickname or even your girlfriends name, assuming a sad man like you would have one.");
        System.Console.WriteLine("");
    }
} while (playerName == "" || playerName.Length > 8);


System.Console.WriteLine($"Announcer: Welcome {playerName} to the tournament! Your fight will begin in 30min, please spin the lotto to determine your sparring partner.");





Console.ReadKey();





