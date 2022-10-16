// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] num = new int[7];
Random rnd = new Random();
int sum = 0;
for(int i = 0; i < num.Length; i++) {
    num[i] = rnd.Next(0, 10);
    Console.WriteLine(num[i]);
    if(i%2==0) {
        sum = sum + num[i];
    }
} 
Console.WriteLine(sum); 