
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
            this.buildingsTabPage = new System.Windows.Forms.TabPage();
            this.buildingsListView = new System.Windows.Forms.ListView();
            this.objectsTabPage = new System.Windows.Forms.TabPage();
            this.objectsListView = new System.Windows.Forms.ListView();
            this.gameControl = new GameEditor.GameControl();
            this.button1 = new System.Windows.Forms.Button();
            this.comboLevelNb = new System.Windows.Forms.ComboBox();
            this.objectTabControl.SuspendLayout();
            this.groundTabPage.SuspendLayout();
            this.buildingsTabPage.SuspendLayout();
            this.objectsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectTabControl
            // 
            this.objectTabControl.Controls.Add(this.groundTabPage);
            this.objectTabControl.Controls.Add(this.buildingsTabPage);
            this.objectTabControl.Controls.Add(this.objectsTabPage);
            this.objectTabControl.Location = new System.Drawing.Point(1744, 12);
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
            // buildingsTabPage
            // 
            this.buildingsTabPage.Controls.Add(this.buildingsListView);
            this.buildingsTabPage.Location = new System.Drawing.Point(4, 25);
            this.buildingsTabPage.Name = "buildingsTabPage";
            this.buildingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.buildingsTabPage.Size = new System.Drawing.Size(303, 989);
            this.buildingsTabPage.TabIndex = 1;
            this.buildingsTabPage.Text = "buildings";
            this.buildingsTabPage.UseVisualStyleBackColor = true;
            // 
            // buildingsListView
            // 
            this.buildingsListView.HideSelection = false;
            this.buildingsListView.Location = new System.Drawing.Point(6, 4);
            this.buildingsListView.Name = "buildingsListView";
            this.buildingsListView.Size = new System.Drawing.Size(291, 980);
            this.buildingsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.buildingsListView.TabIndex = 1;
            this.buildingsListView.UseCompatibleStateImageBehavior = false;
            this.buildingsListView.View = System.Windows.Forms.View.List;
            // 
            // objectsTabPage
            // 
            this.objectsTabPage.Controls.Add(this.objectsListView);
            this.objectsTabPage.Location = new System.Drawing.Point(4, 25);
            this.objectsTabPage.Name = "objectsTabPage";
            this.objectsTabPage.Size = new System.Drawing.Size(303, 989);
            this.objectsTabPage.TabIndex = 2;
            this.objectsTabPage.Text = "objects";
            this.objectsTabPage.UseVisualStyleBackColor = true;
            // 
            // objectsListView
            // 
            this.objectsListView.HideSelection = false;
            this.objectsListView.Location = new System.Drawing.Point(6, 4);
            this.objectsListView.Name = "objectsListView";
            this.objectsListView.Size = new System.Drawing.Size(291, 980);
            this.objectsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectsListView.TabIndex = 1;
            this.objectsListView.UseCompatibleStateImageBehavior = false;
            this.objectsListView.View = System.Windows.Forms.View.List;
            // 
            // gameControl
            // 
            this.gameControl.CurrentAtlasName = null;
            this.gameControl.CurrentTileName = null;
            this.gameControl.Location = new System.Drawing.Point(12, 161);
            this.gameControl.MouseHoverUpdatesOnly = false;
            this.gameControl.Name = "gameControl";
            this.gameControl.Size = new System.Drawing.Size(1691, 865);
            this.gameControl.TabIndex = 0;
            this.gameControl.Text = "gameControl";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboLevelNb
            // 
            this.comboLevelNb.FormattingEnabled = true;
            this.comboLevelNb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboLevelNb.Location = new System.Drawing.Point(73, 36);
            this.comboLevelNb.Name = "comboLevelNb";
            this.comboLevelNb.Size = new System.Drawing.Size(121, 24);
            this.comboLevelNb.TabIndex = 3;
            // 
            // GameEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2067, 1042);
            this.Controls.Add(this.comboLevelNb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.objectTabControl);
            this.Controls.Add(this.gameControl);
            this.Name = "GameEditorForm";
            this.Text = "Game Editor";
            this.objectTabControl.ResumeLayout(false);
            this.groundTabPage.ResumeLayout(false);
            this.buildingsTabPage.ResumeLayout(false);
            this.objectsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GameControl gameControl;
        private System.Windows.Forms.TabControl objectTabControl;
        private System.Windows.Forms.TabPage groundTabPage;
        private System.Windows.Forms.ListView groundListView;
        private System.Windows.Forms.TabPage buildingsTabPage;
        private System.Windows.Forms.ListView buildingsListView;
        private System.Windows.Forms.TabPage objectsTabPage;
        private System.Windows.Forms.ListView objectsListView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboLevelNb;
    }
}

