namespace Abstract
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
            this.btnWorkerTed = new System.Windows.Forms.Button();
            this.btnRaiseTed = new System.Windows.Forms.Button();
            this.btnRaiseJohn = new System.Windows.Forms.Button();
            this.btnManagerJohn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnWorkerTed
            // 
            this.btnWorkerTed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkerTed.Location = new System.Drawing.Point(20, 28);
            this.btnWorkerTed.Name = "btnWorkerTed";
            this.btnWorkerTed.Size = new System.Drawing.Size(164, 96);
            this.btnWorkerTed.TabIndex = 0;
            this.btnWorkerTed.Text = "Production Worker \r\nTed";
            this.btnWorkerTed.UseVisualStyleBackColor = true;
            this.btnWorkerTed.Click += new System.EventHandler(this.btnWorkerTed_Click);
            // 
            // btnRaiseTed
            // 
            this.btnRaiseTed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiseTed.Location = new System.Drawing.Point(206, 28);
            this.btnRaiseTed.Name = "btnRaiseTed";
            this.btnRaiseTed.Size = new System.Drawing.Size(164, 96);
            this.btnRaiseTed.TabIndex = 1;
            this.btnRaiseTed.Text = "Pay Raise Ted";
            this.btnRaiseTed.UseVisualStyleBackColor = true;
            this.btnRaiseTed.Click += new System.EventHandler(this.btnRaiseTed_Click);
            // 
            // btnRaiseJohn
            // 
            this.btnRaiseJohn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiseJohn.Location = new System.Drawing.Point(206, 139);
            this.btnRaiseJohn.Name = "btnRaiseJohn";
            this.btnRaiseJohn.Size = new System.Drawing.Size(164, 96);
            this.btnRaiseJohn.TabIndex = 2;
            this.btnRaiseJohn.Text = "Pay Raise John";
            this.btnRaiseJohn.UseVisualStyleBackColor = true;
            this.btnRaiseJohn.Click += new System.EventHandler(this.btnRaiseJohn_Click);
            // 
            // btnManagerJohn
            // 
            this.btnManagerJohn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagerJohn.Location = new System.Drawing.Point(20, 139);
            this.btnManagerJohn.Name = "btnManagerJohn";
            this.btnManagerJohn.Size = new System.Drawing.Size(164, 96);
            this.btnManagerJohn.TabIndex = 3;
            this.btnManagerJohn.Text = "Manager\r\nJohn";
            this.btnManagerJohn.UseVisualStyleBackColor = true;
            this.btnManagerJohn.Click += new System.EventHandler(this.btnManagerJohn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Percent Raised";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(412, 213);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(188, 20);
            this.txtInput.TabIndex = 5;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(16, 249);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(584, 134);
            this.rtbDisplay.TabIndex = 6;
            this.rtbDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 411);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnManagerJohn);
            this.Controls.Add(this.btnRaiseJohn);
            this.Controls.Add(this.btnRaiseTed);
            this.Controls.Add(this.btnWorkerTed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWorkerTed;
        private System.Windows.Forms.Button btnRaiseTed;
        private System.Windows.Forms.Button btnRaiseJohn;
        private System.Windows.Forms.Button btnManagerJohn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RichTextBox rtbDisplay;
    }
}

