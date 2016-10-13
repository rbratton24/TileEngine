using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace TileEngine
{/*
    public class Player: Entity
    {
        const int DOWN = 0;
        const int LEFT = 1;
        const int UP = 2;
        const int RIGHT = 3;

        public bool isAttacking;
        public bool isWalking;
        public int heading;
        const int animationRate = 250;
        int currentFrame;
        long animationCounter;

        int numberOfFramesInAnimation;
        int level;

        public MainGame maingame;

        int speed;
        Vector2 possibleUpdate;

        Rectangle srcRect;
        int roomX, roomY;

        public Player(Texture2D tex, Vector2 pos, Vector2 vel)
            :base(tex, pos, vel)
        {
            isAttacking = false;
            isWalking = false;
            heading = UP;
            currentFrame = 0;
            speed = 250;
            numberOfFramesInAnimation = 2;

            srcRect = new Rectangle(0,0,16,16);
            sprite.Width = Tile.TileSize;
            sprite.Height = Tile.TileSize;
            level = 0;
            roomX = 7; roomY = 0;
        }

        public void UpdateSrcRect() {
            srcRect.X = (heading * numberOfFramesInAnimation + currentFrame) * 16;
            srcRect.Width = srcRect.X + Tile.TileSize;

            if (isAttacking)
            {
                srcRect.Y = (level * 2 + 1) * 16;
            }
            else {
                srcRect.Y = (level * 2) * 16;
            }

            srcRect.Width = srcRect.Y + Tile.TileSize;
            


        }

        public override void Update(GamePadState gamePadData)
        {
            possibleUpdate.X = 0;
            possibleUpdate.Y = 0;

            bool movingLeft = ();
            bool movingRight = ();
            bool movingUp = ();
            bool movingDown = ();

            float secondsSinceLastFrame = mainGame.deltaTime / 1000.0f;

            if (movingUp)
            {
                isWalking = true;
                heading = UP;
                possibleUpdate.Y -= secondsSinceLastFrame * speed;
            }
            else if (movingLeft)
            {
                isWalking = true;
                heading = LEFT;
                possibleUpdate.X -= secondsSinceLastFrame * speed;
            }
            else if (movingDown)
            {
                isWalking = true;
                heading = DOWN;
                possibleUpdate.Y += secondsSinceLastFrame * speed;
            }
            else if (movingRight)
            {
                isWalking = true;
                heading = RIGHT;
                possibleUpdate.X += secondsSinceLastFrame * speed;
            }
            else
            {
                isWalking = false;
            }

            Pos += possibleUpdate;

            //collision detection
            if (mainGame.currentRoom.CollidesWith(this))
            {
                Pos -= possibleUpdate;
            }


            animationCounter += mainGame.deltaTime;
            if (animationCounter > animationRate)
            {
                animationCounter -= animationRate;
                if (isWalking)
                {
                    currentFrame++;
                }
                currentFrame %= numberOfFramesInAnimation;
            }
            updateSrcRect();



            if (Pos.X > mainGame.screenWidth)
            {
                roomX++;
                mainGame.currentRoom.LoadRoom(roomX, roomY);
                pos.X = 0;
            }
            else if (pos.X < 0)
            {
                roomX--;
                mainGame.currentRoom.LoadRoom(roomX, roomY);
                pos.X = mainGame.screenWidth - sprite.Width;
            }
            else if (pos.Y > mainGame.screenHeight)
            {
                roomY--;
                mainGame.currentRoom.LoadRoom(roomX, roomY);
                Pos.Y = 0;
            }
            else if (Pos.Y < 0)
            {
                roomY++;
                mainGame.currentRoom.LoadRoom(roomX, roomY);
                Pos.Y = mainGame.screenHeight;
            }

            base.Update(gamePadData);
        }
        
    }*/
}
