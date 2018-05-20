namespace OOPHuman.Classes
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        public int Health;
        public Human(string name, int str = 3, int intl = 3, int dex = 3, int hlth = 100)
        {
            Name = name;
            Strength = str;
            Intelligence = intl;
            Dexterity = dex;
            Health = hlth;
        }
        public void Stats()
        {
            System.Console.WriteLine("Name: {0}, Strength: {1}, Intelligence: {2}, Dexterity: {3}, Health: {4}", Name, Strength, Intelligence, Dexterity, Health);
        }

        public void Attack(Human human)
        {
            int damage = 5 * Strength;
            System.Console.WriteLine("Attacking {0}...!", human.Name);
            System.Console.WriteLine("Dealt " + damage + " damage!");
            human.Health -= damage;
        }
    }
}