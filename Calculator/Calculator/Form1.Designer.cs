namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnAc = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.Gainsboro;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnOne.Location = new System.Drawing.Point(8, 298);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(77, 67);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.buttons);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnTwo.Location = new System.Drawing.Point(91, 298);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(77, 67);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.buttons);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnThree.Location = new System.Drawing.Point(174, 298);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(77, 67);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.buttons);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnFour.Location = new System.Drawing.Point(8, 225);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(77, 67);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.buttons);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnFive.Location = new System.Drawing.Point(91, 225);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(77, 67);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.buttons);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSix.Location = new System.Drawing.Point(174, 225);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(77, 67);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.buttons);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnSeven.Location = new System.Drawing.Point(8, 152);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(77, 67);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.buttons);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnEight.Location = new System.Drawing.Point(91, 152);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(77, 67);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.buttons);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNine.Location = new System.Drawing.Point(174, 152);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(77, 67);
            this.btnNine.TabIndex = 8;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.buttons);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Gainsboro;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnC.Location = new System.Drawing.Point(174, 371);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(77, 67);
            this.btnC.TabIndex = 9;
            this.btnC.Text = ",";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMultiply.Location = new System.Drawing.Point(257, 152);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(77, 67);
            this.btnMultiply.TabIndex = 10;
            this.btnMultiply.Text = "x";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnMinus.Location = new System.Drawing.Point(257, 225);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(77, 67);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnPlus.Location = new System.Drawing.Point(257, 298);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(77, 67);
            this.btnPlus.TabIndex = 12;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnEqual.Location = new System.Drawing.Point(257, 373);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(77, 63);
            this.btnEqual.TabIndex = 13;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.Gainsboro;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnZero.Location = new System.Drawing.Point(10, 371);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(158, 67);
            this.btnZero.TabIndex = 14;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.buttons);
            // 
            // btnAc
            // 
            this.btnAc.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAc.Location = new System.Drawing.Point(8, 79);
            this.btnAc.Name = "btnAc";
            this.btnAc.Size = new System.Drawing.Size(158, 67);
            this.btnAc.TabIndex = 15;
            this.btnAc.Text = " AC";
            this.btnAc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAc.UseVisualStyleBackColor = false;
            this.btnAc.Click += new System.EventHandler(this.btnAc_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnDivide.Location = new System.Drawing.Point(257, 79);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(77, 67);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 67);
            this.label1.TabIndex = 17;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btnBackSpace.Location = new System.Drawing.Point(174, 80);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(77, 67);
            this.btnBackSpace.TabIndex = 18;
            this.btnBackSpace.Text = "C";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(346, 448);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnAc);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnAc;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackSpace;
    }
}

