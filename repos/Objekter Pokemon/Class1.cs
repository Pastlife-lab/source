namespace Objekter_Pichachu
{
    class Pikachu
    {
        public string Type { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }

        public string Name { get; set; } = "Pikachu";
        public Pikachu()
        {
            Type = "Electric";
            Level = 5;
            Health = 100;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}: Type: {Type}, Level: {Level}, Helse: {Health}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           Pikachu pika = new Pikachu();
           pika.ShowInfo();
        }
    }
}