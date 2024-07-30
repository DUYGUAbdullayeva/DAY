namespace ConsoleApplsn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime Metodlari:
            DateTime dateTime = new DateTime();//Bos datetime
            DateTime dateTime1 = new DateTime(2029, 07, 29);//saat,ay,gun
            DateTime dateTime2 = new DateTime(2024, 07, 29, 10, 58, 54);//il,ay,gun,saat,dq,san
            DateTime dateTime3 = DateTime.Now;//Cari tarix ve zaman
            DateTime dateTime4 = DateTime.Today;//Cari Tarix
            DateTime dateTime5 = DateTime.Parse("2024-07-29");//String olaraq verilmis tarixi DateTime obyektine cevirir
            DateTime dateTime6 = DateTime.MinValue;//0001-01-01 00:00:00
            DateTime dateTime7 = DateTime.MaxValue;//31.12.9999 23:59:59
            int dateTime8 = DateTime.Compare(dateTime1, dateTime3);// compare olanda qarsisinda int olur/dateTime1 ve dateTime2-ni muqayise edir.eger birinci 2ciden sonradisa netice musbet olur,evveldirse menfi olur,eger beraberdise 0 olur.
            DateTime dateTime9 = new DateTime(2023, 7, 29);
            DateTime dateTime10 = new DateTime(2024, 7, 29);

            int dateTime11 = DateTime.Compare(dateTime9, dateTime10);

            if (dateTime11 < 0)
            {
                Console.WriteLine("dateTime9 tarix olaraq dateTime10-dan evveldir.");
            }
            else if (dateTime11 > 0)
            {
                Console.WriteLine("dateTime9 tarix olaraq dateTime10-dan sonradır.");
            }
            else
            {
                Console.WriteLine("dateTime9 və dateTime10 beraberdir.");
            }
            int dateTime12 = DateTime.DaysInMonth(2024, 2);//2024cu ilin 2ci ayinda nece gun oldugunu gosterir/daysinyear?
            bool dateTime13 = DateTime.IsLeapYear(2024);//yazilmis ilin leap year olub-olmadigini bildirir
            bool dateTime14 = DateTime.Equals(dateTime2, dateTime3);//datetime2 ve 3 yoxlayir beraberdirse true deyillse false qaytarir
            bool dateTime15 = dateTime2.Equals(dateTime3);//belede yazila biler yene eyni funksiyani yerine yetirir
            long binaryDate = 5646477483;/*binaryData dəyişəni DateTime obyektinin binar təmsilidir. Bu dəyəri DateTime
                                         FromBinary metoduna ötürərək, həmin binar dəyəri DateTime obyektinə çevirmək olar*/
            DateTime dateTime16 = DateTime.FromBinary(binaryDate);
            DateTime dateTime17 = DateTime.UtcNow;//beynəlxalq vaxt standartıdır. Bu vaxt, Yer kürəsinin hər bir yerində eyni vaxtı təmin etmək üçün istifadə olunur
            //ADD olunma qaydasi:
            DateTime dateTime18 = new DateTime(2024, 08, 01, 22, 08, 43);
            DateTime dateTime19 = dateTime18.AddDays(2);//2 gun elave olunur saatda deyisiklik olmur
            DateTime dateTime20 = dateTime18.Date;/* obyektinin tarix hissəsini alır və vaxt hissəsini gecə yarısına (00:00:00) təyin edir. Bu xüsusiyyət
                                                   bir DateTime obyektindən yalnız tarixi çıxarmaq üçün istifadə olunur, vaxt komponentini nəzərə almadan.*/

            DateTime dateTime21 = dateTime18.AddMinutes(61);//dq elave etdi
            int dateTime22 = dateTime18.DayOfYear;//ilin necenci gunu oldugunu bildirir-int type
            DayOfWeek dateTime23 = dateTime18.DayOfWeek;//Heftenin gununu gosterir ve qarsidaki tipe fikir ver/enum deyer qaytarir
            DayOfWeek dateTime24 = DateTime.Now.DayOfWeek;
            int dateTime25 = dateTime18.CompareTo(dateTime2);//muqayise edir
            int dateTime26 = DateTime.Compare(dateTime18, dateTime2);
            int dateTime27 = dateTime18.Day;//necenci gun oldugunu gosterir,mes 1
            int dateTime28 = dateTime18.Minute;
            Type dateTime29 = dateTime18.GetType();//tipini gosterir
            DateTime dateTime30 = dateTime18.ToUniversalTime();
            TimeSpan dateTime31 = dateTime18.TimeOfDay;//saat,dq,sn

            DateTime dateTime32 = dateTime18.Add(new TimeSpan(1, 2, 40, 25));//1gun 2saat 40dq 25sn elave olunur
            DateTime dateTime33 = dateTime18.ToLocalTime();//utc vaxtini yeri vaxta cevirir/ utc vaxti bizden 4 saat geridir
            bool dateTime34 = dateTime18.IsDaylightSavingTime();//yay vaxti olub olmadigini mueyyen edirik
            DateTime dateTime35 = dateTime18.AddTicks(1000000);//Sorus
            string dateTime36 = dateTime18.ToString();
            Console.WriteLine(dateTime36);
            Type dateTime37 = dateTime36.GetType();
            Console.WriteLine(dateTime37);
        }
    }
}
