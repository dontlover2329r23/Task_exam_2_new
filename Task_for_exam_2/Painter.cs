using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_for_exam_2
{
    internal class Painter
    {
        private Size containerSize;
        private Graphics mainGraphics;
        private BufferedGraphics bg;

        Pen pen = new Pen(Color.Black);

        public double minOX;
        public double minOY;
        public double maxOX;
        public double maxOY;
        public int accuracy;
        public string functionIntegral;

        // Задание MainGraphics + двойная буфферизация
        public Graphics MainGraphics
        {
            get => mainGraphics;
            set
            {
                mainGraphics = value;
                ContainerSize = mainGraphics.VisibleClipBounds.Size.ToSize();
                bg = BufferedGraphicsManager.Current.Allocate(
                        mainGraphics, new Rectangle(new Point(0, 0), ContainerSize)
                    );
                
            }
        }

        // Свойство ContainerSize
        public Size ContainerSize
        {
            get => containerSize;
            set
            {
                containerSize = value;
            }
        }

        // Конструктор Painter
        public Painter(Graphics mainGraphics)
        {
            this.MainGraphics = mainGraphics;
        }

        public void paint(double a, double b, double c)
        {

            bg.Graphics.Clear(Color.White);

            Function f = new Function(a, b, c, minOX, maxOX, minOY, maxOY);
            showAxes(f);

            int step = accuracy;

            for (int i = 0; i < containerSize.Width - step; i += step)
            {
                bg.Graphics.DrawLine(pen, i, find_y(f, i), i + step, find_y(f, i + step));
                
            }

            bg.Render();
        }

        // Сохраняет в byte
        public byte[] SaveGraph()
        {
            // Создаем объект Bitmap размером с контейнер
            Bitmap bitmap = new Bitmap(containerSize.Width, containerSize.Height);

            // Создаем объект Graphics из bitmap
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                // Копируем изображение из BufferedGraphics на bitmap
                bg.Render(graphics);

                // Сохраняем изображение в MemoryStream в формате PNG
                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Png);
                    return stream.ToArray();
                }
            }

        }

        private int find_y(Function f, int i) // pixel
        {

            ScreenPoints xS = new ScreenPoints(i);
            Decarts xD = new Decarts(xS, ContainerSize, f);
            double y = f.func(xD.X);
            if (y > 10) y = 11;
            else if (y < -10) y = -11;
            Decarts yD = new Decarts(0, y);
            ScreenPoints yS = new ScreenPoints(yD, ContainerSize, f);
            return yS.Y;
        }

        private void showAxes(Function f)
        {
            bg.Graphics.DrawLine(pen, -Convert.ToInt32(containerSize.Width * f.minX / (f.maxX - f.minX)), 0,
                -Convert.ToInt32(containerSize.Width * f.minX / (f.maxX - f.minX)), containerSize.Height);  // OY

            bg.Graphics.DrawLine(pen, 0, Convert.ToInt32(containerSize.Height * f.maxY / (f.maxY - f.minY)),
                containerSize.Width, Convert.ToInt32(containerSize.Height * f.maxY / (f.maxY - f.minY))); // OX
        }
    }
}
