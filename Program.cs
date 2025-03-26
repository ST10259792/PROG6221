
Console.WriteLine("Playing MP3 file...");



Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online.");
Console.WriteLine("   /\\   ");
Console.WriteLine("  /  \\  ");
Console.WriteLine(" /____\\ ");
Console.WriteLine(" |    | ");
Console.WriteLine(" |____| ");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("What is your name?");

Console.ForegroundColor = ConsoleColor.White;
string Name = Console.ReadLine();
Console.WriteLine("Nice to meet you " + Name + ".");

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("How are you?");
string howYou = Console.ReadLine();

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("That is awesome! I'm doing great!");


int point = 0;


//Q1
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Would you like to learn about Cyber Security? ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1) Yes");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2) No");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("EG:Enter '1'");
int YesNo1 =0;

try {
    Console.ForegroundColor = ConsoleColor.White;
    YesNo1 = Convert.ToInt32(Console.ReadLine());
}
catch(Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
}

if (YesNo1 == 1)
{
    point = 1;
}
if(YesNo1 ==2)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Haha, but let me teach you anyway;)");
    point = 1;
}

while (point == 0)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Would you like to learn about cyber security? ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1) Yes");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("2) No");
    try
    {
        Console.ForegroundColor = ConsoleColor.White;
        YesNo1 = Convert.ToInt32(Console.ReadLine());
    }
    catch(Exception e)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("I didn't quite understand that. Could you rephrase?");
    }
    if (YesNo1 == 1)
    {
        point = 1;
    }
    if (YesNo1 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Haha, but let me teach you anyway;)");
        point = 1;
    }
    
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Okay great lets begin:");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("**********************");


//Q2
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Would you like to learn about VPN Security? ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1) Yes");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2) No");
int YesNo2=0;
try
{
    Console.ForegroundColor = ConsoleColor.White;
    YesNo2 = Convert.ToInt32(Console.ReadLine());
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
}

if (YesNo2 == 1)
{
    point = 2;
}
if (YesNo2 == 2)
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Haha very funny, but let me teach you anyway;)");
    point = 2;
}

while (point == 1)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Would you like to learn about VPN Security? ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1) Yes");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("2) No");
    
    try
    {
        Console.ForegroundColor = ConsoleColor.White;
        YesNo2 = Convert.ToInt32(Console.ReadLine());

        if (YesNo2 == 1)
        {
            point = 3;
        }
        if (YesNo2 == 2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Let me mention it anyway just incase you missed something;)");
            point = 3;
        }
    }
    catch(Exception e)
    {
        point = 1;
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Haha very funny, but let me teach you anyway;)");
    }


  
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("A VPN, or virtual private network, encrypts your internet traffic, making it harder for hackers, ISPs (internet service providers), or other prying eyes to monitor your online activities. When you connect to a VPN, your data travels through a secure tunnel, ensuring confidentiality.");



//Q3
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Would you like to learn about Trojen Attack? ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1) Yes");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2) No");
int YesNo3 = 0;



try
{
    Console.ForegroundColor = ConsoleColor.White;
    YesNo3 = Convert.ToInt32(Console.ReadLine());
    if (YesNo3 == 1)
    {
        point = 4;
    }
    if (YesNo3 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Okay but let me still tell you a little...");
        point = 4;
    }
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
}



while (point == 1)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Would you like to learn about Trojen Attacks? ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1) Yes");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("2) No");
    YesNo3 = 0;
    try
    {
        Console.ForegroundColor = ConsoleColor.White;
        YesNo3 = Convert.ToInt32(Console.ReadLine());
        if (YesNo3 == 1)
        {
            point = 4;
        }
        if (YesNo3 == 2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Okay but let me still tell you a little...");
            point = 4;
        }
    }
    catch (Exception e)
    {
        point = 1;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("I didn't quite understand that. Could you rephrase?");
    }

    
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("A Trojan (often referred to as a Trojan virus) is a type of malware that hides within a legitimate file or program to gain access to your device. Because Trojan malware is delivered inside a legitimate app or file, it’s very difficult to detect.");



//Q4
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Would you like to learn about Phishing attacks? ");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("1) Yes");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("2) No");
int YesNo4 = 0;
try
{
    Console.ForegroundColor = ConsoleColor.White;
    YesNo4 = Convert.ToInt32(Console.ReadLine());
    if (YesNo4 == 1)
    {
        point = 4;
    }
    if (YesNo4 == 2)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Well then let me teach you a little more anyway;)");
        point = 4;
    }
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("I didn't quite understand that. Could you rephrase?");
}


while (point==1)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Would you like to learn about Phishing attacks? ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1) Yes");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("2) No");
    YesNo4 = 0;


    try
    {
        Console.ForegroundColor = ConsoleColor.White;
        YesNo4 = Convert.ToInt32(Console.ReadLine());
        if (YesNo4 == 1)
        {
            point = 4;
        }
        if (YesNo4 == 2)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Well then let me teach you a little more anyway;)");
            point = 4;
        }
    }
    catch (Exception e)
    {
        point = 1;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("I didn't quite understand that. Could you rephrase?");
    }

    
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Phishing is a form of online fraud in which hackers attempt to get your private information such as passwords, credit cards, or bank account data. This is usually done by sending false emails or messages that appear to be from trusted sources like banks or well-known websites. They aim to convince you so that they can manage to have your information and use it as a fraudster. Always ensure that you are certain about whom you are dealing with before you provide any information.");


//Final Greeting
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Thank you for learning about Cyber Security Here is a Virtual Gift.");
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("  **     **  ");
Console.WriteLine(" *  *   *  * ");
Console.WriteLine("*    * *    *");
Console.WriteLine(" *    *    * ");
Console.WriteLine("  *       *  ");
Console.WriteLine("   *     *   ");
Console.WriteLine("    *   *    ");
Console.WriteLine("     * *     ");
Console.WriteLine("      *      ");


