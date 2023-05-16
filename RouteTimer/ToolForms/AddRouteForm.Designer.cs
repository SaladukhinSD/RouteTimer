namespace RouteTimer
{
    partial class AddRouteForm
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
            this.textBoxNumberRoute = new System.Windows.Forms.TextBox();
            this.textBoxAllTime = new System.Windows.Forms.TextBox();
            this.textBoxNameRoute = new System.Windows.Forms.TextBox();
            this.textBoxDirectionRoute = new System.Windows.Forms.TextBox();
            this.textBoxKindOfTransport = new System.Windows.Forms.TextBox();
            this.buttonAddRoute = new System.Windows.Forms.Button();
            this.textBoxDistanceAboutBusStopRoute = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxNumberRoute
            // 
            this.textBoxNumberRoute.Location = new System.Drawing.Point(39, 35);
            this.textBoxNumberRoute.Multiline = true;
            this.textBoxNumberRoute.Name = "textBoxNumberRoute";
            this.textBoxNumberRoute.Size = new System.Drawing.Size(223, 38);
            this.textBoxNumberRoute.TabIndex = 0;
            this.textBoxNumberRoute.Enter += new System.EventHandler(this.textBoxNumberRoute_Enter);
            this.textBoxNumberRoute.Leave += new System.EventHandler(this.textBoxNumberRoute_Leave);
            // 
            // textBoxAllTime
            // 
            this.textBoxAllTime.Location = new System.Drawing.Point(285, 35);
            this.textBoxAllTime.Multiline = true;
            this.textBoxAllTime.Name = "textBoxAllTime";
            this.textBoxAllTime.Size = new System.Drawing.Size(223, 306);
            this.textBoxAllTime.TabIndex = 4;
            this.textBoxAllTime.Enter += new System.EventHandler(this.textBoxAllTime_Enter);
            this.textBoxAllTime.Leave += new System.EventHandler(this.textBoxAllTime_Leave);
            // 
            // textBoxNameRoute
            // 
            this.textBoxNameRoute.Location = new System.Drawing.Point(39, 103);
            this.textBoxNameRoute.Multiline = true;
            this.textBoxNameRoute.Name = "textBoxNameRoute";
            this.textBoxNameRoute.Size = new System.Drawing.Size(223, 38);
            this.textBoxNameRoute.TabIndex = 5;
            this.textBoxNameRoute.Enter += new System.EventHandler(this.textBoxNameRoute_Enter);
            this.textBoxNameRoute.Leave += new System.EventHandler(this.textBoxNameRoute_Leave);
            // 
            // textBoxDirectionRoute
            // 
            this.textBoxDirectionRoute.Location = new System.Drawing.Point(39, 174);
            this.textBoxDirectionRoute.Multiline = true;
            this.textBoxDirectionRoute.Name = "textBoxDirectionRoute";
            this.textBoxDirectionRoute.Size = new System.Drawing.Size(223, 38);
            this.textBoxDirectionRoute.TabIndex = 6;
            this.textBoxDirectionRoute.Enter += new System.EventHandler(this.textBoxDirectionRoute_Enter);
            this.textBoxDirectionRoute.Leave += new System.EventHandler(this.textBoxDirectionRoute_Leave);
            // 
            // textBoxKindOfTransport
            // 
            this.textBoxKindOfTransport.Location = new System.Drawing.Point(39, 303);
            this.textBoxKindOfTransport.Multiline = true;
            this.textBoxKindOfTransport.Name = "textBoxKindOfTransport";
            this.textBoxKindOfTransport.Size = new System.Drawing.Size(223, 38);
            this.textBoxKindOfTransport.TabIndex = 7;
            this.textBoxKindOfTransport.Enter += new System.EventHandler(this.textBoxKindOfTransport_Enter);
            this.textBoxKindOfTransport.Leave += new System.EventHandler(this.textBoxKindOfTransport_Leave);
            // 
            // buttonAddRoute
            // 
            this.buttonAddRoute.Location = new System.Drawing.Point(39, 362);
            this.buttonAddRoute.Name = "buttonAddRoute";
            this.buttonAddRoute.Size = new System.Drawing.Size(469, 45);
            this.buttonAddRoute.TabIndex = 8;
            this.buttonAddRoute.Text = "Route data entry";
            this.buttonAddRoute.UseVisualStyleBackColor = true;
            this.buttonAddRoute.Click += new System.EventHandler(this.buttonAddRoute_Click);
            // 
            // textBoxDistanceAboutBusStopRoute
            // 
            this.textBoxDistanceAboutBusStopRoute.Location = new System.Drawing.Point(39, 239);
            this.textBoxDistanceAboutBusStopRoute.Multiline = true;
            this.textBoxDistanceAboutBusStopRoute.Name = "textBoxDistanceAboutBusStopRoute";
            this.textBoxDistanceAboutBusStopRoute.Size = new System.Drawing.Size(223, 38);
            this.textBoxDistanceAboutBusStopRoute.TabIndex = 9;
            this.textBoxDistanceAboutBusStopRoute.Enter += new System.EventHandler(this.textBoxDistanceAboutBusStopRoute_Enter);
            this.textBoxDistanceAboutBusStopRoute.Leave += new System.EventHandler(this.textBoxDistanceAboutBusStopRoute_Leave);
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 402);
            this.Controls.Add(this.textBoxDistanceAboutBusStopRoute);
            this.Controls.Add(this.buttonAddRoute);
            this.Controls.Add(this.textBoxKindOfTransport);
            this.Controls.Add(this.textBoxDirectionRoute);
            this.Controls.Add(this.textBoxNameRoute);
            this.Controls.Add(this.textBoxAllTime);
            this.Controls.Add(this.textBoxNumberRoute);
            this.Name = "AddRouteForm";
            this.Text = "AddRoute";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumberRoute;
        private System.Windows.Forms.TextBox textBoxAllTime;
        private System.Windows.Forms.TextBox textBoxNameRoute;
        private System.Windows.Forms.TextBox textBoxDirectionRoute;
        private System.Windows.Forms.TextBox textBoxKindOfTransport;
        private System.Windows.Forms.Button buttonAddRoute;
        private System.Windows.Forms.TextBox textBoxDistanceAboutBusStopRoute;
    }
}