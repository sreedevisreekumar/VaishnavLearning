using SmallBasicFun;

namespace SimpleSquare
{
    public class SimpleSquare
	{
    
        public static void Main()
		{
            Tortoise.Show();
            Tortoise.SetSpeed(7);
            int sides = MessageBox.AskForInput("How many sides");
            for (int i = 0; i < sides; i++)
            {
                Tortoise.SetPenWidth(i*2.5);
                Tortoise.SetPenColor(Colors.GetRandomColor());
                Tortoise.Move(i*3.5);
                Tortoise.Turn(-3*360.0 / sides);

            }
          

        }
	}
}