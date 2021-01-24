using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Name_search
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class Program
    {
        /*
     PROGRAMME	:	Assignment Name Search 
      
     OUTLINE	:	Program has the user type in a name they want to see either first or last and the program checks
                    to see if such name exists in the file if so it would type it out and say what named you called 
                    it by if not the program will say that name doesnt exist. The program uses methods, if statments,
                    and arrays to do this. 
     
     PROGRAMMER	:	Methunan Uthayakumar
    
      DATE		:	September 28, 2020
    */

        static void Main(string[] args)

        {
         
            Console.WriteLine("Enter the name you want to see from the file after doing so press enter to proceed: "); // asks for user input and makes sure console stays up
            var searchedName = Console.ReadLine(); 
           
            var nameFile = NameFileSearch(searchedName, 0); // is an array holding two varaibles 

            string[] halfName = nameFile.Split( ); // splits the name in two 


            if ( halfName[0] == searchedName) // if the input is true and the file name is equal to the first name you searched then it prints the name and says you searched by first name 
            {
                Console.WriteLine(" Yes " + nameFile + " is in the file " + " with the first name you searched " + halfName[0] + " \n press enter to close");

            }
            else if ( halfName[1] == searchedName) // if the input is true and the file name is equal to the last name you searched then it prints the name and says you searched by last name 
            {
                Console.WriteLine(" Yes " + nameFile + " is in the file " + " with the last name you searched " + halfName[1] + " \n press enter to close");
            }
            else
            {
                Console.WriteLine(" No " + searchedName + " is not there in the file press enter to close "); // will say if your name isnt on there 

            }
            Console.ReadLine(); // keeps console open 

           
        }

        static string NameFileSearch(string aInput, int num) // uses a method where searchedName becomes aInput and 0 becomes int num
        {
            var filePath = @"E:\C#\Assignment Name search\Assignment Name search\bin\Debug\name.txt"; // set a variable to read the file 
            string[] fileLine = File.ReadAllLines(filePath); // array making sure all lines in the file are read 

            if (num < fileLine.Length) // if statment if the num which is less then the lines length it exercutes the following code
            {
                if (fileLine[num].Contains(aInput)) // if the statment is true the name written is there it ends and returns the value to the array represented by aInput
                {
                    return ( fileLine[num]);
                }
                else // it increases the count and returns the value to the method so num would be 1 instead of 0 and would loop till the space 
                {
                    return NameFileSearch(aInput, num + 1);
                }
            }
            else
            {
                return (" "); // if this isnt true this will return as null which is basically nothimg 
            }
            
           
        }


        
      



    }


}


