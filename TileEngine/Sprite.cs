using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TileEngine
{
    public class Sprite
    {
        public float Rotation;

        protected Texture2D texture;

        public Vector2 Position;

        public Vector2 Center;

        public Vector2 Scale = Vector2.One;

        float width, height;

        public float Width
        {
            get { return width * Scale.X; }
            set { width = value; }
        }

        public float Height
        {
            get { return height * Scale.Y; }
            set { height = value; }
        }

        public Sprite(Texture2D texture)
        {
            if (texture == null)
                throw new Exception("ERROR texture is null");
            this.texture = texture;
            this.Width = texture.Width;
            this.Height = texture.Height;


        }

        public void Update()
        {
        }

        public void Draw(SpriteBatch sb)
        {
            sb.Draw(texture,Position,Color.White);
        }
    }
}
