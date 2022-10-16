// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
int [] num = new int[8];
Random rnd = new Random();
int max = 0;
int min = 0;
int rez = S(num, max, min);
Console.WriteLine("Разница между max и min "+rez);
int S(int[]n, int m1, int m2) {
    int rezult = 0;
    for(int i = 0; i < n.Length; i++) {
        num[i] = rnd.Next(0, 9);
        Console.Write(num[i]+" ");
        if(n[i]>m1) {
        m1 = n[i];
        } else if(n[i]<m2) {
        m2 = n[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("max "+m1);
    Console.WriteLine("min "+m2);
    rezult = m1 - m2;
    return rezult;
    
}