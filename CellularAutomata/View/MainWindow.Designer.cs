﻿namespace CellularAutomata.View
{
    partial class MainWindow
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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.mapPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timerLabelTitle = new System.Windows.Forms.Label();
            this.populationCountLabel = new System.Windows.Forms.Label();
            this.populationCountLabelTitle = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.neighborCountLableTitle = new System.Windows.Forms.Label();
            this.neighborCellCountLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainPanel.Controls.Add(this.mapPanel);
            this.mainPanel.Controls.Add(this.controlPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(479, 558);
            this.mainPanel.TabIndex = 3;
            // 
            // mapPanel
            // 
            this.mapPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mapPanel.Location = new System.Drawing.Point(3, 3);
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.Size = new System.Drawing.Size(468, 439);
            this.mapPanel.TabIndex = 0;
            // 
            // controlPanel
            // 
            this.controlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlPanel.Controls.Add(this.neighborCellCountLabel);
            this.controlPanel.Controls.Add(this.neighborCountLableTitle);
            this.controlPanel.Controls.Add(this.timerLabel);
            this.controlPanel.Controls.Add(this.timerLabelTitle);
            this.controlPanel.Controls.Add(this.populationCountLabel);
            this.controlPanel.Controls.Add(this.populationCountLabelTitle);
            this.controlPanel.Controls.Add(this.startButton);
            this.controlPanel.Location = new System.Drawing.Point(3, 448);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(468, 103);
            this.controlPanel.TabIndex = 2;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(54, 29);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(13, 13);
            this.timerLabel.TabIndex = 5;
            this.timerLabel.Text = "0";
            // 
            // timerLabelTitle
            // 
            this.timerLabelTitle.AutoSize = true;
            this.timerLabelTitle.Location = new System.Drawing.Point(9, 29);
            this.timerLabelTitle.Name = "timerLabelTitle";
            this.timerLabelTitle.Size = new System.Drawing.Size(36, 13);
            this.timerLabelTitle.TabIndex = 4;
            this.timerLabelTitle.Text = "Timer:";
            // 
            // populationCountLabel
            // 
            this.populationCountLabel.AutoSize = true;
            this.populationCountLabel.Location = new System.Drawing.Point(106, 12);
            this.populationCountLabel.Name = "populationCountLabel";
            this.populationCountLabel.Size = new System.Drawing.Size(13, 13);
            this.populationCountLabel.TabIndex = 3;
            this.populationCountLabel.Text = "0";
            // 
            // populationCountLabelTitle
            // 
            this.populationCountLabelTitle.AutoSize = true;
            this.populationCountLabelTitle.Location = new System.Drawing.Point(9, 12);
            this.populationCountLabelTitle.Name = "populationCountLabelTitle";
            this.populationCountLabelTitle.Size = new System.Drawing.Size(91, 13);
            this.populationCountLabelTitle.TabIndex = 2;
            this.populationCountLabelTitle.Text = "Population Count:";
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(374, 3);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(91, 97);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // neighborCountLableTitle
            // 
            this.neighborCountLableTitle.AutoSize = true;
            this.neighborCountLableTitle.Location = new System.Drawing.Point(9, 45);
            this.neighborCountLableTitle.Name = "neighborCountLableTitle";
            this.neighborCountLableTitle.Size = new System.Drawing.Size(123, 13);
            this.neighborCountLableTitle.TabIndex = 6;
            this.neighborCountLableTitle.Text = "Selected Cell Neighbors:";
            // 
            // neighborCellCountLabel
            // 
            this.neighborCellCountLabel.AutoSize = true;
            this.neighborCellCountLabel.Location = new System.Drawing.Point(138, 45);
            this.neighborCellCountLabel.Name = "neighborCellCountLabel";
            this.neighborCellCountLabel.Size = new System.Drawing.Size(10, 17);
            this.neighborCellCountLabel.TabIndex = 7;
            this.neighborCellCountLabel.Text = "0";
            this.neighborCellCountLabel.UseCompatibleTextRendering = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 558);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainWindow";
            this.Text = "Cellular Automata";
            this.mainPanel.ResumeLayout(false);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel mapPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label populationCountLabel;
        private System.Windows.Forms.Label populationCountLabelTitle;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timerLabelTitle;
        private System.Windows.Forms.Label neighborCellCountLabel;
        private System.Windows.Forms.Label neighborCountLableTitle;
    }
}

