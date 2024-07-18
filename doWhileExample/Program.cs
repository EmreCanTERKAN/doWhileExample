Console.WriteLine("Bir Sayı Giriniz : ");
int limit = int.Parse(Console.ReadLine());
int sayac = 0;
//While
while (sayac <= limit - 1)
{

    Console.WriteLine("Ben Bir Patikalıyım.");
    sayac++;
}

//do-while
do
{

    sayac++;
    Console.WriteLine("Ben Bir Patikalıyım");

} while (sayac <= limit-1);

// while döngüsünde koşulu başında kontrol eder programı ona göre çalıştırır . Do-while döngüsünde ise önce program çalışıcaktır, bir kere tur dönecektir. Eğer yanlış ise döngüden çıkar,doğru ise döngüyü devam ettirir.