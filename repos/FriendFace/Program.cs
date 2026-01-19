namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Friends = new Friends();

            while (true)
            {
                Friends.Run();
            }
        }
    }
}
