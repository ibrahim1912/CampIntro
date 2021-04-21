using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //bunlar ilk başta PersonManager içindeydi 
        //daha iyi olması için buraya aldık

        void ApplyForMask(Person person);

        List<Person> GetList();

        //Mernise bağlanıcak kişi dogru mu kontrol edicek
        bool CheckPerson(Person person);

    }
}

//interfaci kullanırken;
//yazılımda bağımlılığı azaltmak için kullanırız
//yazılımcının amacı sadece imza oluşturmak değil
//zounlu olarak implement etmek amacı olmamalı 
//bağımlılığı çözmek daha önemli
