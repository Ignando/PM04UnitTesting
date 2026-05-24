namespace PayrollApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        mainLayoutPanel = new TableLayoutPanel();
        titleLabel = new Label();
        inputGroupBox = new GroupBox();
        inputLayoutPanel = new TableLayoutPanel();
        contractorNameLabel = new Label();
        contractorNameTextBox = new TextBox();
        hoursWorkedLabel = new Label();
        hoursWorkedTextBox = new TextBox();
        dependentsLabel = new Label();
        dependentsTextBox = new TextBox();
        buttonPanel = new FlowLayoutPanel();
        calculateButton = new Button();
        clearButton = new Button();
        resultsGroupBox = new GroupBox();
        resultsLayoutPanel = new TableLayoutPanel();
        grossPayLabel = new Label();
        grossPayValueLabel = new Label();
        uifLabel = new Label();
        uifValueLabel = new Label();
        payeLabel = new Label();
        payeValueLabel = new Label();
        membershipLabel = new Label();
        membershipValueLabel = new Label();
        totalDeductionsLabel = new Label();
        totalDeductionsValueLabel = new Label();
        netPayLabel = new Label();
        netPayValueLabel = new Label();
        statusLabel = new Label();
        mainLayoutPanel.SuspendLayout();
        inputGroupBox.SuspendLayout();
        inputLayoutPanel.SuspendLayout();
        buttonPanel.SuspendLayout();
        resultsGroupBox.SuspendLayout();
        resultsLayoutPanel.SuspendLayout();
        SuspendLayout();
        // 
        // mainLayoutPanel
        // 
        mainLayoutPanel.ColumnCount = 1;
        mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        mainLayoutPanel.Controls.Add(titleLabel, 0, 0);
        mainLayoutPanel.Controls.Add(inputGroupBox, 0, 1);
        mainLayoutPanel.Controls.Add(resultsGroupBox, 0, 2);
        mainLayoutPanel.Controls.Add(statusLabel, 0, 3);
        mainLayoutPanel.Dock = DockStyle.Fill;
        mainLayoutPanel.Location = new Point(0, 0);
        mainLayoutPanel.Name = "mainLayoutPanel";
        mainLayoutPanel.Padding = new Padding(18);
        mainLayoutPanel.RowCount = 4;
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 190F));
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        mainLayoutPanel.Size = new Size(760, 560);
        mainLayoutPanel.TabIndex = 0;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Dock = DockStyle.Fill;
        titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        titleLabel.Location = new Point(21, 18);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(718, 48);
        titleLabel.TabIndex = 0;
        titleLabel.Text = "Mzansi Tech Contractors Payroll";
        titleLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // inputGroupBox
        // 
        inputGroupBox.Controls.Add(inputLayoutPanel);
        inputGroupBox.Dock = DockStyle.Fill;
        inputGroupBox.Location = new Point(21, 69);
        inputGroupBox.Name = "inputGroupBox";
        inputGroupBox.Padding = new Padding(14);
        inputGroupBox.Size = new Size(718, 184);
        inputGroupBox.TabIndex = 1;
        inputGroupBox.TabStop = false;
        inputGroupBox.Text = "Contractor Details";
        // 
        // inputLayoutPanel
        // 
        inputLayoutPanel.ColumnCount = 2;
        inputLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 170F));
        inputLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        inputLayoutPanel.Controls.Add(contractorNameLabel, 0, 0);
        inputLayoutPanel.Controls.Add(contractorNameTextBox, 1, 0);
        inputLayoutPanel.Controls.Add(hoursWorkedLabel, 0, 1);
        inputLayoutPanel.Controls.Add(hoursWorkedTextBox, 1, 1);
        inputLayoutPanel.Controls.Add(dependentsLabel, 0, 2);
        inputLayoutPanel.Controls.Add(dependentsTextBox, 1, 2);
        inputLayoutPanel.Controls.Add(buttonPanel, 1, 3);
        inputLayoutPanel.Dock = DockStyle.Fill;
        inputLayoutPanel.Location = new Point(14, 30);
        inputLayoutPanel.Name = "inputLayoutPanel";
        inputLayoutPanel.RowCount = 4;
        inputLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        inputLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        inputLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
        inputLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        inputLayoutPanel.Size = new Size(690, 140);
        inputLayoutPanel.TabIndex = 0;
        // 
        // contractorNameLabel
        // 
        contractorNameLabel.AutoSize = true;
        contractorNameLabel.Dock = DockStyle.Fill;
        contractorNameLabel.Location = new Point(3, 0);
        contractorNameLabel.Name = "contractorNameLabel";
        contractorNameLabel.Size = new Size(164, 34);
        contractorNameLabel.TabIndex = 0;
        contractorNameLabel.Text = "Contractor name";
        contractorNameLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // contractorNameTextBox
        // 
        contractorNameTextBox.Dock = DockStyle.Fill;
        contractorNameTextBox.Location = new Point(173, 3);
        contractorNameTextBox.Name = "contractorNameTextBox";
        contractorNameTextBox.Size = new Size(514, 23);
        contractorNameTextBox.TabIndex = 1;
        // 
        // hoursWorkedLabel
        // 
        hoursWorkedLabel.AutoSize = true;
        hoursWorkedLabel.Dock = DockStyle.Fill;
        hoursWorkedLabel.Location = new Point(3, 34);
        hoursWorkedLabel.Name = "hoursWorkedLabel";
        hoursWorkedLabel.Size = new Size(164, 34);
        hoursWorkedLabel.TabIndex = 2;
        hoursWorkedLabel.Text = "Hours worked";
        hoursWorkedLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // hoursWorkedTextBox
        // 
        hoursWorkedTextBox.Dock = DockStyle.Fill;
        hoursWorkedTextBox.Location = new Point(173, 37);
        hoursWorkedTextBox.Name = "hoursWorkedTextBox";
        hoursWorkedTextBox.Size = new Size(514, 23);
        hoursWorkedTextBox.TabIndex = 3;
        // 
        // dependentsLabel
        // 
        dependentsLabel.AutoSize = true;
        dependentsLabel.Dock = DockStyle.Fill;
        dependentsLabel.Location = new Point(3, 68);
        dependentsLabel.Name = "dependentsLabel";
        dependentsLabel.Size = new Size(164, 34);
        dependentsLabel.TabIndex = 4;
        dependentsLabel.Text = "Dependents";
        dependentsLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dependentsTextBox
        // 
        dependentsTextBox.Dock = DockStyle.Fill;
        dependentsTextBox.Location = new Point(173, 71);
        dependentsTextBox.Name = "dependentsTextBox";
        dependentsTextBox.Size = new Size(514, 23);
        dependentsTextBox.TabIndex = 5;
        // 
        // buttonPanel
        // 
        buttonPanel.Controls.Add(calculateButton);
        buttonPanel.Controls.Add(clearButton);
        buttonPanel.Dock = DockStyle.Fill;
        buttonPanel.Location = new Point(170, 102);
        buttonPanel.Margin = new Padding(0);
        buttonPanel.Name = "buttonPanel";
        buttonPanel.Padding = new Padding(0, 8, 0, 0);
        buttonPanel.Size = new Size(520, 38);
        buttonPanel.TabIndex = 6;
        // 
        // calculateButton
        // 
        calculateButton.Location = new Point(3, 11);
        calculateButton.Name = "calculateButton";
        calculateButton.Size = new Size(120, 27);
        calculateButton.TabIndex = 0;
        calculateButton.Text = "Calculate";
        calculateButton.UseVisualStyleBackColor = true;
        calculateButton.Click += CalculateButton_Click;
        // 
        // clearButton
        // 
        clearButton.Location = new Point(129, 11);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(90, 27);
        clearButton.TabIndex = 1;
        clearButton.Text = "Clear";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += ClearButton_Click;
        // 
        // resultsGroupBox
        // 
        resultsGroupBox.Controls.Add(resultsLayoutPanel);
        resultsGroupBox.Dock = DockStyle.Fill;
        resultsGroupBox.Location = new Point(21, 259);
        resultsGroupBox.Name = "resultsGroupBox";
        resultsGroupBox.Padding = new Padding(14);
        resultsGroupBox.Size = new Size(718, 246);
        resultsGroupBox.TabIndex = 2;
        resultsGroupBox.TabStop = false;
        resultsGroupBox.Text = "Payroll Results";
        // 
        // resultsLayoutPanel
        // 
        resultsLayoutPanel.ColumnCount = 2;
        resultsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        resultsLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        resultsLayoutPanel.Controls.Add(grossPayLabel, 0, 0);
        resultsLayoutPanel.Controls.Add(grossPayValueLabel, 1, 0);
        resultsLayoutPanel.Controls.Add(uifLabel, 0, 1);
        resultsLayoutPanel.Controls.Add(uifValueLabel, 1, 1);
        resultsLayoutPanel.Controls.Add(payeLabel, 0, 2);
        resultsLayoutPanel.Controls.Add(payeValueLabel, 1, 2);
        resultsLayoutPanel.Controls.Add(membershipLabel, 0, 3);
        resultsLayoutPanel.Controls.Add(membershipValueLabel, 1, 3);
        resultsLayoutPanel.Controls.Add(totalDeductionsLabel, 0, 4);
        resultsLayoutPanel.Controls.Add(totalDeductionsValueLabel, 1, 4);
        resultsLayoutPanel.Controls.Add(netPayLabel, 0, 5);
        resultsLayoutPanel.Controls.Add(netPayValueLabel, 1, 5);
        resultsLayoutPanel.Dock = DockStyle.Fill;
        resultsLayoutPanel.Location = new Point(14, 30);
        resultsLayoutPanel.Name = "resultsLayoutPanel";
        resultsLayoutPanel.RowCount = 6;
        resultsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        resultsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        resultsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        resultsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        resultsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        resultsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        resultsLayoutPanel.Size = new Size(690, 202);
        resultsLayoutPanel.TabIndex = 0;
        // 
        // grossPayLabel
        // 
        grossPayLabel.AutoSize = true;
        grossPayLabel.Dock = DockStyle.Fill;
        grossPayLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        grossPayLabel.Location = new Point(3, 0);
        grossPayLabel.Name = "grossPayLabel";
        grossPayLabel.Size = new Size(339, 33);
        grossPayLabel.TabIndex = 0;
        grossPayLabel.Text = "Gross pay";
        grossPayLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // grossPayValueLabel
        // 
        grossPayValueLabel.AutoSize = true;
        grossPayValueLabel.Dock = DockStyle.Fill;
        grossPayValueLabel.Location = new Point(348, 0);
        grossPayValueLabel.Name = "grossPayValueLabel";
        grossPayValueLabel.Size = new Size(339, 33);
        grossPayValueLabel.TabIndex = 1;
        grossPayValueLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // uifLabel
        // 
        uifLabel.AutoSize = true;
        uifLabel.Dock = DockStyle.Fill;
        uifLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        uifLabel.Location = new Point(3, 33);
        uifLabel.Name = "uifLabel";
        uifLabel.Size = new Size(339, 33);
        uifLabel.TabIndex = 2;
        uifLabel.Text = "UIF deduction";
        uifLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // uifValueLabel
        // 
        uifValueLabel.AutoSize = true;
        uifValueLabel.Dock = DockStyle.Fill;
        uifValueLabel.Location = new Point(348, 33);
        uifValueLabel.Name = "uifValueLabel";
        uifValueLabel.Size = new Size(339, 33);
        uifValueLabel.TabIndex = 3;
        uifValueLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // payeLabel
        // 
        payeLabel.AutoSize = true;
        payeLabel.Dock = DockStyle.Fill;
        payeLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        payeLabel.Location = new Point(3, 66);
        payeLabel.Name = "payeLabel";
        payeLabel.Size = new Size(339, 33);
        payeLabel.TabIndex = 4;
        payeLabel.Text = "PAYE deduction";
        payeLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // payeValueLabel
        // 
        payeValueLabel.AutoSize = true;
        payeValueLabel.Dock = DockStyle.Fill;
        payeValueLabel.Location = new Point(348, 66);
        payeValueLabel.Name = "payeValueLabel";
        payeValueLabel.Size = new Size(339, 33);
        payeValueLabel.TabIndex = 5;
        payeValueLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // membershipLabel
        // 
        membershipLabel.AutoSize = true;
        membershipLabel.Dock = DockStyle.Fill;
        membershipLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        membershipLabel.Location = new Point(3, 99);
        membershipLabel.Name = "membershipLabel";
        membershipLabel.Size = new Size(339, 33);
        membershipLabel.TabIndex = 6;
        membershipLabel.Text = "Membership fee";
        membershipLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // membershipValueLabel
        // 
        membershipValueLabel.AutoSize = true;
        membershipValueLabel.Dock = DockStyle.Fill;
        membershipValueLabel.Location = new Point(348, 99);
        membershipValueLabel.Name = "membershipValueLabel";
        membershipValueLabel.Size = new Size(339, 33);
        membershipValueLabel.TabIndex = 7;
        membershipValueLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // totalDeductionsLabel
        // 
        totalDeductionsLabel.AutoSize = true;
        totalDeductionsLabel.Dock = DockStyle.Fill;
        totalDeductionsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        totalDeductionsLabel.Location = new Point(3, 132);
        totalDeductionsLabel.Name = "totalDeductionsLabel";
        totalDeductionsLabel.Size = new Size(339, 33);
        totalDeductionsLabel.TabIndex = 8;
        totalDeductionsLabel.Text = "Total deductions";
        totalDeductionsLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // totalDeductionsValueLabel
        // 
        totalDeductionsValueLabel.AutoSize = true;
        totalDeductionsValueLabel.Dock = DockStyle.Fill;
        totalDeductionsValueLabel.Location = new Point(348, 132);
        totalDeductionsValueLabel.Name = "totalDeductionsValueLabel";
        totalDeductionsValueLabel.Size = new Size(339, 33);
        totalDeductionsValueLabel.TabIndex = 9;
        totalDeductionsValueLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // netPayLabel
        // 
        netPayLabel.AutoSize = true;
        netPayLabel.Dock = DockStyle.Fill;
        netPayLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        netPayLabel.Location = new Point(3, 165);
        netPayLabel.Name = "netPayLabel";
        netPayLabel.Size = new Size(339, 37);
        netPayLabel.TabIndex = 10;
        netPayLabel.Text = "Net pay";
        netPayLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // netPayValueLabel
        // 
        netPayValueLabel.AutoSize = true;
        netPayValueLabel.Dock = DockStyle.Fill;
        netPayValueLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        netPayValueLabel.Location = new Point(348, 165);
        netPayValueLabel.Name = "netPayValueLabel";
        netPayValueLabel.Size = new Size(339, 37);
        netPayValueLabel.TabIndex = 11;
        netPayValueLabel.TextAlign = ContentAlignment.MiddleRight;
        // 
        // statusLabel
        // 
        statusLabel.AutoSize = true;
        statusLabel.Dock = DockStyle.Fill;
        statusLabel.ForeColor = Color.DimGray;
        statusLabel.Location = new Point(21, 508);
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(718, 34);
        statusLabel.TabIndex = 3;
        statusLabel.Text = "Ready.";
        statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(760, 560);
        Controls.Add(mainLayoutPanel);
        MinimumSize = new Size(640, 520);
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Mzansi Tech Contractors Payroll";
        mainLayoutPanel.ResumeLayout(false);
        mainLayoutPanel.PerformLayout();
        inputGroupBox.ResumeLayout(false);
        inputLayoutPanel.ResumeLayout(false);
        inputLayoutPanel.PerformLayout();
        buttonPanel.ResumeLayout(false);
        resultsGroupBox.ResumeLayout(false);
        resultsLayoutPanel.ResumeLayout(false);
        resultsLayoutPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel mainLayoutPanel;
    private Label titleLabel;
    private GroupBox inputGroupBox;
    private TableLayoutPanel inputLayoutPanel;
    private Label contractorNameLabel;
    private TextBox contractorNameTextBox;
    private Label hoursWorkedLabel;
    private TextBox hoursWorkedTextBox;
    private Label dependentsLabel;
    private TextBox dependentsTextBox;
    private FlowLayoutPanel buttonPanel;
    private Button calculateButton;
    private Button clearButton;
    private GroupBox resultsGroupBox;
    private TableLayoutPanel resultsLayoutPanel;
    private Label grossPayLabel;
    private Label grossPayValueLabel;
    private Label uifLabel;
    private Label uifValueLabel;
    private Label payeLabel;
    private Label payeValueLabel;
    private Label membershipLabel;
    private Label membershipValueLabel;
    private Label totalDeductionsLabel;
    private Label totalDeductionsValueLabel;
    private Label netPayLabel;
    private Label netPayValueLabel;
    private Label statusLabel;
}
