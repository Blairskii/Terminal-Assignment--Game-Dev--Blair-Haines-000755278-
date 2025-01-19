using System.Diagnostics;

Start:
Console.WriteLine("You come across a mysterious cabinet you cant seem to recognize");
//Player options for scenario 1 
Console.WriteLine("do you [open] the cabinet?" );
Console.WriteLine("do you leave the cabinet [closed]?");
//get player input 
string input = Console.ReadLine();
//check player response From First Scenario
if (input == "open") 
{
    //"open" choice path
    //-not working
    //figured it out, unfinished rogue bracket
    //unintentionally have "enter" prompt, kinda works,don't know why
    Console.WriteLine("you open the door and step into a magical ethereal world!");
}
else if (input == "closed") 
    //"closed" choice path
{
    Console.WriteLine("are you sure you want to keep the cabinet [closed] or will you [open] it?");
    string input2 = Console.ReadLine();
    if (input2 == "open")
        Console.WriteLine("you open the door and step into a magical ethereal world!");
        
    else  
    {
        Console.WriteLine("You are sucked in to a magical ethereal world!");
    }
}
else
{
    //rewrite this in theme or end
    Console.WriteLine("You entered an invalid input");
    goto Start;
}
Console.WriteLine("After Gaining your bearings, your eyes focus and rest upon a grungy man waving at you.");
    
// ask player name 
    
        Console.WriteLine("Hello!\nyou look positively confused! what is your name?");
        string playername = Console.ReadLine();
        Console.WriteLine();
//repeat back input name
        Console.WriteLine($"Nice to meet you {playername}!");
    
//tell player about hatchet for sale
    Console.Write("theres something strange happening over at the farm"+
        " you should have a weapon to protect yourself with" );
        Console.WriteLine("im selling a Hatchet for only 2 pennies.");
        //ask for pennies
        Console.WriteLine("how many pennies do you have?");
        bool hasHatchet = false;
        int pennies = int.Parse(Console.ReadLine());
//response to enough pennies
        if (pennies >= 2)
        {
            hasHatchet = true;
            Console.WriteLine("I'll take those 2 pennies");
            Console.WriteLine();
            Console.WriteLine("heres your hatchet");
            // have to hit enter twice for input to register
            
                Console.WriteLine("thank you for your lovely pennies.");
                
            

// deduct pennies. //
            pennies -= 2;
            //update player on their pennies
            Console.WriteLine($"you have {pennies} pennies left, " +
                              $"can you head to the farm to check on farmer John, im worried about him.");
        }
        //not enough
        else
        {
            Console.WriteLine("you dont have enough, maybe you should check out the campsite, i heard wood chopping over there.");
        }
Console.Write("you leave the strange salesman and wander further ahead close by you see a campsite. About three kilometres away is a farm");
//player options for scenario 
Travel: 
        Console.WriteLine("do you check out the [campsite]?");
        Console.WriteLine("do you trek to the [farm]");
//farm and campsite scenario
        Console.WriteLine();
        bool isDead = false;
        string input3 = Console.ReadLine();
        if (input3 == "campsite")
        {
            Console.Write("you walk up to the campsite and notice" +
                          " a hatchet stuck into a pile of wood");
            Console.WriteLine("do you take the hatchet and go to the [farm]" +
                              " or continue to [search]?");

            string input5 = Console.ReadLine();
            if (input5 == "farm")
                Console.WriteLine("you arrive thirsty and tired to a Farmhouse with the door wide open");
            else if (input5 == "search")
            {
                Console.WriteLine($"you dont find anything but the hatchet and head to the farmhouse anyways");

            }

            hasHatchet = true;
        }
        else if (input3 == "farm")
        {
            Console.Write("you arrive thirsty and " +
                          "tired to a Farmhouse with the door wide open");
        }
        else
        {
            Console.WriteLine("You entered an invalid input");
            goto Travel;
        }
// second farm scenario
            Console.WriteLine(" do you [enter] or [yell]");
        
        string input6 = Console.ReadLine();
        if (input6 == "enter")
        {
            Console.WriteLine(
                "you enter the farmhouse." +
                " its seems deserted." +
                " but you notice a trail of blood leading into the hallway");
        }
        else if (input6 == "yell")
        {
            Console.WriteLine("you hear nothing except for wind chimes.");
            Console.WriteLine();
            Console.WriteLine("do you [Leave] the farmhouse?");
            Console.WriteLine();
            Console.WriteLine("or do you [enter] the farmhouse through the open door?");
            string input7 = Console.ReadLine();
            if (input7 == "enter")
            {
                Console.WriteLine(
                    "you enter the farmhouse." +
                    " its seems deserted." +
                    " but you notice a trail of blood leading into the hallway");

            }
            else
            {
                Console.WriteLine(
                    "you leave the farmhouse.out of the corners of your eyes you see flickering shadows as if the light behind you is being blocked" +
                    "you turn around to see what it is" +
                    "but its too late... a knife is in your back");
                isDead = true;
                goto Ending;
            }
        }

        Console.WriteLine("will you [follow] the trail of blood or [leave]?");
            string input8 = Console.ReadLine();
            if (input8 == "follow")
            {
                if (hasHatchet)
                {


                    Console.Write("you brandish your hatchet and follow the blood trail");
                    Console.WriteLine(" you enter the room the blood trail was leading to, ready to fuck shit up" +
                                      "you hear a floorboard creak just to the left of the door frame" +
                                      "without hesitation you swing your hatchet inside the door frame" +
                                      "THUNK" +
                                      "you hear a scream and a thud as a bloodied leper falls to the floor");
                }
                else
                {
                    Console.WriteLine("You follow the trail to a darkened room." +
                                      "carefully you poke your head in to see if anything is in there" +
                                      "you look to the left, nothing..." +
                                      "you look to the right, man with big sword" +
                                      "theres nothing you can do now" +
                                      "you accept your fate as your head is cleaved off");
                    isDead = true;
                }
            }
            else
            {
                Console.WriteLine(
                    "you leave the farmhouse.out of the corners of your eyes you see flickering shadows as if the light behind you is being blocked" +
                    "you turn around to see what it is" +
                    "but its too late... a knife is in your back");
                isDead = true;
            }

            Ending:
            Console.WriteLine(
                "You are abruptly sucked backward, taking in the trail you've followed back into the cabinet where you started" +
                "you awake in your bed" +
                "it was all a dream");
            Console.WriteLine(hasHatchet ? "You remember getting a Hatchet" : "You failed to get a Hatchet");
            Console.WriteLine(isDead ? "you remember being murdered" : "you remember killing a Leper farmer murderer");
        
        
        