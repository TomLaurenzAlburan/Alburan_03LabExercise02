using System;


class LabExercise_Alburan
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Welcome to Our Enrollment Portal!");               // first nag greet po for the uniqueness lang po
            Console.WriteLine("Are you going to enroll in our program? (yes/no)"); // dito po nag ask po tayo sa user/possible enrollee
            string response = Console.ReadLine().Trim().ToLower(); // user inputted yung answer sa yes/no, nilagay ko into lowercase pero nilagyan ko din ng trim para any case po yung ilagay ng user tatanggapin parin po
            Console.WriteLine();

            if (response == "no") 
            {
                Console.WriteLine("We’re sorry to see you go. Hope to see you soon!"); // dito sa part na 'to pag response mopo is "no" mag e-end na po yung program and ito po yung lalabas
                break;
            }

            Console.WriteLine("Awesome! Let’s get started."); // ito yung lalabas pag "yes" yung response ng user
            Console.Write("First, how much money do you have? "); // dito user inputted kung magkano yung money na meron sila for enrollment
            string moneyInput = Console.ReadLine().Trim(); // dito nilagyan ko ulit ng trim para kung may spaces man malagay yung user hindi siya magiging problem para sa program
            int money = Convert.ToInt32(moneyInput); 

            if (money > 25000) // yung 25000 po dito, assume natin na 25000 na may butal pa yung tuition fee ng mga courses na available dito sa school or available sa school na pag e-enrollan ng enrollee so bawal yung below and equal sa 25000 yung i-input ng user
            {
                Console.WriteLine();
                Console.WriteLine("Perfect! Now, we need to check if you have the required documents."); // print out din pag "yes" ang response ng user
                Console.WriteLine();

                Console.Write("Do you have your SHS/ISD Diploma? (yes/no): "); // user inputted ulit also may trim and to lower case muna pero any case po yung inaaccept niya and if may spaces, okay lang kasi may trim po akong nilagay
                string diploma = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                Console.Write("Do you have your Form 137? (yes/no): "); // same lang po dito up to medical cert na user inputted saka may trim
                string form137 = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                Console.Write("Do you have a Good Moral Certificate? (yes/no): ");
                string goodMoral = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                Console.Write("Do you have a copy of your PSA? (yes/no): ");
                string psa = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                Console.Write("Do you have a Medical Certificate? (yes/no): ");
                string medCert = Console.ReadLine().Trim().ToLower();
                Console.WriteLine();

                if (diploma == "yes" && form137 == "yes" && goodMoral == "yes" && psa == "yes" && medCert == "yes") // dito na po yung pag determine if yes or no yung response ng user for the documents
                {
                    Console.WriteLine();
                    Console.WriteLine("Congratulations! You’ve got everything you need to enroll!"); // print out if all documents are presented then mag e-end na yung program
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Oops! It seems like you're missing some documents. Please make sure you have all of them and come back."); // print out if ever may kulang or wala pong nai-present na document yung user (if may no or puro no yung response niya sa documents) also mag e-end na po yung program after nun
                    break;
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("It looks like you don't have enough money at the moment. Remember, you need more than 25,000."); // dito naman po, print out pag kulang or sakto sa 25000 yung pera na ininput ng user kanina dun sa part na nanghihingi kung magkano yung pera na meron yung user. mag e-end din po yung program pag kulang yung pera or sakto po
                break;
            }

        }
    }
}

