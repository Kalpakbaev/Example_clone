// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int Test (){
    Console.WriteLine("Введите трехзначное число");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if (userNumber < 100 ){
        Console.WriteLine("Вы ввели некорректное число");
        return userNumber;
        
    }  // Как добавить ошибку когда пользователь введет ошибочно или вообще не цифру и.т.п
    int one = userNumber / 100;
    int two = userNumber / 10 % 10;
    int three = userNumber % 10;
    return two;
}
int result = Test();
Console.WriteLine(result);
