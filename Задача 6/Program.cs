// Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int [] num = new int[8];
Random rnd = new Random();
for(int i = 0; i < num.Length; i++) {
    num[i] = rnd.Next(0, 9);
    Console.Write(num[i]+" ");
} 
Console.WriteLine();
for(int j = 0; j < num.Length-1; j++) {
    int composition = (num[j]*num[j+1]);
    Console.Write(composition+" ");  
} 
Console.WriteLine();
for(int z = 0; z < num.Length/2; z++) {
        int composition1 = (num[z]*num[(num.Length-1)-z]);
        Console.Write(composition1+" ");  
} 






