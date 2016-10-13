using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TileEngine
{
    
    public class Entity
    {
        public Sprite sprite;
        public Vector2 Pos;
        public Vector2 vel;
        public bool isAlive;
        public float rot;
        public int hitSizeSquared;
      public Entity()
      {
      }
        

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }

        public Texture2D texture;

        public Entity(Texture2D tex, Vector2 pos, Vector2 vel)
        {
            sprite = new Sprite(tex);
            this.Pos = pos;
            this.vel = vel;
            this.isAlive = true;
            this.rot = 0.0f;
            this.hitSizeSquared = tex.Width * tex.Width;
        }

        public virtual void Update(GamePadState gamePadData)
        {
            sprite.Rotation = rot;
            sprite.Position = Pos;
        }


        public virtual void Draw(SpriteBatch sb)
        {
            sprite.Draw(sb);
        }
    }
}
