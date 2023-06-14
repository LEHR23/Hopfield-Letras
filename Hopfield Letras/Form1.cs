using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hopfield_Letras
{
    public partial class Form1 : Form
    {

        int[] vector = new int[25];
        int[] vectorres = new int[25];
        Panel[] vpanele = new Panel[25];
        Panel[] vpanels = new Panel[25];

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 25; i++)
            {
                vector[i] = 0;
                vectorres[i] = 0;
            }
            crear(true);
            crear(false);
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                vpanele[i].BackColor = Color.White;
                vpanels[i].BackColor = Color.White;
                vector[i] = -1;
                vectorres[i] = -1;
            }
        }

        private void btnvectorentrada(object sender, EventArgs e)
        {
            var btn = (Panel)sender;
            if (vector[int.Parse(btn.Tag.ToString())] == -1)
            {
                btn.BackColor = Color.Black;
                vector[int.Parse(btn.Tag.ToString())] = 1;
            }
            else
            {
                btn.BackColor = Color.White;
                vector[int.Parse(btn.Tag.ToString())] = -1;
            }
        }

        private void hopfield_Click(object sender, EventArgs e)
        {
            metodohopfield();
        }

        private void crear(bool panel)
        {
            Panel p;
            int x = 17;
            int y = 17;
            int c = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    p = new Panel();
                    p.Location = new Point(x,y);
                    p.Size = new Size(20,20);
                    p.BackColor = Color.White;
                    p.Tag = c;
                    if (panel)
                    {
                        p.Click += new EventHandler(btnvectorentrada);
                        pvectorent.Controls.Add(p);
                        vpanele[c] = p;
                    }
                    else
                    {
                        pvectorres.Controls.Add(p);
                        vpanels[c] = p;
                    }
                    c++;
                    x += 26;
                }
                x = 17;
                y += 26;
            }
        }

        private void mostrarres()
        {
            for (int i = 0; i < 25; i++)
            {
                if (vectorres[i] == 1)
                {
                    vpanels[i].BackColor = Color.Black;
                }
            }
        }

        private void metodohopfield()
        {
            int[] A = { -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, 1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, 1 };
            int[] O = { 1, 1, 1, 1, 1, 1, -1, -1, -1, 1, 1, -1, -1, -1, 1, 1, -1, -1, -1, 1, 1, 1, 1, 1, 1 };
            int[] Z = { 1, 1, 1, 1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, 1, 1, 1, 1 };
            int[] X = { 1, -1, -1, -1, 1, -1, 1, -1, 1, -1, -1, -1, 1, -1, -1, -1, 1, -1, 1, -1, 1, -1, -1, -1, 1 };
            int[] L = { 1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, -1, -1, -1, -1, 1, 1, 1, 1, 1 };
            int[] W = { 1, -1, -1, -1, 1, 1, -1, -1, -1, 1, 1, -1, 1, -1, 1, 1, 1, -1, 1, 1, 1, -1, -1, -1, 1 };

            Metodos m = new Metodos();
            int[,] matrizT = m.sumamatrices(m.multiplicaciovector(A), m.multiplicaciovector(O));
            matrizT = m.sumamatrices(matrizT, m.multiplicaciovector(Z));
            matrizT = m.sumamatrices(matrizT, m.multiplicaciovector(X));
            matrizT = m.sumamatrices(matrizT, m.multiplicaciovector(L));
            matrizT = m.sumamatrices(matrizT, m.multiplicaciovector(W));

            matrizT = m.matrizentrenamiento(matrizT);
            int[] v1 = vector;
            int[] v2 = new int[25];
            bool control = true;
            int cont = 0;
            while (control)
            {
                v2 = m.multiplicacionmv(v1, matrizT);
                v2 = m.funcionactivacion(v2);
                control = m.iguales(v2, v1);
                cont++;
                if (control)
                {
                    v1 = v2;
                    if (cont == 100)
                    {
                        MessageBox.Show("no hay estabilidad");
                        control = false;
                    }
                }
            }

            for (int i = 0; i < vector.Length; i++)
            {
                vectorres[i] =  v2[i];
            }
            mostrarres();
        }
    }
}
