using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("==>Müşteri Bilgileri Eklendi.");
        }
        public void Update()
        {
            Console.WriteLine("==>Müşteri Bilgileri Güncellendi.\n");
        }
        public void Delete()
        {
            Console.WriteLine("==>Müşteri Bilgileri Silindi.");
        }
        public void List()
        {
            Console.WriteLine("==>Müşteri Bilgileri Listelendi.");
        }
    }
}
