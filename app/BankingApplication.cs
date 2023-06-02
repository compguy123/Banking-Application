
using System;

namespace app
{
    class Program
    {
        static void Main(string [] args){
            Console.WriteLine("Hello world!");



        int [] nums = new int[25];


        bool breaks= false;
        for(int i=0; i<nums.Length && breaks==false;i++ ){

            if(nums[i]==10){
                breaks=true;
            }
        }




        }
    }
}