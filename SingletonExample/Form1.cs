using System.Windows.Forms;

namespace SingletonExample
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void cmdAddition_Click(object sender, System.EventArgs e)
      {
         frmAddition f = new frmAddition();
         f.Show();
      }

      private void cmdSubtraction_Click(object sender, System.EventArgs e)
      {

      }
   }
}
