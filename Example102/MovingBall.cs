using System.Numerics; // Vector2
using Raylib_cs; // Color

/*
In this class, we have the properties:

- Vector2  Position
- float    Rotation
- Vector2  Scale

- Vector2 TextureSize
- Vector2 Pivot
- Color Color

Methods:

- AddChild(Node child)
- RemoveChild(Node child, bool keepAlive = false)
*/

namespace Movement
{
	class MovingBall : SpriteNode
	{
		// your private fields here (add Velocity)
		private Vector2 Velocity = new Vector2(600,400);

		// constructor + call base constructor
		public MovingBall() : base("resources/dvdlogo.png")
		{
			Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 4);
			Color = Color.ORANGE;
		}

		// Update is called every frame
		public override void Update(float deltaTime)
		{
			Move(deltaTime);
			BounceEdges();
		}

		// your own private methods
		private void Move(float deltaTime)
		{
			// TODO implement
			Position += Velocity * deltaTime;
		}

		private void BounceEdges()
		{
			float scr_width = Settings.ScreenSize.X;
			float scr_height = Settings.ScreenSize.Y;
			float spr_width = TextureSize.X;
			float spr_height = TextureSize.Y; 

			// TODO implement...
			//Ball position X
			if (Position.X + spr_width / 2 > scr_width)
			{
				Velocity.X = Velocity.X * -1;
				Color = Color.BLUE;
			}
			if (Position.X - spr_width / 2 < 0)
			{
				Velocity.X = Velocity.X * -1;
				Color = Color.GREEN;
			}
			//Ball position Y 
			if (Position.Y + spr_height / 2 > scr_height)
			{
				Velocity.Y = Velocity.Y * -1;
				Color = Color.PINK;
			}
			if (Position.Y - spr_height / 2 < 0)
			{
				Velocity.Y = Velocity.Y * -1;
				Color = Color.YELLOW;
			}
		}

	}
}
