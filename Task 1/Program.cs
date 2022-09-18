using static System.Console;
Write("Введите число: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число: ");
int b = Convert.ToInt32(ReadLine());
int max = 0;
int min = 0;
if (a > b){
    max = a;
    min = b;
}
else {
    max = b;
    min = a;
}
WriteLine($"max = {max}");
WriteLine($"min = {min}");