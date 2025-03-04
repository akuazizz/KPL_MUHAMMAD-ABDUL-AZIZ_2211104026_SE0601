using System;

class Program
{
    static void Main()
    {
        // Implementasi A: Menerima input satu karakter dengan huruf kapital
        Console.Write("Masukkan satu huruf: ");
        char huruf = Char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        // Mengecek apakah huruf adalah vokal atau konsonan
        if (huruf == 'A' || huruf == 'I' || huruf == 'U' || huruf == 'E' || huruf == 'O')
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf vokal");
        }
        else
        {
            Console.WriteLine($"Huruf {huruf} merupakan huruf konsonan");
        }

        // Implementasi B: Membuat array bilangan genap dan menampilkannya
        int[] bilanganGenap = { 2, 4, 6, 8, 10 };

        // Iterasi dan menampilkan output
        for (int i = 0; i < bilanganGenap.Length; i++)
        {
            Console.WriteLine($"Angka genap {i + 1} : {bilanganGenap[i]}");
        }
    }
}