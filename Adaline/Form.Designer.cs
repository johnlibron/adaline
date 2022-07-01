namespace Adaline
{
    partial class FormAdaline
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
            this.cboBoxLetters = new System.Windows.Forms.ComboBox();
            this.txtBoxResult = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.radioBtnCharacter = new System.Windows.Forms.RadioButton();
            this.radioBtnCharacterType = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cboBoxLetters
            // 
            this.cboBoxLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxLetters.FormattingEnabled = true;
            this.cboBoxLetters.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cboBoxLetters.Location = new System.Drawing.Point(342, 77);
            this.cboBoxLetters.Margin = new System.Windows.Forms.Padding(2);
            this.cboBoxLetters.Name = "cboBoxLetters";
            this.cboBoxLetters.Size = new System.Drawing.Size(67, 24);
            this.cboBoxLetters.TabIndex = 48;
            this.cboBoxLetters.SelectedIndexChanged += new System.EventHandler(this.CboBoxLetters_SelectedIndexChanged);
            // 
            // txtBoxResult
            // 
            this.txtBoxResult.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxResult.Location = new System.Drawing.Point(342, 30);
            this.txtBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxResult.Name = "txtBoxResult";
            this.txtBoxResult.ReadOnly = true;
            this.txtBoxResult.Size = new System.Drawing.Size(197, 34);
            this.txtBoxResult.TabIndex = 47;
            this.txtBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(227, 77);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 33);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(227, 30);
            this.btnResult.Margin = new System.Windows.Forms.Padding(2);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(84, 33);
            this.btnResult.TabIndex = 45;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 33);
            this.button1.TabIndex = 44;
            this.button1.Text = "Train";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnTrain_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Location = new System.Drawing.Point(30, 30);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(173, 218);
            this.tableLayoutPanel.TabIndex = 43;
            this.tableLayoutPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.TableLayoutPanel_CellPaint);
            this.tableLayoutPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TableLayoutPanel_MouseClick);
            // 
            // radioBtnCharacter
            // 
            this.radioBtnCharacter.AutoSize = true;
            this.radioBtnCharacter.Location = new System.Drawing.Point(420, 102);
            this.radioBtnCharacter.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnCharacter.Name = "radioBtnCharacter";
            this.radioBtnCharacter.Size = new System.Drawing.Size(91, 21);
            this.radioBtnCharacter.TabIndex = 51;
            this.radioBtnCharacter.Text = "Character";
            this.radioBtnCharacter.UseVisualStyleBackColor = true;
            // 
            // radioBtnCharacterType
            // 
            this.radioBtnCharacterType.AutoSize = true;
            this.radioBtnCharacterType.Checked = true;
            this.radioBtnCharacterType.Location = new System.Drawing.Point(420, 77);
            this.radioBtnCharacterType.Margin = new System.Windows.Forms.Padding(2);
            this.radioBtnCharacterType.Name = "radioBtnCharacterType";
            this.radioBtnCharacterType.Size = new System.Drawing.Size(127, 21);
            this.radioBtnCharacterType.TabIndex = 50;
            this.radioBtnCharacterType.TabStop = true;
            this.radioBtnCharacterType.Text = "Character Type";
            this.radioBtnCharacterType.UseVisualStyleBackColor = true;
            // 
            // FormAdaline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(581, 287);
            this.Controls.Add(this.radioBtnCharacter);
            this.Controls.Add(this.radioBtnCharacterType);
            this.Controls.Add(this.cboBoxLetters);
            this.Controls.Add(this.txtBoxResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdaline";
            this.Text = "Adaline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxLetters;
        private System.Windows.Forms.TextBox txtBoxResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.RadioButton radioBtnCharacter;
        private System.Windows.Forms.RadioButton radioBtnCharacterType;
    }
}

