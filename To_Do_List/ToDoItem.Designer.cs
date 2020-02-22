namespace To_Do_List
{
    partial class ToDoItem
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Label = new System.Windows.Forms.Label();
            this.DoneButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.DeleteButton = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DoneButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Label
            // 
            this.Label.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label.ForeColor = System.Drawing.Color.White;
            this.Label.Location = new System.Drawing.Point(10, 14);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(513, 33);
            this.Label.TabIndex = 0;
            this.Label.Text = "Text";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.Color.Transparent;
            this.DoneButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DoneButton.Image = global::To_Do_List.Properties.Resources.unnamed;
            this.DoneButton.ImageActive = null;
            this.DoneButton.Location = new System.Drawing.Point(521, 0);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(40, 65);
            this.DoneButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DoneButton.TabIndex = 3;
            this.DoneButton.TabStop = false;
            this.DoneButton.Zoom = 0;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteButton.Image = global::To_Do_List.Properties.Resources.trash_can_icon_24;
            this.DeleteButton.ImageActive = null;
            this.DeleteButton.Location = new System.Drawing.Point(561, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(40, 65);
            this.DeleteButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Zoom = 0;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ToDoItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(71)))), ((int)(((byte)(127)))));
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Label);
            this.Name = "ToDoItem";
            this.Size = new System.Drawing.Size(601, 65);
            ((System.ComponentModel.ISupportInitialize)(this.DoneButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label Label;
        private Bunifu.Framework.UI.BunifuImageButton DeleteButton;
        private Bunifu.Framework.UI.BunifuImageButton DoneButton;
    }
}
