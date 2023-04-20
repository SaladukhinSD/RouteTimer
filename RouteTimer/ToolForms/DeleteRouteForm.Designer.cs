namespace RouteTimer
{
    partial class DeleteRouteForm
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
            this.textBoxAllInformationRoute = new System.Windows.Forms.TextBox();
            this.comboBoxNumberRoute = new System.Windows.Forms.ComboBox();
            this.buttonDeliteRoute = new System.Windows.Forms.Button();
            this.labelNumberRoute = new System.Windows.Forms.Label();
            this.abelAllInformationRoute = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAllInformationRoute
            // 
            this.textBoxAllInformationRoute.Location = new System.Drawing.Point(11, 107);
            this.textBoxAllInformationRoute.Multiline = true;
            this.textBoxAllInformationRoute.Name = "textBoxAllInformationRoute";
            this.textBoxAllInformationRoute.Size = new System.Drawing.Size(348, 139);
            this.textBoxAllInformationRoute.TabIndex = 0;
            // 
            // comboBoxNumberRoute
            // 
            this.comboBoxNumberRoute.FormattingEnabled = true;
            this.comboBoxNumberRoute.Location = new System.Drawing.Point(11, 42);
            this.comboBoxNumberRoute.Name = "comboBoxNumberRoute";
            this.comboBoxNumberRoute.Size = new System.Drawing.Size(160, 21);
            this.comboBoxNumberRoute.TabIndex = 1;
            // 
            // buttonDeliteRoute
            // 
            this.buttonDeliteRoute.Location = new System.Drawing.Point(11, 252);
            this.buttonDeliteRoute.Name = "buttonDeliteRoute";
            this.buttonDeliteRoute.Size = new System.Drawing.Size(348, 31);
            this.buttonDeliteRoute.TabIndex = 3;
            this.buttonDeliteRoute.Text = "Delite Route";
            this.buttonDeliteRoute.UseVisualStyleBackColor = true;
            this.buttonDeliteRoute.Click += new System.EventHandler(this.buttonDeliteRoute_Click);
            // 
            // labelNumberRoute
            // 
            this.labelNumberRoute.AutoSize = true;
            this.labelNumberRoute.Location = new System.Drawing.Point(13, 13);
            this.labelNumberRoute.Name = "labelNumberRoute";
            this.labelNumberRoute.Size = new System.Drawing.Size(76, 13);
            this.labelNumberRoute.TabIndex = 5;
            this.labelNumberRoute.Text = "Number Route";
            // 
            // abelAllInformationRoute
            // 
            this.abelAllInformationRoute.AutoSize = true;
            this.abelAllInformationRoute.Location = new System.Drawing.Point(13, 78);
            this.abelAllInformationRoute.Name = "abelAllInformationRoute";
            this.abelAllInformationRoute.Size = new System.Drawing.Size(105, 13);
            this.abelAllInformationRoute.TabIndex = 7;
            this.abelAllInformationRoute.Text = "All Information Route";
            // 
            // DeliteRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 295);
            this.Controls.Add(this.abelAllInformationRoute);
            this.Controls.Add(this.labelNumberRoute);
            this.Controls.Add(this.buttonDeliteRoute);
            this.Controls.Add(this.comboBoxNumberRoute);
            this.Controls.Add(this.textBoxAllInformationRoute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeliteRouteForm";
            this.Text = "Delite Route";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAllInformationRoute;
        private System.Windows.Forms.ComboBox comboBoxNumberRoute;
        private System.Windows.Forms.Button buttonDeliteRoute;
        private System.Windows.Forms.Label labelNumberRoute;
        private System.Windows.Forms.Label abelAllInformationRoute;
    }
}