using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace TileEngine
{
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

        int speed;
        Vector3 possibleUpdate;

        Vector4 srcRect;
        int roomX, roomY;

    }
}
