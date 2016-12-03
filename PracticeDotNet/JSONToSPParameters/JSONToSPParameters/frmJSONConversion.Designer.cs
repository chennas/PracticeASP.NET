namespace JSONToSPParameters
{
    partial class frmJSONConversion
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
            this.txtStoredProcName = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.rtbRawJSON = new System.Windows.Forms.RichTextBox();
            this.rtbConvertedData = new System.Windows.Forms.RichTextBox();
            this.lblSPName = new System.Windows.Forms.Label();
            this.lblRawJSON = new System.Windows.Forms.Label();
            this.lblConvertedData = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStoredProcName
            // 
            this.txtStoredProcName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoredProcName.Location = new System.Drawing.Point(18, 36);
            this.txtStoredProcName.Multiline = true;
            this.txtStoredProcName.Name = "txtStoredProcName";
            this.txtStoredProcName.Size = new System.Drawing.Size(412, 47);
            this.txtStoredProcName.TabIndex = 0;
            // 
            // btnConvert
            // 
            this.btnConvert.AccessibleDescription = "";
            this.btnConvert.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(446, 36);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(148, 47);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // rtbRawJSON
            // 
            this.rtbRawJSON.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbRawJSON.Location = new System.Drawing.Point(18, 109);
            this.rtbRawJSON.Name = "rtbRawJSON";
            this.rtbRawJSON.Size = new System.Drawing.Size(339, 342);
            this.rtbRawJSON.TabIndex = 2;
            this.rtbRawJSON.Text = "";
            // 
            // rtbConvertedData
            // 
            this.rtbConvertedData.Enabled = false;
            this.rtbConvertedData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConvertedData.Location = new System.Drawing.Point(375, 109);
            this.rtbConvertedData.Name = "rtbConvertedData";
            this.rtbConvertedData.Size = new System.Drawing.Size(481, 342);
            this.rtbConvertedData.TabIndex = 3;
            this.rtbConvertedData.Text = "";
            // 
            // lblSPName
            // 
            this.lblSPName.AutoSize = true;
            this.lblSPName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSPName.Location = new System.Drawing.Point(18, 10);
            this.lblSPName.Name = "lblSPName";
            this.lblSPName.Size = new System.Drawing.Size(190, 20);
            this.lblSPName.TabIndex = 4;
            this.lblSPName.Text = "Enter Stored Procedure Name";
            // 
            // lblRawJSON
            // 
            this.lblRawJSON.AutoSize = true;
            this.lblRawJSON.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRawJSON.Location = new System.Drawing.Point(18, 86);
            this.lblRawJSON.Name = "lblRawJSON";
            this.lblRawJSON.Size = new System.Drawing.Size(306, 20);
            this.lblRawJSON.TabIndex = 5;
            this.lblRawJSON.Text = "Copy Paste RawJSON SP Parameters From Logs";
            // 
            // lblConvertedData
            // 
            this.lblConvertedData.AutoSize = true;
            this.lblConvertedData.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvertedData.Location = new System.Drawing.Point(376, 86);
            this.lblConvertedData.Name = "lblConvertedData";
            this.lblConvertedData.Size = new System.Drawing.Size(252, 20);
            this.lblConvertedData.TabIndex = 6;
            this.lblConvertedData.Text = "Formatted Stored Procedure Parameters";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(610, 36);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(115, 47);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(741, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 47);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmJSONConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 463);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblConvertedData);
            this.Controls.Add(this.lblRawJSON);
            this.Controls.Add(this.lblSPName);
            this.Controls.Add(this.rtbConvertedData);
            this.Controls.Add(this.rtbRawJSON);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtStoredProcName);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmJSONConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application to Convert from JSON Parameters to Stored Procedure Parameters";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStoredProcName;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RichTextBox rtbRawJSON;
        private System.Windows.Forms.RichTextBox rtbConvertedData;
        private System.Windows.Forms.Label lblSPName;
        private System.Windows.Forms.Label lblRawJSON;
        private System.Windows.Forms.Label lblConvertedData;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

