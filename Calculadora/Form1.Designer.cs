namespace Calculadora
{
    partial class FormCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalc));
            ButtonPorc = new Button();
            TextBoxOperation = new TextBox();
            ButtonMod = new Button();
            ButtonCE = new Button();
            ButtonDiv = new Button();
            ButtonNum1 = new Button();
            ButtonNum7 = new Button();
            ButtomPlus = new Button();
            ButtonNum6 = new Button();
            ButtonNum5 = new Button();
            ButtonNum4 = new Button();
            ButtomProd = new Button();
            ButtonNum3 = new Button();
            ButtonNum2 = new Button();
            ButtomMinus = new Button();
            ButtonNum9 = new Button();
            ButtonNum8 = new Button();
            ButtonNum0 = new Button();
            ButtonEqual = new Button();
            ButtonDot = new Button();
            textBoxParcial = new TextBox();
            creator = new Label();
            SuspendLayout();
            // 
            // ButtonPorc
            // 
            ButtonPorc.BackColor = SystemColors.ActiveCaption;
            ButtonPorc.FlatStyle = FlatStyle.Flat;
            ButtonPorc.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonPorc.Location = new Point(12, 113);
            ButtonPorc.Name = "ButtonPorc";
            ButtonPorc.Size = new Size(64, 45);
            ButtonPorc.TabIndex = 0;
            ButtonPorc.Text = "%";
            ButtonPorc.UseVisualStyleBackColor = false;
            ButtonPorc.Click += ButtonPorc_Click;
            // 
            // TextBoxOperation
            // 
            TextBoxOperation.BackColor = SystemColors.HighlightText;
            TextBoxOperation.Font = new Font("Segoe UI", 25F);
            TextBoxOperation.ImeMode = ImeMode.NoControl;
            TextBoxOperation.Location = new Point(12, 57);
            TextBoxOperation.MaximumSize = new Size(0, 50);
            TextBoxOperation.MinimumSize = new Size(0, 50);
            TextBoxOperation.Multiline = true;
            TextBoxOperation.Name = "TextBoxOperation";
            TextBoxOperation.Size = new Size(280, 50);
            TextBoxOperation.TabIndex = 1;
            TextBoxOperation.Text = "0";
            TextBoxOperation.TextAlign = HorizontalAlignment.Right;
            // 
            // ButtonMod
            // 
            ButtonMod.BackColor = SystemColors.ActiveCaption;
            ButtonMod.FlatStyle = FlatStyle.Flat;
            ButtonMod.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonMod.Location = new Point(82, 113);
            ButtonMod.Name = "ButtonMod";
            ButtonMod.Size = new Size(64, 45);
            ButtonMod.TabIndex = 2;
            ButtonMod.Text = "MOD";
            ButtonMod.UseVisualStyleBackColor = false;
            ButtonMod.Click += ButtonMod_Click;
            // 
            // ButtonCE
            // 
            ButtonCE.BackColor = SystemColors.ActiveCaption;
            ButtonCE.FlatStyle = FlatStyle.Flat;
            ButtonCE.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonCE.Location = new Point(154, 113);
            ButtonCE.Name = "ButtonCE";
            ButtonCE.Size = new Size(64, 45);
            ButtonCE.TabIndex = 3;
            ButtonCE.Text = "CE";
            ButtonCE.UseVisualStyleBackColor = false;
            ButtonCE.Click += ButtonCE_Click;
            // 
            // ButtonDiv
            // 
            ButtonDiv.BackColor = SystemColors.ActiveCaption;
            ButtonDiv.FlatStyle = FlatStyle.Flat;
            ButtonDiv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonDiv.Location = new Point(227, 113);
            ButtonDiv.Name = "ButtonDiv";
            ButtonDiv.Size = new Size(64, 45);
            ButtonDiv.TabIndex = 4;
            ButtonDiv.Text = "/";
            ButtonDiv.UseVisualStyleBackColor = false;
            ButtonDiv.Click += ButtonDiv_Click;
            // 
            // ButtonNum1
            // 
            ButtonNum1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum1.Location = new Point(12, 268);
            ButtonNum1.Name = "ButtonNum1";
            ButtonNum1.Size = new Size(64, 45);
            ButtonNum1.TabIndex = 5;
            ButtonNum1.Text = "1";
            ButtonNum1.UseVisualStyleBackColor = true;
            ButtonNum1.Click += ButtonNum1_Click;
            // 
            // ButtonNum7
            // 
            ButtonNum7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum7.Location = new Point(12, 166);
            ButtonNum7.Name = "ButtonNum7";
            ButtonNum7.Size = new Size(64, 45);
            ButtonNum7.TabIndex = 6;
            ButtonNum7.Text = "7";
            ButtonNum7.UseVisualStyleBackColor = true;
            ButtonNum7.Click += ButtonNum7_Click;
            // 
            // ButtomPlus
            // 
            ButtomPlus.BackColor = SystemColors.ActiveCaption;
            ButtomPlus.FlatStyle = FlatStyle.Flat;
            ButtomPlus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtomPlus.Location = new Point(225, 217);
            ButtomPlus.Name = "ButtomPlus";
            ButtomPlus.Size = new Size(64, 45);
            ButtomPlus.TabIndex = 7;
            ButtomPlus.Text = "+";
            ButtomPlus.UseVisualStyleBackColor = false;
            ButtomPlus.Click += ButtonPlus_Click;
            // 
            // ButtonNum6
            // 
            ButtonNum6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum6.Location = new Point(155, 217);
            ButtonNum6.Name = "ButtonNum6";
            ButtonNum6.Size = new Size(64, 45);
            ButtonNum6.TabIndex = 8;
            ButtonNum6.Text = "6";
            ButtonNum6.UseVisualStyleBackColor = true;
            ButtonNum6.Click += ButtonNum6_Click;
            // 
            // ButtonNum5
            // 
            ButtonNum5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum5.Location = new Point(83, 217);
            ButtonNum5.Name = "ButtonNum5";
            ButtonNum5.Size = new Size(64, 45);
            ButtonNum5.TabIndex = 9;
            ButtonNum5.Text = "5";
            ButtonNum5.UseVisualStyleBackColor = true;
            ButtonNum5.Click += ButtonNum5_Click;
            // 
            // ButtonNum4
            // 
            ButtonNum4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum4.Location = new Point(12, 217);
            ButtonNum4.Name = "ButtonNum4";
            ButtonNum4.Size = new Size(64, 45);
            ButtonNum4.TabIndex = 10;
            ButtonNum4.Text = "4";
            ButtonNum4.UseVisualStyleBackColor = true;
            ButtonNum4.Click += ButtonNum4_Click;
            // 
            // ButtomProd
            // 
            ButtomProd.BackColor = SystemColors.ActiveCaption;
            ButtomProd.FlatStyle = FlatStyle.Flat;
            ButtomProd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtomProd.Location = new Point(226, 166);
            ButtomProd.Name = "ButtomProd";
            ButtomProd.Size = new Size(64, 45);
            ButtomProd.TabIndex = 11;
            ButtomProd.Text = "X";
            ButtomProd.UseVisualStyleBackColor = false;
            ButtomProd.Click += ButtonProd_Click;
            // 
            // ButtonNum3
            // 
            ButtonNum3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum3.Location = new Point(154, 268);
            ButtonNum3.Name = "ButtonNum3";
            ButtonNum3.Size = new Size(64, 45);
            ButtonNum3.TabIndex = 12;
            ButtonNum3.Text = "3";
            ButtonNum3.UseVisualStyleBackColor = true;
            ButtonNum3.Click += ButtonNum3_Click;
            // 
            // ButtonNum2
            // 
            ButtonNum2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum2.Location = new Point(83, 268);
            ButtonNum2.Name = "ButtonNum2";
            ButtonNum2.Size = new Size(64, 45);
            ButtonNum2.TabIndex = 13;
            ButtonNum2.Text = "2";
            ButtonNum2.UseVisualStyleBackColor = true;
            ButtonNum2.Click += ButtonNum2_Click;
            // 
            // ButtomMinus
            // 
            ButtomMinus.BackColor = SystemColors.ActiveCaption;
            ButtomMinus.FlatStyle = FlatStyle.Flat;
            ButtomMinus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtomMinus.Location = new Point(225, 268);
            ButtomMinus.Name = "ButtomMinus";
            ButtomMinus.Size = new Size(64, 45);
            ButtomMinus.TabIndex = 14;
            ButtomMinus.Text = "-";
            ButtomMinus.UseVisualStyleBackColor = false;
            ButtomMinus.Click += ButtonMinus_Click;
            // 
            // ButtonNum9
            // 
            ButtonNum9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum9.Location = new Point(154, 166);
            ButtonNum9.Name = "ButtonNum9";
            ButtonNum9.Size = new Size(64, 45);
            ButtonNum9.TabIndex = 15;
            ButtonNum9.Text = "9";
            ButtonNum9.UseVisualStyleBackColor = true;
            ButtonNum9.Click += ButtonNum9_Click;
            // 
            // ButtonNum8
            // 
            ButtonNum8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum8.Location = new Point(82, 166);
            ButtonNum8.Name = "ButtonNum8";
            ButtonNum8.Size = new Size(64, 45);
            ButtonNum8.TabIndex = 16;
            ButtonNum8.Text = "8";
            ButtonNum8.UseVisualStyleBackColor = true;
            ButtonNum8.Click += ButtonNum8_Click;
            // 
            // ButtonNum0
            // 
            ButtonNum0.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonNum0.Location = new Point(82, 319);
            ButtonNum0.Name = "ButtonNum0";
            ButtonNum0.Size = new Size(64, 45);
            ButtonNum0.TabIndex = 17;
            ButtonNum0.Text = "0";
            ButtonNum0.UseMnemonic = false;
            ButtonNum0.UseVisualStyleBackColor = true;
            ButtonNum0.Click += ButtonNum0_Click;
            // 
            // ButtonEqual
            // 
            ButtonEqual.BackColor = SystemColors.ActiveCaption;
            ButtonEqual.FlatStyle = FlatStyle.Flat;
            ButtonEqual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonEqual.Location = new Point(225, 319);
            ButtonEqual.Name = "ButtonEqual";
            ButtonEqual.Size = new Size(64, 45);
            ButtonEqual.TabIndex = 18;
            ButtonEqual.Text = "=";
            ButtonEqual.UseMnemonic = false;
            ButtonEqual.UseVisualStyleBackColor = false;
            ButtonEqual.Click += ButtonEquals_Click;
            // 
            // ButtonDot
            // 
            ButtonDot.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ButtonDot.Location = new Point(152, 319);
            ButtonDot.Name = "ButtonDot";
            ButtonDot.Size = new Size(64, 45);
            ButtonDot.TabIndex = 19;
            ButtonDot.Text = ".";
            ButtonDot.UseMnemonic = false;
            ButtonDot.UseVisualStyleBackColor = true;
            ButtonDot.Click += ButtonDot_Click;
            // 
            // textBoxParcial
            // 
            textBoxParcial.BackColor = SystemColors.HighlightText;
            textBoxParcial.Font = new Font("Segoe UI", 15F);
            textBoxParcial.ImeMode = ImeMode.NoControl;
            textBoxParcial.Location = new Point(12, 10);
            textBoxParcial.MaximumSize = new Size(0, 50);
            textBoxParcial.MinimumSize = new Size(0, 50);
            textBoxParcial.Multiline = true;
            textBoxParcial.Name = "textBoxParcial";
            textBoxParcial.ReadOnly = true;
            textBoxParcial.Size = new Size(280, 50);
            textBoxParcial.TabIndex = 20;
            textBoxParcial.TextAlign = HorizontalAlignment.Right;
            // 
            // creator
            // 
            creator.AutoSize = true;
            creator.Font = new Font("Segoe UI", 6F);
            creator.Location = new Point(3, 379);
            creator.Name = "creator";
            creator.Size = new Size(106, 11);
            creator.TabIndex = 21;
            creator.Text = "Hecho por Nehuen Giacone";
            creator.Click += ButtonEquals_Click;
            // 
            // FormCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 399);
            Controls.Add(creator);
            Controls.Add(textBoxParcial);
            Controls.Add(ButtonDot);
            Controls.Add(ButtonEqual);
            Controls.Add(ButtonNum0);
            Controls.Add(ButtonNum8);
            Controls.Add(ButtonNum9);
            Controls.Add(ButtomMinus);
            Controls.Add(ButtonNum2);
            Controls.Add(ButtonNum3);
            Controls.Add(ButtomProd);
            Controls.Add(ButtonNum4);
            Controls.Add(ButtonNum5);
            Controls.Add(ButtonNum6);
            Controls.Add(ButtomPlus);
            Controls.Add(ButtonNum7);
            Controls.Add(ButtonNum1);
            Controls.Add(ButtonDiv);
            Controls.Add(ButtonCE);
            Controls.Add(ButtonMod);
            Controls.Add(TextBoxOperation);
            Controls.Add(ButtonPorc);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(318, 438);
            MinimumSize = new Size(318, 438);
            Name = "FormCalc";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonPorc;
        private TextBox TextBoxOperation;
        private Button ButtonMod;
        private Button ButtonCE;
        private Button ButtonDiv;
        private Button ButtonNum1;
        private Button ButtonNum7;
        private Button ButtomPlus;
        private Button ButtonNum6;
        private Button ButtonNum5;
        private Button ButtonNum4;
        private Button ButtomProd;
        private Button ButtonNum3;
        private Button ButtonNum2;
        private Button ButtomMinus;
        private Button ButtonNum9;
        private Button ButtonNum8;
        private Button ButtonNum0;
        private Button ButtonEqual;
        private Button ButtonDot;
        private TextBox textBoxParcial;
        private Label creator;
    }
}
