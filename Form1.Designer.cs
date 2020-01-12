namespace Crom.Controls
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
            this.button1 = new System.Windows.Forms.Button();
            this.dockContainer1 = new Crom.Controls.DockContainer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dockContainer1
            // 
            this.dockContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dockContainer1.BackColor = System.Drawing.SystemColors.Window;
            this.dockContainer1.BottomPanelHeight = 150;
            this.dockContainer1.LeftPanelWidth = 150;
            this.dockContainer1.Location = new System.Drawing.Point(98, 2);
            this.dockContainer1.MinimumSize = new System.Drawing.Size(504, 518);
            this.dockContainer1.Name = "dockContainer1";
            this.dockContainer1.RightPanelWidth = 150;
            this.dockContainer1.SelectToolWindowsOnHoover = true;
            this.dockContainer1.Size = new System.Drawing.Size(723, 518);
            this.dockContainer1.TabButtonNotSelectedColor = System.Drawing.Color.DarkGray;
            this.dockContainer1.TabButtonSelectedBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.dockContainer1.TabButtonSelectedBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(157)))));
            this.dockContainer1.TabButtonSelectedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(111)))));
            this.dockContainer1.TabButtonSelectedColor = System.Drawing.Color.Black;
            this.dockContainer1.TabButtonShowSelection = false;
            this.dockContainer1.TabIndex = 0;
            this.dockContainer1.TopPanelHeight = 150;
            this.dockContainer1.Load += new System.EventHandler(this.dockContainer1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dockContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DockContainer dockContainer1;
        private System.Windows.Forms.Button button1;
    }
}