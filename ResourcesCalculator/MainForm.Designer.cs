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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpSupplyChain = new System.Windows.Forms.TabPage();
            this.tbpUserBuildings = new System.Windows.Forms.TabPage();
            this.ttMain = new System.Windows.Forms.ToolTip(this.components);
            this.tbpProfits = new System.Windows.Forms.TabPage();
            this.grbDailyTotals = new System.Windows.Forms.GroupBox();
            this.txtProfitTotals = new System.Windows.Forms.TextBox();
            this.lblDailyAll = new System.Windows.Forms.Label();
            this.txtMines = new System.Windows.Forms.TextBox();
            this.lblMines = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tbpProfits.SuspendLayout();
            this.grbDailyTotals.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpProfits);
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
            // tbpProfits
            // 
            this.tbpProfits.Controls.Add(this.grbDailyTotals);
            this.tbpProfits.Location = new System.Drawing.Point(4, 22);
            this.tbpProfits.Name = "tbpProfits";
            this.tbpProfits.Size = new System.Drawing.Size(946, 501);
            this.tbpProfits.TabIndex = 2;
            this.tbpProfits.Text = "Profitsssssss";
            this.tbpProfits.UseVisualStyleBackColor = true;
            // 
            // grbDailyTotals
            // 
            this.grbDailyTotals.Controls.Add(this.txtMines);
            this.grbDailyTotals.Controls.Add(this.lblMines);
            this.grbDailyTotals.Controls.Add(this.txtProfitTotals);
            this.grbDailyTotals.Controls.Add(this.lblDailyAll);
            this.grbDailyTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.grbDailyTotals.Location = new System.Drawing.Point(3, 3);
            this.grbDailyTotals.Name = "grbDailyTotals";
            this.grbDailyTotals.Size = new System.Drawing.Size(318, 198);
            this.grbDailyTotals.TabIndex = 1;
            this.grbDailyTotals.TabStop = false;
            this.grbDailyTotals.Text = "Daily Totals";
            // 
            // txtProfitTotals
            // 
            this.txtProfitTotals.Location = new System.Drawing.Point(137, 31);
            this.txtProfitTotals.Name = "txtProfitTotals";
            this.txtProfitTotals.ReadOnly = true;
            this.txtProfitTotals.Size = new System.Drawing.Size(175, 32);
            this.txtProfitTotals.TabIndex = 1;
            this.txtProfitTotals.WordWrap = false;
            // 
            // lblDailyAll
            // 
            this.lblDailyAll.AutoSize = true;
            this.lblDailyAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblDailyAll.Location = new System.Drawing.Point(6, 41);
            this.lblDailyAll.Name = "lblDailyAll";
            this.lblDailyAll.Size = new System.Drawing.Size(31, 17);
            this.lblDailyAll.TabIndex = 0;
            this.lblDailyAll.Text = "All:";
            // 
            // txtMines
            // 
            this.txtMines.Location = new System.Drawing.Point(137, 69);
            this.txtMines.Name = "txtMines";
            this.txtMines.ReadOnly = true;
            this.txtMines.Size = new System.Drawing.Size(175, 32);
            this.txtMines.TabIndex = 3;
            this.txtMines.WordWrap = false;
            // 
            // lblMines
            // 
            this.lblMines.AutoSize = true;
            this.lblMines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMines.Location = new System.Drawing.Point(6, 79);
            this.lblMines.Name = "lblMines";
            this.lblMines.Size = new System.Drawing.Size(55, 17);
            this.lblMines.TabIndex = 2;
            this.lblMines.Text = "Mines:";
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
            this.tbpProfits.ResumeLayout(false);
            this.grbDailyTotals.ResumeLayout(false);
            this.grbDailyTotals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpSupplyChain;
        private System.Windows.Forms.TabPage tbpUserBuildings;
        private System.Windows.Forms.TabPage tbpProfits;
        private System.Windows.Forms.GroupBox grbDailyTotals;
        private System.Windows.Forms.TextBox txtMines;
        private System.Windows.Forms.Label lblMines;
        private System.Windows.Forms.TextBox txtProfitTotals;
        private System.Windows.Forms.Label lblDailyAll;
        private System.Windows.Forms.ToolTip ttMain;
    }
}

