
// Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
// Console.WriteLine("--------------------------------------------");
// Console.WriteLine();


// void MooseSays(string message)
// {
//     Console.WriteLine($@"
//                                        _.--^^^--,
//                                     .'          `\
//   .-^^^^^^-.                      .'              |
//  /          '.                   /            .-._/
// |             `.                |             |
//  \              \          .-._ |          _   \
//   `^^'-.         \_.-.     \   `          ( \__/
//         |             )     '=.       .,   \
//        /             (         \     /  \  /
//      /`               `\        |   /    `'
//      '..-`\        _.-. `\ _.__/   .=.
//           |  _    / \  '.-`    `-.'  /
//           \_/ |  |   './ _     _  \.'
//                '-'    | /       \ |
//                       |  .-. .-.  |
//                       \ / o| |o \ /
//                        |   / \   |    {message}
//                       / `^`   `^` \
//                      /             \
//                     | '._.'         \
//                     |  /             |
//                      \ |             |
//                       ||    _    _   /
//                       /|\  (_\  /_) /
//                       \ \'._  ` '_.'
//                        `^^` `^^^`
//     ");

// }

// // Let the moose speak!
// MooseSays("H I, I'M  E N T H U S I A S T I C !");
// MooseSays("I really am enthusiastic");

// bool MooseAsks(string question)
// {
//     // {question} allow you to pass a question that can be answered with the one of the parameter (Y/N)
//     Console.Write($"{question} (Y/N): ");
//     string answer = Console.ReadLine().ToLower(); //answer will be read through the console and will be set to lower case

//     while (answer != "y" && answer != "n")
//     {
//         Console.Write($"{question} (Y/N): ");
//         answer = Console.ReadLine().ToLower();
//     }

//     if (answer == "y")
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// // As a question
// // bool isTrue = MooseAsks("Is Canada real?");
// // Console.WriteLine(isTrue);

// // Ask a question
// bool isTrue = MooseAsks("Is Canada real?");
// if (isTrue)
// {
//     MooseSays("Really? It seems very unlikely.");
// }
// else
// {
//     MooseSays("I  K N E W  I T !!!");
// }



// void CanadaQuestion()
// {
//     bool isTrue = MooseAsks("Is Canada real?");
//     if (isTrue)
//     {
//         MooseSays("Really? It seems very unlikely.");
//     }
//     else
//     {
//         MooseSays("I  K N E W  I T !!!");
//     }
// }

// void EnthusiasticQuestion()
// {
//     bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
//     if (isEnthusiastic)
//     {
//         MooseSays("Yay!");
//     }
//     else
//     {
//         MooseSays("You should try it!");
//     }
// }

// void LoveCSharpQuestion()
// {
//     bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
//     if (doesLoveCSharp)
//     {
//         MooseSays("Good job sucking up to your instructor!");
//     }
//     else
//     {
//         MooseSays("You will...oh, yes, you will...");
//     }
// }

// void SecretQuestion()
// {
//     bool wantsSecret = MooseAsks("Do you want to know a secret?");
//     if (wantsSecret)
//     {
//         MooseSays("ME TOO!!!! I love secrets...tell me one!");
//     }
//     else
//     {
//         MooseSays("Oh, no...secrets are the best, I love to share them!");
//     }
// }

// // Ask some questions
// CanadaQuestion();
// EnthusiasticQuestion();
// LoveCSharpQuestion();
// SecretQuestion();

// Main();

// void Main()
// {
//     Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine();

//     // Let the moose speak!
//     MooseSays("H I, I'M  E N T H U S I A S T I C !");
//     MooseSays("I really am enthusiastic");

//     // As a question
//     CanadaQuestion();
//     EnthusiasticQuestion();
//     LoveCSharpQuestion();
//     SecretQuestion();
// }

// using System;
// using System.Collections.Generic;

// class FortuneTellingMoose
// {
//     static void Main()
//     {
//         Random rand = new Random();
//         List<string> responses = new List<string>()
//         {
//             "It is certain",
//             "It is decidedly so",
//             "Without a doubt",
//             "Yes, definitely",
//             "You may rely on it",
//             "As I see it, yes",
//             "Most likely",
//             "Outlook good",
//             "Yes",
//             "Signs point to yes",
//             "Reply hazy, try again",
//             "Ask again later",
//             "Better not tell you now",
//             "Cannot predict now",
//             "Concentrate and ask again",
//             "Don't count on it",
//             "Outlook not so good",
//             "My sources say no",
//             "Very doubtful",
//             "My reply is no"
//         };

//         Console.WriteLine("Welcome to the Fortune Telling Moose! Ask me any yes or no question, and I'll give you an answer. Hit ENTER without typing a question to exit.");
        
//         // Loop until the user hits ENTER without typing a question
//         while (true)
//         {
//             Console.Write("\nWhat is your question? ");
//             string question = Console.ReadLine();
            
//             // Exit the program if the user hits ENTER without typing a question
//             if (question.Trim() == "")
//             {
//                 break;
//             }

//             // Generate a random index to select a response from the list of possible responses
//             int responseIndex = rand.Next(responses.Count);

//             Console.WriteLine("\nThinking...\n");
//             Console.WriteLine(responses[responseIndex]);
//         }

//         Console.WriteLine("\nThank you for using the Fortune Telling Moose. Press any key to exit.");
//         Console.ReadKey();
//     }
// }


// using System;
// class RockPaperScissors
// {
//     Random rand = new Random();
//         List<string> responses = new List<string>()
//         {
//             "Rock",
//             "Paper",
//             "Scissors",
//         };

//     // Loop until the user hits ENTER without typing a question
//     while (true)
//     {
//         Console.Write("\nWhat is your question? ");
//         string question = Console.ReadLine();
        
//         // Exit the program if the user hits ENTER without typing a question
//         if (question.Trim() == "")
//         {
//             break;
//         }

//         // Generate a random index to select a response from the list of possible responses
//         int responseIndex = rand.Next(responses.Count);

//         Console.WriteLine("\nThinking...\n");
//         Console.WriteLine(responses[responseIndex]);
//     }
        


    // Console.WriteLine("----------------------------------------");
    // Console.WriteLine("| Player: score | Computer: score|");
    // Console.WriteLine("----------------------------------------");
// }


// a list for rock paper and scissors
// while statement that plays until score is 3 if score = 3 displace you win or lose
//{score}
// random generator for computer output
//user enters their input 

