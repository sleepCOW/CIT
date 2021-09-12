
namespace CITUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.InsertBT = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.PathList = new System.Windows.Forms.ListBox();
            this.RemoveDirBT = new System.Windows.Forms.Button();
            this.AddDirBT = new System.Windows.Forms.Button();
            this.RecursiveCB = new System.Windows.Forms.CheckBox();
            this.AllExtensionCB = new System.Windows.Forms.CheckBox();
            this.ExtensionBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddExtensionBT = new System.Windows.Forms.Button();
            this.RemoveExtensionBT = new System.Windows.Forms.Button();
            this.ExtensionInput = new System.Windows.Forms.TextBox();
            this.OpenTSBT = new System.Windows.Forms.ToolStripButton();
            this.SaveTSBT = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InsertBT
            // 
            this.InsertBT.Location = new System.Drawing.Point(375, 400);
            this.InsertBT.Name = "InsertBT";
            this.InsertBT.Size = new System.Drawing.Size(100, 23);
            this.InsertBT.TabIndex = 0;
            this.InsertBT.Text = "Insert";
            this.InsertBT.UseVisualStyleBackColor = true;
            this.InsertBT.Click += new System.EventHandler(this.InsertBT_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 43);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(355, 100);
            this.TextBox.TabIndex = 1;
            this.TextBox.WordWrap = false;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(12, 25);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(74, 15);
            this.TextLabel.TabIndex = 2;
            this.TextLabel.Text = "Text to insert";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTSBT,
            this.SaveTSBT});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(486, 25);
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // PathList
            // 
            this.PathList.FormattingEnabled = true;
            this.PathList.ItemHeight = 15;
            this.PathList.Location = new System.Drawing.Point(13, 164);
            this.PathList.Name = "PathList";
            this.PathList.Size = new System.Drawing.Size(355, 94);
            this.PathList.TabIndex = 5;
            // 
            // RemoveDirBT
            // 
            this.RemoveDirBT.Location = new System.Drawing.Point(373, 193);
            this.RemoveDirBT.Name = "RemoveDirBT";
            this.RemoveDirBT.Size = new System.Drawing.Size(102, 23);
            this.RemoveDirBT.TabIndex = 6;
            this.RemoveDirBT.Text = "Remove";
            this.RemoveDirBT.UseVisualStyleBackColor = true;
            this.RemoveDirBT.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddDirBT
            // 
            this.AddDirBT.Location = new System.Drawing.Point(374, 164);
            this.AddDirBT.Name = "AddDirBT";
            this.AddDirBT.Size = new System.Drawing.Size(101, 23);
            this.AddDirBT.TabIndex = 7;
            this.AddDirBT.Text = "Add";
            this.AddDirBT.UseVisualStyleBackColor = true;
            this.AddDirBT.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RecursiveCB
            // 
            this.RecursiveCB.AutoSize = true;
            this.RecursiveCB.Location = new System.Drawing.Point(13, 379);
            this.RecursiveCB.Name = "RecursiveCB";
            this.RecursiveCB.Size = new System.Drawing.Size(76, 19);
            this.RecursiveCB.TabIndex = 8;
            this.RecursiveCB.Text = "Recursive";
            this.RecursiveCB.UseVisualStyleBackColor = true;
            // 
            // AllExtensionCB
            // 
            this.AllExtensionCB.AutoSize = true;
            this.AllExtensionCB.Location = new System.Drawing.Point(13, 404);
            this.AllExtensionCB.Name = "AllExtensionCB";
            this.AllExtensionCB.Size = new System.Drawing.Size(94, 19);
            this.AllExtensionCB.TabIndex = 9;
            this.AllExtensionCB.Text = "All extension";
            this.AllExtensionCB.UseVisualStyleBackColor = true;
            // 
            // ExtensionBox
            // 
            this.ExtensionBox.FormattingEnabled = true;
            this.ExtensionBox.ItemHeight = 15;
            this.ExtensionBox.Location = new System.Drawing.Point(13, 279);
            this.ExtensionBox.Name = "ExtensionBox";
            this.ExtensionBox.Size = new System.Drawing.Size(355, 94);
            this.ExtensionBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Directories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Extensions";
            // 
            // AddExtensionBT
            // 
            this.AddExtensionBT.Location = new System.Drawing.Point(374, 308);
            this.AddExtensionBT.Name = "AddExtensionBT";
            this.AddExtensionBT.Size = new System.Drawing.Size(101, 23);
            this.AddExtensionBT.TabIndex = 13;
            this.AddExtensionBT.Text = "Add";
            this.AddExtensionBT.UseVisualStyleBackColor = true;
            this.AddExtensionBT.Click += new System.EventHandler(this.AddExtensionBT_Click);
            // 
            // RemoveExtensionBT
            // 
            this.RemoveExtensionBT.Location = new System.Drawing.Point(374, 337);
            this.RemoveExtensionBT.Name = "RemoveExtensionBT";
            this.RemoveExtensionBT.Size = new System.Drawing.Size(101, 23);
            this.RemoveExtensionBT.TabIndex = 14;
            this.RemoveExtensionBT.Text = "Remove";
            this.RemoveExtensionBT.UseVisualStyleBackColor = true;
            this.RemoveExtensionBT.Click += new System.EventHandler(this.RemoveExtensionBT_Click);
            // 
            // ExtensionInput
            // 
            this.ExtensionInput.Location = new System.Drawing.Point(375, 279);
            this.ExtensionInput.Name = "ExtensionInput";
            this.ExtensionInput.Size = new System.Drawing.Size(100, 23);
            this.ExtensionInput.TabIndex = 15;
            // 
            // OpenTSBT
            // 
            this.OpenTSBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenTSBT.Image = ((System.Drawing.Image)(resources.GetObject("OpenTSBT.Image")));
            this.OpenTSBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenTSBT.Name = "OpenTSBT";
            this.OpenTSBT.Size = new System.Drawing.Size(23, 22);
            this.OpenTSBT.Text = "Open";
            this.OpenTSBT.Click += new System.EventHandler(this.OpenTSBT_Click);
            // 
            // SaveTSBT
            // 
            this.SaveTSBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveTSBT.Image = ((System.Drawing.Image)(resources.GetObject("SaveTSBT.Image")));
            this.SaveTSBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveTSBT.Name = "SaveTSBT";
            this.SaveTSBT.Size = new System.Drawing.Size(23, 22);
            this.SaveTSBT.Text = "toolStripButton2";
            this.SaveTSBT.ToolTipText = "Save";
            this.SaveTSBT.Click += new System.EventHandler(this.SaveTSBT_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 436);
            this.Controls.Add(this.ExtensionInput);
            this.Controls.Add(this.RemoveExtensionBT);
            this.Controls.Add(this.AddExtensionBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExtensionBox);
            this.Controls.Add(this.AllExtensionCB);
            this.Controls.Add(this.RecursiveCB);
            this.Controls.Add(this.AddDirBT);
            this.Controls.Add(this.RemoveDirBT);
            this.Controls.Add(this.PathList);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.InsertBT);
            this.Name = "MainWindow";
            this.Text = "Comment Insert Tool";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertBT;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ListBox PathList;
        private System.Windows.Forms.Button RemoveDirBT;
        private System.Windows.Forms.Button AddDirBT;
        private System.Windows.Forms.CheckBox RecursiveCB;
        private System.Windows.Forms.CheckBox AllExtensionCB;
        private System.Windows.Forms.ListBox ExtensionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddExtensionBT;
        private System.Windows.Forms.Button RemoveExtensionBT;
        private System.Windows.Forms.TextBox ExtensionInput;
        private System.Windows.Forms.ToolStripButton OpenTSBT;
        private System.Windows.Forms.ToolStripButton SaveTSBT;
    }
}

