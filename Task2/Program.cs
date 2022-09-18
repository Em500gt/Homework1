using static System.Console;
Write("Введите число: ");
int a = Convert.ToInt32(ReadLine());
Write("Введите число: ");
int b = Convert.ToInt32(ReadLine());
Write("Введите число: ");
int c = Convert.ToInt32(ReadLine());
int max = a;
if (max < b){
    max = b;
}
if (max < c){
    max = c;
}
WriteLine($"max = {max}");
