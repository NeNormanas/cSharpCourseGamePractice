using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGame.Gui
{
    class TextLine : GuiObject
    {
        private string _data;

        public TextLine(int x, int y, int width, string data) : base(x, y, width, 0)
        {
            _data = data;
        }

        public void Render()
        {
            Console.SetCursorPosition(X, Y);
            if (Width > _data.Length)
            {
                int offset = (Width - _data.Length) / 2;
                for (int i = 0; i < offset; i++)
                {
                    Console.Write(' ');
                }
            }

            Console.Write(_data);
        }
    }
}
