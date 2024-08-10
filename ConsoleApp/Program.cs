using ConsoleApp.Classes;

namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        // Придумать и создать 3-4 класса, которые как минимум дважды наследуются и написать краткое описание текстом.
        // Создать свой дженерик интерфейс IMyCloneable для реализации шаблона "Прототип".
        // Сделать возможность клонирования объекта для каждого из этих классов, используя вызовы родительских конструкторов.
        // Составить тесты или написать программу для демонстрации функции клонирования.
        // Добавить к каждому классу реализацию стандартного интерфейса ICloneable и реализовать его функционал через уже созданные методы.
        // Написать вывод: какие преимущества и недостатки у каждого из интерфейсов: IMyCloneable и ICloneable.
        
        Person person = new Person("Maks", 20);
        Person personClone = person.CloneThisObj();
        personClone.Name = "Maksim";
        personClone.Age = 30;
        
        Console.WriteLine(person);
        Console.WriteLine(personClone);
        
        BankClient bankClient = new BankClient(
            "Maks", 20, "maks@mail.com", new Bank("Sberbank"));
        BankClient clone = (BankClient)bankClient.Clone();
        clone.Name = "Maksim";
        clone.Age = 30;
        clone.Bank.Name = "Tinkoff";
        
        Console.WriteLine(bankClient);
        Console.WriteLine(clone);
        Console.ReadKey();
    }
}

