
//Aufgabe 1

Console.WriteLine($"size of short: {short.MaxValue}");
Console.WriteLine($"size of short: {short.MinValue}");
/* 
 * Bit 16
size of short: 32767
size of short: -32768
*/


Console.WriteLine($"size of int: {int.MaxValue}");
Console.WriteLine($"size of int: {int.MinValue}");
/*
 * 32-Bit-Ganzzah
size of int: 2147483647
size of int: -2147483648
*/

Console.WriteLine($"size of long: {long.MaxValue}");
Console.WriteLine($"size of long: {long.MinValue}");
/*
 * 64-Bit-Ganzzahl
size of long: 9223372036854775807
size of long: -9223372036854775808
*/

Console.WriteLine($"size of float:{float.MaxValue}");
Console.WriteLine($"size of float: {float.MinValue}");

/*
 * 32-Bit-Dezimalzahl
size of float:3,4028235E+38
size of float: -3,4028235E+38
*/

Console.WriteLine($"size of double:{double.MaxValue}");
Console.WriteLine($"size of double: {double.MinValue}");

/*
 * 64-Bit-Dezimalzahl
size of double:1,7976931348623157E+308
size of double: -1,7976931348623157E+308
*/

Console.WriteLine($"size of decimal:{decimal.MaxValue}");
Console.WriteLine($"size of decimal:{decimal.MinValue}");

/*
 * 128-Bit-Dezimalzahl
size of decimal:79228162514264337593543950335
size of decimal:-79228162514264337593543950335
*/

//Aufgabe 2
Console.WriteLine("Persönliche Daten");

string vorname = "Mazen";
short alter = 17;
bool frage = true;

Console.WriteLine(vorname);
Console.WriteLine(alter);
Console.WriteLine(frage);

