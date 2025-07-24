using NumberForAdd.Models;
using Addition.Managers;
using System;
class Program
{
    public static void Main(string[] args)
    {
        NumberToBeAddedModel modelObj1 = new NumberToBeAddedModel(5); //passing number 1
        NumberToBeAddedModel modelObj2 = new NumberToBeAddedModel(6); // passing number 2
        AdditionManager managerObj = new AdditionManager();
        int sumOfNums = managerObj.AdditionMethod(modelObj1, modelObj2);
        Console.WriteLine($"The sum of both Numbers is : {sumOfNums}");//this is a console application t
    }
}