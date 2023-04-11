namespace PlayerFF
{
    partial class btnCut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _Button1 = new CustomControls.RJControls._Button();
            SuspendLayout();
            // 
            // _Button1
            // 
            _Button1.BackColor = Color.Transparent;
            _Button1.BackgroundColor = Color.Transparent;
            _Button1.BackgroundImage = Properties.Resources.cut_48px;
            _Button1.BackgroundImageLayout = ImageLayout.Stretch;
            _Button1.BorderColor = Color.White;
            _Button1.BorderRadius = 7;
            _Button1.BorderSize = 1;
            _Button1.FlatAppearance.BorderSize = 0;
            _Button1.FlatStyle = FlatStyle.Flat;
            _Button1.ForeColor = Color.White;
            _Button1.Location = new Point(5, 0);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(35, 35);
            _Button1.TabIndex = 6;
            _Button1.TextColor = Color.White;
            _Button1.UseVisualStyleBackColor = false;
            // 
            // btnCut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            Controls.Add(_Button1);
            Name = "btnCut";
            Size = new Size(45, 150);
            ResumeLayout(false);
        }

        #endregion

        private CustomControls.RJControls._Button _Button1;
    }
}
