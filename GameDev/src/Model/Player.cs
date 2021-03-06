﻿using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace GameDev.model
{
	public class Player{
		public Vector2 Position;

		// Amount of hit points that player has
		private int health;
		public int Health
		{
			get { return health; }
			set { health = value; }
		}

		// Get the width of the player ship
		public int Width
		{
			get { return PlayerTexture.Width; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerTexture.Height; }
		}

		// State of the player
		private bool active;
		public bool Active
		{
			get { return active; }
			set { active = value; }
		}

		// Animation representing the player
		private Texture2D playerTexture;
		public Texture2D PlayerTexture
		{
			get { return playerTexture; }
			set { playerTexture =  value; }
		}
		
		public Player (){
		}
			

		public void Update(){
		}


		public void Initialize(Texture2D texture, Vector2 position)
		{
			PlayerTexture = texture; 

			// Set the starting position of the player around the middle of the screen and to the back 
			Position = position;

			// Set the player to be active 
			Active = true;

			// Set the player health
			Health = 100;
		}

		public void Draw(SpriteBatch spriteBatch)
		{ 
			spriteBatch.Draw(PlayerTexture, Position, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
		}

	}
}

