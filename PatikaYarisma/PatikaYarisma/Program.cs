

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Bilgi Yarışmasına Hoşgeldiniz!");
Console.WriteLine("Aşağıdaki 3 sorudan 2'sine doğru cevap verirseniz 1 MİLYON TL'lik büyük ödülü kazanacaksınız!\n\n");

Console.WriteLine("1.Soru\nTürkiye'nin yüzölçümü en büyük ili hangisidir?\na)Konya\nb)Sivas\n");
Console.Write("Cevabınız: ");
string cevap1 = Console.ReadLine().ToLower();

bool bosCevap = int.TryParse(cevap1, out int c1);


    switch (cevap1)
    {
        case "a":
            Console.WriteLine("Cevabınız doğru. Diğer soruya geçiniz.\n\n");
            c1 = 1;
            break;
        case "b":
            Console.WriteLine("Cevabınız yanlış. Diğer soruya geçiniz.\n\n");
            c1 = 0;
            break;
        default:
            Console.WriteLine("Geçerli cevap giriniz.");
            return;
            
    }


Console.WriteLine("2.Soru\nPopun kralı kimdir?\na)Michael Jackson\nb)Prince\n");
Console.Write("Cevabınız: ");
string cevap2 = Console.ReadLine().ToLower();

bool bosCevap2 = int.TryParse(cevap1, out int c2);


switch (cevap2)
{
    case "a":
        Console.WriteLine("Cevabınız doğru. Diğer soruya geçiniz.\n\n");
        c2 = 1;
        break;
    case "b":
        Console.WriteLine("Cevabınız yanlış. Diğer soruya geçiniz.\n\n");
        c2 = 0;
        break;
    default:
        Console.WriteLine("Geçerli cevap giriniz.");
        return;

}

int sumCheck = c1 + c2; // 3.soruya geçmeden önce kazanma durumunu incelemek için oluşturulan ara toplam değişkeni
if (sumCheck == 2)
{
    Console.WriteLine("Tebrikler ödülü kazandınız!");
    return; 
}

Console.WriteLine("3.Soru\nCacık Türklerin mi, Yunanların mı?\na)Türklerin\nb):)\n");
Console.Write("Cevabınız: ");
string cevap3 = Console.ReadLine().ToLower();

bool bosCevap3 = int.TryParse(cevap1, out int c3);


switch (cevap3)
{
    case "a":
        Console.WriteLine("Cevabınız doğru. Diğer soruya geçiniz.\n\n");
        c3 = 1;
        break;
    case "b":
        Console.WriteLine("Cevabınız yanlış. \n\n");
        c3 = 0;
        break;
    default:
        Console.WriteLine("Geçerli cevap giriniz.");
        return;

}

int sum = c1+c2+c3; // Tüm soruların cevaplarına göre kazanma durumu

if (sum >= 2)
{
    Console.WriteLine("Tebrikler ödülü kazandınız!");
}
else
{
    Console.WriteLine("Ödülü kazanamadınız :( ");
}