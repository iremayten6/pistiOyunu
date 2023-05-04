// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        // Kartları hazırla
        List<int> kartlar = Enumerable.Range(1, 13).ToList();

        // Karıştır
        Random rastgele = new Random();
        kartlar = kartlar.OrderBy(x => rastgele.Next()).ToList();

        // Oyuncuların kartları ve puanları
        List<int> oyuncu1_kartlar = new List<int>();
        List<int> oyuncu2_kartlar = new List<int>();
        int oyuncu1_puan = 0;
        int oyuncu2_puan = 0;

        // Kartları dağıt
        for (int i = 0; i < kartlar.Count; i++)
        {
            if (i % 2 == 0)
            {
                oyuncu1_kartlar.Add(kartlar[i]);
            }
            else
            {
                oyuncu2_kartlar.Add(kartlar[i]);
            }
        }

        // Oyun başlar
        while (oyuncu1_kartlar.Count > 0 && oyuncu2_kartlar.Count > 0)
        {
            // Oyuncu 1'in kartı
            int kart1 = oyuncu1_kartlar[0];
            Console.WriteLine("Oyuncu 1'in kartı: " + kart1);
            oyuncu1_kartlar.RemoveAt(0);

            // Oyuncu 2'in kartı
            int kart2 = oyuncu2_kartlar[0];
            Console.WriteLine("Oyuncu 2'nin kartı: " + kart2);
            oyuncu2_kartlar.RemoveAt(0);

            // Eşleşme durumu
            if (kart1 == kart2)
            {
                Console.WriteLine("Eşleşme! Her iki oyuncu da 2 puan kazanır.");
                oyuncu1_puan += 2;
                oyuncu2_puan += 2;
            }
            else if (kart1 == 1 || kart1 == 11) // Oyuncu 1 Pişti yaptı
            {
                Console.WriteLine("Oyuncu 1 Pişti! 10 puan kazandı.");
                oyuncu1_puan += 10;
            }
            else if (kart2 == 1 || kart2 == 11) // Oyuncu 2 Pişti yaptı
            {
                Console.WriteLine("Oyuncu 2 Pişti! 10 puan kazandı.");
                oyuncu2_puan += 10;
            }
            else 
            {
                Console.WriteLine("Puan yok!");
            }

            Console.WriteLine("Oyuncu 1 Puanı: " + oyuncu1_puan);
            Console.WriteLine("Oyuncu 2 Puanı: " + oyuncu2_puan);
        }

        // Oyun bitti
        Console.WriteLine("Oyun bitti!");

        if (oyuncu1_puan > oyuncu2_puan)
        {
            Console.WriteLine("Oyuncu 1 kazandı!");
        }
        else
        {
            Console.WriteLine("Oyuncu 2 kazandı!");
        }
    }
}
       



