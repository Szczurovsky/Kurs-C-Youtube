namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool player1 = true;
        int move = 0;
        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnNewGame();
            scoreO.Text = "0";
            scoreX.Text = "0";
            lblWho.Text = "O";
            player1 = true;
        }

        private void btnNewGame()
        {
            move = 0;
            Button[] allButtons = new Button[9];
            allButtons[0] = btn1;
            allButtons[1] = btn2;
            allButtons[2] = btn3;
            allButtons[3] = btn4;
            allButtons[4] = btn5;
            allButtons[5] = btn6;
            allButtons[6] = btn7;
            allButtons[7] = btn8;
            allButtons[8] = btn9;
            foreach(Button b in allButtons)
            {
                b.Enabled = true;
                b.Text = "";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }
       
        

        private void btn2_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            move++;
            ((Button)sender).Text = player1 ? "O" : "X";
            ((Button)sender).Enabled = false;
            if (move >= 5)
            {
                CheckWin();

            }
            player1 = !player1;
            lblWho.Text = player1 ? "O" : "X";
        }
        private void CheckWin()
        {
            if (btn1.Text != "" && btn1.Text == btn2.Text && btn2.Text == btn3.Text)
            {
                Win();
            }
            else if (btn4.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text) { Win(); }
            else if (btn7.Text != "" && btn7.Text == btn8.Text && btn8.Text == btn9.Text) { Win(); }
            else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text) { Win(); }
            else if (btn2.Text != "" && btn2.Text == btn5.Text && btn5.Text == btn8.Text) { Win(); }
            else if (btn3.Text != "" && btn3.Text == btn6.Text && btn6.Text == btn9.Text) { Win(); }
            else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text) { Win(); }
            else if (btn3.Text != "" && btn3.Text == btn5.Text && btn5.Text == btn7.Text) { Win(); }
            else if (move == 9) { MessageBox.Show("Remis", "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Warning);btnNewGame(); }
            //else if (btn1.Text != "" && btn1.Text == btn4.Text && btn4.Text == btn7.Text)
            //{
            //    Wygrana();
            //}
            //else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text) { }
            //else if (btn1.Text != "" && btn4.Text == btn5.Text && btn5.Text == btn6.Text) { }
            //else if (btn1.Text != "" && btn1.Text == btn5.Text && btn5.Text == btn9.Text) { }

        }

        private void Win()
        {
            MessageBox.Show("Wygrywa gracz: " + (player1 ? "O" : "X"), "Wygrana!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (player1)
                scoreO.Text = ((int.Parse(scoreO.Text)) + 1.ToString());
            else
                scoreX.Text = ((int.Parse(scoreX.Text)) + 1.ToString());
            btnNewGame();

        }
    }
}