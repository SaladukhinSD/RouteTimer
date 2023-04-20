namespace RouteTimer
{
    partial class ModifyRouteForm
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
            this.comboBoxNumberRoute = new System.Windows.Forms.ComboBox();
            this.textBoxModifyRoute = new System.Windows.Forms.TextBox();
            this.buttonModifyRoute = new System.Windows.Forms.Button();
            this.listBoxInformationRoute = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // comboBoxNumberRoute
            // 
            this.comboBoxNumberRoute.FormattingEnabled = true;
            this.comboBoxNumberRoute.Location = new System.Drawing.Point(294, 34);
            this.comboBoxNumberRoute.Name = "comboBoxNumberRoute";
            this.comboBoxNumberRoute.Size = new System.Drawing.Size(189, 21);
            this.comboBoxNumberRoute.TabIndex = 0;
            this.comboBoxNumberRoute.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberRoute_SelectedIndexChanged);
            // 
            // textBoxModifyRoute
            // 
            this.textBoxModifyRoute.Location = new System.Drawing.Point(294, 77);
            this.textBoxModifyRoute.Multiline = true;
            this.textBoxModifyRoute.Name = "textBoxModifyRoute";
            this.textBoxModifyRoute.Size = new System.Drawing.Size(189, 187);
            this.textBoxModifyRoute.TabIndex = 2;
            // 
            // buttonModifyRoute
            // 
            this.buttonModifyRoute.Location = new System.Drawing.Point(294, 286);
            this.buttonModifyRoute.Name = "buttonModifyRoute";
            this.buttonModifyRoute.Size = new System.Drawing.Size(189, 46);
            this.buttonModifyRoute.TabIndex = 3;
            this.buttonModifyRoute.Text = "Modify";
            this.buttonModifyRoute.UseVisualStyleBackColor = true;
            this.buttonModifyRoute.Click += new System.EventHandler(this.buttonModifyRoute_Click);
            // 
            // listBoxInformationRoute
            // 
            this.listBoxInformationRoute.FormattingEnabled = true;
            this.listBoxInformationRoute.Location = new System.Drawing.Point(12, 34);
            this.listBoxInformationRoute.Name = "listBoxInformationRoute";
            this.listBoxInformationRoute.Size = new System.Drawing.Size(248, 290);
            this.listBoxInformationRoute.TabIndex = 4;
            this.listBoxInformationRoute.SelectedIndexChanged += new System.EventHandler(this.listBoxNumberRoute_SelectedIndexChanged);
            // 
            // ModifyRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 352);
            this.Controls.Add(this.listBoxInformationRoute);
            this.Controls.Add(this.buttonModifyRoute);
            this.Controls.Add(this.textBoxModifyRoute);
            this.Controls.Add(this.comboBoxNumberRoute);
            this.Name = "ModifyRouteForm";
            this.Text = "ModifyRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNumberRoute;
        private System.Windows.Forms.TextBox textBoxModifyRoute;
        private System.Windows.Forms.Button buttonModifyRoute;
        private System.Windows.Forms.ListBox listBoxInformationRoute;
    }
}