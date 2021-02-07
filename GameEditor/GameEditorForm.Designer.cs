
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
            this.objectTabControl = new System.Windows.Forms.TabControl();
            this.groundTabPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groundListView = new System.Windows.Forms.ListView();
            this.objectTabControl.SuspendLayout();
            this.groundTabPage.SuspendLayout();
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
            // objectTabControl
            // 
            this.objectTabControl.Controls.Add(this.groundTabPage);
            this.objectTabControl.Controls.Add(this.tabPage2);
            this.objectTabControl.Location = new System.Drawing.Point(1287, 12);
            this.objectTabControl.Name = "objectTabControl";
            this.objectTabControl.SelectedIndex = 0;
            this.objectTabControl.Size = new System.Drawing.Size(311, 1018);
            this.objectTabControl.TabIndex = 1;
            // 
            // groundTabPage
            // 
            this.groundTabPage.Controls.Add(this.groundListView);
            this.groundTabPage.Location = new System.Drawing.Point(4, 25);
            this.groundTabPage.Name = "groundTabPage";
            this.groundTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.groundTabPage.Size = new System.Drawing.Size(303, 989);
            this.groundTabPage.TabIndex = 0;
            this.groundTabPage.Text = "ground";
            this.groundTabPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(303, 989);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groundListView
            // 
            this.groundListView.HideSelection = false;
            this.groundListView.Location = new System.Drawing.Point(6, 3);
            this.groundListView.Name = "groundListView";
            this.groundListView.Size = new System.Drawing.Size(291, 980);
            this.groundListView.TabIndex = 0;
            this.groundListView.UseCompatibleStateImageBehavior = false;
            // 
            // GameEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1610, 1042);
            this.Controls.Add(this.objectTabControl);
            this.Controls.Add(this.gameControl1);
            this.Name = "GameEditorForm";
            this.Text = "Game Editor";
            this.objectTabControl.ResumeLayout(false);
            this.groundTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GameControl gameControl1;
        private System.Windows.Forms.TabControl objectTabControl;
        private System.Windows.Forms.TabPage groundTabPage;
        private System.Windows.Forms.ListView groundListView;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

