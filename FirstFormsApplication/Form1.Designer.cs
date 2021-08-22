
namespace FirstFormsApplication
{
    partial class Calculate
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
            this.components = new System.ComponentModel.Container();
            this.FirstNumber = new System.Windows.Forms.Label();
            this.firstNumberPrompt = new System.Windows.Forms.TextBox();
            this.secondNumber = new System.Windows.Forms.Label();
            this.secondNumberPrompt = new System.Windows.Forms.TextBox();
            this.selectOperation = new System.Windows.Forms.Label();
            this.operationDropDown = new System.Windows.Forms.ComboBox();
            this.calculationButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ResultLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.OperationTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // FirstNumber
            // 
            this.FirstNumber.AutoSize = true;
            this.FirstNumber.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNumber.Location = new System.Drawing.Point(87, 107);
            this.FirstNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(133, 23);
            this.FirstNumber.TabIndex = 0;
            this.FirstNumber.Text = "First Number: ";
            this.FirstNumber.Click += new System.EventHandler(this.FirstNumber_Click);
            // 
            // firstNumberPrompt
            // 
            this.firstNumberPrompt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberPrompt.Location = new System.Drawing.Point(369, 105);
            this.firstNumberPrompt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.firstNumberPrompt.Name = "firstNumberPrompt";
            this.firstNumberPrompt.Size = new System.Drawing.Size(209, 30);
            this.firstNumberPrompt.TabIndex = 1;
            this.firstNumberPrompt.TextChanged += new System.EventHandler(this.firstNumberPrompt_TextChanged);
            // 
            // secondNumber
            // 
            this.secondNumber.AutoSize = true;
            this.secondNumber.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumber.Location = new System.Drawing.Point(87, 205);
            this.secondNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.secondNumber.Name = "secondNumber";
            this.secondNumber.Size = new System.Drawing.Size(154, 23);
            this.secondNumber.TabIndex = 2;
            this.secondNumber.Text = "Second Number: ";
            this.secondNumber.Click += new System.EventHandler(this.secondNumber_Click);
            // 
            // secondNumberPrompt
            // 
            this.secondNumberPrompt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberPrompt.Location = new System.Drawing.Point(369, 198);
            this.secondNumberPrompt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secondNumberPrompt.Name = "secondNumberPrompt";
            this.secondNumberPrompt.Size = new System.Drawing.Size(209, 30);
            this.secondNumberPrompt.TabIndex = 3;
            this.secondNumberPrompt.TextChanged += new System.EventHandler(this.secondNumberPrompt_TextChanged);
            // 
            // selectOperation
            // 
            this.selectOperation.AutoSize = true;
            this.selectOperation.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOperation.Location = new System.Drawing.Point(87, 268);
            this.selectOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectOperation.Name = "selectOperation";
            this.selectOperation.Size = new System.Drawing.Size(171, 92);
            this.selectOperation.TabIndex = 4;
            this.selectOperation.Text = "Select Operation:\r\n+ for Addition\r\n- for Subtraction\r\n* for Multiplication\r\n";
            this.selectOperation.Click += new System.EventHandler(this.selectOperation_Click);
            // 
            // operationDropDown
            // 
            this.operationDropDown.BackColor = System.Drawing.SystemColors.ControlLight;
            this.operationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.operationDropDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationDropDown.FormattingEnabled = true;
            this.operationDropDown.Location = new System.Drawing.Point(-6, 544);
            this.operationDropDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.operationDropDown.Name = "operationDropDown";
            this.operationDropDown.Size = new System.Drawing.Size(10, 10);
            this.operationDropDown.TabIndex = 5;
            // 
            // calculationButton
            // 
            this.calculationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculationButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationButton.Location = new System.Drawing.Point(371, 368);
            this.calculationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(211, 52);
            this.calculationButton.TabIndex = 6;
            this.calculationButton.Text = "Calculate:";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(51, 469);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(71, 23);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result:";
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(176, 458);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 23);
            this.AnswerLabel.TabIndex = 8;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.SystemColors.Window;
            this.outputLabel.Location = new System.Drawing.Point(128, 458);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(311, 34);
            this.outputLabel.TabIndex = 9;
            this.outputLabel.Click += new System.EventHandler(this.outputLabel_Click);
            // 
            // OperationTextBox
            // 
            this.OperationTextBox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationTextBox.Location = new System.Drawing.Point(371, 284);
            this.OperationTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OperationTextBox.Name = "OperationTextBox";
            this.OperationTextBox.Size = new System.Drawing.Size(209, 30);
            this.OperationTextBox.TabIndex = 10;
            this.OperationTextBox.TextChanged += new System.EventHandler(this.OperationTextBox_TextChanged);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 566);
            this.Controls.Add(this.OperationTextBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.operationDropDown);
            this.Controls.Add(this.selectOperation);
            this.Controls.Add(this.secondNumberPrompt);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.firstNumberPrompt);
            this.Controls.Add(this.FirstNumber);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Calculate";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstNumber;
        private System.Windows.Forms.TextBox firstNumberPrompt;
        private System.Windows.Forms.Label secondNumber;
        private System.Windows.Forms.TextBox secondNumberPrompt;
        private System.Windows.Forms.Label selectOperation;
        private System.Windows.Forms.ComboBox operationDropDown;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox OperationTextBox;
    }
}

