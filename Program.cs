// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
void SecondNumExtract (int num) {
    if (num > 99 && num < 1000) {
        int num2 = num / 10 % 10;
        Console.WriteLine(num + " -> " + num2);
    }
    else {
        Console.WriteLine("Ввод некорректен");
    }
}
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32 (Console.ReadLine());
SecondNumExtract (number);


//Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
void ThirdNumShow (int num) {
    if (num > 99) {
        int current = num;
        while (current > 999){
            current = current / 10;
        }
        int thirdnum = current % 10;
        Console.WriteLine(num + " -> " + thirdnum);
        }
        else {
            Console.WriteLine(num + " -> третьей цифры нет");
        }
    }
Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
ThirdNumShow (number);


//  Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
void DayNumber (int num) {
    if (num > 0 && num < 8) {
        if (num < 6) {
            Console.WriteLine(num + " -> нет");
        }
        else {
            Console.WriteLine(num + " -> да");
        }
    }
    else {
        Console.WriteLine("Ввод некорректен");
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32 (Console.ReadLine());
DayNumber (number);


//Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
void Kratnost(int num){
    if (num % 7 == 0 && num % 23 == 0){
        Console.WriteLine(num + " -> да");
    }
    else{
        Console.WriteLine(num + " -> нет"); 
    }
}
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Kratnost(number);


// Программа, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого
void SquareCheck(int num1, int num2){
    if (num1 == num2 * num2 || num2 == num1 * num1){
        Console.WriteLine(num1 + ", " + num2 + " -> да");
    }
    else{
        Console.WriteLine(num1 + ", " + num2 + " -> нет"); 
    }
}
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
SquareCheck(number1, number2);
