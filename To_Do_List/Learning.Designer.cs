namespace To_Do_List
{
    partial class Learning
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemsParent = new System.Windows.Forms.Panel();
            this.TextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AddItemButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.AddItemButton)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ToDoList | Learning";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(11, 316);
            this.panel1.TabIndex = 1;
            // 
            // ItemsParent
            // 
            this.ItemsParent.AutoScroll = true;
            this.ItemsParent.Location = new System.Drawing.Point(17, 29);
            this.ItemsParent.Name = "ItemsParent";
            this.ItemsParent.Size = new System.Drawing.Size(633, 316);
            this.ItemsParent.TabIndex = 2;
            // 
            // TextBox
            // 
            this.TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox.HintForeColor = System.Drawing.Color.Empty;
            this.TextBox.HintText = "";
            this.TextBox.isPassword = false;
            this.TextBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.TextBox.LineIdleColor = System.Drawing.Color.Gray;
            this.TextBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.TextBox.LineThickness = 3;
            this.TextBox.Location = new System.Drawing.Point(17, 357);
            this.TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(555, 44);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.Transparent;
            this.AddItemButton.Image = global::To_Do_List.Properties.Resources.plus;
            this.AddItemButton.ImageActive = null;
            this.AddItemButton.Location = new System.Drawing.Point(582, 350);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(58, 58);
            this.AddItemButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddItemButton.TabIndex = 3;
            this.AddItemButton.TabStop = false;
            this.AddItemButton.Zoom = 10;
            this.AddItemButton.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Learning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.ItemsParent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Learning";
            this.Size = new System.Drawing.Size(650, 420);
            this.Load += new System.EventHandler(this.Learning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AddItemButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ItemsParent;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextBox;
        private Bunifu.Framework.UI.BunifuImageButton AddItemButton;
    }
}
