using System;
using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

namespace TileEngine
{
    class Room
    {
        int[,] tileMap;

        public Texture2D Texture
        {
            get { return texture; }
            set { texture = value; }
        }
        Texture2D texture;

        public int Height
        {
            get;
            set;
        }
        
        
        string FileName;
        List<Texture2D> tiles = new List<Texture2D>();
        

        public Room(ContentManager Content)
        {
            tiles.Add(Content.Load<Texture2D>("0"));
            tiles.Add(Content.Load<Texture2D>("1"));
            tiles.Add(Content.Load<Texture2D>("2"));
            tiles.Add(Content.Load<Texture2D>("3"));
            tiles.Add(Content.Load<Texture2D>("4"));
            tiles.Add(Content.Load<Texture2D>("5"));
            tiles.Add(Content.Load<Texture2D>("6"));
            tiles.Add(Content.Load<Texture2D>("7"));
            tiles.Add(Content.Load<Texture2D>("8"));
            tiles.Add(Content.Load<Texture2D>("9"));
            tiles.Add(Content.Load<Texture2D>("10"));
            tiles.Add(Content.Load<Texture2D>("11"));
            tiles.Add(Content.Load<Texture2D>("12"));
            tiles.Add(Content.Load<Texture2D>("13"));
            tiles.Add(Content.Load<Texture2D>("14"));
            tiles.Add(Content.Load<Texture2D>("15"));
            tiles.Add(Content.Load<Texture2D>("16"));
            tiles.Add(Content.Load<Texture2D>("17"));
            tiles.Add(Content.Load<Texture2D>("18"));
            tiles.Add(Content.Load<Texture2D>("19"));
            tiles.Add(Content.Load<Texture2D>("20"));
            tiles.Add(Content.Load<Texture2D>("21"));
            tiles.Add(Content.Load<Texture2D>("22"));
            tiles.Add(Content.Load<Texture2D>("23"));
            tiles.Add(Content.Load<Texture2D>("24"));
            tiles.Add(Content.Load<Texture2D>("25"));
            tiles.Add(Content.Load<Texture2D>("26"));
            tiles.Add(Content.Load<Texture2D>("27"));
            tiles.Add(Content.Load<Texture2D>("28"));
            tiles.Add(Content.Load<Texture2D>("29"));
            tiles.Add(Content.Load<Texture2D>("30"));
            tiles.Add(Content.Load<Texture2D>("31"));
            tiles.Add(Content.Load<Texture2D>("32"));
            tiles.Add(Content.Load<Texture2D>("33"));
            tiles.Add(Content.Load<Texture2D>("34"));
            tiles.Add(Content.Load<Texture2D>("35"));
            tiles.Add(Content.Load<Texture2D>("36"));
            tiles.Add(Content.Load<Texture2D>("37"));
            tiles.Add(Content.Load<Texture2D>("38"));
            tiles.Add(Content.Load<Texture2D>("39"));
            tiles.Add(Content.Load<Texture2D>("40"));
            tiles.Add(Content.Load<Texture2D>("41"));
            tiles.Add(Content.Load<Texture2D>("42"));
            tiles.Add(Content.Load<Texture2D>("43"));
            tiles.Add(Content.Load<Texture2D>("44"));
            tiles.Add(Content.Load<Texture2D>("45"));
            tiles.Add(Content.Load<Texture2D>("46"));
            tiles.Add(Content.Load<Texture2D>("47"));
            tiles.Add(Content.Load<Texture2D>("48"));
            tiles.Add(Content.Load<Texture2D>("49"));
            tiles.Add(Content.Load<Texture2D>("50"));
            tiles.Add(Content.Load<Texture2D>("51"));
            tiles.Add(Content.Load<Texture2D>("52"));
            tiles.Add(Content.Load<Texture2D>("53"));
            tiles.Add(Content.Load<Texture2D>("54"));
            tiles.Add(Content.Load<Texture2D>("55"));
            tiles.Add(Content.Load<Texture2D>("56"));
            tiles.Add(Content.Load<Texture2D>("57"));
            tiles.Add(Content.Load<Texture2D>("58"));
            tiles.Add(Content.Load<Texture2D>("59"));
            tiles.Add(Content.Load<Texture2D>("60"));
            tiles.Add(Content.Load<Texture2D>("61"));
            tiles.Add(Content.Load<Texture2D>("62"));
            tiles.Add(Content.Load<Texture2D>("63"));
            tiles.Add(Content.Load<Texture2D>("64"));
            tiles.Add(Content.Load<Texture2D>("65"));
            tiles.Add(Content.Load<Texture2D>("66"));
            tiles.Add(Content.Load<Texture2D>("67"));
            tiles.Add(Content.Load<Texture2D>("68"));
            tiles.Add(Content.Load<Texture2D>("69"));
            tiles.Add(Content.Load<Texture2D>("70"));
            tiles.Add(Content.Load<Texture2D>("71"));
            tiles.Add(Content.Load<Texture2D>("72"));
            tiles.Add(Content.Load<Texture2D>("73"));
            tiles.Add(Content.Load<Texture2D>("74"));
            tiles.Add(Content.Load<Texture2D>("75"));
            tiles.Add(Content.Load<Texture2D>("76"));
            tiles.Add(Content.Load<Texture2D>("77"));
            tiles.Add(Content.Load<Texture2D>("78"));
            tiles.Add(Content.Load<Texture2D>("79"));
            tiles.Add(Content.Load<Texture2D>("80"));
            tiles.Add(Content.Load<Texture2D>("81"));
            tiles.Add(Content.Load<Texture2D>("82"));
            tiles.Add(Content.Load<Texture2D>("83"));
            tiles.Add(Content.Load<Texture2D>("84"));
            tiles.Add(Content.Load<Texture2D>("85"));
            tiles.Add(Content.Load<Texture2D>("86"));
            tiles.Add(Content.Load<Texture2D>("87"));
            tiles.Add(Content.Load<Texture2D>("88"));
            tiles.Add(Content.Load<Texture2D>("89"));
            tiles.Add(Content.Load<Texture2D>("90"));
            tiles.Add(Content.Load<Texture2D>("91"));
            tiles.Add(Content.Load<Texture2D>("92"));
            tiles.Add(Content.Load<Texture2D>("93"));
            tiles.Add(Content.Load<Texture2D>("94"));
            tiles.Add(Content.Load<Texture2D>("95"));
            tiles.Add(Content.Load<Texture2D>("96"));
            tiles.Add(Content.Load<Texture2D>("97"));
            tiles.Add(Content.Load<Texture2D>("98"));
            tiles.Add(Content.Load<Texture2D>("99"));
            tiles.Add(Content.Load<Texture2D>("100"));
            tiles.Add(Content.Load<Texture2D>("101"));
            tiles.Add(Content.Load<Texture2D>("102"));
            tiles.Add(Content.Load<Texture2D>("103"));
            tiles.Add(Content.Load<Texture2D>("104"));
            tiles.Add(Content.Load<Texture2D>("105"));
            tiles.Add(Content.Load<Texture2D>("106"));
            tiles.Add(Content.Load<Texture2D>("107"));
            tiles.Add(Content.Load<Texture2D>("108"));
            tiles.Add(Content.Load<Texture2D>("109"));
            tiles.Add(Content.Load<Texture2D>("110"));
            tiles.Add(Content.Load<Texture2D>("111"));
            tiles.Add(Content.Load<Texture2D>("112"));
            tiles.Add(Content.Load<Texture2D>("113"));
            tiles.Add(Content.Load<Texture2D>("114"));
            tiles.Add(Content.Load<Texture2D>("115"));
            tiles.Add(Content.Load<Texture2D>("116"));
            tiles.Add(Content.Load<Texture2D>("117"));
            tiles.Add(Content.Load<Texture2D>("118"));
            tiles.Add(Content.Load<Texture2D>("119"));
            tiles.Add(Content.Load<Texture2D>("120"));
            tiles.Add(Content.Load<Texture2D>("121"));
            tiles.Add(Content.Load<Texture2D>("122"));
            tiles.Add(Content.Load<Texture2D>("123"));
            tiles.Add(Content.Load<Texture2D>("124"));
            tiles.Add(Content.Load<Texture2D>("125"));
            tiles.Add(Content.Load<Texture2D>("126"));
            tiles.Add(Content.Load<Texture2D>("127"));
            tiles.Add(Content.Load<Texture2D>("128"));
            tiles.Add(Content.Load<Texture2D>("129"));
            tiles.Add(Content.Load<Texture2D>("130"));
            tiles.Add(Content.Load<Texture2D>("131"));
            tiles.Add(Content.Load<Texture2D>("132"));
            tiles.Add(Content.Load<Texture2D>("133"));
            tiles.Add(Content.Load<Texture2D>("134"));
            tiles.Add(Content.Load<Texture2D>("135"));
            tiles.Add(Content.Load<Texture2D>("136"));
            tiles.Add(Content.Load<Texture2D>("137"));
            tiles.Add(Content.Load<Texture2D>("138"));
            tiles.Add(Content.Load<Texture2D>("139"));
            tiles.Add(Content.Load<Texture2D>("140"));
            tiles.Add(Content.Load<Texture2D>("141"));
            tiles.Add(Content.Load<Texture2D>("142"));
            tiles.Add(Content.Load<Texture2D>("143"));


            
            tileMap = new int[10, 16];
            LoadRoom(7, 0);
        }

