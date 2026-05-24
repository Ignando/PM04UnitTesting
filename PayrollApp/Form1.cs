namespace PayrollApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        ClearResults();
    }

    private void CalculateButton_Click(object? sender, EventArgs e)
    {
        if (!PayrollInputValidator.TryValidate(
                contractorNameTextBox.Text,
                hoursWorkedTextBox.Text,
                dependentsTextBox.Text,
                out var hoursWorked,
                out var dependents,
                out var errorMessage))
        {
            statusLabel.Text = errorMessage;
            statusLabel.ForeColor = Color.Firebrick;
            ClearResults();
            return;
        }

        var result = PayrollCalculator.Calculate(contractorNameTextBox.Text, hoursWorked, dependents);
        DisplayResult(result);
        statusLabel.Text = "Payroll calculated successfully.";
        statusLabel.ForeColor = Color.DarkGreen;
    }

    private void ClearButton_Click(object? sender, EventArgs e)
    {
        contractorNameTextBox.Clear();
        hoursWorkedTextBox.Clear();
        dependentsTextBox.Clear();
        ClearResults();
        statusLabel.Text = "Ready.";
        statusLabel.ForeColor = Color.DimGray;
        contractorNameTextBox.Focus();
    }

    private void DisplayResult(PayrollResult result)
    {
        grossPayValueLabel.Text = FormatCurrency(result.GrossPay);
        uifValueLabel.Text = FormatCurrency(result.UifDeduction);
        payeValueLabel.Text = FormatCurrency(result.PayeDeduction);
        membershipValueLabel.Text = FormatCurrency(result.MembershipFee);
        totalDeductionsValueLabel.Text = FormatCurrency(result.TotalDeductions);
        netPayValueLabel.Text = FormatCurrency(result.NetPay);
    }

    private void ClearResults()
    {
        grossPayValueLabel.Text = FormatCurrency(0m);
        uifValueLabel.Text = FormatCurrency(0m);
        payeValueLabel.Text = FormatCurrency(0m);
        membershipValueLabel.Text = FormatCurrency(0m);
        totalDeductionsValueLabel.Text = FormatCurrency(0m);
        netPayValueLabel.Text = FormatCurrency(0m);
    }

    private static string FormatCurrency(decimal value)
    {
        return $"R {value:N2}";
    }
}
