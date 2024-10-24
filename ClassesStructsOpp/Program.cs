namespace ClassesStructsOpp
{
    public class Character
    {
        public string name;
        public int exp;

        public Character()
        {
            name = "N/A";
        }

        public Character(string name)
        {
            this.name = name;
        }

        public virtual void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - " + this.exp + " EXP");
        }
        private void Reset()
        {
            this.name = "Not assigned";
            this.exp = 0;
        }
    }

    public class Paladin : Character
    {
        public Weapon weapon;
        public Paladin(string name, Weapon weapon) : base(name)
        {
            this.weapon = weapon;
        }

        public override void PrintStatsInfo()
        {
            Console.WriteLine("Hero: " + this.name + " - take your " + this.weapon.name + "!");
        }
    }

    public struct Weapon
    {
        public string name;
        public int damage;
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public void PrintWeaponStats()
        {
            Console.WriteLine("Weapon: " + this.name + " - " + this.damage + " DMG");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character todd = new Character();
            todd.PrintStatsInfo();

            Character dave = new Character("dave");
            dave.PrintStatsInfo();

            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.PrintWeaponStats();

            Character villian = dave;

            dave.PrintStatsInfo();
            villian.PrintStatsInfo();

            villian.name = "Sir Kane the Brave";

            dave.PrintStatsInfo();
            villian.PrintStatsInfo();

            //Testing value types
            //note: hunting bow is declared above
            Weapon warBow = huntingBow;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingBow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            //Experimenting with Inheritance
            Paladin knight = new Paladin("Sir Arthur", huntingBow);
            knight.PrintStatsInfo();

            //Testing external files
            Adventurer mike = new Adventurer("Mike");
            mike.PrintStatsInfo();

            Dude tom = new Dude("Tom");
            tom.PrintStatsInfo();


        }
    }
}
    

