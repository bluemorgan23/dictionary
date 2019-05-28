/*
    Author: Chris Morgan
    Date: May 28th, 2019
    Exercises: 
        1. Dictionary of Words
        2. List of Dictionaries about Words
 */
using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Begin Dictionary of Words Exercise
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Learn", "To gain or acquire kowledge of or skill in (something) by study, experience, or being taught.");
            wordsAndDefinitions.Add("Sponge", "A piece of a soft, light, porous substance originally consisting of the fibrous skeleton of an invertebrate but now usually made of synthetic material. Sponges absorb liquid and are used for washing and cleaning.");
            wordsAndDefinitions.Add("Swole", "Extremely muscular");

            /*
                Use square bracket lookup to get the definition two
                words and output them to the console
            */
            Console.WriteLine("Begin Dictionary of Words Exercise: ");
            Console.WriteLine(wordsAndDefinitions["Awesome"]);
            Console.WriteLine(wordsAndDefinitions["Swole"]);
            Console.WriteLine(" ");

            /*
                Loop over dictionary to get the following output:
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
                    The definition of [WORD] is [DEFINITION]
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Begin List of Dictionaries Exercise: ");

            // Begin list of dictionaries exercise: 

           // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few word
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "excited");
            excitedWord.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness.");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "I am excited to learn C#!");

            // Add Dictionary to your `dictionaryOfWords` list

            dictionaryOfWords.Add(excitedWord);


            // create another Dictionary and add that to the list

            Dictionary<string, string> swoleWord = new Dictionary<string, string>();

            swoleWord.Add("word", "swole");
            swoleWord.Add("definition", "extremely strong.");
            swoleWord.Add("part of speech", "adjective");
            swoleWord.Add("example sentence", "I am too swole to wear this shirt.");

            dictionaryOfWords.Add(swoleWord);

            /*
                Iterate your list of dictionaries and output the data

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            foreach (Dictionary<string, string> wordAttr in dictionaryOfWords)
            {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> wordData in wordAttr)
                {
                    Console.WriteLine($"{wordData.Key}: {wordData.Value}");
                }
            }
        }
    }
}
