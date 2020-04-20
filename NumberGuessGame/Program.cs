
using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
          
           int level;
        //Asking a user to choose a level, 1 = easy, 2 = medium, 3 = hard
          Console.WriteLine("Hey welcome to Number guess game(NGG), what level would you want to play?\nEnter 1 for easy mode, enter 2 for medium, enter 3 for hard");
        //saving a user choice of level
          level = int.Parse(Console.ReadLine());
          
        //level 1 start here   
            if(level == 1){
              Console.WriteLine("Hey, You're playing easy \n Total point is for this is 60 points. 10 ponts would be substracted at each wrong guess.");
              Console.WriteLine("Choose a number between 1 - 10 to play");
             //first guess 
              int guess1 = 0;
              // string letters = "";
              // letters = Console.WriteReadLine();
              guess1 = Convert.ToInt32(Console.ReadLine());
              if(guess1 == 1 || guess1  == 2 || guess1 == 4||guess1 ==  5 ||guess1 == 7 || guess1 == 6 || guess1 ==  8|| guess1 == 9 || guess1 == 10){
                 Console.WriteLine("Wrong guess, you have 5 chances left and 50 points obtainable. Guess again!");
              
                   Console.WriteLine("Choose a number between 1 - 5 to play for second guess");
                   int guess2 = 0;
                   guess2 = Convert.ToInt32(Console.ReadLine());
                   if(guess2 == 1 || guess2  == 2 || guess2 == 4||guess2 ==  5 ||guess2 == 7 || guess2 == 6 || guess2 ==  8|| guess2 == 9 || guess2 == 10){
                     Console.WriteLine("Wrong guess, you have 4 chances left and 40 points obtainable. Guess again!");
                      
                    int guess3 = 0;
                    Console.WriteLine("Choose another number betwwen 1 to 10");
                    guess3 = Convert.ToInt32(Console.ReadLine());
                     if(guess3 == 1 || guess3  == 2 || guess3 == 4||guess3 ==  5 ||guess3 == 7 || guess3 == 6 || guess3 ==  8|| guess3 == 9 || guess3 == 10){
                     Console.WriteLine("Wrong guess, you have 3 chances left and 30 points obtainable. Guess again!");

                       int guess4 = 0;
                       Console.WriteLine("Choose another number betwwen 1 to 10");
                       guess4 = Convert.ToInt32(Console.ReadLine());
                       if(guess4 == 1 || guess4  == 2 || guess4 == 4||guess4 ==  5 ||guess4 == 7 || guess4 == 6 || guess4 ==  8|| guess4 == 9 || guess4 == 10){
                         Console.WriteLine("Wrong guess, you have 2 chances left and 20 ponts obtainable. Guess again!");

                          int guess5 = 0;
                          Console.WriteLine("5th guess, choose another number betwwen 1 to 10");
                          guess5 = Convert.ToInt32(Console.ReadLine());
                          if(guess5 == 1 || guess5  == 2 || guess5 == 4||guess5 ==  5 ||guess5 == 7 || guess5 == 6 || guess5 ==  8|| guess5 == 9 || guess5 == 10){
                            Console.WriteLine("Wrong guess, you have 1 chances left and 10 points obtainable. Guess again!");
                            
                            int guess6 = 0;
                            Console.WriteLine("Choose another number betwwen 1 to 10");
                            guess6 = Convert.ToInt32(Console.ReadLine());
                            if(guess6 == 1 || guess6  == 2 || guess6 == 4||guess6 ==  5 ||guess6 == 7 || guess6 == 6 || guess6 ==  8|| guess6 == 9 || guess6 == 10){
                              Console.WriteLine("Wrong guess, sorry you've lost! \nTotal ponts is 0");
                            }
                            else if(guess6 == 3){
                              Console.WriteLine("Correct guess! Congratulations \nYou've won with 10 full points");
                            }
                            else{
                              Console.WriteLine("Please you have to choose from 1 -10. Try again later.");
                            }
                          }
                          else if(guess5 == 3){
                            Console.WriteLine("Correct guess! Congratulations \nYou've won with 20 full points"); 
                          }
                          else{
                            Console.WriteLine("Please you have to choose from 1 -10. Try again later.");
                          }
                       }
                       else if(guess4 == 3){
                         Console.WriteLine("Correct guess! Congratulations \nYou've won with 30 full points");
                       }
                       else{
                         Console.WriteLine("Please you have to choose from 1 -10. Try again later.");
                       }
                     }
                     else if(guess3 == 3){
                     Console.WriteLine("Correct guess! Congratulations \nYou've won with 40 full points");
                       
   
                     }
                     else{
                     Console.WriteLine("Please you have to choose from 1 -10. Try again later.");
                     }
                   }


                   else if(guess2 == 3){
                     Console.WriteLine("Correct guess! Congratulations \nYou've won with 50 full points");
                   }
                   else{
                     Console.WriteLine("Please you have to choose from 1 -10. Try again later.");
                   }


                }
                else if(guess1 == 3){
                    Console.WriteLine("Correct guess! Congratulations \nYou've won with 60 full points");
                   
              }
              else{
                  Console.WriteLine("Please try again, choose a number between 1 - 6");
              }
           
           }
           //level 1 ends here
           //level 2 start here
            else if(level == 2){

              Console.WriteLine("Hey, You're playing medium \n The total point for this level is 100. 24 ponts would be substracted at each wrong guess  and you can only guess 4 times.");
              Console.WriteLine("Choose a number between 1 - 20 to play");
             //first guess 
              int guess1 = 0;
              guess1 = Convert.ToInt32(Console.ReadLine());
              if(guess1 == 1 || guess1  == 2 || guess1 == 3||guess1 ==  4 ||guess1 == 5 || guess1 == 6 || guess1 ==  8|| guess1 == 9 || guess1 == 10 ||guess1 == 11 ||guess1 == 12 ||guess1 == 13 ||guess1 == 14 ||guess1 == 15 ||guess1 == 16 ||guess1 == 17 ||guess1 ==18 ||guess1 == 19 ||guess1 ==20){
                 Console.WriteLine("Wrong guess, you have 3 chances left and 73 points obtainable. Guess again!");
              
                   Console.WriteLine("Choose a number between 1 - 20 to play for second guess");
                   int guess2 = 0;
                   guess2 = Convert.ToInt32(Console.ReadLine());
                   if(guess2 == 1 || guess2  == 2 || guess2 == 3||guess2 ==  4 ||guess2 == 5 || guess2 == 6 || guess2 ==  8|| guess2 == 9 || guess2 == 10 ||guess2 == 11 ||guess2 == 12 ||guess2 == 13 ||guess2 == 14 ||guess2 == 15 ||guess2 == 16 ||guess2 == 17 ||guess2 ==18 ||guess2 == 19 ||guess2 ==20){
                     Console.WriteLine("Wrong guess, you have 2 chances left and 50 points obtainable. Guess again!");
                      
                    int guess3 = 0;
                    Console.WriteLine("Choose another number betwwen 1 to 20");
                    guess3 = Convert.ToInt32(Console.ReadLine());
                     if(guess3 == 1 || guess3  == 2 || guess3 == 3||guess3 ==  4 ||guess3 == 5 || guess3 == 6 || guess3 ==  8|| guess3 == 9 || guess3 == 10 ||guess3 == 11 ||guess3 == 12 ||guess3 == 13 ||guess3 == 14 ||guess3 == 15 ||guess3 == 16 ||guess3 == 17 ||guess3 ==18 ||guess3 == 19 ||guess3 ==20){
                     Console.WriteLine("Wrong guess, you have 1 chances left and 25 points obtainable. Guess again!");

                       int guess4 = 0;
                       Console.WriteLine("Choose another number betwwen 1 to 20");
                       guess4 = Convert.ToInt32(Console.ReadLine());
                       if(guess4 == 1 || guess4  == 2 || guess4 == 3||guess4 ==  4 ||guess4 == 5 || guess4 == 6 || guess4 ==  8|| guess4 == 9 || guess4 == 10 ||guess4 == 11 ||guess4 == 12 ||guess4 == 13 ||guess4 == 14 ||guess4 == 15 ||guess4 == 16 ||guess4 == 17 ||guess4 ==18 ||guess4 == 19 ||guess4 ==20){
                         Console.WriteLine("Wrong guess, gave over! You have 0");

                             
                       }
                       else if(guess4 == 7){
                         Console.WriteLine("Correct guess! Congratulations \nYou've won with 25 total points");
                       }
                       else{
                         Console.WriteLine("Please you have to choose from 1 -20. Try again later.");
                       }
                     }
                     else if(guess3 == 7){
                     Console.WriteLine("Correct guess! Congratulations \nYou've won with 50 total points");
                       
                          
                     }
                     else{
                     Console.WriteLine("Please you have to choose from 1 -20. Try again later.");
                     }
                   }


                   else if(guess2 == 7){
                     Console.WriteLine("Correct guess! Congratulations \nYou've won with 75 full points");
                   }
                   else{
                     Console.WriteLine("Please you have to choose from 1 -20. Try again later.");
                   }


                }
                else if(guess1 == 7){
                    Console.WriteLine("Correct guess! Congratulations \nYou've won with 100 full points");
                   
              }
              else{
                  Console.WriteLine("Please try again, choose a number between 1 - 20");
              }

            }
            //level 2 ends here
            //level 3 starts here
            else if(level == 3){
              Console.WriteLine("Hey, You're playing hard \n Total point is for this is 150 points. 50 ponts would be substracted at each wrong guess.");
              Console.WriteLine("Choose a number between 1 - 50 to play");
              int guess1 = 0;
              guess1 = Convert.ToInt32(Console.ReadLine());
              if(guess1 == 1 || guess1  == 2 || guess1 == 3||guess1 ==  4 ||guess1 == 5 || guess1 == 6 || guess1 ==  8|| guess1 == 9 || guess1 == 10 || guess1 == 12 ||guess1 == 13 ||guess1 == 14 ||guess1 == 15 ||guess1 == 16 ||guess1 == 17 ||guess1 ==18 ||guess1 == 19 ||guess1 ==20 || guess1 == 21 || guess1  == 22 || guess1 == 23||guess1 ==  24 ||guess1 == 25 || guess1 == 26 || guess1 ==  28|| guess1 == 29 || guess1 == 30 ||guess1 == 31 ||guess1 == 32 ||guess1 == 33 ||guess1 == 34 ||guess1 == 35 ||guess1 == 36 ||guess1 == 37 ||guess1 ==38 ||guess1 == 39 ||guess1 ==40 || guess1 == 41 || guess1  == 42 || guess1 == 43||guess1 ==  44 ||guess1 == 45 || guess1 == 46 || guess1 ==  47|| guess1 == 48 || guess1 == 49 ||guess1 == 50 ){
                Console.WriteLine("Wrong guess, you have 2 chances left and 100 points obtainable. Guess again!");
                
                   Console.WriteLine("Choose a number between 1 - 50 to play for second guess");
                   int guess2 = 0;
                   guess2 = Convert.ToInt32(Console.ReadLine());
                   if(guess2 == 1 || guess2  == 2 || guess2 == 3||guess2 ==  4 ||guess2 == 5 || guess2 == 6 || guess2 ==  8|| guess2 == 9 || guess2 == 10 || guess2 == 12 ||guess2 == 13 ||guess2 == 14 ||guess2 == 15 ||guess2 == 16 ||guess2 == 17 ||guess2 ==18 ||guess2 == 19 ||guess2 ==20 || guess2 == 21 || guess2  == 22 || guess2 == 23||guess2 ==  24 ||guess2 == 25 || guess2 == 26 || guess2 ==  28|| guess2 == 29 || guess2 == 30 ||guess2 == 31 ||guess2 == 32 ||guess2 == 33 ||guess2 == 34 ||guess2 == 35 ||guess2 == 36 ||guess2 == 37 ||guess2 ==38 ||guess2 == 39 ||guess2 ==40 || guess2 == 41 || guess2  == 42 || guess2 == 43||guess2 ==  44 ||guess2 == 45 || guess2 == 46 || guess2 ==  47|| guess2 == 48 || guess2 == 49 ||guess2 == 50 ){
                     Console.WriteLine("Wrong guess, you have 1 chances left and 50 points obtainable. Guess again!");

                      Console.WriteLine("Choose a number between 1 - 50 to play for third and final guess");
                      int guess3 = 0;
                      guess3 = Convert.ToInt32(Console.ReadLine());
                      if(guess3 == 1 || guess3  == 2 || guess3 == 3||guess3 ==  4 ||guess3 == 5 || guess3 == 6 || guess3 ==  8|| guess3 == 9 || guess3 == 10 || guess3 == 12 ||guess3 == 13 ||guess3 == 14 ||guess3 == 15 ||guess3 == 16 ||guess3 == 17 ||guess3 ==18 ||guess3 == 19 ||guess3 ==20 || guess3 == 21 || guess3  == 22 || guess3 == 23||guess3 ==  24 ||guess3 == 25 || guess3 == 26 || guess3 ==  28|| guess3 == 29 || guess3 == 30 ||guess3 == 31 ||guess3 == 32 ||guess3 == 33 ||guess3 == 34 ||guess3 == 35 ||guess3 == 36 ||guess3 == 37 ||guess3 ==38 ||guess3 == 39 ||guess3 ==40 || guess3 == 41 || guess3  == 42 || guess3 == 43||guess3 ==  44 ||guess3 == 45 || guess3 == 46 || guess3 ==  47|| guess3 == 48 || guess3 == 49 ||guess3 == 50 ){
                       Console.WriteLine("Wrong guess, gave over! You have 0");
                      }
                      else if(guess3 == 11){
                       Console.WriteLine("Correct guess! Congratulations \nYou've won with 50 total points");
                      }
                      else{
                        Console.WriteLine("Please try again, choose a number between 1 - 50 and play again");
                      }

                   }
                   else if(guess2 == 11){
                     Console.WriteLine("Wow, congratulations. You won the game with 100 total points");
                   }
                   else{
                     Console.WriteLine("Please try again, choose a number between 1 - 50 and play again"); 
                   }

              }
              else if(guess1 == 11){
                Console.WriteLine("Wow, congratulations. You won the game with 150 full points");
              }
              else{
                Console.WriteLine("Please try again, choose a number between 1 - 50 and play again"); 
              }

            } 
             //So user dosen't select another number(outside 1, 2 and 3)
            else{
                Console.WriteLine("Choose either 1 for easy, 2 for medium or 3 for hard");
            }
            //level 3 ends here
            Console.WriteLine("My name is Bethel Oguzierem, this game is my task3 @start.ng program. \n Special thank to Mr Vicent(Mentor C#) and Mr. Seyi(start.ng cordinator)");
        }
    }
}
