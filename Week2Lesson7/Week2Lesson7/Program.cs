/*
 1.Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy sąone równe czy nie.Dane testowe:a: 5b: 5Rezultat w terminalu :5 i 5 są równe
*/

int a = 5;
int b = 5;
if (a == b)
{
    Console.WriteLine($" {a} i {b} są równe");
}
else
    Console.WriteLine($"{a} i {b} nie są równe");

Console.ReadKey();


/* 
 Napisz program w C#, który sprawdzi czy podana przez użytkownika liczbajest parzysta czy nieparzysta.Dane testowe : 15Rezultat w terminalu :15 jest liczbą nieparzystą
*/

int a = 15;

if (a % 2 == 0)
{
    Console.WriteLine($"{a} jest liczbą parzystą");
}
else
    Console.WriteLine($"{a} jest liczbą nieparzystą");

Console.ReadKey();

/*
 3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna.
Dane testowe : 14 Rezultat w terminalu : 14 jest liczbą dodatnią
*/


int a = 14;

if (a > 0)
{
    Console.WriteLine($"{a} jest liczbą dodatnią");
}
else
    Console.WriteLine($" {a} jest liczbą ujemną");

Console.ReadKey();



/*
    4.Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
Dane testowe : 2016
Rezultat w terminalu :
2016 jest rokiem przestępnym
*/


Console.WriteLine("Podaj rok:");
int a = int.Parse(Console.ReadLine());

if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
{
    Console.WriteLine($"{a} jest rokiem przestępnym");
}
else
    Console.WriteLine($"{a} nie jest rokiem przestępnym");

/*
5.Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się o stanowisko posła, premiera, sentarora, prezydenta.
Dane testowe : 21
Rezultat w terminalu :Możesz zostać posłem
*/



Console.WriteLine("Podaj swój wiek:");
int a = int.Parse(Console.ReadLine());

if (a >= 35)
{
    Console.WriteLine("Możesz zostać prezydenetem");
}

else if (a >= 25)
{
    Console.WriteLine("Możesz zostać senatorem");
}
else if (a >= 21)
{
    Console.WriteLine("Możesz zostać premierem i posłem");
}
else
    Console.WriteLine("Jesteś za młody żeby kandydować ");

Console.ReadKey();

/*
6.Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu.
Dane testowe : 140 Rezultat w terminalu : Jesteś krasnoludem
*/


Console.WriteLine("Podaj swój wzrost");
double a = double.Parse(Console.ReadLine());


if (a > 140 && a <= 160)
{
    Console.WriteLine("Jesteś większy od Krasnoluda.");
}
else if (a > 160 && a <= 180)
{
    Console.WriteLine("Jesteś wysoki.");
}

else if (a > 180)
{
    Console.WriteLine("Jesteś bardzo wysoki.");
}

else
    Console.WriteLine("Jesteś krasoludem.");

Console.ReadKey();


/*
 7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
Dane testowe:
25
63
79
Rezultat w terminalu :
79 jest największa z podanych
*/



Console.WriteLine("Podaj 3 dowolne liczby");
Console.WriteLine("Podaj 1 liczbę:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj 2 liczbę:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj 3 liczbę:");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"{a} jest największą liczbą.");
}
else if (b > a && b > c)
{
    Console.WriteLine($"{b} jest największą liczbą");
}
else if (c > a && c > b)
{
    Console.WriteLine($"{c} jest największą liczbą");
}
else
    Console.WriteLine("Stosuj się do instrukcji!");

Console.ReadKey();

/*
 *8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce na studiach wg. Następujących kryteriów:Wynik z Matury z matematyki powyżej 70 Wynik z fizyki powyżej 55
Wynik z chemii powyżej 45
Łączny wynik z 3 przedmiotów powyżej 180 Albo
Wynik z matematyki i jednego przedmiotu powyżej 150
Dane testowe:
Matematyka 80
Fizyka 71
Chemia 0
Rezultat w terminalu :
Kandydat dopuszczony do rekrutacji
*/


Console.WriteLine("Podaj swoje wyniki z matruy z następujących przedmiotów.");
Console.WriteLine("Wynik z matematyki:");
double math = double.Parse(Console.ReadLine());
Console.WriteLine("Wynik z chemii:");
double chemistry = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj wynik z Fizyki:");
double physics = double.Parse(Console.ReadLine());
double result;

result = math + chemistry + physics;
Console.WriteLine($"Twój wynik to {result}");
if (result > 180 || math + chemistry + physics > 150)
{

    Console.WriteLine("Kandydant dopuszony do rekrutacji.");

}
else
    Console.WriteLine("Kandydat niedopuszczony do rekrutacji");

