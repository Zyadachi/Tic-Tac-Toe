﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool gracz1 = true;
        int ruch = 0;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestartuj_Click(object sender, EventArgs e)
        {
            Restartuj();
            WynikGraczO.Text = "0";
            WynikGraczX.Text = "0";
            lblKto.Text = "O";
            gracz1 = true;
        }

        private void Restartuj()
        {
            ruch = 0;
            Button[] all = new Button[9];
            all[0] = btn1;
            all[1] = btn2;
            all[2] = btn3;
            all[3] = btn4;
            all[4] = btn5;
            all[5] = btn6;
            all[6] = btn7;
            all[7] = btn8;
            all[8] = btn9;
            foreach(Button b in all)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }
        private void Sprawdz()
        {
            if(btn1.Text != "" && btn1.Text == btn2.Text && btn1.Text == btn3.Text)
            {
                Wygrana();
            } 
            else if(btn4.Text != "" && btn4.Text == btn5.Text && btn4.Text == btn6.Text)
            {
                Wygrana();
            }
            else if(btn7.Text != "" && btn7.Text == btn8.Text && btn7.Text == btn9.Text)
            {
                Wygrana();
            }
            else if(btn1.Text != "" && btn1.Text == btn4.Text && btn1.Text == btn7.Text)
            {
                Wygrana();
            }
            else if(btn2.Text != "" && btn2.Text == btn5.Text && btn2.Text == btn8.Text)
            {
                Wygrana();
            }
            else if(btn3.Text != "" && btn3.Text == btn6.Text && btn3.Text == btn9.Text)
            {
                Wygrana();
            }
            else if(btn1.Text != "" && btn1.Text == btn5.Text && btn1.Text == btn9.Text)
            {
                Wygrana();
            }
            else if(btn3.Text != "" && btn3.Text == btn5.Text && btn3.Text == btn7.Text)
            {
                Wygrana();
            }
            else if(ruch == 9)
            {
                MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Restartuj();
            }
        }

        private void Wygrana()
        {
            MessageBox.Show("Wygrywa gracz: " + (gracz1 ? "O" : "X"), "Wygrana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (gracz1)
                WynikGraczO.Text = ((int.Parse(WynikGraczO.Text)) + 1).ToString();
            else
                WynikGraczX.Text = ((int.Parse(WynikGraczX.Text)) + 1).ToString();
            Restartuj();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if(ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ruch++;
            ((Button)sender).Text = gracz1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (ruch >= 5)
            {
                Sprawdz();
            }
            gracz1 = !gracz1;
            lblKto.Text = gracz1 ? "O" : "X";
        }
    }
}
