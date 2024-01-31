using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment1 = new Assignment("Trevor Coolguy", "Metals");
        System.Console.WriteLine(assignment1.GetSummary());


        MathAssignment mathAssignment1 = new MathAssignment("James Theman", "Calculus", "Integrals", "4-32");        
        System.Console.WriteLine(mathAssignment1.GetSummary());
        System.Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Neil Awesomesauce", "Fantasy", "The Wishing Well");
        System.Console.WriteLine(writingAssignment1.GetSummary());
        System.Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}