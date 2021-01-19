using System;

namespace RefAndOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 15;
            int sonuc1 = Carpma(x, y);

            Console.WriteLine("Başlangıçta ;  5 * 15  = "+sonuc1); // bu satırda 10 çıktısını alırız. 
                                   //biz değer tipli olarak methoda gönderdik.
            
            Console.WriteLine("\nRef anahtar kelimesi ile ");
            int a = 1; 
            int b = 5;
            int sonuc2 = Carpma1(ref a, b);
            Console.WriteLine("1 * 5 = "+sonuc2);
            //ref keywordu ile a 'yı referans tipine dönüştürmüş olduk.
            //çıktımız a'nın değerini  kullanacaktır yani cıktımız 10 olacaktır.

            Console.WriteLine("a degeri :" +a); // ref keyworduyle beraber a değeri 2 olmuş olacak.

            Console.WriteLine("\nOut anahtar kelimesi ile ");

            int birinci; // birinciyi out ile kullandığımız için setleme yapmaya ihtiyacımız olmayacaktır.
            int ikinci = 6;
            int sonuc3 = Carpma2(out birinci, ref ikinci);
            Console.WriteLine("buranının sonucu : "+sonuc3); // hem ref hemde out olarak kullandık verilerimizi.
            Console.WriteLine("birinci deger : "+birinci +"  ikinci deger : "+ikinci);
          // birinci deger 2 , ikinci deger 5 çıktı olarak verilecektir.
        }
        static int Carpma(int number1, int number2)
        {
            number1 = 2;
            number2 = 5;
            int sonuc = number1 * number2;
            return sonuc;
        }
        static int Carpma1(ref int number1, int number2)
        {
            number1 = 2;
            number2 = 5;
            int sonuc = number1 * number2;
            return sonuc;
        }
        static int Carpma2(out int number1, ref int number2)
        {
            number1 = 2; // Out anahtar kelimesi için burda setleme yapmak zorundayız.
            number2 = 5;
            int sonuc = number1 * number2;
            return sonuc;
        }
    }
}

  