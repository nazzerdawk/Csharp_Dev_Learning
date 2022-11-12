
/*
    This is a simple program I created after a prompt on kudvenkat's C# tutorial on Youtube. In part 12, at about 3:50, I saw what he was going
    for and launched into my own version of the program. I thought I'd add tax, try using the TryParse method a bit more, try out storing prices
    using the Float datatype (And when that gave a fractional result more than 2 decimal places, found out how to round decimal types to better
    resemble real-world price calculations.) I also wanted to see if I could make it loop with a While loop so that the program has a bit more 
    of a limited set of states: The next implementation of this I would try would be setting up a finite state machine, possibly even with 
    placeholder imaginary methods for triggering automated kitchen actions as if this were the console kiosk interface for a retro-futuristic
    AutoCafe. I could also easily add various customization options, price variations, coupon code simulation.
    The Coffeebilities are Endless!
                                        (Please don't hit me.)
    
    For added fun, try some invalid inputs, I think I worked out most of the possible exceptions quite broadly (At one point I tried 
    to do some Try/Catch/Finally commands for specific likely invalid inputs, but I quickly recognized that trying to achieve that scope was a 
    bit of overkill for a program with such a finite possibility space. )

*/
internal class Program
{ 
    static void Main(string[] args)
    {
        
        decimal SubTotal = 0.00M; //The M suffix identifies the input data as a Decimal number. If no letter suffix is usesd, it is treated as Int32.
        decimal TaxRate = 1.0086M;
        decimal Total = 0.00M;
        
        int UserChoice;
        bool ValidSelectionMade = false; //This is used to identify if the program needs to restart.    

        while (ValidSelectionMade == false) //Main loop of program
            {
                Console.WriteLine("1 - Small, 2 - Medium, 3 - Large ");
                string? UserInput = Console.ReadLine(); //Made this nullable, but I notice that as an external terminal application, it doesn't seem like 
                                                        //null values happen even if enter is pressed with an empty input line. 

                bool IsInputValid = false;
                
                if (UserInput != null) {
                        {IsInputValid = int.TryParse(UserInput, out UserChoice);}  //See if the input is just integers. 
                    if (IsInputValid == false)
                        {Console.WriteLine("Invalid Entry. Try again."); continue;} //Continue skips the rest of the iteration of this loop. Will loop again as long 
                                                                                    //as ValidSelectionMade = false
                } 
                else 
                    {Console.WriteLine("Please select an option."); continue;}

                switch (UserChoice){
                    case 1: {SubTotal += 1.50M; ValidSelectionMade = true ;} break;
                    case 2: {SubTotal += 2.25M; ValidSelectionMade = true ;} break;
                    case 3: {SubTotal += 2.75M; ValidSelectionMade = true ;} break;
                    default: {Console.WriteLine("Choice \"{0}\" is Invalid.",UserChoice); continue;} 
                }
                
                Total = SubTotal*TaxRate;
                Total = Decimal.Round(Total,2); //Rounds to 2 decimal places! Vital for prices. 
                Console.WriteLine("Total is : ${0}",Total);
                Console.ReadKey();
                Console.WriteLine("Do you have another order? Y/N");
                UserInput = Console.ReadLine();
                UserInput = UserInput.ToUpper();
                switch (UserInput){ //Yes inputs reset the main loop
                    case "Y": ValidSelectionMade = false ; continue;
                    case "N": Console.WriteLine("Thank you! Please come again."); break;
                    default: Console.WriteLine("Invalid Input, Please Try Again."); break;
                }
            }
        Console.WriteLine("Have a nice day!\nPress Enter To Exit.");

        /////////Leave this for console to stay visible after execution of final line. 
        Console.ReadKey();
    }

}
