namespace Delegates
{
    public partial class Form1 : Form
    {
        private int YPos = 44;
        private int Nr = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Button neuerButton = new Button()
            {
                Location = new Point(12, YPos),
                Size = new Size(75, 26),
                Text = Nr + ""
            };
            neuerButton.Click += new EventHandler(NeuerButton_Click);
            Controls.Add(neuerButton);
            YPos = YPos + 32;
            Nr = Nr + 1;
        }

        private void NeuerButton_Click(object sender, EventArgs e)
        {
            Button cmd = sender as Button;
            Controls.Remove(cmd);
            MessageBox.Show("Button " + cmd.Text + " wurde gelöscht");
        }
    }
}