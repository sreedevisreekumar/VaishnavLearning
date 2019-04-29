using SmallBasicFun;

namespace SimpleSquare
{
    public class SimpleSquare
	{
        private const int sides = 10;
           

        public static void Main()
		{
            Tortoise.Show();
          
            Tortoise.SetSpeed(10);
         
            for (int i = 0; i < sides; i++)
            {
                Tortoise.SetPenWidth(2);
                Tortoise.SetPenColor(Colors.GetRandomColor());
                Tortoise.Move(50);
                Tortoise.Turn(360.0 / sides);

            }
          

        }
	}
}