// See https://aka.ms/new-console-template for more information

using System;

int number1 = 2;
int number2 = 4;

int sum = number1 + number2;
// Use comparison '==' to obtain a boolean. Do NOT attempt to assign to an expression.
bool isTrue = (sum == 6);

void ShowResult(bool value)
{
    if (value)
    {
        Console.WriteLine("Denne metoden returnerer ingenting. ;)");  //som beskrevet i oppgaven xD 
    }
    else
    {
        Console.WriteLine("Denne metoden er Falsk. ;)");  //hvorfor ikke det også xD
    }
}

ShowResult(isTrue);