using RomanNumerical.Functions;

namespace NumericNumber.UI;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void TxtInput_TextChanged(object sender, EventArgs e)
    {
        int input;

        string? text = TxtInput.Text;
        bool isNumber = Int32.TryParse(text, out input);
        if (isNumber && input > 0 && input < 4000)
        {
            TxtOutput.Text = RomanNumericalFunction.IntToRoman(input);
            LblError.Text = "";
        }
        else
        {
            LblError.Text = "Bitte geben Sie eine Zahl zwischen 1 und 3999 ein!";
            TxtOutput.Text = "";
        }

    }

    private void BtnExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}