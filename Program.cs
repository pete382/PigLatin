//Pig Latin Lab

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;


public class PigLatin
{

    public static void Main()

    {
        string t = "y";

        static bool CheckInput(string t)
        {
            if (t == "y") { return true; }
            else { return false; }            


        }  
         
        
        do

        {



            System.Console.WriteLine("Type in a word and I will make it sound like pig latin!");
            string word = Console.ReadLine();
            //bool isVowel = true;



            if (word.ToLower().StartsWith('a') || word.ToLower().StartsWith('e') || word.ToLower().StartsWith('e') || word.ToLower().StartsWith('i') || word.ToLower().StartsWith('o') || word.ToLower().StartsWith('u'))
            {

                Console.WriteLine(word + "way");
            }

            else
            {
                char[] seperator = { 'a', 'e', 'i', 'o', 'u' };

                string[] snippets = word.Split(seperator);

                string firstLetters = snippets[0];
                int Snipper = firstLetters.Length;


                string remainderWord = word.Substring(Snipper) + firstLetters + "ay";

                Console.WriteLine(remainderWord);

                             

            }

            
                Console.WriteLine("Do you want to try another word ? Type 'y' for yes and 'n' for no");
            t = Console.ReadLine().ToLower().Trim();

        }
        while (t == "y" ) ;

             
            
    
    }


}

