//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int [] num = new int[8];
Random rnd = new Random();
for(int i = 0; i < num.Length; i++) {
    num[i] = rnd.Next(0, 2);
    Console.WriteLine(num[i]);
}    