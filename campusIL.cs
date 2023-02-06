
class Program
{

    static void Main(string[] args)
    {
        
     
    }
    // מסיבת יום הולדת
    private static void BirthdayBalloons()
    {
            Console.WriteLine("Enter the number of participants: ");
            int participants = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of balloons: ");
            int balloons = int.Parse(Console.ReadLine());

            int balloonsPerParticipant = balloons / participants;
            int balloonsLeft = balloons % participants;

            Console.WriteLine("Each participant will receive " + balloonsPerParticipant + " balloons.");
            Console.WriteLine("The organizer will have " + balloonsLeft + " balloons left.");

    }

    // הופכים מספר דו-ספרתי
    private static void ReverseNumber()
    {
            Console.Write("Enter a two-digit number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            int firstDigit = inputNumber % 10;
            int secondDigit = inputNumber / 10;
            int reversedNumber = firstDigit * 10 + secondDigit;

            Console.WriteLine("The reversed number is: " + reversedNumber);  
    }

    // הופכים מספר תלת-ספרתי
    private static void Reverse3Number()
    {
        Console.WriteLine("Enter 3 Numbers");
        int inputNumber = int.Parse(Console.ReadLine());

        int firstDigit = ((inputNumber / 100) % 10);
        int secondDigit = inputNumber / 10;
        int ThirdDigit = inputNumber / 100;

        int reversedNumber = (firstDigit * 100) + (secondDigit * 10) + ThirdDigit;
        
        Console.WriteLine("The reversed number is: " + reversedNumber);  

    }

    // חדר במלון מספר חדר וקומה
    private static void RoomHotel()
    {
        Console.WriteLine("Enter Full Number Of the Room");
        int NumberRoom = int.Parse(Console.ReadLine());
        Console.WriteLine("Floor: " + (NumberRoom / 100));
        Console.WriteLine("Room: " + (NumberRoom % 100));
    }

    // מספר 6 ספרתי לתאריך
    private static void Number6ForData()
    {
        Console.WriteLine("Enter Number");
        int InputUser = int.Parse(Console.ReadLine());
        int day = InputUser / 10000;
        int mounth = ((InputUser / 100) % 10);
        int year = InputUser = InputUser % 100;
        Console.WriteLine(day + "/" + mounth + "/" + year);
    }

    // ?כמה עודף מגיע
    private static void CashRegister()
    {
        Console.WriteLine("How much pay?");
        int amountToPay = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Money from the customer?");
        int moneyReceived = int.Parse(Console.ReadLine());
        
        int excess = moneyReceived - amountToPay;
        Console.WriteLine("Left: " + excess);

        int num10NIS = excess / 10;
        excess = excess % 10;
        Console.WriteLine(num10NIS + " coins of 10 NIS");

        int num5NIS = excess / 5;
        excess = excess % 5;
        Console.WriteLine(num5NIS + " NIS 5 coins");

        int num2NIS = excess / 2;
        excess = excess % 2;
        Console.WriteLine(num2NIS + " NIS 2 coins");

        Console.WriteLine(excess + " NIS 1 coins");

    }

}
