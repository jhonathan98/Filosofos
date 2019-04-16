using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Filosofos
{
    public partial class Form1 : Form
    {
        int t1, t2, t3, t4, t5;
        int f1, f2, f3, f4, f5;
        Boolean inicia = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button2.BackColor = Color.Gray;
            button3.BackColor = Color.Gray;
            button4.BackColor = Color.Gray;
            button5.BackColor = Color.Gray;
            button6.BackColor = Color.Gray;
            button7.BackColor = Color.Gray;
            button8.BackColor = Color.Gray;
            button9.BackColor = Color.Gray;
            button10.BackColor = Color.Gray;

            t1 = 1;
            t2 = 1;
            t3 = 3;
            t4 = 3;
            t5 = 5;


        }

        private void esperar()
        {
            int cont = 0;
            while (inicia)
            {

                if (cont == 1)
                {
                    if (t2 == 1)
                    {
                        //button7.Text = "2";
                        t2 = 2;
                    }
                    else
                    {
                        //button7.Text = "1";
                        t2 = 1;
                    }
                    if (t3 == 3)
                    {
                        //button8.Text = "2";
                        t3 = 2;
                    }
                    else
                    {
                        //button8.Text = "3";
                        t3 = 3;
                    }
                    if (t4 == 3)
                    {
                        //button9.Text = "4";
                        t4 = 4;
                    }
                    else
                    {
                        //button9.Text = "3";
                        t4 = 3;
                    }
                    /*if (t5 == 4)
                    {
                        //button10.Text = "5";
                        t5 = 5;
                    }
                    else
                    {
                        //button10.Text = "4";
                        t5 = 4;
                    }*/
                    /*MessageBox.Show(t1.ToString() + "hh" + t2.ToString() +
                        t3.ToString() + "hh" + t4.ToString() + " ss " + t5.ToString());*/
                    if (t1 == 1 && t2 == 1)
                    {
                        f1++;
                        button1.BackColor = Color.Yellow;
                        button6.BackColor = Color.Yellow;
                        button7.BackColor = Color.Yellow;
                    }
                    if (t2 == 2 && t3 == 2)
                    {
                        f2++;
                        button2.BackColor = Color.Yellow;
                        button7.BackColor = Color.Yellow;
                        button8.BackColor = Color.Yellow;
                    }
                    if (t3 == 3 && t4 == 3)
                    {
                        f3++;
                        button3.BackColor = Color.Yellow;
                        button8.BackColor = Color.Yellow;
                        button9.BackColor = Color.Yellow;
                    }
                    if (t4 == 4 && t5 == 4)
                    {
                        f4++;
                        button4.BackColor = Color.Yellow;
                        button9.BackColor = Color.Yellow;
                        button10.BackColor = Color.Yellow;
                    }

                    if (t1 == 5 && t5 == 5)
                    {
                        f5++;
                        button5.BackColor = Color.Yellow;
                        button6.BackColor = Color.Yellow;
                        button10.BackColor = Color.Yellow;
                    }

                    Thread.Sleep(5000);
                    cont = 0;
                    button1.BackColor = Color.Gray;
                    button2.BackColor = Color.Gray;
                    button3.BackColor = Color.Gray;
                    button4.BackColor = Color.Gray;
                    button5.BackColor = Color.Gray;
                    button6.BackColor = Color.Gray;
                    button7.BackColor = Color.Gray;
                    button8.BackColor = Color.Gray;
                    button9.BackColor = Color.Gray;
                    button10.BackColor = Color.Gray;

                }
                else
                {

                    if (t1 == 1)
                    {
                        //button6.Text = "5";
                        t1 = 5;

                    }
                    else
                    {
                        //button6.Text = "1";
                        t1 = 1;

                    }
                    if (t2 == 1)
                    {
                        //button7.Text = "2";
                        t2 = 2;
                    }
                    else
                    {
                        //button7.Text = "1";
                        t2 = 1;
                    }
                    if (t3 == 3)
                    {
                        //button8.Text = "2";
                        t3 = 2;
                    }
                    else
                    {
                        //button8.Text = "3";
                        t3 = 3;
                    }
                    if (t4 == 3)
                    {
                        //button9.Text = "4";
                        t4 = 4;
                    }
                    else
                    {
                        //button9.Text = "3";
                        t4 = 3;
                    }
                    if (t5 == 4)
                    {
                        //button10.Text = "5";
                        t5 = 5;
                    }
                    else
                    {
                        //button10.Text = "4";
                        t5 = 4;
                    }
                    /*MessageBox.Show(t1.ToString() + "hh" + t2.ToString()+
                        t3.ToString() + "hh" + t4.ToString()+" ss "+t5.ToString());*/
                    if (t1 == 1 && t2 == 1)
                    {
                        f1++;
                        button1.BackColor = Color.Yellow;
                        button6.BackColor = Color.Yellow;
                        button7.BackColor = Color.Yellow;
                    }
                    if (t2 == 2 && t3 == 2)
                    {
                        f2++;

                        button2.BackColor = Color.Yellow;
                        button7.BackColor = Color.Yellow;
                        button8.BackColor = Color.Yellow;
                    }
                    if (t3 == 3 && t4 == 3)
                    {
                        f3++;
                        button3.BackColor = Color.Yellow;
                        button8.BackColor = Color.Yellow;
                        button9.BackColor = Color.Yellow;
                    }
                    if (t4 == 4 && t5 == 4)
                    {
                        f4++;
                        button4.BackColor = Color.Yellow;
                        button9.BackColor = Color.Yellow;
                        button10.BackColor = Color.Yellow;
                    }
                    if (t1 == 5 && t5 == 5)
                    {
                        f5++;
                        button5.BackColor = Color.Yellow;
                        button6.BackColor = Color.Yellow;
                        button10.BackColor = Color.Yellow;
                    }
                    cont++;
                    Thread.Sleep(5000);
                    button1.BackColor = Color.Gray;
                    button2.BackColor = Color.Gray;
                    button3.BackColor = Color.Gray;
                    button4.BackColor = Color.Gray;
                    button5.BackColor = Color.Gray;
                    button6.BackColor = Color.Gray;
                    button7.BackColor = Color.Gray;
                    button8.BackColor = Color.Gray;
                    button9.BackColor = Color.Gray;
                    button10.BackColor = Color.Gray;
                }


            }
        }



        private void button11_Click(object sender, EventArgs e)
        {
            Thread hilo = new Thread(esperar);
            hilo.Start();
            hilo.Join();
            MessageBox.Show("sdsddssssss");
        }


    }
}