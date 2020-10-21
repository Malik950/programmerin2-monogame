using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    class Player : Playerbase
    {
        public Player(Texture2D tex) : base(tex)
        {

        }
        public override void Update()
        {
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.Right))
                xwingpos.X++;
            if (kstate.IsKeyDown(Keys.Left))
                xwingpos.X--;
            if (kstate.IsKeyDown(Keys.Up))
                xwingpos.Y--;
            if (kstate.IsKeyDown(Keys.Down))
                xwingpos.Y++;



        }

    }
}

    
    


