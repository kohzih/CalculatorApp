namespace CalculatorApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DisplayTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new CalculatorApp.Models.DerivedButton();
            this.btnClear = new CalculatorApp.Models.DerivedButton();
            this.btnAllClear = new CalculatorApp.Models.DerivedButton();
            this.btnDivide = new CalculatorApp.Models.DerivedButton();
            this.btnMultiply = new CalculatorApp.Models.DerivedButton();
            this.btnNumber7 = new CalculatorApp.Models.DerivedButton();
            this.btnNumber8 = new CalculatorApp.Models.DerivedButton();
            this.btnNumber9 = new CalculatorApp.Models.DerivedButton();
            this.btnNumber4 = new CalculatorApp.Models.DerivedButton();
            this.btnNumber5 = new CalculatorApp.Models.DerivedButton();
            this.btnNumber6 = new CalculatorApp.Models.DerivedButton();
            this.btnSubtract = new CalculatorApp.Models.DerivedButton();
            this.btnNumber1 = new CalculatorApp.Models.DerivedButton();
            this.btnNumber2 = new CalculatorApp.Models.DerivedButton();
            this.btnNumber3 = new CalculatorApp.Models.DerivedButton();
            this.btnAdd = new CalculatorApp.Models.DerivedButton();
            this.btnNumber0 = new CalculatorApp.Models.DerivedButton();
            this.btnDot = new CalculatorApp.Models.DerivedButton();
            this.btnEquals = new CalculatorApp.Models.DerivedButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DisplayTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.DisplayTextBox, 4);
            this.DisplayTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayTextBox.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DisplayTextBox.Location = new System.Drawing.Point(3, 3);
            this.DisplayTextBox.Name = "DisplayTextBox";
            this.DisplayTextBox.Size = new System.Drawing.Size(806, 103);
            this.DisplayTextBox.TabIndex = 1;
            this.DisplayTextBox.Text = "0";
            this.DisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnDelete, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClear, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAllClear, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDivide, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnMultiply, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber8, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber9, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber6, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnSubtract, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber2, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber3, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAdd, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnNumber0, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnDot, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnEquals, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.DisplayTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 754);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayText = "←";
            this.btnDelete.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDelete.Location = new System.Drawing.Point(614, 125);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(193, 95);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "←";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.DisplayText = "CE";
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(208, 125);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(193, 95);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CE";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnAllClear
            // 
            this.btnAllClear.DisplayText = "C";
            this.btnAllClear.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAllClear.Location = new System.Drawing.Point(411, 125);
            this.btnAllClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(193, 95);
            this.btnAllClear.TabIndex = 4;
            this.btnAllClear.Text = "C";
            this.btnAllClear.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            this.btnDivide.DisplayText = "÷";
            this.btnDivide.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDivide.Location = new System.Drawing.Point(614, 230);
            this.btnDivide.Margin = new System.Windows.Forms.Padding(5);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(193, 95);
            this.btnDivide.TabIndex = 6;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            this.btnMultiply.DisplayText = "×";
            this.btnMultiply.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnMultiply.Location = new System.Drawing.Point(614, 335);
            this.btnMultiply.Margin = new System.Windows.Forms.Padding(5);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(193, 95);
            this.btnMultiply.TabIndex = 5;
            this.btnMultiply.Text = "×";
            this.btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnNumber7
            // 
            this.btnNumber7.DisplayText = null;
            this.btnNumber7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber7.Location = new System.Drawing.Point(5, 335);
            this.btnNumber7.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber7.Name = "btnNumber7";
            this.btnNumber7.Size = new System.Drawing.Size(193, 95);
            this.btnNumber7.TabIndex = 7;
            this.btnNumber7.Text = "7";
            this.btnNumber7.UseVisualStyleBackColor = true;
            // 
            // btnNumber8
            // 
            this.btnNumber8.DisplayText = "8";
            this.btnNumber8.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber8.Location = new System.Drawing.Point(208, 335);
            this.btnNumber8.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber8.Name = "btnNumber8";
            this.btnNumber8.Size = new System.Drawing.Size(193, 95);
            this.btnNumber8.TabIndex = 8;
            this.btnNumber8.Text = "8";
            this.btnNumber8.UseVisualStyleBackColor = true;
            // 
            // btnNumber9
            // 
            this.btnNumber9.DisplayText = "9";
            this.btnNumber9.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber9.Location = new System.Drawing.Point(411, 335);
            this.btnNumber9.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber9.Name = "btnNumber9";
            this.btnNumber9.Size = new System.Drawing.Size(193, 95);
            this.btnNumber9.TabIndex = 9;
            this.btnNumber9.Text = "9";
            this.btnNumber9.UseVisualStyleBackColor = true;
            // 
            // btnNumber4
            // 
            this.btnNumber4.DisplayText = "4";
            this.btnNumber4.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber4.Location = new System.Drawing.Point(5, 440);
            this.btnNumber4.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber4.Name = "btnNumber4";
            this.btnNumber4.Size = new System.Drawing.Size(193, 95);
            this.btnNumber4.TabIndex = 10;
            this.btnNumber4.Text = "4";
            this.btnNumber4.UseVisualStyleBackColor = true;
            // 
            // btnNumber5
            // 
            this.btnNumber5.DisplayText = "5";
            this.btnNumber5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber5.Location = new System.Drawing.Point(208, 440);
            this.btnNumber5.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber5.Name = "btnNumber5";
            this.btnNumber5.Size = new System.Drawing.Size(193, 95);
            this.btnNumber5.TabIndex = 11;
            this.btnNumber5.Text = "5";
            this.btnNumber5.UseVisualStyleBackColor = true;
            // 
            // btnNumber6
            // 
            this.btnNumber6.DisplayText = "6";
            this.btnNumber6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber6.Location = new System.Drawing.Point(411, 440);
            this.btnNumber6.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber6.Name = "btnNumber6";
            this.btnNumber6.Size = new System.Drawing.Size(193, 95);
            this.btnNumber6.TabIndex = 12;
            this.btnNumber6.Text = "6";
            this.btnNumber6.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.DisplayText = "－";
            this.btnSubtract.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSubtract.Location = new System.Drawing.Point(614, 440);
            this.btnSubtract.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(193, 95);
            this.btnSubtract.TabIndex = 13;
            this.btnSubtract.Text = "－";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnNumber1
            // 
            this.btnNumber1.DisplayText = "1";
            this.btnNumber1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber1.Location = new System.Drawing.Point(5, 545);
            this.btnNumber1.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(193, 95);
            this.btnNumber1.TabIndex = 14;
            this.btnNumber1.Text = "1";
            this.btnNumber1.UseVisualStyleBackColor = true;
            // 
            // btnNumber2
            // 
            this.btnNumber2.DisplayText = "2";
            this.btnNumber2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber2.Location = new System.Drawing.Point(208, 545);
            this.btnNumber2.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(193, 95);
            this.btnNumber2.TabIndex = 15;
            this.btnNumber2.Text = "2";
            this.btnNumber2.UseVisualStyleBackColor = true;
            // 
            // btnNumber3
            // 
            this.btnNumber3.DisplayText = "3";
            this.btnNumber3.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber3.Location = new System.Drawing.Point(411, 545);
            this.btnNumber3.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(193, 95);
            this.btnNumber3.TabIndex = 16;
            this.btnNumber3.Text = "3";
            this.btnNumber3.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayText = "＋";
            this.btnAdd.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAdd.Location = new System.Drawing.Point(614, 545);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(193, 95);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "＋";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnNumber0
            // 
            this.btnNumber0.DisplayText = "0";
            this.btnNumber0.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnNumber0.Location = new System.Drawing.Point(208, 650);
            this.btnNumber0.Margin = new System.Windows.Forms.Padding(5);
            this.btnNumber0.Name = "btnNumber0";
            this.btnNumber0.Size = new System.Drawing.Size(193, 99);
            this.btnNumber0.TabIndex = 19;
            this.btnNumber0.Text = "0";
            this.btnNumber0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            this.btnDot.DisplayText = "．";
            this.btnDot.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDot.Location = new System.Drawing.Point(411, 650);
            this.btnDot.Margin = new System.Windows.Forms.Padding(5);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(193, 99);
            this.btnDot.TabIndex = 20;
            this.btnDot.Text = "．";
            this.btnDot.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            this.btnEquals.DisplayText = "＝";
            this.btnEquals.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnEquals.Location = new System.Drawing.Point(614, 650);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(5);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(193, 99);
            this.btnEquals.TabIndex = 21;
            this.btnEquals.Text = "＝";
            this.btnEquals.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 754);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "電卓";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Models.DerivedButton btnDelete;
        private System.Windows.Forms.TextBox DisplayTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Models.DerivedButton btnClear;
        private Models.DerivedButton btnAllClear;
        private Models.DerivedButton btnDivide;
        private Models.DerivedButton btnMultiply;
        private Models.DerivedButton btnNumber7;
        private Models.DerivedButton btnNumber8;
        private Models.DerivedButton btnNumber9;
        private Models.DerivedButton btnNumber4;
        private Models.DerivedButton btnNumber5;
        private Models.DerivedButton btnNumber6;
        private Models.DerivedButton btnSubtract;
        private Models.DerivedButton btnNumber1;
        private Models.DerivedButton btnNumber2;
        private Models.DerivedButton btnNumber3;
        private Models.DerivedButton btnAdd;
        private Models.DerivedButton btnNumber0;
        private Models.DerivedButton btnDot;
        private Models.DerivedButton btnEquals;
    }
}

