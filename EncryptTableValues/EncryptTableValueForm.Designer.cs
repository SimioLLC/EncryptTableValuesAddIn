namespace EncryptTableValuesAddIn
{
    partial class EncryptTableValueForm
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
            this.KeyTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EncryptRadioButton = new System.Windows.Forms.RadioButton();
            this.DecryptRadioButton = new System.Windows.Forms.RadioButton();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.ColumnComboBox = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KeyTextbox
            // 
            this.KeyTextbox.Location = new System.Drawing.Point(57, 43);
            this.KeyTextbox.Name = "KeyTextbox";
            this.KeyTextbox.ReadOnly = true;
            this.KeyTextbox.Size = new System.Drawing.Size(580, 22);
            this.KeyTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Column";
            // 
            // EncryptRadioButton
            // 
            this.EncryptRadioButton.AutoSize = true;
            this.EncryptRadioButton.Checked = true;
            this.EncryptRadioButton.Location = new System.Drawing.Point(57, 227);
            this.EncryptRadioButton.Name = "EncryptRadioButton";
            this.EncryptRadioButton.Size = new System.Drawing.Size(113, 20);
            this.EncryptRadioButton.TabIndex = 6;
            this.EncryptRadioButton.TabStop = true;
            this.EncryptRadioButton.Text = "Encrypt Button";
            this.EncryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // DecryptRadioButton
            // 
            this.DecryptRadioButton.AutoSize = true;
            this.DecryptRadioButton.Location = new System.Drawing.Point(57, 271);
            this.DecryptRadioButton.Name = "DecryptRadioButton";
            this.DecryptRadioButton.Size = new System.Drawing.Size(115, 20);
            this.DecryptRadioButton.TabIndex = 7;
            this.DecryptRadioButton.Text = "Decrypt Button";
            this.DecryptRadioButton.UseVisualStyleBackColor = true;
            // 
            // TableComboBox
            // 
            this.TableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(57, 110);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(580, 24);
            this.TableComboBox.TabIndex = 8;
            this.TableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // ColumnComboBox
            // 
            this.ColumnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColumnComboBox.FormattingEnabled = true;
            this.ColumnComboBox.Location = new System.Drawing.Point(57, 182);
            this.ColumnComboBox.Name = "ColumnComboBox";
            this.ColumnComboBox.Size = new System.Drawing.Size(580, 24);
            this.ColumnComboBox.TabIndex = 9;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(219, 242);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(188, 49);
            this.OKButton.TabIndex = 10;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(449, 242);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(188, 49);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // EncryptTableValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 329);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.ColumnComboBox);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.DecryptRadioButton);
            this.Controls.Add(this.EncryptRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyTextbox);
            this.Name = "EncryptTableValueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EncryptTableValueForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.RadioButton EncryptRadioButton;
        public System.Windows.Forms.RadioButton DecryptRadioButton;
        internal System.Windows.Forms.ComboBox TableComboBox;
        internal System.Windows.Forms.ComboBox ColumnComboBox;
        private System.Windows.Forms.Button CancelButton;
        internal System.Windows.Forms.Button OKButton;
        internal System.Windows.Forms.TextBox KeyTextbox;
    }
}