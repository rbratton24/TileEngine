using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Diagnostics;

namespace TileEngine
{
    public class MainGame
    {
        public int screenWidth, screenHeight;
       // private GameState state;

       public Stopwatch clock;
        public long lastTime, currentTime, deltaTime;

        public Room currentRoom;
        //public Player hero;


        public void Initialize(GraphicsDevice context, ContentManager content, Texture2D tex)
        {
            
            //state = new GameState(STATES.Menu);
            currentRoom = new Room(content);
            screenWidth = context.Viewport.Width;
            screenHeight = context.Viewport.Height;

            
            Vector2 tempPos = new Vector2(screenWidth / 2, screenHeight / 2);
            Vector2 tempVel = new Vector2();
           // hero = new Player(tex, tempPos, tempVel);

            clock = new Stopwatch();
            clock.Start();
            currentTime = clock.ElapsedMilliseconds;
            lastTime = currentTime;

        }

        public void Update(GamePadState gamePadData)
        {
            currentTime = clock.ElapsedMilliseconds;

            deltaTime = currentTime - lastTime;
            lastTime = currentTime;

           // hero.Update(gamePadData);
        }

        public void Render(SpriteBatch sb)
        {
            currentRoom.Draw(sb);
           // hero.Draw(sb);
        }
    }
}