Console.ReadKey();


/*9.Napisz program, który odczyta temperaturę I zwróci nazwę jak w poniższych kryteriach
Temp < 0 – cholernie piździTemp 0 – 10 – zimno
Temp 10 – 20 – chłodno
Temp 20 – 30 – w sam raz
Temp 30 – 40 – zaczyna być słabo, bo gorąco
Temp >= 40 – a weź wyprowadzam się na Alaskę.
*/

Console.WriteLine("Podaj temperature.");

int temp = int.Parse(Console.ReadLine());

if (temp < 0)
{
    Console.WriteLine("Cholernie piździ.");
}
else if (temp >= 0 && temp <= 10)
{
    Console.WriteLine("Zimno.");
}
else if (temp > 10 && temp <= 20)
{
    Console.WriteLine("Chłodono.");
}
else if (temp > 20 && temp <= 30)
{
    Console.WriteLine("W sam raz ");
}
else if (temp > 30 && temp <= 40)
{
    Console.WriteLine("Zaczyna być słabo, bo gorąco.");
}
else if (temp > 40)
{
    Console.WriteLine("A weź wyprowadzam się na Alaskę.");
}
else
    Console.WriteLine("Proszę podać poprawną wartość.");

Console.ReadKey();

/*
 10. Napisz program, który sprawdzi, czy z 3 podanych długości można stworzyć trójkąt
Dane testowe : 40 55 65
Rezultat w terminalu :Można zbudować trójkąt*/

Console.WriteLine("Podaj długości trójąta...");
Console.WriteLine("Podaj 1 długośćl.");
int side1 = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj 2 długość.");
int side2 = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj 3 długość.");
int side3 = int.Parse(Console.ReadLine());

if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
{
    Console.WriteLine("Można zbudować trójkąt.");
}
else
    Console.WriteLine("Nie można zbudwoać trójąta.");

Console.ReadKey();


/* 
 Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
 */

Console.WriteLine("Podaj ocenę.");
int mark = int.Parse(Console.ReadLine());

switch (mark)
{
    case 1:
        Console.WriteLine("Niedostateczny ");
        break;
    case 2:
        Console.WriteLine("Douszczający.");
        break;
    case 3:
        Console.WriteLine("Dostateczny.");
        break;
    case 4:
        Console.WriteLine("Dobry.");
        break;
    case 5:
        Console.WriteLine("Bardzo dobry.");
        break;
    case 6:
        Console.WriteLine("Celujący");
        break;
    default:
        Console.WriteLine("Wpisano nieodpowednią ocenę!");
        break;

}
Console.ReadKey();

/*12.Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
Dane testowe : 4
*/

Console.WriteLine("Podaj dzień tygodnia.");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1:
        Console.WriteLine("Poniedziałek.");
        break;
    case 2:
        Console.WriteLine("Wtorek.");
        break;
    case 3:
        Console.WriteLine("Środa.");
        break;
    case 4:
        Console.WriteLine("Czwartek");
        break;
    case 5:
        Console.WriteLine("Piątek.");
        break;
    case 6:
        Console.WriteLine("Sobota.");
        break;
    case 7:
        Console.WriteLine("Niedziela.");
        break;
    default:
        Console.WriteLine("Podana nie odpowiednią wartość.");
        break;
}
Console.ReadKey();

/*
 13.Napisz program, który będzie posiadał proste menu (wg. Wzoru poniżej) I będzie prostym kalkulatoremPodaj pierwszą liczbę:
...
Podaj drugą liczbę:
...
Podaj numer operacji do wykonania:
1.Dodawanie 2.Odejmowanie 3.Mnożenie
4.Dzielenie...
Twój wynik to:*/

Console.WriteLine("Podaj pierwszą liczbę...");
double firstNumber = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj drugą liczbę...");
double secondNuber = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj numer operacji do wykonania...");
Console.WriteLine("1. Dodawanie.");
Console.WriteLine("2. Odejmowanie.");
Console.WriteLine("3. Mnożenie.");
Console.WriteLine("4. Dzielenie.");
int task = int.Parse(Console.ReadLine());
double result = 0;
switch (task)
{
    case 1:

        result = firstNumber + secondNuber;
        break;
    case 2:
        result = firstNumber - secondNuber;
        break;
    case 3:
        result = firstNumber * secondNuber;
        break;
    case 4:
        result = firstNumber / secondNuber;
        break;
    default:
        Console.WriteLine("Wprowadzono zły numer.");
        break;
}

Console.WriteLine($"Wynik to {result}");
Console.ReadKey();