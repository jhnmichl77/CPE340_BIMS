namespace CPE340_BIMS
{
    partial class Dashboard
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
            materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            Resident = new TabPage();
            textBox1 = new TextBox();
            materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            materialListBox1 = new MaterialSkin.Controls.MaterialListBox();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            checkBox1 = new CheckBox();
            materialTabControl1.SuspendLayout();
            Resident.SuspendLayout();
            tabPage6.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(Resident);
            materialTabControl1.Controls.Add(tabPage2);
            materialTabControl1.Controls.Add(tabPage3);
            materialTabControl1.Controls.Add(tabPage4);
            materialTabControl1.Controls.Add(tabPage5);
            materialTabControl1.Controls.Add(tabPage6);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.Location = new Point(3, 85);
            materialTabControl1.Margin = new Padding(3, 4, 3, 4);
            materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(908, 511);
            materialTabControl1.TabIndex = 0;
            // 
            // Resident
            // 
            Resident.Controls.Add(textBox1);
            Resident.Controls.Add(materialTextBox3);
            Resident.Controls.Add(materialListBox1);
            Resident.Controls.Add(materialLabel2);
            Resident.Controls.Add(materialLabel1);
            Resident.Controls.Add(materialTextBox1);
            Resident.Controls.Add(materialDivider1);
            Resident.Controls.Add(materialTextBox2);
            Resident.Location = new Point(4, 29);
            Resident.Margin = new Padding(3, 4, 3, 4);
            Resident.Name = "Resident";
            Resident.Padding = new Padding(3, 4, 3, 4);
            Resident.Size = new Size(900, 478);
            Resident.TabIndex = 0;
            Resident.Text = "Resident";
            Resident.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 9;
            // 
            // materialTextBox3
            // 
            materialTextBox3.AnimateReadOnly = false;
            materialTextBox3.BorderStyle = BorderStyle.None;
            materialTextBox3.Depth = 0;
            materialTextBox3.Font = new Font("Microsoft Sans Serif", 9.6F);
            materialTextBox3.LeadingIcon = null;
            materialTextBox3.Location = new Point(6, 165);
            materialTextBox3.MaxLength = 50;
            materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox3.Multiline = false;
            materialTextBox3.Name = "materialTextBox3";
            materialTextBox3.Size = new Size(107, 50);
            materialTextBox3.TabIndex = 8;
            materialTextBox3.Text = "Name:";
            materialTextBox3.TrailingIcon = null;
            // 
            // materialListBox1
            // 
            materialListBox1.BackColor = Color.White;
            materialListBox1.BorderColor = Color.LightGray;
            materialListBox1.Depth = 0;
            materialListBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialListBox1.Location = new Point(124, 109);
            materialListBox1.MouseState = MaterialSkin.MouseState.HOVER;
            materialListBox1.Name = "materialListBox1";
            materialListBox1.SelectedIndex = -1;
            materialListBox1.SelectedItem = null;
            materialListBox1.Size = new Size(141, 50);
            materialListBox1.TabIndex = 7;
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(6, 74);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(107, 19);
            materialLabel2.TabIndex = 6;
            materialLabel2.Text = "materialLabel2";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(790, 74);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(107, 19);
            materialLabel1.TabIndex = 5;
            materialLabel1.Text = "materialLabel1";
            // 
            // materialTextBox1
            // 
            materialTextBox1.AnimateReadOnly = false;
            materialTextBox1.BorderStyle = BorderStyle.None;
            materialTextBox1.Depth = 0;
            materialTextBox1.Font = new Font("Microsoft Sans Serif", 9.6F);
            materialTextBox1.LeadingIcon = null;
            materialTextBox1.Location = new Point(6, 109);
            materialTextBox1.MaxLength = 50;
            materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox1.Multiline = false;
            materialTextBox1.Name = "materialTextBox1";
            materialTextBox1.Size = new Size(112, 50);
            materialTextBox1.TabIndex = 4;
            materialTextBox1.Text = "Resident ID:";
            materialTextBox1.TrailingIcon = null;
            // 
            // materialDivider1
            // 
            materialDivider1.BackColor = Color.FromArgb(30, 0, 0, 0);
            materialDivider1.Depth = 0;
            materialDivider1.Location = new Point(3, 63);
            materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            materialDivider1.Name = "materialDivider1";
            materialDivider1.Size = new Size(901, 40);
            materialDivider1.TabIndex = 3;
            materialDivider1.Text = "materialDivider1";
            // 
            // materialTextBox2
            // 
            materialTextBox2.AnimateReadOnly = false;
            materialTextBox2.BorderStyle = BorderStyle.None;
            materialTextBox2.Depth = 0;
            materialTextBox2.Font = new Font("Microsoft Sans Serif", 9.6F);
            materialTextBox2.LeadingIcon = null;
            materialTextBox2.Location = new Point(360, 7);
            materialTextBox2.MaxLength = 50;
            materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox2.Multiline = false;
            materialTextBox2.Name = "materialTextBox2";
            materialTextBox2.Size = new Size(187, 50);
            materialTextBox2.TabIndex = 2;
            materialTextBox2.Text = "Resident Management";
            materialTextBox2.TrailingIcon = null;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(900, 478);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(900, 478);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3, 4, 3, 4);
            tabPage4.Size = new Size(900, 478);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(3, 4, 3, 4);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3, 4, 3, 4);
            tabPage5.Size = new Size(900, 478);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(checkBox1);
            tabPage6.Location = new Point(4, 29);
            tabPage6.Margin = new Padding(3, 4, 3, 4);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3, 4, 3, 4);
            tabPage6.Size = new Size(900, 478);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(268, 134);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(materialTabControl1);
            DrawerTabControl = materialTabControl1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Padding = new Padding(3, 85, 3, 4);
            Text = "Dashboard";
            Load += Dashboard_Load;
            materialTabControl1.ResumeLayout(false);
            Resident.ResumeLayout(false);
            Resident.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private TabPage Resident;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialListBox materialListBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private TextBox textBox1;
        private CheckBox checkBox1;
    }
}