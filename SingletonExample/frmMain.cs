using System.Windows.Forms;

namespace SingletonExample
{
   public partial class frmMain : Form
   {
      public frmMain()
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
         frmSubtraction f = new frmSubtraction();
         f.Show();
      }
   }
}
