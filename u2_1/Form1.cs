namespace u2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if (c.ShowDialog() == DialogResult.OK) { 
            btnColor.BackColor = c.Color;
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {

            ColorDialog p = new ColorDialog();
            p.Color = btnColor.BackColor;
            Graphics papel = pB1.CreateGraphics();
            Pen lapiz = new Pen(p.Color);
            SolidBrush brocha = new SolidBrush(p.Color);
            
            if (cbLinea.Checked)
            {
                if (cbRandom.Checked)
                {

                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawLine(lapiz, x, y, 100, 10);
                    cbLinea.Checked = !cbLinea.Checked;
                }
                else
                {
                    papel.DrawLine(lapiz, 10, 10, 100, 10);
                    cbLinea.Checked = !cbLinea.Checked;
                }
                 
            }
            if (cbRectangulo.Checked)
            {
                if (cbRandom.Checked)
                {
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawRectangle(lapiz, x, y, 100, 50);
                    cbRectangulo.Checked = !cbRectangulo.Checked;
                }
                else
                {
                    papel.DrawRectangle(lapiz, 110, 10, 100, 50);
                    cbRectangulo.Checked = !cbRectangulo.Checked;
                }
                
            }
            if (cbCuadrado.Checked)
            {
                if (cbRandom.Checked)
                {
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawRectangle(lapiz, x, y, 50, 50);
                    cbCuadrado.Checked = !cbCuadrado.Checked;
                }
                else
                {
                    papel.DrawRectangle(lapiz, 220, 10, 50, 50);
                    cbCuadrado.Checked = !cbCuadrado.Checked;
                }
            }
            if (cbElipce.Checked)
            {
                if (cbRandom.Checked)
                {
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.DrawEllipse(lapiz, x, y, 100, 50);
                    cbElipce.Checked = !cbElipce.Checked;
                }
                else
                {
                    papel.DrawEllipse(lapiz, 280, 10, 100, 50);
                    cbElipce.Checked = !cbElipce.Checked;
                }
               
            }
            if (cbElipcell.Checked) 
            {
                if (cbRandom.Checked)
                {
                    Random r = new Random();
                    int n = r.Next(5);
                    Random x1 = new Random();
                    int x = x1.Next(280);
                    Random y1 = new Random();
                    int y = y1.Next(300);
                    papel.FillEllipse(brocha, x,y, 100, 50);
                    cbElipcell.Checked = !cbElipcell.Checked;
                }
                else
                {
                    papel.FillEllipse(brocha, 10, 70, 100, 50);
                    cbElipcell.Checked = !cbElipcell.Checked;
                }
                
            }
           /* if (cbRandom.Checked)
            {
                Random r = new Random();
                int n= r.Next(5);
                Random x1 = new Random();
                int x = x1.Next(280);
                Random y1 = new Random();
                int y = y1.Next(300);

                 switch (n)
                 {
                     case 1:papel.DrawLine(lapiz, x, y, 100, 10); break;
                     case 2: papel.DrawRectangle(lapiz, x, y, 100, 50); break;
                     case 3: papel.DrawRectangle(lapiz, x, y, 50, 50); break;
                     case 4: papel.DrawEllipse(lapiz, x, y, 100, 50); break;
                     case 5: papel.FillEllipse(brocha, x, y, 100, 50); break;

                 }
                cbRandom.Checked = !cbRandom.Checked;
             }*/

            }
            private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            pB1.Image = null;
            btnColor.BackColor = Color.Black;

        }

    }
}