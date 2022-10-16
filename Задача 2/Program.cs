//Задать массив из 12 элементов, заполненных числами из [0,9]. 
//Найти сумму положительных/отрицательных элементов массива
int [] num = new int[12];
int summin = 0;
int summax = 0;
Random rnd = new Random();
for(int i = 0; i < num.Length; i++) {
    num[i] = rnd.Next(0, 9);
    Console.WriteLine(num[i]);
    if(num[i]>=0) {
        summax = summax + num[i];
    } else {
        summin = summin + num[i];
    }

}
Console.WriteLine(summax);
Console.WriteLine(summin);