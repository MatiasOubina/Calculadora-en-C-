namespace Calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnOpAdd = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnOpSubs = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnOpMult = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnOpDiv = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNum7
            // 
            this.btnNum7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum7.Location = new System.Drawing.Point(18, 72);
            this.btnNum7.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(60, 65);
            this.btnNum7.TabIndex = 0;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum8.Location = new System.Drawing.Point(82, 72);
            this.btnNum8.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(60, 65);
            this.btnNum8.TabIndex = 1;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnOpAdd
            // 
            this.btnOpAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpAdd.Location = new System.Drawing.Point(212, 72);
            this.btnOpAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpAdd.Name = "btnOpAdd";
            this.btnOpAdd.Size = new System.Drawing.Size(60, 65);
            this.btnOpAdd.TabIndex = 3;
            this.btnOpAdd.Text = "+";
            this.btnOpAdd.UseVisualStyleBackColor = true;
            this.btnOpAdd.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum9.Location = new System.Drawing.Point(147, 72);
            this.btnNum9.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(60, 65);
            this.btnNum9.TabIndex = 2;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnOpSubs
            // 
            this.btnOpSubs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpSubs.Location = new System.Drawing.Point(212, 141);
            this.btnOpSubs.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpSubs.Name = "btnOpSubs";
            this.btnOpSubs.Size = new System.Drawing.Size(60, 65);
            this.btnOpSubs.TabIndex = 7;
            this.btnOpSubs.Text = "-";
            this.btnOpSubs.UseVisualStyleBackColor = true;
            this.btnOpSubs.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum6.Location = new System.Drawing.Point(147, 141);
            this.btnNum6.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(60, 65);
            this.btnNum6.TabIndex = 6;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum5.Location = new System.Drawing.Point(82, 141);
            this.btnNum5.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(60, 65);
            this.btnNum5.TabIndex = 5;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum4.Location = new System.Drawing.Point(18, 141);
            this.btnNum4.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(60, 65);
            this.btnNum4.TabIndex = 4;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnOpMult
            // 
            this.btnOpMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpMult.Location = new System.Drawing.Point(212, 211);
            this.btnOpMult.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpMult.Name = "btnOpMult";
            this.btnOpMult.Size = new System.Drawing.Size(60, 65);
            this.btnOpMult.TabIndex = 11;
            this.btnOpMult.Text = "*";
            this.btnOpMult.UseVisualStyleBackColor = true;
            this.btnOpMult.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum3.Location = new System.Drawing.Point(147, 211);
            this.btnNum3.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(60, 65);
            this.btnNum3.TabIndex = 10;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum2.Location = new System.Drawing.Point(82, 211);
            this.btnNum2.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(60, 65);
            this.btnNum2.TabIndex = 9;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum1.Location = new System.Drawing.Point(18, 211);
            this.btnNum1.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(60, 65);
            this.btnNum1.TabIndex = 8;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnOpDiv
            // 
            this.btnOpDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpDiv.Location = new System.Drawing.Point(212, 281);
            this.btnOpDiv.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpDiv.Name = "btnOpDiv";
            this.btnOpDiv.Size = new System.Drawing.Size(60, 65);
            this.btnOpDiv.TabIndex = 15;
            this.btnOpDiv.Text = "/";
            this.btnOpDiv.UseVisualStyleBackColor = true;
            this.btnOpDiv.Click += new System.EventHandler(this.OperatorAction_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(147, 281);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(2);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(60, 65);
            this.btnEquals.TabIndex = 14;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.BtnEquals_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNum0.Location = new System.Drawing.Point(82, 281);
            this.btnNum0.Margin = new System.Windows.Forms.Padding(2);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(60, 65);
            this.btnNum0.TabIndex = 13;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.NumberAction_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(18, 281);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 65);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(18, 28);
            this.txtValue.Margin = new System.Windows.Forms.Padding(2);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(254, 32);
            this.txtValue.TabIndex = 16;
            this.txtValue.Text = "0";
            this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 379);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnOpDiv);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpMult);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnOpSubs);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnOpAdd);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MO - Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNum7;
        private System.Windows.Forms.Button btnNum8;
        private System.Windows.Forms.Button btnOpAdd;
        private System.Windows.Forms.Button btnNum9;
        private System.Windows.Forms.Button btnOpSubs;
        private System.Windows.Forms.Button btnNum6;
        private System.Windows.Forms.Button btnNum5;
        private System.Windows.Forms.Button btnNum4;
        private System.Windows.Forms.Button btnOpMult;
        private System.Windows.Forms.Button btnNum3;
        private System.Windows.Forms.Button btnNum2;
        private System.Windows.Forms.Button btnNum1;
        private System.Windows.Forms.Button btnOpDiv;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnNum0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtValue;
    }
}

