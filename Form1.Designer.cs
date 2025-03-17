namespace CPE340_BIMS
{
    partial class Form1
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
            tbxPasskey = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            btnLogin = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // tbxPasskey
            // 
            tbxPasskey.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxPasskey.AnimateReadOnly = false;
            tbxPasskey.BackgroundImageLayout = ImageLayout.None;
            tbxPasskey.CharacterCasing = CharacterCasing.Normal;
            tbxPasskey.Depth = 0;
            tbxPasskey.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            tbxPasskey.HideSelection = true;
            tbxPasskey.Hint = "Passkey";
            tbxPasskey.LeadingIcon = null;
            tbxPasskey.Location = new Point(119, 217);
            tbxPasskey.MaxLength = 32767;
            tbxPasskey.MouseState = MaterialSkin.MouseState.OUT;
            tbxPasskey.Name = "tbxPasskey";
            tbxPasskey.PasswordChar = '\0';
            tbxPasskey.PrefixSuffixText = null;
            tbxPasskey.ReadOnly = false;
            tbxPasskey.RightToLeft = RightToLeft.No;
            tbxPasskey.SelectedText = "";
            tbxPasskey.SelectionLength = 0;
            tbxPasskey.SelectionStart = 0;
            tbxPasskey.ShortcutsEnabled = true;
            tbxPasskey.Size = new Size(250, 48);
            tbxPasskey.TabIndex = 0;
            tbxPasskey.TabStop = false;
            tbxPasskey.TextAlign = HorizontalAlignment.Left;
            tbxPasskey.TrailingIcon = null;
            tbxPasskey.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            materialLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(143, 195);
            materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(200, 19);
            materialLabel1.TabIndex = 1;
            materialLabel1.Text = "Welcome, Login to continue.";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.Location = new Point(205, 274);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(64, 36);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(500, 500);
            Controls.Add(btnLogin);
            Controls.Add(materialLabel1);
            Controls.Add(tbxPasskey);
            Name = "Form1";
            Text = "Barangay Information System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox2 tbxPasskey;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton btnLogin;
    }
}
