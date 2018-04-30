using System;
// Reference for all Model objects
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using GameDev.model;


namespace GameDev.Controller
{
	public class Controller
	{
		// Represents the player 
		private Player player;

		public Controller ()
		{
			
		}

		public void Initialize(){
			// Initialize the player class
			player = new Player();
		}

//		public void LoadContent(){
//			// Load the player resources 
//			Vector2 playerPosition = new Vector2(GraphicsDevice.Viewport.TitleSafeArea.X, GraphicsDevice.Viewport.TitleSafeArea.Y + GraphicsDevice.Viewport.TitleSafeArea.Height / 2);
//
//			player.Initialize(Content.Load<Texture2D>("Texture/player"), playerPosition);
//		}

		public void Draw(SpriteBatch spriteBatch){
			// Start drawing 
			spriteBatch.Begin(); 
			// Draw the Player 
			player.Draw(spriteBatch); 
			// Stop drawing 
			spriteBatch.End();
		}
	}
}

