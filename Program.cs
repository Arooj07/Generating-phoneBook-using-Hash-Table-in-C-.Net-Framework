using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable phoneBook = new Hashtable();
            int id = 0;

            while (true)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Generating a phone Book Using a Hash Table");
                Console.WriteLine("Press '1' to add the number to the phone Book");
                Console.WriteLine("Press '2' to get the number from the phone Book");
                Console.WriteLine("Press '3' to display all the History of phone Book");
                Console.WriteLine("Press '4' to exit the phone Book");
                Console.WriteLine("Press '5' to clear the whole History of Phone Book");
                Console.WriteLine("----------------------------------------------------");
                // Entering the random number to chose what we want to do with phone Book
                long number = 0;
                string name = " ";
                
                
                Console.WriteLine("Enter a number to add/get/display/exit or clear the phone Book");
                Console.WriteLine("----------------------------------------------------");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("----------------------------------------------------");
                switch (num)
                {
                    case 1:
                        {
                           
                            Console.Write("Enter your name : ");
                            name = Console.ReadLine();
                            Console.WriteLine("----------------------------------------------------");
                            Console.Write("Enter your phone number : ");
                            number = Convert.ToInt64(Console.ReadLine());
                            id = id + 1;
                            Console.WriteLine(id);
                            var string1 = string.Concat(name,"  ", "+92 ", number.ToString());
                            phoneBook.Add(id, string1);
                            //phoneBook1.Add(id, number);

                           /* Console.Write("Enter your name : ");
                            name = Console.ReadLine();
                            Console.WriteLine("----------------------------------------------------");
                            Console.Write("Enter your phone number : ");
                            number = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("----------------------------------------------------");
                            phoneBook.Add(name, number);
                            Console.WriteLine("----------------------------------------------------");

                            if (phoneBook.Contains(name))
                            {
                                Console.Write("Enter your phone number : ");
                                number = Convert.ToInt64(Console.ReadLine());
                                var arr = new ArrayList();
                                arr.Add(number);
                                phoneBook.Add(name,arr);
                            }*/



                        }
                        break;
                    case 2:
                        {
                           
                            Console.Write("Enter your name : ");
                            name = Console.ReadLine();
                            Console.WriteLine("----------------------------------------------------");
                            foreach(string myValue in phoneBook.Values)
                            {
                            
                                if (myValue.Contains(name))
                                { 
                                    Console.WriteLine("Name and Number of Person: " + myValue);
                                //Console.WriteLine("myValue = " + myValue);
                               // number = Convert.ToInt64(phoneBook[id]);
                               // Console.WriteLine("Name: " + name + ", phone number: +92 " + number.ToString());
                               // Console.WriteLine("----------------------------------------------------");
                                }
                                else
                                {
                                    Console.WriteLine("Given name is not found in phonebook");
                                    Console.WriteLine("----------------------------------------------------");
                                    break;
                                }
                            }
                            
                            
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Data of phoneBook");
                            foreach (DictionaryEntry de in phoneBook)
                                Console.WriteLine("Id: {0}, Name and Number: {1}", de.Key, de.Value);
                            Console.WriteLine("----------------------------------------------------");
                            
                            if (phoneBook.Count==0)
                            {
                                Console.WriteLine("phoneBook is Empty");
                            }
                        }
                        
                        break;
                    case 4:
                        {
                            goto OUT;
                          //Console.WriteLine("----------------------------------------------------");
                        }
               
                        break;
                    case 5:
                        {
                            phoneBook.Clear();
                            Console.WriteLine("You Cleared the whole History of phoneBook");
                            Console.WriteLine("----------------------------------------------------");
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Kindly Try Again :)");
                            Console.WriteLine("----------------------------------------------------");
                        }
                        break;
                }
            }
        OUT:
            Console.WriteLine("Thankyou for visiting my phonebook");
            Console.WriteLine("----------------------------------------------------");
        }
    }
}
    

