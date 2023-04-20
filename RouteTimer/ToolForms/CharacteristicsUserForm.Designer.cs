namespace RouteTimer
{
    partial class CharacteristicsUserForm
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
            this.textBoxSpeed = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEnterData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSpeed
            // 
            this.textBoxSpeed.Location = new System.Drawing.Point(164, 48);
            this.textBoxSpeed.Multiline = true;
            this.textBoxSpeed.Name = "textBoxSpeed";
            this.textBoxSpeed.Size = new System.Drawing.Size(117, 36);
            this.textBoxSpeed.TabIndex = 0;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(164, 147);
            this.textBoxMinutes.Multiline = true;
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(117, 36);
            this.textBoxMinutes.TabIndex = 1;
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Location = new System.Drawing.Point(164, 203);
            this.textBoxDistance.Multiline = true;
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.Size = new System.Drawing.Size(117, 36);
            this.textBoxDistance.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "km/h";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 141);
            this.label2.MaximumSize = new System.Drawing.Size(100, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Time in minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(7, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distance";
            // 
            // buttonEnterData
            // 
            this.buttonEnterData.Location = new System.Drawing.Point(37, 249);
            this.buttonEnterData.Name = "buttonEnterData";
            this.buttonEnterData.Size = new System.Drawing.Size(207, 39);
            this.buttonEnterData.TabIndex = 7;
            this.buttonEnterData.Text = "EnterData";
            this.buttonEnterData.UseVisualStyleBackColor = true;
            this.buttonEnterData.Click += new System.EventHandler(this.buttonEnterData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enter your walking speed ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Or your time and walking distance";
            // 
            // CharacteristicsUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEnterData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxSpeed);
            this.Name = "CharacteristicsUserForm";
            this.Text = "CharacteristicsUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSpeed;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEnterData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}