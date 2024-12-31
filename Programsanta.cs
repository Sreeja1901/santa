﻿// See https://aka.ms/new-console-template for more information
using System;

class SantaGiftingSystem
{
    static void Main()
    {
       
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();       
        int correctAnswers = 0;        
        correctAnswers += AskQuestion("What is your name?", "Rani");
        correctAnswers += AskQuestion("What is Your favourite color?", "Black");
        correctAnswers += AskQuestion("How old are you?", "15");
        correctAnswers += AskQuestion("What is 5 * 6?", "30");
        correctAnswers += AskQuestion("What is your favourite food?", "Biryani");
        int gifts = correctAnswers; 
        Console.WriteLine($"\n{userName}, you answered {correctAnswers} questions correctly.");
        Console.WriteLine($"Santa will give you {gifts} gifts this year!");
        Console.ReadLine();
    }
    static int AskQuestion(string question, string correctAnswer)
    {
        Console.WriteLine(question);
        string userAnswer = Console.ReadLine().Trim();
        if (userAnswer.Equals(correctAnswer, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Correct!");
            return 1;  
        }
        else
        {
            Console.WriteLine("Incorrect.");
            return 0; 
        }
    }
}

