namespace BasicQueuingForm
{
    partial class NextQueue
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
            label1 = new Label();
            lblServing = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 60);
            label1.Name = "label1";
            label1.Size = new Size(161, 32);
            label1.TabIndex = 0;
            label1.Text = "*Next Serving";
            // 
            // lblServing
            // 
            lblServing.AutoSize = true;
            lblServing.Font = new Font("Segoe UI Emoji", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblServing.Location = new Point(132, 121);
            lblServing.Name = "lblServing";
            lblServing.Size = new Size(0, 38);
            lblServing.TabIndex = 1;
            // 
            // NextQueue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 259);
            Controls.Add(lblServing);
            Controls.Add(label1);
            Name = "NextQueue";
            Text = "NextQueue";
            Load += NextQueue_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblServing;
    }
}