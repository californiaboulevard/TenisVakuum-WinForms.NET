using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Drawing.Text;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace TenisVakuum
{
    public partial class Form1 : Form
    {
        public PlotView Graf;

        public Form1()
        {
            InitializeComponent();
            Graf = new PlotView
            {
                Location = new System.Drawing.Point(100, 270),
                Size = new System.Drawing.Size(1750, 700)
            };
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            double g;
            if (textBox8.Text == "")
            {
                g = -9.81;
            }
            else
            {
                g = Convert.ToDouble(textBox8.Text);
            }

            int N;
            if (textBox2.Text == "")
            {
                N = 500;
            }
            else
            {
                N = Convert.ToInt32(textBox2.Text);
            }

            double dt;
            if (textBox1.Text == "")
            {
                dt = 0.001;
            }
            else
            {
                dt = Convert.ToDouble(textBox1.Text);
            }

            double m;
            if (textBox3.Text == "")
            {
                m = 1.0;
            }
            else
            {
                m = Convert.ToDouble(textBox3.Text);
            }

            double x;
            if (textBox4.Text == "")
            {
                x = 0.0;
            }
            else
            {
                x = Convert.ToDouble(textBox4.Text);
            }

            double z;
            if (textBox5.Text == "")
            {
                z = 1.5;
            }
            else
            {
                z = Convert.ToDouble(textBox5.Text);
            }

            double vx;
            if (textBox6.Text == "")
            {
                vx = 35.0;
            }
            else
            {
                vx = Convert.ToDouble(textBox6.Text);
            }

            double vz;
            if (textBox7.Text == "")
            {
                vz = 0.0;
            }
            else
            {
                vz = Convert.ToDouble(textBox7.Text);
            }

            double[] xpole = new double[N];
            xpole[0] = x;

            double[] zpole = new double[N];
            zpole[0] = z;


            for (int i = 0; i < N; i++)
            {
                xpole[i] = x + vx * dt;
                x = x + (vx * dt);
                zpole[i] = z + vz * dt;
                z = z + (vz * dt);
                vx = vx;
                vz = vz + g * dt;
            }

            switch (z)
            {
                case 0.0:
                    label3.Text = "";
                    label3.Text = "lopticka sa dotkla zeme";

                    break;
                case < 0.0:
                    label3.Text = "";
                    label3.Text = "lopticka presla zemou!";
                    break;
                case > 0.0:
                    label3.Text = "";
                    break;
            }


            label1.Text = xpole[N - 1].ToString();
            label2.Text = zpole[N - 1].ToString();


            var graf = new PlotModel
            {
                Title = "tenis vo vakuu"
            };

            var grafciary = new LineSeries
            {
            };

            for (int i = 0; i < xpole.Length; i++)
            {
                grafciary.Points.Add(new DataPoint(xpole[i], zpole[i]));
            }

            graf.Series.Add(grafciary);
            Graf.Model = graf;
            if (!this.Controls.Contains(Graf))
            {
                this.Controls.Add(Graf);
            }

            Graf.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }
    }
}