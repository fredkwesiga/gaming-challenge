﻿// See https://aka.ms/new-console-template for more information
using System;
double total = 0;
double minimumSpend = 30.00;

double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    // Calculate the discounted price of the item
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    // Check if the total meets the minimum
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    // Format the double so only 2 decimal places are displayed
    return input.ToString().Substring(0, 5);
}

//Create a method that returns an integer
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");


int UsdToVnd(double usd)
{
    int rate = 23500;
    return (int)(rate * usd);
}

double VndToUsd(int vnd)
{
    double rate = 23500;
    return vnd / rate;
}

//Return strings from methods

string input = "there are snakes at the zoo";
string ReverseWord(string word)
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--)
    {
        result += word[i];
    }
    return result;
}
Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

//revese and maintain position of each word
string ReverseSentence(string input)
{
    string result = "";
    string[] words = input.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }

    return result.Trim();
}
Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));


//Create a method that returns a Boolean
string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

Console.WriteLine("Is it a palindrome?");
foreach (string word in words)
{
    Console.WriteLine($"{word}: {IsPalindrome(word)}");
}

bool IsPalindrome(string word)
{
    int start = 0;
    int end = word.Length - 1;

    while (start < end)
    {
        if (word[start] != word[end])
        {
            return false;
        }
        start++;
        end--;
    }

    return true;
}
//Return arrays from methods.

int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target)
{
    for (int curr = 0; curr < coins.Length; curr++)
    {
        for (int next = curr + 1; next < coins.Length; next++)
        {
            if (coins[curr] + coins[next] == target)
            {
                return new int[] { curr, next };
            }

        }
    }

    return new int[0];
}

//Exercise - Complete the challenge to add methods to make the game playable
Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay()){
    PlayGame();
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

void PlayGame(){
    var play = true;
    while (play) {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();

    }
}

int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}


