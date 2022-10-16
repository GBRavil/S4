int [] num = new int[5];
Random rnd = new Random();
for(int i = 0; i < num.Length; i++) {
    num[i] = rnd.Next(0, 2);
    Console.WriteLine(num[i]);
}