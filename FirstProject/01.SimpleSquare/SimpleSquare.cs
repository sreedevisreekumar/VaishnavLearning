using SmallBasicFun;

namespace SimpleSquare
{
    public class SimpleSquare
	{
    
        public static void Main()
		{
            Tortoise.Show();
            Tortoise.SetSpeed(5);
            int sides = MessageBox.AskForInput("How many sides");
            for (int i = 0; i < sides; i++)
            {
                Tortoise.SetPenWidth(5);
                Tortoise.SetPenColor(Colors.GetRandomColor());
                Tortoise.Move(50);
                Tortoise.Turn(360.0 / sides);

            }
          

        }
	}
}