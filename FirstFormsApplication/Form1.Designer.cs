
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
            // 
            // firstNumberPrompt
            // 
            this.firstNumberPrompt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNumberPrompt.Location = new System.Drawing.Point(369, 106);
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
            // 
            // secondNumberPrompt
            // 
            this.secondNumberPrompt.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNumberPrompt.Location = new System.Drawing.Point(369, 205);
            this.secondNumberPrompt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.secondNumberPrompt.Name = "secondNumberPrompt";
            this.secondNumberPrompt.Size = new System.Drawing.Size(209, 30);
            this.secondNumberPrompt.TabIndex = 3;
            // 
            // selectOperation
            // 
            this.selectOperation.AutoSize = true;
            this.selectOperation.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectOperation.Location = new System.Drawing.Point(87, 300);
            this.selectOperation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectOperation.Name = "selectOperation";
            this.selectOperation.Size = new System.Drawing.Size(170, 23);
            this.selectOperation.TabIndex = 4;
            this.selectOperation.Text = "Select Operation : ";
            // 
            // operationDropDown
            // 
            this.operationDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationDropDown.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operationDropDown.FormattingEnabled = true;
            this.operationDropDown.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication"});
            this.operationDropDown.Location = new System.Drawing.Point(369, 291);
            this.operationDropDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.operationDropDown.Name = "operationDropDown";
            this.operationDropDown.Size = new System.Drawing.Size(209, 31);
            this.operationDropDown.TabIndex = 5;
            // 
            // calculationButton
            // 
            this.calculationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculationButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculationButton.Location = new System.Drawing.Point(369, 379);
            this.calculationButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(211, 52);
            this.calculationButton.TabIndex = 6;
            this.calculationButton.Text = "Calculate:";
            this.calculationButton.UseVisualStyleBackColor = true;
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
            this.ResultLabel.Location = new System.Drawing.Point(87, 456);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(71, 23);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.Text = "Result:";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(176, 458);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(0, 23);
            this.AnswerLabel.TabIndex = 8;
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 560);
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
    }
}

