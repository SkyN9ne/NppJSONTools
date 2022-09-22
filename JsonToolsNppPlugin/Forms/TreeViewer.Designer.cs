﻿namespace JSON_Tools.Forms
{
    partial class TreeViewer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeViewer));
            this.Tree = new System.Windows.Forms.TreeView();
            this.TypeIconList = new System.Windows.Forms.ImageList(this.components);
            this.QueryBox = new System.Windows.Forms.TextBox();
            this.SubmitQueryButton = new System.Windows.Forms.Button();
            this.SaveQueryButton = new System.Windows.Forms.Button();
            this.QueryToCsvButton = new System.Windows.Forms.Button();
            this.FullTreeCheckBox = new System.Windows.Forms.CheckBox();
            this.NodeRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyValueMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyKeyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JavaScriptStyleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PythonStyleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemesPathStyleItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPathItem = new System.Windows.Forms.ToolStripMenuItem();
            this.JavaScriptStyleKeyItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PythonStylePathItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemesPathStylePathItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NodeRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tree
            // 
            this.Tree.Location = new System.Drawing.Point(4, 91);
            this.Tree.Name = "Tree";
            this.Tree.Size = new System.Drawing.Size(398, 534);
            this.Tree.TabIndex = 0;
            this.Tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Tree_NodeMouseClick);
            // 
            // TypeIconList
            // 
            this.TypeIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TypeIconList.ImageStream")));
            this.TypeIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.TypeIconList.Images.SetKeyName(0, "array type icon.PNG");
            this.TypeIconList.Images.SetKeyName(1, "bool type icon.PNG");
            this.TypeIconList.Images.SetKeyName(2, "date type icon.PNG");
            this.TypeIconList.Images.SetKeyName(3, "float type icon.PNG");
            this.TypeIconList.Images.SetKeyName(4, "int type icon.PNG");
            this.TypeIconList.Images.SetKeyName(5, "object type icon.PNG");
            this.TypeIconList.Images.SetKeyName(6, "string type icon.PNG");
            this.TypeIconList.Images.SetKeyName(7, "null type icon.PNG");
            // 
            // QueryBox
            // 
            this.QueryBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.QueryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBox.Location = new System.Drawing.Point(4, 4);
            this.QueryBox.Multiline = true;
            this.QueryBox.Name = "QueryBox";
            this.QueryBox.Size = new System.Drawing.Size(164, 74);
            this.QueryBox.TabIndex = 0;
            this.QueryBox.Text = "@";
            // 
            // SubmitQueryButton
            // 
            this.SubmitQueryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitQueryButton.Location = new System.Drawing.Point(174, 4);
            this.SubmitQueryButton.Name = "SubmitQueryButton";
            this.SubmitQueryButton.Size = new System.Drawing.Size(119, 26);
            this.SubmitQueryButton.TabIndex = 1;
            this.SubmitQueryButton.Text = "Submit query";
            this.SubmitQueryButton.UseVisualStyleBackColor = true;
            this.SubmitQueryButton.Click += new System.EventHandler(this.SubmitQueryButton_Click);
            // 
            // SaveQueryButton
            // 
            this.SaveQueryButton.Location = new System.Drawing.Point(174, 36);
            this.SaveQueryButton.Name = "SaveQueryButton";
            this.SaveQueryButton.Size = new System.Drawing.Size(119, 27);
            this.SaveQueryButton.TabIndex = 2;
            this.SaveQueryButton.Text = "Save query result";
            this.SaveQueryButton.UseVisualStyleBackColor = true;
            this.SaveQueryButton.Click += new System.EventHandler(this.SaveQueryResultButton_Click);
            // 
            // QueryToCsvButton
            // 
            this.QueryToCsvButton.Location = new System.Drawing.Point(299, 4);
            this.QueryToCsvButton.Name = "QueryToCsvButton";
            this.QueryToCsvButton.Size = new System.Drawing.Size(103, 26);
            this.QueryToCsvButton.TabIndex = 3;
            this.QueryToCsvButton.Text = "Query to CSV";
            this.QueryToCsvButton.UseVisualStyleBackColor = true;
            this.QueryToCsvButton.Click += new System.EventHandler(this.QueryToCsvButton_Click);
            // 
            // FullTreeCheckBox
            // 
            this.FullTreeCheckBox.AutoSize = true;
            this.FullTreeCheckBox.Location = new System.Drawing.Point(174, 69);
            this.FullTreeCheckBox.Name = "FullTreeCheckBox";
            this.FullTreeCheckBox.Size = new System.Drawing.Size(130, 20);
            this.FullTreeCheckBox.TabIndex = 4;
            this.FullTreeCheckBox.Text = "View all subtrees";
            this.FullTreeCheckBox.UseVisualStyleBackColor = true;
            this.FullTreeCheckBox.CheckedChanged += new System.EventHandler(this.FullTreeCheckBox_CheckedChanged);
            // 
            // NodeRightClickMenu
            // 
            this.NodeRightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.NodeRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyValueMenuItem,
            this.CopyKeyItem,
            this.CopyPathItem});
            this.NodeRightClickMenu.Name = "NodeRightClickMenu";
            this.NodeRightClickMenu.Size = new System.Drawing.Size(231, 76);
            // 
            // CopyValueMenuItem
            // 
            this.CopyValueMenuItem.Name = "CopyValueMenuItem";
            this.CopyValueMenuItem.Size = new System.Drawing.Size(230, 24);
            this.CopyValueMenuItem.Text = "Value to clipboard";
            // 
            // CopyKeyItem
            // 
            this.CopyKeyItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JavaScriptStyleItem,
            this.PythonStyleItem,
            this.RemesPathStyleItem});
            this.CopyKeyItem.Name = "CopyKeyItem";
            this.CopyKeyItem.Size = new System.Drawing.Size(230, 24);
            this.CopyKeyItem.Text = "Key/index to clipboard";
            // 
            // JavaScriptStyleItem
            // 
            this.JavaScriptStyleItem.Name = "JavaScriptStyleItem";
            this.JavaScriptStyleItem.Size = new System.Drawing.Size(198, 26);
            this.JavaScriptStyleItem.Text = "JavaScript style";
            // 
            // PythonStyleItem
            // 
            this.PythonStyleItem.Name = "PythonStyleItem";
            this.PythonStyleItem.Size = new System.Drawing.Size(198, 26);
            this.PythonStyleItem.Text = "Python style";
            // 
            // RemesPathStyleItem
            // 
            this.RemesPathStyleItem.Name = "RemesPathStyleItem";
            this.RemesPathStyleItem.Size = new System.Drawing.Size(198, 26);
            this.RemesPathStyleItem.Text = "RemesPath style";
            // 
            // CopyPathItem
            // 
            this.CopyPathItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.JavaScriptStyleKeyItem,
            this.PythonStylePathItem,
            this.RemesPathStylePathItem});
            this.CopyPathItem.Name = "CopyPathItem";
            this.CopyPathItem.Size = new System.Drawing.Size(230, 24);
            this.CopyPathItem.Text = "Path to clipboard";
            // 
            // JavaScriptStyleKeyItem
            // 
            this.JavaScriptStyleKeyItem.Name = "JavaScriptStyleKeyItem";
            this.JavaScriptStyleKeyItem.Size = new System.Drawing.Size(198, 26);
            this.JavaScriptStyleKeyItem.Text = "JavaScript style";
            // 
            // PythonStylePathItem
            // 
            this.PythonStylePathItem.Name = "PythonStylePathItem";
            this.PythonStylePathItem.Size = new System.Drawing.Size(198, 26);
            this.PythonStylePathItem.Text = "Python style";
            // 
            // RemesPathStylePathItem
            // 
            this.RemesPathStylePathItem.Name = "RemesPathStylePathItem";
            this.RemesPathStylePathItem.Size = new System.Drawing.Size(198, 26);
            this.RemesPathStylePathItem.Text = "RemesPath style";
            // 
            // TreeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 631);
            this.Controls.Add(this.FullTreeCheckBox);
            this.Controls.Add(this.QueryToCsvButton);
            this.Controls.Add(this.SaveQueryButton);
            this.Controls.Add(this.SubmitQueryButton);
            this.Controls.Add(this.QueryBox);
            this.Controls.Add(this.Tree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TreeViewer";
            this.Text = "TreeViewer";
            this.NodeRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView Tree;
        private System.Windows.Forms.ImageList TypeIconList;
        private System.Windows.Forms.TextBox QueryBox;
        private System.Windows.Forms.Button SubmitQueryButton;
        private System.Windows.Forms.Button SaveQueryButton;
        private System.Windows.Forms.Button QueryToCsvButton;
        private System.Windows.Forms.CheckBox FullTreeCheckBox;
        private System.Windows.Forms.ContextMenuStrip NodeRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyValueMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyKeyItem;
        private System.Windows.Forms.ToolStripMenuItem JavaScriptStyleItem;
        private System.Windows.Forms.ToolStripMenuItem PythonStyleItem;
        private System.Windows.Forms.ToolStripMenuItem RemesPathStyleItem;
        private System.Windows.Forms.ToolStripMenuItem CopyPathItem;
        private System.Windows.Forms.ToolStripMenuItem JavaScriptStyleKeyItem;
        private System.Windows.Forms.ToolStripMenuItem PythonStylePathItem;
        private System.Windows.Forms.ToolStripMenuItem RemesPathStylePathItem;
    }
}