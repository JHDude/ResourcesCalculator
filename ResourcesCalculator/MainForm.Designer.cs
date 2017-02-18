namespace ResourcesCalculator
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpSupplyChain = new System.Windows.Forms.TabPage();
            this.tbpUserBuildings = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpSupplyChain);
            this.tabControl1.Controls.Add(this.tbpUserBuildings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(954, 527);
            this.tabControl1.TabIndex = 0;
            // 
            // tbpSupplyChain
            // 
            this.tbpSupplyChain.BackColor = System.Drawing.Color.Transparent;
            this.tbpSupplyChain.Location = new System.Drawing.Point(4, 22);
            this.tbpSupplyChain.Name = "tbpSupplyChain";
            this.tbpSupplyChain.Padding = new System.Windows.Forms.Padding(3);
            this.tbpSupplyChain.Size = new System.Drawing.Size(946, 501);
            this.tbpSupplyChain.TabIndex = 0;
            this.tbpSupplyChain.Text = "Supply Chain";
            // 
            // tbpUserBuildings
            // 
            this.tbpUserBuildings.Location = new System.Drawing.Point(4, 22);
            this.tbpUserBuildings.Name = "tbpUserBuildings";
            this.tbpUserBuildings.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUserBuildings.Size = new System.Drawing.Size(946, 501);
            this.tbpUserBuildings.TabIndex = 1;
            this.tbpUserBuildings.Text = "User Buildings";
            this.tbpUserBuildings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 551);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Resource Calculator";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpSupplyChain;
        private System.Windows.Forms.TabPage tbpUserBuildings;
    }
}

