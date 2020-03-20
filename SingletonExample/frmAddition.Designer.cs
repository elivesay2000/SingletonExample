namespace SingletonExample
{
   partial class frmAddition
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
         this.cmdCalculate = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.textBox3 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // cmdCalculate
         // 
         this.cmdCalculate.Location = new System.Drawing.Point(89, 140);
         this.cmdCalculate.Name = "cmdCalculate";
         this.cmdCalculate.Size = new System.Drawing.Size(75, 23);
         this.cmdCalculate.TabIndex = 12;
         this.cmdCalculate.Text = "Calculate";
         this.cmdCalculate.UseVisualStyleBackColor = true;
         this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(43, 43);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(13, 13);
         this.label2.TabIndex = 11;
         this.label2.Text = "+";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(74, 59);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(106, 13);
         this.label1.TabIndex = 10;
         this.label1.Text = "---------------------------------";
         // 
         // textBox3
         // 
         this.textBox3.Location = new System.Drawing.Point(77, 78);
         this.textBox3.Name = "textBox3";
         this.textBox3.Size = new System.Drawing.Size(100, 20);
         this.textBox3.TabIndex = 9;
         this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(77, 36);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(100, 20);
         this.textBox2.TabIndex = 8;
         this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(77, 10);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 20);
         this.textBox1.TabIndex = 7;
         this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         // 
         // frmAddition
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(250, 174);
         this.Controls.Add(this.cmdCalculate);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.textBox3);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Name = "frmAddition";
         this.Text = "Add";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

        #endregion

        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}