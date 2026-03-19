namespace EchoMessenger
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
            label1 = new Label();
            MessageList = new ListBox();
            EnterMessage = new TextBox();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("굴림체", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(47, 19);
            label1.Name = "label1";
            label1.Size = new Size(385, 64);
            label1.TabIndex = 0;
            label1.Text = "에코 메신저";
            label1.Click += label1_Click;
            // 
            // MessageList
            // 
            MessageList.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            MessageList.FormattingEnabled = true;
            MessageList.Location = new Point(47, 100);
            MessageList.Name = "MessageList";
            MessageList.Size = new Size(683, 221);
            MessageList.TabIndex = 1;
            MessageList.SelectedIndexChanged += MessageList_SelectedIndexChanged;
            MessageList.DataContextChanged += MessageList_DataContextChanged;
            // 
            // EnterMessage
            // 
            EnterMessage.Cursor = Cursors.IBeam;
            EnterMessage.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            EnterMessage.Location = new Point(47, 357);
            EnterMessage.Name = "EnterMessage";
            EnterMessage.Size = new Size(492, 33);
            EnterMessage.TabIndex = 2;
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.Cyan;
            btnEnter.Cursor = Cursors.Hand;
            btnEnter.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnEnter.Location = new Point(567, 339);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(163, 65);
            btnEnter.TabIndex = 3;
            btnEnter.Text = "전 송";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += btnEnter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(EnterMessage);
            Controls.Add(MessageList);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Echo Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox MessageList;
        private TextBox EnterMessage;
        private Button btnEnter;
    }
}
