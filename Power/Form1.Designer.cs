namespace Power {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            SleepButton=new Button();
            ShutdownButton=new Button();
            RestartButton=new Button();
            LockButton=new Button();
            SuspendLayout();
            // 
            // SleepButton
            // 
            SleepButton.BackColor=Color.Transparent;
            SleepButton.FlatAppearance.BorderColor=Color.White;
            SleepButton.FlatAppearance.BorderSize=0;
            SleepButton.FlatAppearance.MouseOverBackColor=Color.FromArgb(64, 64, 64);
            SleepButton.FlatStyle=FlatStyle.Flat;
            SleepButton.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            SleepButton.ForeColor=SystemColors.ControlLight;
            SleepButton.Image=Properties.Resources.WhiteSleep_24x24;
            SleepButton.ImageAlign=ContentAlignment.MiddleLeft;
            SleepButton.Location=new Point(0, 0);
            SleepButton.Name="SleepButton";
            SleepButton.Padding=new Padding(10, 0, 0, 0);
            SleepButton.RightToLeft=RightToLeft.No;
            SleepButton.Size=new Size(257, 46);
            SleepButton.TabIndex=1;
            SleepButton.Text="         Sleep";
            SleepButton.TextAlign=ContentAlignment.MiddleLeft;
            SleepButton.UseVisualStyleBackColor=false;
            SleepButton.Click+=SleepButton_Click;
            // 
            // ShutdownButton
            // 
            ShutdownButton.BackColor=Color.Transparent;
            ShutdownButton.FlatAppearance.BorderColor=Color.White;
            ShutdownButton.FlatAppearance.BorderSize=0;
            ShutdownButton.FlatAppearance.MouseOverBackColor=Color.FromArgb(64, 64, 64);
            ShutdownButton.FlatStyle=FlatStyle.Flat;
            ShutdownButton.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ShutdownButton.ForeColor=SystemColors.ControlLight;
            ShutdownButton.Image=Properties.Resources.WhitePower_24x24;
            ShutdownButton.ImageAlign=ContentAlignment.MiddleLeft;
            ShutdownButton.Location=new Point(0, 46);
            ShutdownButton.Name="ShutdownButton";
            ShutdownButton.Padding=new Padding(10, 0, 0, 0);
            ShutdownButton.Size=new Size(257, 46);
            ShutdownButton.TabIndex=2;
            ShutdownButton.Text="          Shutdown";
            ShutdownButton.TextAlign=ContentAlignment.MiddleLeft;
            ShutdownButton.UseVisualStyleBackColor=false;
            ShutdownButton.Click+=ShutdownButton_Click;
            // 
            // RestartButton
            // 
            RestartButton.BackColor=Color.Transparent;
            RestartButton.FlatAppearance.BorderColor=Color.White;
            RestartButton.FlatAppearance.BorderSize=0;
            RestartButton.FlatAppearance.MouseOverBackColor=Color.FromArgb(64, 64, 64);
            RestartButton.FlatStyle=FlatStyle.Flat;
            RestartButton.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            RestartButton.ForeColor=SystemColors.ControlLight;
            RestartButton.Image=Properties.Resources.WhiteRestartIcon_24x24;
            RestartButton.ImageAlign=ContentAlignment.MiddleLeft;
            RestartButton.Location=new Point(0, 92);
            RestartButton.Name="RestartButton";
            RestartButton.Padding=new Padding(10, 0, 0, 0);
            RestartButton.Size=new Size(257, 46);
            RestartButton.TabIndex=3;
            RestartButton.Text="          Restart";
            RestartButton.TextAlign=ContentAlignment.MiddleLeft;
            RestartButton.UseVisualStyleBackColor=false;
            RestartButton.Click+=RestartButton_Click;
            // 
            // LockButton
            // 
            LockButton.BackColor=Color.Transparent;
            LockButton.FlatAppearance.BorderColor=Color.White;
            LockButton.FlatAppearance.BorderSize=0;
            LockButton.FlatAppearance.MouseOverBackColor=Color.FromArgb(64, 64, 64);
            LockButton.FlatStyle=FlatStyle.Flat;
            LockButton.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LockButton.ForeColor=SystemColors.ControlLight;
            LockButton.Image=Properties.Resources.lock_24;
            LockButton.ImageAlign=ContentAlignment.MiddleLeft;
            LockButton.Location=new Point(0, 138);
            LockButton.Name="LockButton";
            LockButton.Padding=new Padding(10, 0, 0, 0);
            LockButton.Size=new Size(257, 46);
            LockButton.TabIndex=4;
            LockButton.Text="          Lock";
            LockButton.TextAlign=ContentAlignment.MiddleLeft;
            LockButton.UseVisualStyleBackColor=false;
            LockButton.Click+=LockButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(34, 34, 34);
            ClientSize=new Size(257, 184);
            Controls.Add(LockButton);
            Controls.Add(RestartButton);
            Controls.Add(ShutdownButton);
            Controls.Add(SleepButton);
            FormBorderStyle=FormBorderStyle.None;
            Icon=(Icon)resources.GetObject("$this.Icon");
            Name="Form1";
            Text="Power";
            ResumeLayout(false);
        }

        #endregion

        private Button SleepButton;
        private Button ShutdownButton;
        private Button RestartButton;
        private Button LockButton;
    }
}