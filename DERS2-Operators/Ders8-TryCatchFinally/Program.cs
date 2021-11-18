using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders8_TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {

            // TryCatch= Hataları önler. İlk önce kontrol eder daha sonra çalıştırır. Hatasız ise try hatalı ise catch bloğu çalışır. Finally her iki durumda da çalışır.
            int bolunen = 20;
            int bolen = 10;
            
            try
            {
                int bolum = bolunen / bolen;
                Console.WriteLine(bolum);
            }
            catch (Exception)
            {

                Console.WriteLine("Bir hata ile karşılaşıldı. Ancak program durmadı Devam Ediyor.");
            }
            finally
            {
                Console.WriteLine("Tryda ki blok calıssada calısmasada çalışan blok. 2 durumda da çalışır");
            }


            int HataVarmi = 0;
            string HataMesaji;
            try
            {
                // işlemler
            }
            catch (ArgumentNullException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.",
                                       ex.Message,
                                       ex.GetType().Name);
            }
            catch (ArgumentException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (IndexOutOfRangeException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (FormatException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (System.IO.FileNotFoundException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (DivideByZeroException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (NullReferenceException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (OutOfMemoryException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }
            catch (InvalidCastException ex)
            {
                HataVarmi = HataMesaji("İşlem yapılırken bir hata oluştu.", ex.Message, ex.GetType().Name);
            }

        }
        static string HataMesaji()
        {
           
            return " ";
        }
    }
}
