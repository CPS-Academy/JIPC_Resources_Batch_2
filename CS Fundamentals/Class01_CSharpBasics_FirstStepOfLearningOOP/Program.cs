using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
            int i=0;
          for(i=0;i<10;i++){
              Console.WriteLine(i);
          }
            i=0;
          while(i<10){
              Console.WriteLine(i);
              i++;
          }


        
        // int a = Convert.ToInt32(Console.ReadLine());
        // int b = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine(a+b);
      // for, while, do while
    //     int size = Convert.ToInt32(Console.ReadLine());
    //   for(int i=0;i<size;i++){
    //       Console.WriteLine(i);
    //   }
    // Console.WriteLine("While Loop");
    //   int j=0;
    //   while(j<10){
    //       Console.WriteLine(j);
    //       j++;
    //   }
    // Console.WriteLine("For each loop");
    //     int [] numbers = {50,60,10,20,70,30,40,};
    //     foreach(int number in numbers){
    //         Console.WriteLine(number);
    //     }
    //     Array.Sort(numbers);
    //     foreach(int number in numbers){
    //         Console.WriteLine(number);
    //     }
    //     int [,] grid = {
    //         {1,2,3},
    //         {4,5,6},
    //         {7,8,9}
    //     };
    //     string [,] names ={
    //         {"John","Doe"},
    //         {"Jane","Doe"},
    //         {"John","Smith"}
    //     };




        // string name = "John";
        // string name2 = "john";
        // char[] chars = name.ToCharArray();
        // Array.Reverse(chars);
        // Array.Sort(chars);
        // Console.WriteLine(chars);
        // bool isEqual = name.Equals(name2);
        // Console.WriteLine(isEqual);

        // List<int> numbers = new List<int>();
        // numbers.Add(10);
        // numbers.Add(20);
        // numbers.Add(20);
        // numbers.Add(30);
        // foreach(int number in numbers){
        //     Console.WriteLine(number);
        // }
        // numbers.Remove(20);

        // numbers.Remove(20);
        // foreach(int number in numbers){
        //     Console.WriteLine(number);
        // }


    Dictionary<string,int> marks = new Dictionary<string,int>();
        marks.Add("Math",40);
        marks.Add("English",40);
        marks.Add("Bangla",80);
        Console.WriteLine(marks["Bangla"]);
        marks["Bangla"] = 90;
        marks.Remove("Math");
        if(marks.ContainsKey("Bangla")){
            Console.WriteLine(marks["Bangla"]);
        } else {
            Console.WriteLine("Key not found");
        }
        
      // int age = 20;
      // double price =20.95;
      // char grade = 'A';
      // bool isPassed = true; // false/true;
      // string name = "John";
      // if ,else ,if else 
      // int age = 50;
      // switch(age){
      //   case 18:
      //     Console.WriteLine("You are an adult");
      //     break;
      //   case 60:
      //     Console.WriteLine("You are old");
      //     break;
      //   default:
      //     Console.WriteLine("You are a child");
      //     break;
      //}
      // if(age>50){
      //   Console.WriteLine("You are old");
      // }
      // else if(age > 18){
      //   Console.WriteLine("You are an adult");
      // } else {
      //    Console.WriteLine("You are a child");
      // }
    }
}
/*
int price = 20.96
double price =20.95;
char 
bool
string 
*/﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
