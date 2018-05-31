//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Style{
        public const int Min = 1;
        public const int Max = 12;    
        
        public void draw(){}
    }
    
    public class Style1 : Style{
        
        private void TopHeader(){
            System.Console.Write("  ");
            System.Console.Write(" X ");
            System.Console.Write(" ");
            System.Console.Write("|");
            for(int i = Min; i <= Max; i++){
                System.Console.Write("  ");
                System.Console.Write(i.ToString().PadLeft(2,' ').PadRight(3, ' '));
                System.Console.Write(" ");
                System.Console.Write("|");
            }
            System.Console.Write("\r\n");
        } 
        
        private void TableContant(){
            for(int i = Min; i <= Max; i++){
                System.Console.Write("  ");
                System.Console.Write(i.ToString().PadLeft(2,' ').PadRight(3, ' '));
                System.Console.Write(" ");
                System.Console.Write("|");
                for(int j = Min; j <= Max; j++){
                    
                    int answer = i*j;
                    
                    System.Console.Write("  ");
                    
                    System.Console.Write(answer.ToString().PadLeft(2,' ').PadRight(3, ' '));
                    
                    System.Console.Write(" ");
                    System.Console.Write("|");
                }
                System.Console.Write("\r\n");
            }
        }
        
        public void Draw(){
            this.TopHeader();
            this.TableContant();
        }
    }
    
    public class Style2:Style{        
        
        public void TableContant(){
            for(int i = Max; i >= Min; i--){
                for(int j = Min; j <= i; j++){
                    
                    int answer = i*j;
                    
                    System.Console.Write(" ");
                    
                    System.Console.Write(i.ToString().PadLeft(2, ' ') + " X " + 
                                         j.ToString().PadLeft(2, ' ') + " = " + 
                                         answer.ToString().PadLeft(2,' ').PadRight(3, ' '));

                    System.Console.Write("|");
                }
                System.Console.Write("\r\n");
            }
        }
            
        public void Draw(){
            this.TableContant();
        }
    }
    
    public class Program{
             
        public static void Main(string[] args)
        {
            //Style1
            System.Console.Write("Style1: \r\n \r\n");
            Style1 table1 = new Style1();
            table1.Draw();
            System.Console.Write("\r\n");
            
            //Style2
            System.Console.Write("Style2: \r\n \r\n");
            Style2 table2 = new Style2();
            table2.Draw();
        }
        
    }   
}
