using System;
using System.Collections.Generic;

namespace Adventure_Game
{
    abstract class GameCharacter
    {
        private string _name;
        private int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > 100)
                    _health = 100;
                else
                    _health = value;
            }
        }

        public GameCharacter(string name, int health)
        {
            _name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                Health -= amount;
                Console.WriteLine($"{Name} takes {amount} damage.");
                Console.WriteLine($"{Name}'s health: {Health}");
            }
        }

        public void Heal()
        {
            Health += 10;
            Console.WriteLine($"{Name} heals 10 points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }

        public void Heal(int amount)
        {
            if (amount > 0)
            {
                Health += amount;
                Console.WriteLine($"{Name} heals {amount} points.");
                Console.WriteLine($"{Name}'s health: {Health}");
            }
        }
    }

    class Warrior : GameCharacter
    {
        public Warrior(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                int damage = amount - 2;

                if (damage < 0)
                    damage = 0;

                Health -= damage;

                Console.WriteLine($"{Name} takes {damage} damage.");
                Console.WriteLine($"{Name}'s health: {Health}");
            }
        }
    }

    class Wizard : GameCharacter
    {
        public Wizard(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }

        public override void TakeDamage(int amount)
        {
            if (amount > 0)
            {
                Health -= amount;

                Console.WriteLine($"{Name} takes {amount} damage.");
                Console.WriteLine($"{Name}'s health: {Health}");
            }
        }
    }

    interface ICollectible
    {
        void Collect();
    }

    class HealthPotion : ICollectible
    {
        public string PotionName { get; set; }

        public HealthPotion(string potionName)
        {
            PotionName = potionName;
        }

        public void Collect()
        {
            Console.WriteLine($"{PotionName} collected!");
        }

        public void Use(GameCharacter character, string amountText)
        {
            try
            {
                int amount = int.Parse(amountText);
                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine(
                    "Invalid input! Please enter a number.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ADVENTURE GAME\n");

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);

            List<GameCharacter> characters =
                new List<GameCharacter>();

            characters.Add(warrior);
            characters.Add(wizard);

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine(
                    $"{character.GetType().Name} {character.Name} enters the game!");

                character.UseSpecialAbility();

                if (character is Warrior)
                    character.TakeDamage(10);
                else
                    character.TakeDamage(10);

                Console.WriteLine();

                if (character is Warrior)
                {
                    character.Heal();
                    Console.WriteLine();

                    character.Heal(15);
                    Console.WriteLine();
                }
            }

            HealthPotion potion =
                new HealthPotion("Health Potion");

            potion.Collect();
            Console.WriteLine();

            potion.Use(wizard, "15");
            Console.WriteLine();

            potion.Use(wizard, "abc");
        }
    }
}

