// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.WriteLine("task 19");
Console.Write("Put number: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"You number: {number} - palindrome.");
  }
  else Console.WriteLine($"You number: {number} - not palindrome.");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Put correct number");
