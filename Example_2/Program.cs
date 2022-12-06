// : Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int UniCode(){
    Console.WriteLine("Введите трехзначное число");
    int UserNumber = Convert.ToInt32(Console.ReadLine());
    if(UserNumber < 100){
        Console.WriteLine("Третьей цифры нет");
        return UserNumber;
    }else{ 
        int three = UserNumber % 10;
        Console.WriteLine("Третья цифра введеного числа ");
        return three;
    }
}
int res = UniCode();
Console.WriteLine(res);