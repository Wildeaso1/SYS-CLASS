using System.Drawing;

namespace Eindopdracht
{

    class Pingu : Sprite
    {
        public Pingu(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 457, 16, 16);
        }
    }
}