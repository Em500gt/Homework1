using static System.Console;
Write("Введите число: ");
int n = Convert.ToInt32(ReadLine());
int count = 1;
while(count <= n){
    if(count % 2 == 0){
        Write($"{count} ");
    }
    count++;
}
