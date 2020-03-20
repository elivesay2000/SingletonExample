namespace SingletonExample
{
   partial class frmMain
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
         this.cmdAddition = new System.Windows.Forms.Button();
         this.cmdSubtraction = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // cmdAddition
         // 
         this.cmdAddition.Location = new System.Drawing.Point(58, 31);
         this.cmdAddition.Name = "cmdAddition";
         this.cmdAddition.Size = new System.Drawing.Size(75, 23);
         this.cmdAddition.TabIndex = 0;
         this.cmdAddition.Text = "Addition";
         this.cmdAddition.UseVisualStyleBackColor = true;
         this.cmdAddition.Click += new System.EventHandler(this.cmdAddition_Click);
         // 
         // cmdSubtraction
         // 
         this.cmdSubtraction.Location = new System.Drawing.Point(58, 76);
         this.cmdSubtraction.Name = "cmdSubtraction";
         this.cmdSubtraction.Size = new System.Drawing.Size(75, 23);
         this.cmdSubtraction.TabIndex = 1;
         this.cmdSubtraction.Text = "Subtraction";
         this.cmdSubtraction.UseVisualStyleBackColor = true;
         this.cmdSubtraction.Click += new System.EventHandler(this.cmdSubtraction_Click);
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(190, 154);
         this.Controls.Add(this.cmdSubtraction);
         this.Controls.Add(this.cmdAddition);
         this.Name = "Form1";
         this.Text = "Form1";
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.Button cmdAddition;
        private System.Windows.Forms.Button cmdSubtraction;
    }
}

