﻿
namespace tictactoe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.X_O_display_button = new System.Windows.Forms.Button();
            this.AI_button = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.human_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(119, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 622);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player";
            // 
            // X_O_display_button
            // 
            this.X_O_display_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.X_O_display_button.Location = new System.Drawing.Point(933, 195);
            this.X_O_display_button.Name = "X_O_display_button";
            this.X_O_display_button.Size = new System.Drawing.Size(233, 225);
            this.X_O_display_button.TabIndex = 2;
            this.X_O_display_button.Text = "X";
            this.X_O_display_button.UseVisualStyleBackColor = true;
            // 
            // AI_button
            // 
            this.AI_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AI_button.Location = new System.Drawing.Point(933, 552);
            this.AI_button.Name = "AI_button";
            this.AI_button.Size = new System.Drawing.Size(169, 52);
            this.AI_button.TabIndex = 3;
            this.AI_button.Text = "AI";
            this.AI_button.UseVisualStyleBackColor = false;
            this.AI_button.Click += new System.EventHandler(this.ai_button_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Location = new System.Drawing.Point(1054, 676);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Size = new System.Drawing.Size(169, 52);
            this.reset_btn.TabIndex = 5;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = true;
            this.reset_btn.Click += new System.EventHandler(this.reset_Click);
            // 
            // human_button
            // 
            this.human_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.human_button.Location = new System.Drawing.Point(1186, 552);
            this.human_button.Name = "human_button";
            this.human_button.Size = new System.Drawing.Size(169, 52);
            this.human_button.TabIndex = 6;
            this.human_button.Text = "Human";
            this.human_button.UseVisualStyleBackColor = false;
            this.human_button.Click += new System.EventHandler(this.human_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1035, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 37);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose game type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1619, 945);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.human_button);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AI_button);
            this.Controls.Add(this.X_O_display_button);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button X_O_display_button;
        private System.Windows.Forms.Button AI_button;
        private System.Windows.Forms.Button reset_btn;
        private System.Windows.Forms.Button human_button;
        private System.Windows.Forms.Label label2;
    }
}

