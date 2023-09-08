using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Newtonsoft.Json;

namespace Power {
    public partial class Form1 : Form {

        public class FormPosition {
            public int LeftPosition;
            public int TopPosition;
        }

        //for Lock import Dlls
        [DllImport("user32")]
        private static extern void LockWorkStation();

        //for Sleep import Dlls
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        public Form1() {
            int leftPositionDefault = 100;
            int topPositionDefault = 100;

            InitializeComponent();

            SleepButton.MouseEnter += OnMouseEnter_SleepButton;
            SleepButton.MouseLeave += OnMouseLeave_SleepButton;
            ShutdownButton.MouseEnter += OnMouseEnter_ShutdownButton;
            ShutdownButton.MouseLeave += OnMouseLeave_ShutdownButton;
            RestartButton.MouseEnter += OnMouseEnter_RestartButton;
            RestartButton.MouseLeave += OnMouseLeave_RestartButton;
            LockButton.MouseEnter += OnMouseEnter_LockButton;
            LockButton.MouseLeave += OnMouseLeave_LockButton;

            string json = File.ReadAllText(@"C:\Users\ADMIN\source\repos\Power\Power\config.json");

            FormPosition deserialized = JsonConvert.DeserializeObject<FormPosition>(json);

            this.StartPosition = FormStartPosition.Manual;
            if (deserialized != null) {
                this.Location = new Point(deserialized.LeftPosition, deserialized.TopPosition);
            } else {
                this.Location = new Point(leftPositionDefault, topPositionDefault);
            }
        }

        //Drawing Borders around the buttons
        private void OnMouseEnter_SleepButton(object sender, EventArgs e) {
            SleepButton.FlatAppearance.BorderSize = 1;
        }

        private void OnMouseLeave_SleepButton(object sender, EventArgs e) {
            SleepButton.FlatAppearance.BorderSize = 0;
        }

        private void OnMouseEnter_ShutdownButton(object sender, EventArgs e) {
            ShutdownButton.FlatAppearance.BorderSize = 2;
        }

        private void OnMouseLeave_ShutdownButton(object sender, EventArgs e) {
            ShutdownButton.FlatAppearance.BorderSize = 0;
        }

        private void OnMouseEnter_RestartButton(object? sender, EventArgs e) {
            RestartButton.FlatAppearance.BorderSize = 2;
        }

        private void OnMouseLeave_RestartButton(object sender, EventArgs e) {
            RestartButton.FlatAppearance.BorderSize = 0;
        }

        private void OnMouseEnter_LockButton(object sender, EventArgs e) {
            LockButton.FlatAppearance.BorderSize = 2;
        }

        private void OnMouseLeave_LockButton(object sender, EventArgs e) {
            LockButton.FlatAppearance.BorderSize = 0;
        }

        //Button's function
        private void SleepButton_Click(object sender, EventArgs e) {
            SetSuspendState(false, true, true);
        }

        private void ShutdownButton_Click(object sender, EventArgs e) {
            Process.Start("shutdown.exe", "-s -t 00");
        }

        private void RestartButton_Click(object sender, EventArgs e) {
            Process.Start("shutdown.exe", "-r -t 00");
        }

        private void LockButton_Click(object sender, EventArgs e) {
            LockWorkStation();
        }

        //there is how to close the windows form when clicking outside
        protected override void OnMouseDown(MouseEventArgs e) {
            base.OnMouseDown(e);
            this.Close();
        }

        protected override void OnDeactivate(EventArgs e) {
            base.OnDeactivate(e);
            this.Close();
        }
    }
}