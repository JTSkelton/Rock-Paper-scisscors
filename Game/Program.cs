 using System;
//  using Scrabble;

 public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter Your Word:");
      var word = Console.ReadLine();

      static int CheckScore(string word)
      {
      char[]charArray =word.ToCharArray();
        var count = 0;
        //var letters = ("A", "E", "I", "O", "U", "L", "N", "R", "S", "T");
      var letters = "aeioulnrst";
      char[] letter1Array = letters.ToCharArray();
      var letters2 ="dg";
      char[] letter2Array = letters2.ToCharArray();
      var letters3= "bcmp";
      char[] letter3Array = letters3.ToCharArray();
      var letters4="fhvwy";
      char[] letter4Array = letters4.ToCharArray();
      var letters5="k";
      char[] letter5Array = letters5.ToCharArray();
      var letters6="jx";
      char[] letter6Array = letters6.ToCharArray();
      var letters7="qz";
      char[] letter7Array = letters7.ToCharArray();
      
      foreach (var chars in charArray){
        foreach(var letter1 in letter1Array){
          if (chars == letter1) 
          {
            count ++;
          }
        }
        foreach(var letter2 in letter2Array){
          if (chars == letter2)
          {
            count += 2;
          }
        }
        
      }
      return count;
    }
      // var point1 = ("A", "E", "I", "O", "U", "L", "N", "R", "S", "T");

      // if(word.Contains("l"))
      // {
      // return "yes"; 
      // } 
      // else
      // {
      // return "no";
      // }
    // }
    Console.WriteLine(CheckScore(word));
    }
  }


    // public static Dictionary <char, int> ScrabbleDictionary =new Dictionary<char, int> () 
    //   {
    //   {"A", 1},  {"E", 1}, {"I",1}, {"O", 1}, {"U", 1}, {"L", 1},  {"N",1}, {"R", 1}, {"S", 1}, {"T", 1}
    //   };

    // public int GetScore ()
    // {
    //     var word =Console.ReadLine();
    //     char[]charArray =word.ToCharArray();
    //     int score =0; 
    //     foreach (KeyValuePair <char, int> ScrabbleDictionary in charArray) 
    //     {
    //       if (charArray == scrabble.Value)
    //       {
    //       return score ++
    //       }
    //     }
    // }



// foreach( KeyValuePair<string, string> kvp in openWith )
// {
//     Console.WriteLine("Key = {0}, Value = {1}",
//         kvp.Key, kvp.Value);
// }

// foreach(KeyValuePair<string, string> entry in myDictionary)
// {
//     // do something with entry.Value or entry.Key
// }