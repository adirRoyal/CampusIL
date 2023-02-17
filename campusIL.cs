public void BirthdayBalloons()
        {
            Console.WriteLine("Enter the number of participants: ");
            string participants = Console.ReadLine();
            int participantint = 0;

            if(int.TryParse(participants, out participantint))
                {

            
                Console.WriteLine("Enter the number of balloons: ");
                string balloons = Console.ReadLine();
                int balloonint = 0;
                if(int.TryParse(balloons, out balloonint))
                {
                    int balloonsPerParticipant = balloonint / participantint;
                    int balloonsLeft = balloonint % participantint;

                    Console.WriteLine("Each participant will receive " + balloonsPerParticipant + " balloons.");
                    Console.WriteLine("The organizer will have " + balloonsLeft + " balloons left.");
                }
                else
                {
                    Console.WriteLine("Input cannot be null or empty or String");
                }

            }
            else
            {
                Console.WriteLine("Input cannot be null or empty or String");
            }
      

        }

        // הופכים מספר דו-ספרתי
        public void ReverseNumber()
        {
            Console.Write("Enter a two-digit number: ");
            string inputNumber = Console.ReadLine();
            if (int.TryParse(inputNumber, out int number))
            {
                int firstDigit = number % 10;
                int secondDigit = number / 10;
                int reversedNumber = firstDigit * 10 + secondDigit;

                Console.WriteLine("The reversed number is: " + reversedNumber);
            }
            else
            {
                Console.WriteLine("Input cannot be null or empty or String");
            }
        }

        // הופכים מספר תלת-ספרתי
        public void Reverse3Number()
        {
            Console.WriteLine("Enter 3 Numbers");
            string inputNumber = Console.ReadLine();
            if(int.TryParse(inputNumber , out int number))
            {
                int firstDigit =number / 100 ;
                int secondDigit = (number / 10) % 10;
                int ThirdDigit = (number % 100) % 10;
                int reversedNumber = (ThirdDigit * 100) + (secondDigit * 10) + (firstDigit);

                Console.WriteLine("The reversed number is: " + reversedNumber);
            }
            
            else
            {
                Console.WriteLine("Input cannot be null or empty or String");
            }

            

        }

        // חדר במלון מספר חדר וקומה
        public void RoomHotel()
        {
            Console.WriteLine("Enter Full Number Of the Room");
            string StringRoom = Console.ReadLine();
            if(int.TryParse(StringRoom , out int NumberRoom))
            {
                Console.WriteLine("Floor: " + (NumberRoom / 100));
                Console.WriteLine("Room: " + (NumberRoom % 100));

            }
            else
            {
                Console.WriteLine("Input cannot be null or empty or String");
            }
        }

        // מספר 6 ספרתי לתאריך
        public void Number6ForData()
        {
            Console.WriteLine("Enter Number");
            string inputString = Console.ReadLine();

            if (!string.IsNullOrEmpty(inputString))
            {
                if (int.TryParse(inputString, out int inputUser))
                {
                    int day = inputUser / 10000;
                    int month = ((inputUser / 100) % 10);
                    int year = inputUser % 100;
                    Console.WriteLine(day + "/" + month + "/" + year);
                }
                else
                {
                    Console.WriteLine("Invalid input for number");
                }
            }
            else
            {
                Console.WriteLine("Input cannot be null or empty");
            }
        }

        // ?כמה עודף מגיע
        public void CashRegister()
        {
            Console.WriteLine("How much pay?");
            string amountToPayString = Console.ReadLine();
            int amountToPay;

            if (int.TryParse(amountToPayString, out amountToPay))
            {
                Console.WriteLine("Money from the customer?");
                string moneyReceivedString = Console.ReadLine();
                int moneyReceived;

                if (int.TryParse(moneyReceivedString, out moneyReceived))
                {
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
                else
                {
                    Console.WriteLine("Invalid input for money received");
                }
            }
            else
            {
                Console.WriteLine("Invalid input for amount to pay");
            }
        }
