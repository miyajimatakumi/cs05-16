namespace cs05_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("‚±‚ñ‚É‚¿‚í");
            MessageBox.Show(100.ToString());
            MessageBox.Show($"{100}");
            MessageBox.Show($"label1.Top={label1.Top}");
            MessageBox.Show(3.14f.ToString());
            MessageBox.Show($"{3.14f}");

            MessageBox.Show(1+1.ToString());//11
            MessageBox.Show((1+1).ToString());//2
            MessageBox.Show($"{1 + 1}");
        }
    }
}