        public void LoadRoom(int RoomX, int RoomY)
        {
            

            FileName = "Content/Levels/" + RoomX + "_" + RoomY + ".txt";
            StreamReader sr = new StreamReader(TitleContainer.OpenStream(FileName));
            

            try
            {
               for(int y = 0; y < tileMap.GetLength(0); y++)
                {
                    string lie = sr.ReadLine();
                    string[] tileno = lie.Split(',');

                    for (int x = 0; x < tileMap.GetLength(1); x++)
                    {
                            
                        if (sr != null)
                        {
                            int index = tileMap[y, x];
                            
                            tileMap[y, x] = Convert.ToInt32(tileno[x]);
                        }
                    }
                } 
            }
            catch
            {
            }
        }
        public void Draw(SpriteBatch sb)
        {
            List<Texture2D> tex;
            tex = tiles;
            for (int y = 0; y < tileMap.GetLength(0); y++)
            {
                for (int x = 0; x < tileMap.GetLength(1); x++)
                {
                    int index = tileMap[y, x];
                    texture = tex[index];
                    Height = 50;

                    sb.Draw(
                        texture,
                        //new Vector2(x * Tile.TileSize, y * Tile.TileSize),     ///This Makes the tiles really small when displayed
                        new Rectangle(x * 64, y * 64, 70, 70),
                        Color.White
                        );
                    
                }
            }
        }
           
    }
}
