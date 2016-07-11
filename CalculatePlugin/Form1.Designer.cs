namespace CalculatePlugin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsPlugin = new System.Windows.Forms.ToolStripMenuItem();
            this.addPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumber1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumber2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lstFunction = new System.Windows.Forms.ListBox();
            this.btnOperate = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsPlugin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(382, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsPlugin
            // 
            this.mnsPlugin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPluginToolStripMenuItem});
            this.mnsPlugin.Name = "mnsPlugin";
            this.mnsPlugin.Size = new System.Drawing.Size(53, 20);
            this.mnsPlugin.Text = "PlugIn";
            // 
            // addPluginToolStripMenuItem
            // 
            this.addPluginToolStripMenuItem.Name = "addPluginToolStripMenuItem";
            this.addPluginToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.addPluginToolStripMenuItem.Text = "Add Plugin";
            this.addPluginToolStripMenuItem.Click += new System.EventHandler(this.addPluginToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First number";
            // 
            // txtnumber1
            // 
            this.txtnumber1.Location = new System.Drawing.Point(119, 42);
            this.txtnumber1.Name = "txtnumber1";
            this.txtnumber1.Size = new System.Drawing.Size(100, 20);
            this.txtnumber1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second number";
            // 
            // txtnumber2
            // 
            this.txtnumber2.Location = new System.Drawing.Point(119, 81);
            this.txtnumber2.Name = "txtnumber2";
            this.txtnumber2.Size = new System.Drawing.Size(100, 20);
            this.txtnumber2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select function";
            // 
            // lstFunction
            // 
            this.lstFunction.FormattingEnabled = true;
            this.lstFunction.Location = new System.Drawing.Point(26, 154);
            this.lstFunction.Name = "lstFunction";
            this.lstFunction.Size = new System.Drawing.Size(193, 95);
            this.lstFunction.TabIndex = 3;
            // 
            // btnOperate
            // 
            this.btnOperate.Location = new System.Drawing.Point(225, 226);
            this.btnOperate.Name = "btnOperate";
            this.btnOperate.Size = new System.Drawing.Size(75, 23);
            this.btnOperate.TabIndex = 4;
            this.btnOperate.Text = "Operate";
            this.btnOperate.UseVisualStyleBackColor = true;
            this.btnOperate.Click += new System.EventHandler(this.btnOperate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 261);
            this.Controls.Add(this.btnOperate);
            this.Controls.Add(this.lstFunction);
            this.Controls.Add(this.txtnumber2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumber1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsPlugin;
        private System.Windows.Forms.ToolStripMenuItem addPluginToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumber2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstFunction;
        private System.Windows.Forms.Button btnOperate;
    }
}

