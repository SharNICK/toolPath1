
namespace toolPath1
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            infoKoordPrzekr = new Label();
            userWybPrzekr = new ComboBox();
            infoApZgrb = new Label();
            userApZgrb = new TextBox();
            userDataGraf = new DataGridView();
            btnProcessKoord = new Button();
            infoGrafKord = new Panel();
            infoApWyk = new Label();
            userApWyk = new TextBox();
            ((System.ComponentModel.ISupportInitialize)userDataGraf).BeginInit();
            SuspendLayout();
            // 
            // infoKoordPrzekr
            // 
            infoKoordPrzekr.AutoSize = true;
            infoKoordPrzekr.Font = new Font("Segoe UI", 15F);
            infoKoordPrzekr.Location = new Point(12, 9);
            infoKoordPrzekr.Name = "infoKoordPrzekr";
            infoKoordPrzekr.Size = new Size(291, 28);
            infoKoordPrzekr.TabIndex = 0;
            infoKoordPrzekr.Text = "Wybrac przekrój lewy czy prawy";
            infoKoordPrzekr.Click += label1_Click;
            // 
            // userWybPrzekr
            // 
            userWybPrzekr.FormattingEnabled = true;
            userWybPrzekr.Items.AddRange(new object[] { "Prawy", "Lewy" });
            userWybPrzekr.Location = new Point(12, 40);
            userWybPrzekr.Name = "userWybPrzekr";
            userWybPrzekr.Size = new Size(121, 23);
            userWybPrzekr.TabIndex = 1;
            // 
            // infoApZgrb
            // 
            infoApZgrb.AutoSize = true;
            infoApZgrb.Font = new Font("Segoe UI", 15F);
            infoApZgrb.Location = new Point(12, 66);
            infoApZgrb.Name = "infoApZgrb";
            infoApZgrb.Size = new Size(233, 28);
            infoApZgrb.TabIndex = 2;
            infoApZgrb.Text = "Głebokość przejścia zgrb.";
            infoApZgrb.Click += label1_Click_1;
            // 
            // userApZgrb
            // 
            userApZgrb.Location = new Point(12, 97);
            userApZgrb.Name = "userApZgrb";
            userApZgrb.Size = new Size(191, 23);
            userApZgrb.TabIndex = 3;
            // 
            // userDataGraf
            // 
            userDataGraf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGraf.Location = new Point(928, 66);
            userDataGraf.Name = "userDataGraf";
            userDataGraf.Size = new Size(400, 297);
            userDataGraf.TabIndex = 4;
            // 
            // btnProcessKoord
            // 
            btnProcessKoord.Font = new Font("Segoe UI", 13F);
            btnProcessKoord.Location = new Point(838, 329);
            btnProcessKoord.Name = "btnProcessKoord";
            btnProcessKoord.Size = new Size(84, 34);
            btnProcessKoord.TabIndex = 5;
            btnProcessKoord.Text = "Generuj";
            btnProcessKoord.UseVisualStyleBackColor = true;
            btnProcessKoord.Click += btnProcessKoord_Click;
            // 
            // infoGrafKord
            // 
            infoGrafKord.BackColor = SystemColors.ControlLight;
            infoGrafKord.Location = new Point(800, 369);
            infoGrafKord.Name = "infoGrafKord";
            infoGrafKord.Size = new Size(528, 349);
            infoGrafKord.TabIndex = 6;
            infoGrafKord.Paint += infoGrafKord_Paint;
            // 
            // infoApWyk
            // 
            infoApWyk.AutoSize = true;
            infoApWyk.Font = new Font("Segoe UI", 15F);
            infoApWyk.Location = new Point(12, 123);
            infoApWyk.Name = "infoApWyk";
            infoApWyk.Size = new Size(227, 28);
            infoApWyk.TabIndex = 7;
            infoApWyk.Text = "Głebokość przejścia wyk.";
            // 
            // userApWyk
            // 
            userApWyk.Location = new Point(12, 154);
            userApWyk.Name = "userApWyk";
            userApWyk.Size = new Size(191, 23);
            userApWyk.TabIndex = 8;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1403, 740);
            Controls.Add(userApWyk);
            Controls.Add(infoApWyk);
            Controls.Add(infoGrafKord);
            Controls.Add(btnProcessKoord);
            Controls.Add(userDataGraf);
            Controls.Add(userApZgrb);
            Controls.Add(infoApZgrb);
            Controls.Add(userWybPrzekr);
            Controls.Add(infoKoordPrzekr);
            Name = "mainForm";
            Text = "toolPath";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)userDataGraf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label infoKoordPrzekr;
        private ComboBox userWybPrzekr;
        private Label infoApZgrb;
        private TextBox userApZgrb;
        private DataGridView userDataGraf;
        private Button btnProcessKoord;
        private Panel infoGrafKord;
        private Label infoApWyk;
        private TextBox userApWyk;
    }
}
