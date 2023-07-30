// See https://aka.ms/new-console-template for more information
string sayi = "999";
bool sonuc = int.TryParse(sayi, out int outsayi);
if (sonuc)
{
    Console.WriteLine("Basarili");
    Console.WriteLine(outsayi);
}
else
{
    Console.WriteLine("Basarisiz");
}
topla(4, 5, out int sonucu);
Console.WriteLine(sonucu);

int ifade = 999;
Console.WriteLine(ifade.ToString());




static void topla(int deger1, int deger2, out int toplam)
{
    toplam = deger1+ deger2;
}
//static void topla(string deger1, string deger2, int deger3)
//{
 //   Console.WriteLine("Overloading");
//}