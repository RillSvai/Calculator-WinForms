namespace Calculator
{
    partial class StandartCalculatorForm
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
            SuspendLayout();
            // 
            // StandartCalculatorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(390, 570);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StandartCalculatorForm";
            Text = "Standart сalculator";
            FormClosed += StandartCalculatorForm_FormClosed;
            Load += StandartCalculatorForm_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}