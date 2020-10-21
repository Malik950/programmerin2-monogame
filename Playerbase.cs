using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    class Playerbase 
    {
        Texture2D texture;
        protected Vector2 xwingpos = new Vector2(100,100);

        public virtual void Update()
        {

        }

        public Playerbase(Texture2D tex)
        {
            texture = tex;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, xwingpos, Color.White);
        }

    }
}
