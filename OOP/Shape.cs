using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public string Nick;

        private string _description;
        protected string Color { get; set; }

        public string GetColor() {
            return Color;
        }

        public abstract string GetDescription();
    }

    public class Dog : Animal
    {
        public Dog(string nick)
        { 
            Nick = nick ?? throw new ArgumentNullException(nameof(nick));
        }

        public override string GetDescription()
        {
            return "Соба́ка — домашнее животное, одно из наиболее популярных " +
                "животных-компаньонов. Домашняя собака была описана как самостоятельный биологический " +
                "вид Canis familiaris Линнеем в 1758 году;";
        }

        public void SetName()
        {
            Name = "Собаки";
        }
    }

    public class Cat : Animal 
    {
        public Cat(string nick)
        {
            Name = "Кошка";
            Color = "Белые";
            Nick = nick ?? throw new ArgumentNullException(nameof(nick));
        }

        public override string GetDescription()
        {
            return "Кошка — домашнее животное, одно из наиболее популярных «животных-компаньонов». " +
                "С точки зрения научной систематики, домашняя кошка — млекопитающее семейства кошачьих отряда хищных. ";
        }

        public void SetColor()
        {
            Color = "Красные";
        }
    }

    public class SibirianCat : Cat
    {
        public int LengthSherst { get; set; }

        public SibirianCat(string nick) : base(nick)
        {
            Name = "Сибирская кошка";
            LengthSherst = 10;
            Color = "Серые";
        }

        public override string GetDescription()
        {
            return "Сибирская кошка - порода полудлинношёрстных кошек. Сибирская кошка имеет полудлинную густую шерсть, " +
                "не пропускающую влагу, среднего размера уши, пушистый хвост";
        }
    }
}
