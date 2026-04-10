ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.Resize(-20);
imageProcessor.Resize(25);
imageProcessor.Resize(130);
imageProcessor.Resize(150, 250);
imageProcessor.Resize("A3");

class ImageProcessor
{
    public void Resize(int persen)
    {
        if (persen <= 0)
        {
            Console.Write("ERROR! Persentase Tidak Boleh NOL atau NEGATIF!");
        }
        else if (persen < 100)
        {
            Console.WriteLine($"Mengecilkan Gambar Sebesar {persen}%");
        }
        else if (persen > 100)
        {
            Console.WriteLine($"Memperbesar Gambar Sebesar {persen}%");
        }
        else
        {
            Console.WriteLine("Ukuran Tetap (100%) TIDAK ADA PERUBAHAN!");
        }
    }

    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Mengubah Ukuran Gmabar Menjadi {lebar} px X {tinggi}");
    }
    public void Resize(string ukuranKertas)
    {
        Console.WriteLine($"Menyesuaikan ke Format Kertas {ukuranKertas}");
    }
}