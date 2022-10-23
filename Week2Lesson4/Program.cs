/*1.Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
a.Imię,
b.Nazwisko
c.Wiek
d.Płeć (‘m’ albo ‘k’)
e.PESEL
f.Numer pracownika (np. 2509324094)
Zadeklaruj zmienne odpowiednich typów, które mogą przetrzymywać te informacje
*/

using Internal;
using System;

Console.WriteLine("Exercise1");
string name = "Dawid";
string surname = "Kowalski";
int age = 30;
char sex = 'm';
string personalIdNumber = "123456789";
string employeeID = "987654321";

Console.Write($"Imię: {name}\n\rNazwisko: {surname} \n\rWiek: {age}\n\r" +
    $"Płeć: {sex}\n\rPesel: {personalIdNumber}\n\rNumer Pracownika: {employeeID}\n\r");




/*
2. Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w
odwrotnej kolejności niż zostały zadeklarowane.*/


int a = 1, b = 2, c = 3;

Console.WriteLine($"{b} {a} {c}");


/*Napisz program, który na podstawie podanej szerokości i długości prostokąta wyliczy długość
przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())*/


Console.WriteLine("Podaj długość");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj szerokość");
double b = double.Parse(Console.ReadLine());

double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

Console.WriteLine($"Długość przekątnej dla prostokąta o podanych bokach {a} i {b} wynosi {c:F2}");


/*4.Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie
przypiszesz im następujące wartości: a. 10
b.Szkoła Dotneta
c. 12,5
*/
int a = 10;
string b = "Szkoła Dotneta";
double c = 12.5;

Console.WriteLine(a);
Console.WriteLine(b);
Console.WriteLine(c);




/*Napisz program w którym poprosisz użytkownika o jego dane personalne tj.
    Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85, 7), itp
    (postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź do
    odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika).
*/

Console.WriteLine("Podaj swoje Imię");
string name = Console.ReadLine();

Console.WriteLine("Podaj swoje nazwisko");
string lastName = Console.ReadLine();

Console.WriteLine("Podaj swój numer telefonu");
string tel = Console.ReadLine();

Console.WriteLine("Podaj swój adres e-mail.");
string eMail = Console.ReadLine();

Console.WriteLine("Podaj swój wzrost");
int height = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj swoją wagę");
double weight = double.Parse(Console.ReadLine());

Console.WriteLine("Podaj marke samochodu");
string car = Console.ReadLine();

Console.WriteLine("Podaj numer rej. Pojazdu");
string numberPlate = Console.ReadLine();

Console.WriteLine("Pojemność silnika");
double engineSize = double.Parse(Console.ReadLine());


Console.WriteLine($"Imię i Nazwisko: {name} {lastName}");
Console.WriteLine($"Twój numer telefonu: {tel} i adres e-mail: {eMail}");
Console.WriteLine($"Twój wzrost: {height} i waga: {weight}");
Console.WriteLine($"Posiadasz samochód marki: {car} o numer rej: {numberPlate}" +
    $"i pojemność: {engineSize} litra ");


