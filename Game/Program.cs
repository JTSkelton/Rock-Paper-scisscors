 using System;
 using System.Collections.Generic;
//  using Scrabble;

 public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Your Word:");
      var word = Console.ReadLine();
      
      
      static string CheckScore(string word)
      {
      char[]charArray = word.ToCharArray();
      var score = 0;
      Dictionary<char, int> myDictionary = new Dictionary<char, int>() 
      { 
        {'a', 1}, 
        {'e', 1}, 
        {'i', 1},
        {'o', 1},
        {'u', 1},
        {'l', 1},
        {'n', 1},
        {'r', 1},
        {'s', 1},
        {'t', 1},
        {'d', 2}, 
        {'g', 2}, 
        {'b', 3},
        {'c', 3},
        {'m', 3},
        {'p', 3},
        {'f', 4},
        {'h', 4},
        {'v', 4},
        {'w', 4}, 
        {'y', 4},
        {'k', 5},
        {'j', 8}, 
        {'x', 8}, 
        {'q', 10},
        {'z', 10} 
      };
      foreach(var letter in charArray)
      if(myDictionary.ContainsKey(letter))
      {
        score += myDictionary[letter]; 
      }
      return "Your score is: " + score.ToString();
      }
      System.Console.WriteLine(CheckScore(word));
    }
  }