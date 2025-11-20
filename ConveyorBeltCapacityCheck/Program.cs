// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        const double packageWeightPerMotor = 5.6; //hver motor kan bære 5,6 kg
        // her siger vi: en motor højst må bære 5,6kg, det er en konstant, så tallet 5,6 kan ikke ændres senere i programmet. 
       
        Console.WriteLine("How many motors are carrying the packages? ");
        string motorInput = Console.ReadLine();
        int motorCount = int.Parse(motorInput);
        //først skriver programmet spg på skærmen
        //så læser det, hvad brugeren skriver som tekst f.eks 3 som er motor input
        //derefter laver det teksen om til et heltal (motorcount) 
        //nu ved programmet, hvor mange motorer der trækker båndet. 

        Console.WriteLine("How many kg of packages do we expect?");
        string weightInput = Console.ReadLine();
        double packageWeight = double.Parse(weightInput);
        //igen; skriver et spg. 
        //læser brugeren svar som tekst wirght input
        //laver teksten om the kommatal pga. double -> packageweight
        //nu ved progammet, hvor mange kilo pakker der er i alt

        double weightPerMotor = packageWeight / motorCount;
        // her regner programmet ud hvor meget hver motor skal bære, 
        //programmet tager, den samlede vægt packageweight, og dividerer det med antal motorer motorcount. 
        //resultatet er, hvor mange kilo en motro i gennemsnit skal bære. 

        if (weightPerMotor <= packageWeightPerMotor) 
            //denne kode betyder, hvis det, en motor skal bære weightPerMotor er mindre end eller lig med den maksimale tilladte vægt (5.6kg) 
        // så skriver programmet: 
        {
            Console.WriteLine("Jubii, the conveyor belt can carry the packages:D");
        }
        //ellers (hvis det er mere end 5,6 kg pr. motor)
        //skriver programmet:
        else
        {
            Console.WriteLine("Nooooo!. The conveyor belt can carry the packages:(");
        }
    }
}