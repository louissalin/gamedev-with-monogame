
namespace GameEditor
{
    partial class GameEditorForm
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
            this.gameControl1 = new GameEditor.GameControl();
            this.SuspendLayout();
            // 
            // gameControl1
            // 
            this.gameControl1.Location = new System.Drawing.Point(12, 12);
            this.gameControl1.MouseHoverUpdatesOnly = false;
            this.gameControl1.Name = "gameControl1";
            this.gameControl1.Size = new System.Drawing.Size(1269, 1018);
            this.gameControl1.TabIndex = 0;
            this.gameControl1.Text = "gameControl1";
            // 
            // GameEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 1042);
            this.Controls.Add(this.gameControl1);
            this.Name = "GameEditorForm";
            this.Text = "Game Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private GameControl gameControl1;
    }
}

