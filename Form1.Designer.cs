namespace OOP_3_task_1
{
    partial class Form1
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
            lblType = new Label();
            cbType = new ComboBox();
            lblMsg = new Label();
            txtMessage = new TextBox();
            btnCreate = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(20, 20);
            lblType.Name = "lblType";
            lblType.Size = new Size(74, 15);
            lblType.TabIndex = 0;
            lblType.Text = "Тип діалогу:";
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Успішна дія", "Помилка системи" });
            cbType.Location = new Point(140, 18);
            cbType.Name = "cbType";
            cbType.Size = new Size(220, 23);
            cbType.TabIndex = 1;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(20, 60);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(90, 15);
            lblMsg.TabIndex = 2;
            lblMsg.Text = "Повідомлення:";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(140, 58);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(220, 23);
            txtMessage.TabIndex = 3;
            txtMessage.Text = "Дані успішно збережено!";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(140, 100);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(220, 30);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Згенерувати діалог";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblOutput.Location = new Point(20, 150);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(360, 50);
            lblOutput.TabIndex = 5;
            lblOutput.Text = "label1";
            lblOutput.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 221);
            Controls.Add(lblOutput);
            Controls.Add(btnCreate);
            Controls.Add(txtMessage);
            Controls.Add(lblMsg);
            Controls.Add(cbType);
            Controls.Add(lblType);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Фабричний метод";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblType;
        private ComboBox cbType;
        private Label lblMsg;
        private TextBox txtMessage;
        private Button btnCreate;
        private Label lblOutput;
    }
}
