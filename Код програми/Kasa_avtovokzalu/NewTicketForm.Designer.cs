
namespace Kasa_avtovokzalu
{
    partial class NewTicketForm
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
            this.textName = new System.Windows.Forms.TextBox();
            this.textSurname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelWay = new System.Windows.Forms.Label();
            this.listNum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(254, 167);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(139, 20);
            this.textName.TabIndex = 0;
            // 
            // textSurname
            // 
            this.textSurname.Location = new System.Drawing.Point(254, 207);
            this.textSurname.Name = "textSurname";
            this.textSurname.Size = new System.Drawing.Size(139, 20);
            this.textSurname.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Купить билет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(274, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Оформление билета";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // phoneNum
            // 
            this.phoneNum.Location = new System.Drawing.Point(254, 249);
            this.phoneNum.Name = "phoneNum";
            this.phoneNum.Size = new System.Drawing.Size(139, 20);
            this.phoneNum.TabIndex = 6;
            this.phoneNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "+38";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Номер телефона";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.Location = new System.Drawing.Point(70, 69);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(46, 17);
            this.labelData.TabIndex = 11;
            this.labelData.Text = "label6";
            // 
            // labelWay
            // 
            this.labelWay.AutoSize = true;
            this.labelWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWay.Location = new System.Drawing.Point(70, 113);
            this.labelWay.Name = "labelWay";
            this.labelWay.Size = new System.Drawing.Size(46, 17);
            this.labelWay.TabIndex = 12;
            this.labelWay.Text = "label6";
            // 
            // listNum
            // 
            this.listNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listNum.FormattingEnabled = true;
            this.listNum.Location = new System.Drawing.Point(548, 164);
            this.listNum.Name = "listNum";
            this.listNum.Size = new System.Drawing.Size(47, 21);
            this.listNum.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Выбор места в автобусе";
            // 
            // NewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listNum);
            this.Controls.Add(this.labelWay);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textSurname);
            this.Controls.Add(this.textName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "NewTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформление нового билета";
            this.Load += new System.EventHandler(this.NewTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textSurname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phoneNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelData;
        public System.Windows.Forms.Label labelWay;
        private System.Windows.Forms.ComboBox listNum;
        private System.Windows.Forms.Label label6;
    }
}