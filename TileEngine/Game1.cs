using System;
using System.Collections;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TileEngine
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D terrian;
        Texture2D pTexture;
        Room room;
        //Player player;
        Vector2 pPos = new Vector2(50,50);
        Vector2 pVel = new Vector2();
        
        


        /* int[,] map = new int[,]
         {
            { 61,61,61,61,61,61,61, 2, 2,61,61,61,61,61,61,61 },
            { 61,61,61,61,22,61,62, 2, 2,61,61,61,61,61,61,61 },
            { 61,61,61,62, 2, 2, 2, 8, 8,61,61,61,61,61,61,61 },
            { 61,61,62, 2, 2, 2, 2, 2, 2,61,61,61,61,61,61,61 },
            { 61,62, 2, 2, 2, 2, 2, 2, 2,60,61,61,61,61,61,61 },
            {  2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
            { 43,44, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2,43,43 },
            { 61,61, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2,61,61 },
            { 61,61,43,43,43,43,43,43,43,43,43,43,43,43,61,61 },
            { 61,61,61,61,61,61,61,61,61,61,61,61,61,61,61,61 }
         };
         */

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            // room = new Room(Content, "overworldTiles");
            graphics.PreferredBackBufferHeight = 600;
            graphics.PreferredBackBufferWidth = 1024;
            graphics.ApplyChanges();
            base.Initialize();
            
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            terrian = Content.Load<Texture2D>("overworldTiles");
           // pTexture = Content.Load<Texture2D>("link");


            // TODO: use this.Content to load your game content here
            

            room = new Room(Content);
         //   player = new Player(pTexture,pPos, pVel);

        }
        

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            

            // TODO: Add your drawing code here

            
            

            spriteBatch.Begin();

            room.Draw(spriteBatch);
           // player.Draw(spriteBatch);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
