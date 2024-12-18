using System.Diagnostics;

namespace toolPath1
{
    public partial class mainForm : Form
    {

        private List<Point> kordSkraw = new List<Point>(); // przechowywanie koord

        public mainForm()
        {
            InitializeComponent();
            ConfigureDataGridView();
            Debug.WriteLine("Siema Siema");
        }

        private void ConfigureDataGridView()
        {
            // Configure DataGridView for points
            userDataGraf.AllowUserToAddRows = true;
            userDataGraf.AllowUserToDeleteRows = true;

            userDataGraf.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "X",
                HeaderText = "X",
                ValueType = typeof(int),
                Width = 150
            }); ;

            userDataGraf.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Y",
                HeaderText = "Y",
                ValueType = typeof(int),
                Width = 150
            });
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProcessKoord_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("btnProcessKoord Klik");

            // Clear the existing points
            kordSkraw.Clear();

            // Extract points from DataGridView
            foreach (DataGridViewRow row in userDataGraf.Rows)
            {
                if (row.Cells["X"].Value != null && row.Cells["Y"].Value != null)
                {
                    int x = int.Parse(row.Cells["X"].Value.ToString());
                    int y = int.Parse(row.Cells["Y"].Value.ToString());
                    kordSkraw.Add(new Point(x, y));
                }
            }

            // Validate the points
            if (sameX(kordSkraw))
            {
                infoGrafKord.Invalidate();
            }
            else
            {
                MessageBox.Show(
                    "Koordynat X pierwszego i ostatniego punktu musi byæ taki sam",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void infoGrafKord_Paint(object sender, PaintEventArgs e)
        {
            Debug.WriteLine("Panel is being painted");
            if (kordSkraw.Count < 2)
                return; // Need at least two points to draw lines

            // Draw lines connecting points
            using (Pen pen = new Pen(Color.Black, 2))
            {
                for (int i = 0; i < kordSkraw.Count - 1; i++)
                {
                    e.Graphics.DrawLine(pen, kordSkraw[i], kordSkraw[i + 1]);
                }
            }
        }



        //Matematyka
        public bool sameX(List<Point> punkty)
        {
            if (punkty == null || punkty.Count < 2)
            {
                // Show an error or return false if the list is not valid
                MessageBox.Show(
                    "There must be at least two points to check the X coordinates.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }

            Point pPunkt = punkty[0];
            Point oPunkt = punkty[punkty.Count - 1];
            return pPunkt.X == oPunkt.X;

        }



    }
}
