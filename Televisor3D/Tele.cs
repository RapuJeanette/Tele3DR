using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Televisor3D
{
    internal class Tele
    {
        private float alto, largo, ancho;
        private Vector3 vector; //posicion del objeto
        public Tele(Vector3 v, float largo, float alto, float ancho)
        {
            vector = v;
            this.alto = alto;
            this.largo = largo;
            this.ancho = ancho;
        }

        public void dibujar()
        {
            //PARTE DELANTERA
            //PANTALLA
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Black);
            GL.Vertex3(vector.X + 0.03f, vector.Y + 0.04,vector.Z + -0.03);
            GL.Vertex3(vector.X + 0.03f, vector.Y + 0.36,vector.Z + -0.03);
            GL.Vertex3(vector.X + 0.47f, vector.Y + 0.36,vector.Z + -0.03);
            GL.Vertex3(vector.X + 0.47f, vector.Y + 0.04,vector.Z + -0.03);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.DarkBlue);
            GL.Vertex3(vector.X+ 0f,vector.Y + 0f,vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0f,vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0.4f,vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0f,vector.Y + 0.4f,vector.Z + -0.03f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Yellow);
            GL.Vertex3(vector.X + 0.22f,vector.Y + 0f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.22f,vector.Y + -0.05f,vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.26f,vector.Y + -0.05f,vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.26f,vector.Y + 0f,vector.Z + -0.03f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Yellow);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.05f,vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.06f,vector.Z +  -0.03f);
            GL.Vertex3(vector.X + 0.36f,vector.Y + -0.06f,vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.36f,vector.Y + -0.05f, vector.Z + -0.03f);
            GL.End();

            //PARTE TRASERA DEL TV
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.DarkKhaki);
            GL.Vertex3(vector.X + 0f,vector.Y + 0f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0.4f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0f, vector.Y + 0.4f, vector.Z + 0f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Aquamarine);
            GL.Vertex3(vector.X + 0.22f, vector.Y + 0f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.22f, vector.Y + -0.05f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.26f, vector.Y + -0.05f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.26f, vector.Y + 0f, vector.Z + 0f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Aquamarine);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.05f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.06f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.36f, vector.Y + -0.06f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.36f, vector.Y + -0.05f, vector.Z + 0f);
            GL.End();

            //PARTE LATERALES DEL TV
            //UNIENDO DELANTE CON ATRAS
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.DarkGray);
            GL.Vertex3(vector.X + 0.0f, vector.Y + 0.0f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.0f, vector.Y + 0.0f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0f, vector.Y + 0.4f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0f, vector.Y + 0.4f, vector.Z + 0f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.DarkGreen);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0.0f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0.0f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0.4f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.5f, vector.Y + 0.4f, vector.Z + 0f);
            GL.End();

            //UNION DE SOPORTE
            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Red);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.05f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.05f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.06f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.12f, vector.Y + -0.06f, vector.Z + 0f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Red);
            GL.Vertex3(vector.X + 0.36f, vector.Y + -0.05f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.36f, vector.Y + -0.05f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.36f, vector.Y + -0.06f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.36f, vector.Y + -0.06f, vector.Z + 0f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Red);
            GL.Vertex3(vector.X + 0.22f, vector.Y + -0.05f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.22f, vector.Y + -0.05f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.22f, vector.Y + 0f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.22f, vector.Y + 0f, vector.Z + 0f);
            GL.End();

            GL.Begin(PrimitiveType.Quads);
            GL.Color4(Color.Red);
            GL.Vertex3(vector.X + 0.26f, vector.Y + -0.05f, vector.Z + 0f);
            GL.Vertex3(vector.X + 0.26f, vector.Y + -0.05f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.26f, vector.Y + 0f, vector.Z + -0.03f);
            GL.Vertex3(vector.X + 0.26f, vector.Y + 0f, vector.Z + 0f);
            GL.End();

        }
    }
}
