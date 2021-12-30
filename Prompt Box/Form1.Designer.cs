
namespace Prompt_Box
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.selectAccountLabel = new System.Windows.Forms.Label();
            this.selectAccountComboBox = new System.Windows.Forms.ComboBox();
            this.tickerLabel = new System.Windows.Forms.Label();
            this.tickerNameTextBox = new System.Windows.Forms.TextBox();
            this.numShareTextBox = new System.Windows.Forms.TextBox();
            this.numSharesLabel = new System.Windows.Forms.Label();
            this.costPerShareTextBox = new System.Windows.Forms.TextBox();
            this.costPerShareLabel = new System.Windows.Forms.Label();
            this.addHoldingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Holding";
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(344, 14);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(25, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // selectAccountLabel
            // 
            this.selectAccountLabel.AutoSize = true;
            this.selectAccountLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectAccountLabel.ForeColor = System.Drawing.Color.Black;
            this.selectAccountLabel.Location = new System.Drawing.Point(13, 75);
            this.selectAccountLabel.Name = "selectAccountLabel";
            this.selectAccountLabel.Size = new System.Drawing.Size(140, 23);
            this.selectAccountLabel.TabIndex = 2;
            this.selectAccountLabel.Text = "Select Account";
            // 
            // selectAccountComboBox
            // 
            this.selectAccountComboBox.FormattingEnabled = true;
            this.selectAccountComboBox.Items.AddRange(new object[] {
            "M1 Finance",
            "Robinhood",
            "Webull",
            "Prosper",
            "Exodus",
            "Uphold",
            "Celsius",
            "Fundrise"});
            this.selectAccountComboBox.Location = new System.Drawing.Point(17, 110);
            this.selectAccountComboBox.Name = "selectAccountComboBox";
            this.selectAccountComboBox.Size = new System.Drawing.Size(348, 24);
            this.selectAccountComboBox.TabIndex = 3;
            // 
            // tickerLabel
            // 
            this.tickerLabel.AutoSize = true;
            this.tickerLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tickerLabel.ForeColor = System.Drawing.Color.Black;
            this.tickerLabel.Location = new System.Drawing.Point(13, 166);
            this.tickerLabel.Name = "tickerLabel";
            this.tickerLabel.Size = new System.Drawing.Size(63, 23);
            this.tickerLabel.TabIndex = 4;
            this.tickerLabel.Text = "Ticker";
            // 
            // tickerNameTextBox
            // 
            this.tickerNameTextBox.Location = new System.Drawing.Point(17, 197);
            this.tickerNameTextBox.Name = "tickerNameTextBox";
            this.tickerNameTextBox.Size = new System.Drawing.Size(348, 22);
            this.tickerNameTextBox.TabIndex = 5;
            // 
            // numShareTextBox
            // 
            this.numShareTextBox.Location = new System.Drawing.Point(18, 280);
            this.numShareTextBox.Name = "numShareTextBox";
            this.numShareTextBox.Size = new System.Drawing.Size(348, 22);
            this.numShareTextBox.TabIndex = 7;
            // 
            // numSharesLabel
            // 
            this.numSharesLabel.AutoSize = true;
            this.numSharesLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSharesLabel.ForeColor = System.Drawing.Color.Black;
            this.numSharesLabel.Location = new System.Drawing.Point(14, 249);
            this.numSharesLabel.Name = "numSharesLabel";
            this.numSharesLabel.Size = new System.Drawing.Size(72, 23);
            this.numSharesLabel.TabIndex = 6;
            this.numSharesLabel.Text = "Shares";
            // 
            // costPerShareTextBox
            // 
            this.costPerShareTextBox.Location = new System.Drawing.Point(18, 368);
            this.costPerShareTextBox.Name = "costPerShareTextBox";
            this.costPerShareTextBox.Size = new System.Drawing.Size(348, 22);
            this.costPerShareTextBox.TabIndex = 9;
            // 
            // costPerShareLabel
            // 
            this.costPerShareLabel.AutoSize = true;
            this.costPerShareLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerShareLabel.ForeColor = System.Drawing.Color.Black;
            this.costPerShareLabel.Location = new System.Drawing.Point(14, 337);
            this.costPerShareLabel.Name = "costPerShareLabel";
            this.costPerShareLabel.Size = new System.Drawing.Size(141, 23);
            this.costPerShareLabel.TabIndex = 8;
            this.costPerShareLabel.Text = "Cost per share";
            // 
            // addHoldingButton
            // 
            this.addHoldingButton.Location = new System.Drawing.Point(265, 418);
            this.addHoldingButton.Name = "addHoldingButton";
            this.addHoldingButton.Size = new System.Drawing.Size(100, 40);
            this.addHoldingButton.TabIndex = 10;
            this.addHoldingButton.Text = "Add Holding";
            this.addHoldingButton.UseVisualStyleBackColor = true;
            this.addHoldingButton.Click += new System.EventHandler(this.addHoldingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 480);
            this.Controls.Add(this.addHoldingButton);
            this.Controls.Add(this.costPerShareTextBox);
            this.Controls.Add(this.costPerShareLabel);
            this.Controls.Add(this.numShareTextBox);
            this.Controls.Add(this.numSharesLabel);
            this.Controls.Add(this.tickerNameTextBox);
            this.Controls.Add(this.tickerLabel);
            this.Controls.Add(this.selectAccountComboBox);
            this.Controls.Add(this.selectAccountLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label selectAccountLabel;
        private System.Windows.Forms.ComboBox selectAccountComboBox;
        private System.Windows.Forms.Label tickerLabel;
        private System.Windows.Forms.TextBox tickerNameTextBox;
        private System.Windows.Forms.TextBox numShareTextBox;
        private System.Windows.Forms.Label numSharesLabel;
        private System.Windows.Forms.TextBox costPerShareTextBox;
        private System.Windows.Forms.Label costPerShareLabel;
        private System.Windows.Forms.Button addHoldingButton;
    }
}

