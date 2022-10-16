//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int [] num = new int[123];
Random rnd = new Random();
int sum = 0;
for(int i = 0; i < num.Length; i++) {
    num[i] = rnd.Next(0, 100);
    if(num[i]>9 && num[i]<99) {
        sum = sum + num[i];
    }
}   
Console.WriteLine(sum);