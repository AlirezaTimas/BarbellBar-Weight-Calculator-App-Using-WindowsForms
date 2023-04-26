namespace BarbellBar_weight_calculator_app_using_WindowsForms
{
    public partial class Form1 : Form

    {

        int var20kgweight = 0;
        int var10kgweight = 0;
        int var5kgweight = 0;
        int var2kgweight = 0;
        int var1kgweight = 0;
        int userWeight;
        public Form1()
        {
            InitializeComponent();
            InfoLabel.Text = "Enter the amount of weight: ";
            CalculateButton.Enabled = false;
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                userWeight = int.Parse(TextBox.Text);

                if (userWeight <= 1)
                {
                    MessageBox.Show("Weight amount has to be more than 1kg ");
                }
                else
                {
                    userWeight /= 2; //Have to use half the weight , because this app is calculating required weight at "Each end of barbell bar"

                    var20kgweight = userWeight / 20;
                    userWeight %= 20;
                    var10kgweight = userWeight / 10;
                    userWeight %= 10;
                    var5kgweight = userWeight / 5;
                    userWeight %= 5;
                    var2kgweight = userWeight / 2;
                    userWeight %= 2;
                    var1kgweight = userWeight / 1;
                    userWeight %= 1;
                    MessageBox.Show("You have to place weights according to amount given below at each end of barbell bar \n20 kg weight: " + var20kgweight + " \n10 kg weight: " + var10kgweight + " \n5 kg weight: " + var5kgweight + " \n2 kg weight: " + var2kgweight + " \n1 kg weight: " + var1kgweight, "Result!");
                    TextBox.Clear();
                    TextBox.Focus();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nOnly integers are allowed (Characters/symbols are not allowed)", "Error");
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (TextBox.Text.Length <= 0) { CalculateButton.Enabled = false; }
            else { CalculateButton.Enabled = true; }
        }
    }
}

