using System.Threading.Tasks.Dataflow;

namespace W1_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");
            Console.Write("T.C. Kimlik Numarası: ");
            string tcId = Console.ReadLine();
            Console.Write("Adı: ");
            string name = Console.ReadLine();
            Console.Write("Soyadı: ");
            string surname = Console.ReadLine();
            Console.Write("Telefon Numarası: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Yaş: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("İlk Aldığı Ürünün Fiyatı: ");
            int firstItemPrice = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Aldığı Ürünün Fiyatı: ");
            int secondItemPrice = Convert.ToInt32(Console.ReadLine());
            int totalPrice = firstItemPrice + secondItemPrice;
            double bonusPoints = (double)(firstItemPrice + secondItemPrice) * 0.1;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(tcId + " TC numaralı " + name + " " + surname + " isimli kişi için kayıt oluşturulmuştur.");
            Console.WriteLine(phoneNumber + " telefon numarasına bildirim mesaji gönderilmiştir");
            Console.WriteLine(totalPrice + " toplam harcama karşılığı kazanılan 10% patika puan miktarı -> " + String.Format("{0:0.0}", bonusPoints) + " TL'dir.");

            Console.Read();
        }
    }
}