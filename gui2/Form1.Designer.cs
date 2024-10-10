namespace gui2
{
    partial class Form1
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
            this.plusButton = new System.Windows.Forms.Button();
            this.negButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.mutiplicationButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.originNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(35, 162);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 0;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // negButton
            // 
            this.negButton.Location = new System.Drawing.Point(35, 209);
            this.negButton.Name = "negButton";
            this.negButton.Size = new System.Drawing.Size(75, 23);
            this.negButton.TabIndex = 1;
            this.negButton.Text = "-";
            this.negButton.UseVisualStyleBackColor = true;
            this.negButton.Click += new System.EventHandler(this.negButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(35, 256);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 2;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // mutiplicationButton
            // 
            this.mutiplicationButton.Location = new System.Drawing.Point(35, 302);
            this.mutiplicationButton.Name = "mutiplicationButton";
            this.mutiplicationButton.Size = new System.Drawing.Size(75, 23);
            this.mutiplicationButton.TabIndex = 3;
            this.mutiplicationButton.Text = "x";
            this.mutiplicationButton.UseVisualStyleBackColor = true;
            this.mutiplicationButton.Click += new System.EventHandler(this.mutiplicationButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calculator";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(35, 347);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // originNum
            // 
            this.originNum.AutoSize = true;
            this.originNum.Location = new System.Drawing.Point(233, 162);
            this.originNum.Name = "originNum";
            this.originNum.Size = new System.Drawing.Size(67, 13);
            this.originNum.TabIndex = 6;
            this.originNum.Text = "88 ? 420 = ?";
            this.originNum.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.originNum);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mutiplicationButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.negButton);
            this.Controls.Add(this.plusButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button negButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button mutiplicationButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label originNum;
    }
}

