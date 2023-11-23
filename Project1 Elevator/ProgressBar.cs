
namespace Project1_Elevator
{
    public partial class ProgressBar : Form
    {
        
        public ProgressBar()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        public void UpdateProgress(int progressValue, string progressText)
        {
            progressBar1.Value = progressValue;
            label2.Text = progressText;

        }

        private void button1_Click(object sender, EventArgs e) //Cancel Button
        {
           
            this.Close();



        }

      

     
    }
}





