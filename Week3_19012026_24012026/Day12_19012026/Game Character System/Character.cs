using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Character_System
{
    public class Character
    {
        public string Name { get; set; }

        protected int Health;
        protected int Level;
        protected int Damage;

        public Character()
        {
            Console.Write("Enter Character Name: ");
            Name = Console.ReadLine();
            Health = 100;
            Level = 1;
            Damage = 10;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} attacks with {Damage} damage!");
        }

        public void LevelUp()
        {
            Level++;
            Health += 20;
            Damage += 5;
            Console.WriteLine($"{Name} leveled up to Level {Level}!");
        }

        public void ShowStats()
        {
            Console.WriteLine("\nName   : " + Name);
            Console.WriteLine("Level  : " + Level);
            Console.WriteLine("Health : " + Health);
            Console.WriteLine("Damage : " + Damage);
        }
    }

    public class Warrior : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} swings a sword ferociously!");
        }
    }

    public class Mage : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} casts a powerful fireball!");
        }
    }


    public class Archer : Character
    {
        public override void Attack()
        {
            Console.WriteLine($"{Name} shoots an arrow from afar!");
        }
    }


    class Skill
    {
        private string SkillName;
        private int Power;

        public Skill(string name, int power)
        {
            SkillName = name;
            Power = power;
        }

        public void UseSkill(string characterName)
        {
            Console.WriteLine($"{characterName} uses {SkillName} with power {Power}!");
        }
    }

    class Inventory
    {
        private List<string> items = new List<string>();

        public void AddItem(string item)
        {
            items.Add(item);
            Console.WriteLine(item + " added to inventory.");
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventory Items:");
            foreach (string item in items)
                Console.WriteLine("- " + item);
        }
    }


    class Battle
    {
        public static void Fight(Character c1, Character c2)
        {
            Console.WriteLine("\n⚔️ Battle Starts ⚔️");
            c1.Attack();
            c2.Attack();
            Console.WriteLine("Battle Ends!");
        }
    }



}
