namespace RouteTimer
{
    partial class InformationRouteForm
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
            this.textBoxInformationRoute = new System.Windows.Forms.TextBox();
            this.comboBoxNumberRoute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInformationRoute
            // 
            this.textBoxInformationRoute.Location = new System.Drawing.Point(35, 76);
            this.textBoxInformationRoute.Multiline = true;
            this.textBoxInformationRoute.Name = "textBoxInformationRoute";
            this.textBoxInformationRoute.Size = new System.Drawing.Size(321, 233);
            this.textBoxInformationRoute.TabIndex = 3;
            // 
            // comboBoxNumberRoute
            // 
            this.comboBoxNumberRoute.FormattingEnabled = true;
            this.comboBoxNumberRoute.Location = new System.Drawing.Point(35, 38);
            this.comboBoxNumberRoute.Name = "comboBoxNumberRoute";
            this.comboBoxNumberRoute.Size = new System.Drawing.Size(74, 21);
            this.comboBoxNumberRoute.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter number route";
            // 
            // InformationRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxNumberRoute);
            this.Controls.Add(this.textBoxInformationRoute);
            this.Name = "InformationRouteForm";
            this.Text = "InformationRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInformationRoute;
        private System.Windows.Forms.ComboBox comboBoxNumberRoute;
        private System.Windows.Forms.Label label1;
    }
}