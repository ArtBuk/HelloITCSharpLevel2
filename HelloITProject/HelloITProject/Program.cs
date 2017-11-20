using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloITProject
{
    class Paper
    {
        private int _height = 1;
        private int _width = 1;
        private int _thickness = 1;
        private string _colour = "#fff";
        private PaperMaterial _material;

        public Paper(int height, int width, int thickness, string colour, PaperMaterial material)
        {
            Height = height;
            Width = width;
            Thickness = thickness;
            Colour = colour;
            Material = material;
        }

        public int Height
        {
            get { return _height; }
            set
            {
                if (value <= 0) return;
                _height = value;
            }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                if (value <= 0) return;
                _width = value;
            }
        }

        public int Thickness
        {
            get { return _thickness; }
            set
            {
                if (value <= 0) return;
                _thickness = value;
            }
        }

        public string Colour
        {
            get { return _colour; }
            set
            {
                if (!value.Contains("#")) return;

                _colour = value;
            }
        }

        public PaperMaterial Material
        {
            get { return _material; }
            set { _material = value; }
        }
    }

    public enum PaperMaterial
    {
        Paper,
        Cardboard
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Paper(10,20,155,"sadasda", PaperMaterial.Cardboard);
            Console.WriteLine("Width: " + p.Width);
            Console.WriteLine("Height: " + p.Height);
            Console.WriteLine("Material: " + p.Material);
            Console.WriteLine("Colour: " + p.Colour);
            Console.WriteLine("Thickness: " + p.Thickness);


            //p.Height = 10;
            //p.Width = 20;

            //Console.WriteLine("Width: " + p.Width);
            //Console.WriteLine("Height: " + p.Height);
            //p.Width = -10;
            //Console.WriteLine("Width: " + p.Width);

            //p.Colour = "#fff";
            //p.Colour = "White";
            //Console.WriteLine("Colour: " + p.Colour);


            //p.Material = (PaperMaterial) Enum.Parse(typeof(PaperMaterial), "Paper");
            //Console.WriteLine("Material: " + p.Material);
            Console.ReadKey();
        }
    }
}
