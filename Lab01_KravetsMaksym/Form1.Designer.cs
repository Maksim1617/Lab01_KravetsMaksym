
namespace Lab01_KravetsMaksym
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_OK = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Roll = new System.Windows.Forms.Label();
            this.label_Hide = new System.Windows.Forms.Label();
            this.label_Close = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_OK);
            this.groupBox1.Controls.Add(this.button_OK);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_Login);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Авторизація";
            // 
            // label_OK
            // 
            this.label_OK.AutoSize = true;
            this.label_OK.Location = new System.Drawing.Point(127, 76);
            this.label_OK.Name = "label_OK";
            this.label_OK.Size = new System.Drawing.Size(21, 13);
            this.label_OK.TabIndex = 5;
            this.label_OK.Text = "Ok";
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(46, 71);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 4;
            this.button_OK.Text = "Ввійти";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логін";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(57, 45);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 1;
            this.textBox_Password.Enter += new System.EventHandler(this.textBox_Password_Enter);
            this.textBox_Password.Leave += new System.EventHandler(this.textBox_Password_Leave);
            // 
            // textBox_Login
            // 
            this.textBox_Login.Location = new System.Drawing.Point(57, 19);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(100, 20);
            this.textBox_Login.TabIndex = 0;
            this.textBox_Login.Enter += new System.EventHandler(this.textBox_Login_Enter);
            this.textBox_Login.Leave += new System.EventHandler(this.textBox_Login_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label_Roll);
            this.panel1.Controls.Add(this.label_Hide);
            this.panel1.Controls.Add(this.label_Close);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 23);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label_Roll
            // 
            this.label_Roll.AutoSize = true;
            this.label_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Roll.Image = global::Lab01_KravetsMaksym.Properties.Resources.развернут;
            this.label_Roll.Location = new System.Drawing.Point(161, 4);
            this.label_Roll.Name = "label_Roll";
            this.label_Roll.Size = new System.Drawing.Size(14, 16);
            this.label_Roll.TabIndex = 2;
            this.label_Roll.Text = "  ";
            // 
            // label_Hide
            // 
            this.label_Hide.AutoSize = true;
            this.label_Hide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Hide.Location = new System.Drawing.Point(140, 4);
            this.label_Hide.Name = "label_Hide";
            this.label_Hide.Size = new System.Drawing.Size(17, 16);
            this.label_Hide.TabIndex = 1;
            this.label_Hide.Text = "—";
            this.label_Hide.Click += new System.EventHandler(this.label_Hide_Click);
            this.label_Hide.MouseEnter += new System.EventHandler(this.label_Hide_MouseEnter);
            this.label_Hide.MouseLeave += new System.EventHandler(this.label_Hide_MouseLeave);
            // 
            // label_Close
            // 
            this.label_Close.AutoSize = true;
            this.label_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Close.Location = new System.Drawing.Point(179, 3);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(16, 16);
            this.label_Close.TabIndex = 0;
            this.label_Close.Text = "X";
            this.label_Close.Click += new System.EventHandler(this.label_Close_Click);
            this.label_Close.MouseEnter += new System.EventHandler(this.label_Close_MouseEnter);
            this.label_Close.MouseLeave += new System.EventHandler(this.label_Close_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 140);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.Label label_Roll;
        private System.Windows.Forms.Label label_Hide;
        private System.Windows.Forms.Label label_OK;
    }
}

