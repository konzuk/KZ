namespace Framework.Base.View
{
    partial class ContentView
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1141, 400);
            this.panelContent.TabIndex = 1;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFunctions.Location = new System.Drawing.Point(0, 400);
            this.panelFunctions.MaximumSize = new System.Drawing.Size(0, 90);
            this.panelFunctions.MinimumSize = new System.Drawing.Size(0, 90);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(1141, 90);
            this.panelFunctions.TabIndex = 0;
            this.panelFunctions.Visible = false;
            // 
            // ContentView
            // 
            this.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelFunctions);
            this.Name = "ContentView";
            this.Size = new System.Drawing.Size(1141, 490);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFunctions;
        public System.Windows.Forms.Panel panelContent;
    }
}
