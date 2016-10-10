using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TileEngine
{
    class Tile : Entity
    {
        
        public static int TileSize = 16;
        public static int TileStrecth = 50;
        public Texture2D tile;
        private Rectangle scrRect;
        public Rectangle hitbox;
        public Vector2 position;
        public Vector2 velocity;
        public int TileType;

        public static int NOT_PASSABLE = 0;
        public static int PARTIALLY_PASSABLE = 1;
        public static int COMPLETELY_PASSABLE = 2;
        public int passable;
        

        public Tile(){
            

        }

        public Tile(Texture2D x, Vector2 pos, Vector2 vel, int TileType)
            :base(x,pos,vel)
        {
            this.tile = x;
            this.position = pos;
            this.velocity = vel;
            this.TileType = TileType;

            scrRect = new Rectangle();
            scrRect.X = (TileType % 18) * (TileSize + 1) + 1;
            scrRect.Y = (TileType / 18) * (TileSize + 1) + 1;
            scrRect.Width = scrRect.X + TileSize;
            scrRect.Height = scrRect.Y + TileSize;

            sprite.Position = position;
            sprite.Width = TileSize;
            sprite.Height = TileSize;
            SetPassable();
            

        }

        public void SetPassable() {
            passable = NOT_PASSABLE;
            hitbox = new Rectangle((int)position.X, (int)position.Y, (int)position.X + (int)sprite.Width, (int)position.Y + (int)sprite.Height / 2);
            int[] totallyPassable = { 0, 2, 8, 14, 18, 22, 24, 28, 30, 34, 58, 64, 70, 88 };
            int[] partiallyPassable = { 1, 7, 19, 25, 30, 44, 49, 54, 55, 57, 59, 60, 61, 62, 67 };

            for (int i = 0; i < partiallyPassable.Length; i++)
            {
                if (TileType == partiallyPassable[i])
                {
                    passable = PARTIALLY_PASSABLE;
                    hitbox = new Rectangle((int)position.X + (int)sprite.Width * (int)0.25f, (int)position.Y + (int)sprite.Width * (int)0.25f, (int)position.X + (int)sprite.Width * (int)0.75f, (int)position.Y + (int)sprite.Height * (int)0.75f);
                }
            }
        }


        public void Update()
        {

        }


        
    }
}
