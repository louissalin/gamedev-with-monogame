
using System;

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
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboLevelNb = new System.Windows.Forms.ComboBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.gameControl = new GameEditor.GameControl();
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
            this.objectTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectTabControl.Name = "objectTabControl";
            this.objectTabControl.SelectedIndex = 0;
            this.objectTabControl.Size = new System.Drawing.Size(311, 1018);
            this.objectTabControl.TabIndex = 1;
            // 
            // groundTabPage
            // 
            this.groundTabPage.Controls.Add(this.groundListView);
            this.groundTabPage.Location = new System.Drawing.Point(4, 25);
            this.groundTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groundTabPage.Name = "groundTabPage";
            this.groundTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groundTabPage.Size = new System.Drawing.Size(303, 989);
            this.groundTabPage.TabIndex = 0;
            this.groundTabPage.Text = "ground";
            this.groundTabPage.UseVisualStyleBackColor = true;
            // 
            // groundListView
            // 
            this.groundListView.HideSelection = false;
            this.groundListView.Location = new System.Drawing.Point(5, 2);
            this.groundListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buildingsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildingsTabPage.Name = "buildingsTabPage";
            this.buildingsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buildingsTabPage.Size = new System.Drawing.Size(303, 989);
            this.buildingsTabPage.TabIndex = 1;
            this.buildingsTabPage.Text = "buildings";
            this.buildingsTabPage.UseVisualStyleBackColor = true;
            // 
            // buildingsListView
            // 
            this.buildingsListView.HideSelection = false;
            this.buildingsListView.Location = new System.Drawing.Point(5, 4);
            this.buildingsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.objectsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectsTabPage.Name = "objectsTabPage";
            this.objectsTabPage.Size = new System.Drawing.Size(303, 989);
            this.objectsTabPage.TabIndex = 2;
            this.objectsTabPage.Text = "objects";
            this.objectsTabPage.UseVisualStyleBackColor = true;
            // 
            // objectsListView
            // 
            this.objectsListView.HideSelection = false;
            this.objectsListView.Location = new System.Drawing.Point(5, 4);
            this.objectsListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.objectsListView.Name = "objectsListView";
            this.objectsListView.Size = new System.Drawing.Size(291, 980);
            this.objectsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.objectsListView.TabIndex = 1;
            this.objectsListView.UseCompatibleStateImageBehavior = false;
            this.objectsListView.View = System.Windows.Forms.View.List;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(200, 37);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
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
            this.comboLevelNb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboLevelNb.Name = "comboLevelNb";
            this.comboLevelNb.Size = new System.Drawing.Size(121, 24);
            this.comboLevelNb.TabIndex = 3;
            this.comboLevelNb.SelectedIndexChanged += new System.EventHandler(this.comboLevelNb_SelectedIndexChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(283, 37);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // gameControl
            // 
            this.gameControl.CurrentAtlasName = null;
            this.gameControl.CurrentTileName = null;
            this.gameControl.Location = new System.Drawing.Point(15, 103);
            this.gameControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gameControl.MouseHoverUpdatesOnly = false;
            this.gameControl.Name = "gameControl";
            this.gameControl.Size = new System.Drawing.Size(1691, 865);
            this.gameControl.TabIndex = 0;
            this.gameControl.Text = "gameControl";
            // 
            // GameEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2067, 1042);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.comboLevelNb);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.objectTabControl);
            this.Controls.Add(this.gameControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboLevelNb;
        private System.Windows.Forms.Button buttonLoad;
    }
}

