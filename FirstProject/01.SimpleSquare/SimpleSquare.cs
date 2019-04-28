using SmallBasicFun;

namespace SimpleSquare
{
	public class SimpleSquare
	{
		public static void Main()
		{
            Tortoise.Show();
          
            Tortoise.SetSpeed(10);
         
            for (int i = 0; i < 4; i++)
            {
                Tortoise.SetPenColor("blue");
                Tortoise.Move(50);
                Tortoise.Turn(90);

            }
          

        }
	}
}