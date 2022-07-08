namespace Forms1
{
    public partial class Apka : Form
    {
        public Apka()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                if (textBox2.Text.Length > 0)
                {
                    if(!listBox1.Items.Contains(textBox2.Text))
                    {
                        listBox1.Items.Add(textBox2.Text);
                        AktualizujProgres();
                        textBox2.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("Przedmiot znajduje sie juz na liscie", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    MessageBox.Show("Wartoœæ jest pusta", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
             
            }
            else
            {
                
                MessageBox.Show("Lista zakupów pe³na", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
        private void AktualizujProgres()
        {
            var elementsOnList = listBox1.Items.Count;
            progressBar1.Value = elementsOnList * 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if(i != -1)
            {
                listBox1.Items.RemoveAt(i);
                AktualizujProgres();
            }
            else
            {
                MessageBox.Show("¯aden alement nie zosta³ zaznaczony", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}