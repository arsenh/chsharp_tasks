using System;

namespace TaskTwo
{


    /// Есть базовый класс с реалиазцией двух интерфейсов, имеющих одинаковый метод
    /// строка var @base = new Base(); - создаёт объект типа Base
    /// вызов @base.WriteExecutor()    - выводит на экран строку I base Executor!
    ///
    /// Дополните код так, чтобы не создавая новый объект на экран было выведено
    ///
    /// I base Executor!
    /// I one Executor!
    /// I two Executor!

    interface IOneExecutor
    {
        void WriteExecutor();
    }

    interface ITwoExecutor
    {
        void WriteExecutor();
    }

    class Base : IOneExecutor, ITwoExecutor
    {
        // Вариант первый.
        void IOneExecutor.WriteExecutor()
        {
            Console.WriteLine("I one Executor");
        }

        void ITwoExecutor.WriteExecutor()
        {
            Console.WriteLine("I two Executor");
        }

        public IOneExecutor getOneExecutor()
        {
            return this;
        }

        public ITwoExecutor getTwoExecutor()
        {
            return this;
        }

        // вариант второй если не нужно менять функцию main.
        //private readonly IOneExecutor one;
        //private readonly ITwoExecutor two;

        //public Base()
        //{
        //    this.one = this;
        //    this.two = this;
        //}

        public void WriteExecutor()
        {
            Console.WriteLine("I base Executor!");
            //one.WriteExecutor();
            //two.WriteExecutor();
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            var @base = new Base();
            @base.WriteExecutor();
            @base.getOneExecutor().WriteExecutor();
            @base.getTwoExecutor().WriteExecutor();
        }
    }
}
