using System;
using System.Windows.Forms;
using Classes;

namespace SingletonExample
{
   public partial class frmAddition : Form
   {
      public frmAddition()
      {
         InitializeComponent();

         textBox1.Text = "39.9";
         textBox2.Text =  "2.1";
         textBox3.Text =     "";
      }

      private void cmdCalculate_Click(object sender, EventArgs e)
      {
         double value1  = Convert.ToDouble(textBox1.Text);
         double value2  = Convert.ToDouble(textBox2.Text);

         clsSingleton s = clsSingleton.GetClsSingleton();

         double value3  = s.AddTwoNumbers(value1, value2);

         textBox3.Text  = value3.ToString();
      }
   }
}
