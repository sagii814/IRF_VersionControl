namespace week08
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ballButton = new System.Windows.Forms.Button();
            this.carButton = new System.Windows.Forms.Button();
            this.colorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(0, 292);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 158);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coming next:";
            // 
            // ballButton
            // 
            this.ballButton.Location = new System.Drawing.Point(13, 13);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(75, 33);
            this.ballButton.TabIndex = 2;
            this.ballButton.Text = "Ball";
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(95, 13);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(75, 33);
            this.carButton.TabIndex = 3;
            this.carButton.Text = "Car";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Firebrick;
            this.colorButton.Location = new System.Drawing.Point(191, 13);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(58, 33);
            this.colorButton.TabIndex = 4;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.carButton);
            this.Controls.Add(this.ballButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Button colorButton;
    }
}

