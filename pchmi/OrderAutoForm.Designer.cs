namespace pchmi
{
    partial class OrderAutoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.tbComplectation = new System.Windows.Forms.TextBox();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка:";
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(95, 12);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(144, 20);
            this.tbMark.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Год выпуска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Комплектация:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цвет:";
            // 
            // tbColor
            // 
            this.tbColor.Location = new System.Drawing.Point(95, 116);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(144, 20);
            this.tbColor.TabIndex = 6;
            // 
            // tbComplectation
            // 
            this.tbComplectation.Location = new System.Drawing.Point(95, 90);
            this.tbComplectation.Name = "tbComplectation";
            this.tbComplectation.Size = new System.Drawing.Size(144, 20);
            this.tbComplectation.TabIndex = 7;
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(95, 64);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(144, 20);
            this.tbDate.TabIndex = 8;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(95, 38);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(144, 20);
            this.tbModel.TabIndex = 9;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(8, 168);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(75, 23);
            this.buttonOrder.TabIndex = 10;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(164, 168);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(95, 142);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(144, 20);
            this.tbPrice.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Цена:";
            // 
            // OrderAutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 195);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.tbModel);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.tbComplectation);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.label1);
            this.Name = "OrderAutoForm";
            this.Text = "OrderAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbColor;
        private System.Windows.Forms.TextBox tbComplectation;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label6;
    }
}