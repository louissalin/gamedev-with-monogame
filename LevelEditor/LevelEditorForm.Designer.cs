
namespace LevelEditor
{
    partial class LevelEditorForm
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
            this.gameScreen = new LevelEditor.GameScreen();
            this.atlasTilesTabs = new System.Windows.Forms.TabControl();
            this.tabGround = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabOther = new System.Windows.Forms.TabPage();
            this.atlasTilesTabs.SuspendLayout();
            this.tabGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gameScreen
            // 
            this.gameScreen.DrawInterval = 50;
            this.gameScreen.Location = new System.Drawing.Point(12, 12);
            this.gameScreen.MouseHoverUpdatesOnly = false;
            this.gameScreen.Name = "gameScreen";
            this.gameScreen.Size = new System.Drawing.Size(1280, 800);
            this.gameScreen.TabIndex = 0;
            this.gameScreen.Text = "draw test";
            // 
            // atlasTilesTabs
            // 
            this.atlasTilesTabs.Controls.Add(this.tabGround);
            this.atlasTilesTabs.Controls.Add(this.tabOther);
            this.atlasTilesTabs.Location = new System.Drawing.Point(1298, 12);
            this.atlasTilesTabs.Name = "atlasTilesTabs";
            this.atlasTilesTabs.SelectedIndex = 0;
            this.atlasTilesTabs.Size = new System.Drawing.Size(334, 800);
            this.atlasTilesTabs.TabIndex = 1;
            // 
            // tabGround
            // 
            this.tabGround.Controls.Add(this.pictureBox1);
            this.tabGround.Location = new System.Drawing.Point(4, 25);
            this.tabGround.Name = "tabGround";
            this.tabGround.Padding = new System.Windows.Forms.Padding(3);
            this.tabGround.Size = new System.Drawing.Size(326, 771);
            this.tabGround.TabIndex = 0;
            this.tabGround.Text = "ground";
            this.tabGround.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(80, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 72);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabOther
            // 
            this.tabOther.Location = new System.Drawing.Point(4, 25);
            this.tabOther.Name = "tabOther";
            this.tabOther.Padding = new System.Windows.Forms.Padding(3);
            this.tabOther.Size = new System.Drawing.Size(326, 771);
            this.tabOther.TabIndex = 1;
            this.tabOther.Text = "other";
            this.tabOther.UseVisualStyleBackColor = true;
            // 
            // LevelEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 832);
            this.Controls.Add(this.atlasTilesTabs);
            this.Controls.Add(this.gameScreen);
            this.Name = "LevelEditorForm";
            this.Text = "Level Editor";
            this.atlasTilesTabs.ResumeLayout(false);
            this.tabGround.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GameScreen gameScreen;
        private System.Windows.Forms.TabControl atlasTilesTabs;
        private System.Windows.Forms.TabPage tabGround;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabOther;
    }
}

