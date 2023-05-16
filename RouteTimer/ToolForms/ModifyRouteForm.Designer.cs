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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxNumberRoute
            // 
            this.comboBoxNumberRoute.FormattingEnabled = true;
            this.comboBoxNumberRoute.Location = new System.Drawing.Point(294, 48);
            this.comboBoxNumberRoute.Name = "comboBoxNumberRoute";
            this.comboBoxNumberRoute.Size = new System.Drawing.Size(189, 21);
            this.comboBoxNumberRoute.TabIndex = 0;
            this.comboBoxNumberRoute.SelectedIndexChanged += new System.EventHandler(this.comboBoxNumberRoute_SelectedIndexChanged);
            // 
            // textBoxModifyRoute
            // 
            this.textBoxModifyRoute.Location = new System.Drawing.Point(294, 114);
            this.textBoxModifyRoute.Multiline = true;
            this.textBoxModifyRoute.Name = "textBoxModifyRoute";
            this.textBoxModifyRoute.Size = new System.Drawing.Size(189, 187);
            this.textBoxModifyRoute.TabIndex = 2;
            // 
            // buttonModifyRoute
            // 
            this.buttonModifyRoute.Location = new System.Drawing.Point(294, 319);
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
            this.listBoxInformationRoute.Location = new System.Drawing.Point(12, 49);
            this.listBoxInformationRoute.Name = "listBoxInformationRoute";
            this.listBoxInformationRoute.Size = new System.Drawing.Size(248, 316);
            this.listBoxInformationRoute.TabIndex = 4;
            this.listBoxInformationRoute.SelectedIndexChanged += new System.EventHandler(this.listBoxNumberRoute_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Choose number route";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Edit data";
            // 
            // ModifyRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}