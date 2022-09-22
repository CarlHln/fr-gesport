int summa = 1 ; 

Console.WriteLine("What is 10 + 4 ?");
Console.WriteLine("a=12, b=18, c=14");

string answer1 = Console.ReadLine();

if (answer1 == "c"){
    Console.WriteLine("Good job! Points:");
    Console.WriteLine(summa++);
    Console.WriteLine("Next question, what is 15x3 ?");
    Console.WriteLine("a=20, b=45, c=35");
}

else if (answer1 != "c"){
Console.WriteLine("Incorrect.");
Console.WriteLine("Next question, what is 15x3 ?");
Console.WriteLine("a=20, b=45, c=35");
}

string answer2 = Console.ReadLine();
    
if (answer2 == "b"){
Console.WriteLine("Good job! Points:");
Console.WriteLine(summa++);
Console.WriteLine("Next question, what is the gravitational pull of the sun divided by the average lifespan of a human being ?");
Console.WriteLine("a=3.77410468m/s, b=4.523611m/s, c=13.358165m/s");
}

else if (answer2 != "b"){
Console.WriteLine("Incorrect.");
Console.WriteLine("Next question, what is the gravitational pull of the sun divided by the average lifespan of a human being ?");
Console.WriteLine("a=3.77410468m/s, b=4.523611m/s, c=13.358165m/s");
}

string answer3 = Console.ReadLine();
if (answer3 == "a"){
Console.WriteLine("You are intelligent. Points:");
Console.WriteLine(summa++);
Console.WriteLine("Congratulations, you have completed this quiz.");
}

else if (answer3 != "a"){
Console.WriteLine("Incorrect.");
Console.WriteLine("This quiz is now complete.");
}

Console.ReadLine();

