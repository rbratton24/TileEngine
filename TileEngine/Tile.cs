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
        }


        public void Update()
        {

        }


        
    }
}
