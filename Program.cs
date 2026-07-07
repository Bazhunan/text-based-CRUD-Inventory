using System;
using System.Collections.Generic;
using System.Linq;



namespace CRUDv2
{
     class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = new List<string>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("---Product Inventory---");
                Console.WriteLine("1. Add");    //Create
                Console.WriteLine("2. View");   //Read
                Console.WriteLine("3. Update"); //Update
                Console.WriteLine("4. Delete"); //Delete
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Select an Option: ");




                string choice = Console.ReadLine();


                if (choice == "1") //Create
                {
                    
                    Console.Write("Enter the Product Name: ");
                    string productName = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(productName))
                    {
                        Console.WriteLine("Product Name cannot be Blank!");
                    }

                    else if (productName.Any(char.IsDigit))
                    {
                        Console.WriteLine("Product Name Cannot Contain Numbers!");
                    }

                    else if (productName.Length > 20)
                    {
                        Console.WriteLine("Product Name cannot be greater than 20");
                    }

                    else
                    {
                        inventory.Add(productName);
                        Console.WriteLine("Product Name: " + productName + " Successfully added! ");

                    }

                    Console.WriteLine("Enter to Continue");
                    Console.ReadLine();

                }

                else if (choice == "2") // Read
                {
                    Console.WriteLine("---View Mode---");
                    Console.WriteLine();

                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("Product does not Exist!");
                    }
                    else
                    {
                        for (int i = 0; i < inventory.Count; i++) // view loop
                        {
                            Console.WriteLine((i + 1) + ". " + inventory[i]);

                        }

                    }

                    Console.WriteLine("Enter to Continue");
                    Console.ReadLine();
                }


                else if (choice == "3") //Update
                {
                    if (inventory.Count == 0)
                    {
                        Console.WriteLine("Product does not Exist!");
                    }

                    for (int i = 0; i < inventory.Count; i++) 
                    {
                        Console.WriteLine((i + 1) + ". " + inventory[i]);

                    }
                    
                    Console.Write("Enter the number you want to Update: ");

                    if (!int.TryParse(Console.ReadLine(), out int userInput)) // study later
                    {
                        Console.WriteLine("Error: Please enter a valid whole number, not letters!");
                        Console.WriteLine("Enter to Continue");
                        Console.ReadLine();
                        continue; // Bounces back to top of menu smoothly
                    }

                    int index = userInput - 1;

                    if (index < 0) // userinput negative inventory
                    {
                        Console.WriteLine("Product does not exist! Please add a Product!");
                    }

                    else if (index >= inventory.Count) // userinput higher than inventory
                    {
                        Console.WriteLine("There is only " + inventory.Count + " Item on the Inventory");
                    }

                    else
                    {
                        Console.WriteLine("Are you sure you want to Update " + inventory[index] + " ?");
                        Console.Write("Enter a new Name: ");
                        string newName = Console.ReadLine();

                        if (string.IsNullOrWhiteSpace(newName))
                        {
                            Console.WriteLine("Product Name cannot be Blank!");
                        }

                        else if (newName.Any(char.IsDigit))
                        {
                            Console.WriteLine("Product Name cannot contain Numbers");
                        }

                        else
                        {
                            inventory[index] = newName;
                            Console.WriteLine("Product Name Successfuly Updated!");
                        }


                    }

                    Console.WriteLine("Enter to Continue");
                    Console.ReadLine();

                }

                else if (choice == "4") //Delete
                {
                    Console.WriteLine("---Inventory---");
                    Console.WriteLine();
                    for (int i = 0; i < inventory.Count; i++)// view 
                    {
                        Console.WriteLine((i + 1) + ". " + inventory[i]);

                    }


                    Console.Write("Enter the Number you want to Delete: ");

                    if (!int.TryParse(Console.ReadLine(), out int deleteNo)) // study later
                    {
                        Console.WriteLine("Error: Please enter a valid whole number, not letters!");
                        Console.WriteLine("Enter to Continue");
                        Console.ReadLine();
                        continue; // Bounces back to top of menu smoothly
                    }


                    int index = deleteNo - 1;

                    if (index < 0) //Negative
                    {
                        Console.WriteLine("Product does not exist!");
                    }

                    else if (index >= inventory.Count) //Higher
                    {
                        Console.WriteLine("Product does not exist!");
                    }
                    else
                    {
                        
                        
                        Console.WriteLine("Are you sure you want to Delete item No: " + deleteNo + " ?");
                        Console.WriteLine("Please type Yes");
                        string deleteConfirmation = Console.ReadLine();
                        

                        if (deleteConfirmation.ToLower() == "yes")
                        {
                            Console.WriteLine("The Product has been Deleted Successfully!");
                            inventory.RemoveAt(index);
                            
                        }
                        else
                        {
                            Console.WriteLine("Deletion Cancelled, Please try again!");
                            Console.WriteLine("Enter to Continue");
                            Console.ReadLine();
                            continue;
                        }


                    }

                    Console.WriteLine("Enter to Continue");
                    Console.ReadLine();

                }


                else if (choice == "5") //Exit
                {
                    Console.WriteLine("Thank you Please come again!");
                    break;
                }

            }
        }
     }
}
