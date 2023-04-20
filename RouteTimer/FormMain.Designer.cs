namespace RouteTimer
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxSchedule = new System.Windows.Forms.ListBox();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.buttonModifyRoute = new System.Windows.Forms.Button();
            this.buttonDeliteRoute = new System.Windows.Forms.Button();
            this.buttonInformationRoute = new System.Windows.Forms.Button();
            this.buttonUserCharacteristics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxSchedule
            // 
            this.listBoxSchedule.Font = new System.Drawing.Font("Palatino Linotype", 16F);
            this.listBoxSchedule.FormattingEnabled = true;
            this.listBoxSchedule.HorizontalScrollbar = true;
            this.listBoxSchedule.ItemHeight = 28;
            this.listBoxSchedule.Location = new System.Drawing.Point(13, 34);
            this.listBoxSchedule.Name = "listBoxSchedule";
            this.listBoxSchedule.ScrollAlwaysVisible = true;
            this.listBoxSchedule.Size = new System.Drawing.Size(286, 368);
            this.listBoxSchedule.TabIndex = 0;
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.Location = new System.Drawing.Point(321, 34);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(132, 51);
            this.buttonAddRoute.TabIndex = 1;
            this.buttonAddRoute.Text = "Add route";
            this.buttonAddRoute.UseVisualStyleBackColor = true;
            this.buttonAddRoute.Click += new System.EventHandler(this.ButtonAddRoute_Click);
            // 
            // buttonModifyRoute
            // 
            this.buttonModifyRoute.Location = new System.Drawing.Point(321, 102);
            this.buttonModifyRoute.Name = "buttonModifyRoute";
            this.buttonModifyRoute.Size = new System.Drawing.Size(132, 51);
            this.buttonModifyRoute.TabIndex = 2;
            this.buttonModifyRoute.Text = "Modify route";
            this.buttonModifyRoute.UseVisualStyleBackColor = true;
            this.buttonModifyRoute.Click += new System.EventHandler(this.buttonModifyRoute_Click);
            // 
            // buttonDeliteRoute
            // 
            this.buttonDeliteRoute.Location = new System.Drawing.Point(321, 172);
            this.buttonDeliteRoute.Name = "buttonDeliteRoute";
            this.buttonDeliteRoute.Size = new System.Drawing.Size(132, 51);
            this.buttonDeliteRoute.TabIndex = 3;
            this.buttonDeliteRoute.Text = "Delite route";
            this.buttonDeliteRoute.UseVisualStyleBackColor = true;
            this.buttonDeliteRoute.Click += new System.EventHandler(this.buttonDeliteRoute_Click);
            // 
            // buttonInformationRoute
            // 
            this.buttonInformationRoute.Location = new System.Drawing.Point(321, 242);
            this.buttonInformationRoute.Name = "buttonInformationRoute";
            this.buttonInformationRoute.Size = new System.Drawing.Size(132, 51);
            this.buttonInformationRoute.TabIndex = 4;
            this.buttonInformationRoute.Text = "Information about route";
            this.buttonInformationRoute.UseVisualStyleBackColor = true;
            this.buttonInformationRoute.Click += new System.EventHandler(this.buttonInformationRoute_Click);
            // 
            // buttonUserCharacteristics
            // 
            this.buttonUserCharacteristics.Location = new System.Drawing.Point(321, 311);
            this.buttonUserCharacteristics.Name = "buttonUserCharacteristics";
            this.buttonUserCharacteristics.Size = new System.Drawing.Size(132, 51);
            this.buttonUserCharacteristics.TabIndex = 5;
            this.buttonUserCharacteristics.Text = "User characteristicts";
            this.buttonUserCharacteristics.UseVisualStyleBackColor = true;
            this.buttonUserCharacteristics.Click += new System.EventHandler(this.buttonUserCharacteristics_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.buttonUserCharacteristics);
            this.Controls.Add(this.buttonInformationRoute);
            this.Controls.Add(this.buttonDeliteRoute);
            this.Controls.Add(this.buttonModifyRoute);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.listBoxSchedule);
            this.Name = "FormMain";
            this.Text = "RouteTimer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSchedule;
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.Button buttonModifyRoute;
        private System.Windows.Forms.Button buttonDeliteRoute;
        private System.Windows.Forms.Button buttonInformationRoute;
        private System.Windows.Forms.Button buttonUserCharacteristics;
    }
}

