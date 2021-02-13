
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
            this.objectTabControl = new System.Windows.Forms.TabControl();
            this.groundTabPage = new System.Windows.Forms.TabPage();
            this.groundListView = new System.Windows.Forms.ListView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gameControl = new GameEditor.GameControl();
            this.objectTabControl.SuspendLayout();
            this.groundTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectTabControl
            // 
            this.objectTabControl.Controls.Add(this.groundTabPage);
            this.objectTabControl.Controls.Add(this.tabPage2);
            this.objectTabControl.Location = new System.Drawing.Point(1298, 12);
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
            // groundListView
            // 
            this.groundListView.HideSelection = false;
            this.groundListView.Location = new System.Drawing.Point(6, 3);
            this.groundListView.Name = "groundListView";
            this.groundListView.Size = new System.Drawing.Size(291, 980);
            this.groundListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.groundListView.TabIndex = 0;
            this.groundListView.UseCompatibleStateImageBehavior = false;
            this.groundListView.View = System.Windows.Forms.View.List;
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
            // gameControl
            // 
            this.gameControl.CurrentAtlasName = null;
            this.gameControl.CurrentTileName = null;
            this.gameControl.Location = new System.Drawing.Point(12, 12);
            this.gameControl.MouseHoverUpdatesOnly = false;
            this.gameControl.Name = "gameControl";
            this.gameControl.Size = new System.Drawing.Size(1280, 720);
            this.gameControl.TabIndex = 0;
            this.gameControl.Text = "gameControl";
            // 
            // GameEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 1042);
            this.Controls.Add(this.objectTabControl);
            this.Controls.Add(this.gameControl);
            this.Name = "GameEditorForm";
            this.Text = "Game Editor";
            this.objectTabControl.ResumeLayout(false);
            this.groundTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GameControl gameControl;
        private System.Windows.Forms.TabControl objectTabControl;
        private System.Windows.Forms.TabPage groundTabPage;
        private System.Windows.Forms.ListView groundListView;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

