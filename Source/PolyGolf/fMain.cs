using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenGL;

namespace PolyGolf
{
    public partial class fMain : Form
    {
        /* GLOBALS */
        const int w = 800, h = 600;
        //float fps;

        public fMain()
        {
            InitializeComponent();
        }

        private void glControl_ContextCreated(object sender, GlControlEventArgs e)
        {
            // Here you can allocate resources or initialize state
            Gl.MatrixMode(MatrixMode.Projection);
            Gl.LoadIdentity();
            Gl.Ortho(0.0, 1.0f, 0.0, 1.0, 0.0, 1.0);

            dimensions(w, h);
            Gl.MatrixMode(MatrixMode.Modelview);
            Gl.LoadIdentity();
        }

        private void glControl_Render(object sender, GlControlEventArgs e)
        {
            Gl.Clear(ClearBufferMask.ColorBufferBit);

            Gl.Begin(PrimitiveType.Polygon);
            Gl.Color3(1.0f, 0.0f, 0.0f); Gl.Vertex2(0.5f, 0.1f);
            Gl.Color3(1.0f, 1.0f, 0.0f); Gl.Vertex2(0.333333f, 0.333333f);
            Gl.Color3(0.0f, 1.0f, 0.0f); Gl.Vertex2(0.333333f, 0.666666f);
            Gl.Color3(0.0f, 1.0f, 1.0f); Gl.Vertex2(0.5f, 0.9f);
            Gl.Color3(0.0f, 0.0f, 1.0f); Gl.Vertex2(0.666666f, 0.666666f);
            Gl.Color3(1.0f, 0.0f, 1.0f); Gl.Vertex2(0.666666f, 0.333333f);
            Gl.End();
        }

        private void glControl_ContextDestroying(object sender, GlControlEventArgs e)
        {
            // Here you can dispose resources allocated in RenderControl_ContextCreated
        }

        private void dimensions(int width, int height)
        {
            this.Size = new Size(width, height);
            Gl.Viewport(0, 0, this.DisplayRectangle.Width, this.DisplayRectangle.Height);
        }
    }
}
