namespace coursework_1551
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text.ToUpper();
                int shift = int.Parse(txtShift.Text);

                StringProcessing sp = new StringProcessing(input, shift);
                sp.Encode();

                txtResult.Text = "Encoded: " + sp.Print();

                lstCodes.Items.Clear();
                lstCodes.Items.Add("Input ASCII: " + string.Join(", ", sp.InputCode()));
                lstCodes.Items.Add("Output ASCII: " + string.Join(", ", sp.OutputCode()));
                lstCodes.Items.Add("Sorted Input: " + sp.Sort());

                // Reverse encoding test (optional)
                StringProcessing reverse = new StringProcessing(sp.Print(), -shift);
                reverse.Encode();
                lstCodes.Items.Add("Reverse Encoded: " + reverse.Print());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
