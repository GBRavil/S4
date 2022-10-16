//Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел
int [] num = new int[5];
Random rnd = new Random();
int sumeven = 0;
int sumodd = 0;
for(int i = 0; i < num.Length; i++) {
    num[i] = rnd.Next(100, 1000);
    Console.WriteLine(num[i]);
    if(num[i]%2==0) {
        sumeven = sumeven + num[i];
    } else {
        sumodd = sumodd + num[i];
    }
}
Console.WriteLine(sumeven);
Console.WriteLine(sumodd);   