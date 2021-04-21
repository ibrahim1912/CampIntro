using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager:ISupplierService //bir classı çıplak bırakma tahmin et //yeni bir özellik geldiğinde mevcut kodlara dokunmuyoruz solid o harfi
    {
        //dependency injection solid d harfi
        //bağımlılık kontrol ve yönetimi
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService) //PttManagerı new ledğim zman çalışır
        {
            _applicantService = applicantService;

        }
        public void GiveMask(Person person)
        {//maskeyi verebilmen için önce bir kontrol etmen gerek
            
            if (_applicantService.CheckPerson(person)) //eger dogru bir vatandaş ise
            {
                Console.WriteLine(person.FirstName + " İÇİN MASKE VERİLDİ.");//maske verilme kodu
            }
            else
            {
                Console.WriteLine(person.FirstName + " İÇİN MASKE VERİLEMEDi.");
            }

        }

    }
}
//entities hariç
//Bir iş sınıfı başka bir iş sınıfını kullanırken newliyorsa,
//ileriye dönük bu yazılımda değişiklik talebi geldiğinde
//uygulama direnç gösterir.
//new yaptığın zaman diğer class a bağımlı olursun.
//sistem tamamen Person a bağlı baska bir ülkenin vatandaşına vermemiz
//gerekirse sistem patlar
//PersonManager personManager = new PersonManager(); bağımlılık olayı
//ne kadar if varsa kalite düşer kontrol Sonar Cube