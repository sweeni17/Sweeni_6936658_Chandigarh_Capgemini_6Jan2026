namespace Game_Character_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character player1 = new Warrior();
            Character player2 = new Mage();

            Inventory inv = new Inventory();
            inv.AddItem("Health Potion");
            inv.AddItem("Magic Scroll");

            Skill skill = new Skill("Power Strike", 30);

            player1.ShowStats();
            player1.LevelUp();
            skill.UseSkill(player1.Name);

            Battle.Fight(player1, player2);

            inv.ShowInventory();

        }
    }
}
