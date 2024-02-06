//Задайте массив. Напишите программу, которая определяет,
//присутствует ли заданное число в массиве. Программа должна выдать ответ:
// Да/Нет Пример: [1,3,4,19,3], 8 => нет

int[] array = { 1, 3, 4, 19, 3};
int number = 3;
bool result = false;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == number)
    result = true;
}
if (result == true)
{
    System.Console.WriteLine("YES");
}
else
{
    System.Console.WriteLine("NO");
}