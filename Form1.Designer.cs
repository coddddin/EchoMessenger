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
            MainLabel = new Label();
            MessageList = new ListBox();
            EnterMessage = new TextBox();
            BtnEnter = new Button();
            ListCounter = new Label();
            BtnReset = new Button();
            BtnSelectDelete = new Button();
            SuspendLayout();
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.Font = new Font("굴림체", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            MainLabel.ForeColor = Color.Blue;
            MainLabel.Location = new Point(47, 19);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(385, 64);
            MainLabel.TabIndex = 0;
            MainLabel.Text = "에코 메신저";
            // 
            // MessageList
            // 
            MessageList.Font = new Font("한컴 고딕", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 129);
            MessageList.FormattingEnabled = true;
            MessageList.Location = new Point(47, 99);
            MessageList.Name = "MessageList";
            MessageList.Size = new Size(718, 221);
            MessageList.TabIndex = 1;
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
            // BtnEnter
            // 
            BtnEnter.BackColor = Color.Cyan;
            BtnEnter.Cursor = Cursors.Hand;
            BtnEnter.Font = new Font("한컴 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnEnter.Location = new Point(545, 339);
            BtnEnter.Name = "BtnEnter";
            BtnEnter.Size = new Size(101, 65);
            BtnEnter.TabIndex = 3;
            BtnEnter.Text = "전 송";
            BtnEnter.UseVisualStyleBackColor = false;
            BtnEnter.Click += BtnEnter_Click;
            BtnEnter.KeyDown += BtnEnter_KeyDown;
            // 
            // ListCounter
            // 
            ListCounter.AutoSize = true;
            ListCounter.BackColor = Color.White;
            ListCounter.Font = new Font("새굴림", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            ListCounter.Location = new Point(56, 323);
            ListCounter.Name = "ListCounter";
            ListCounter.Size = new Size(117, 19);
            ListCounter.TabIndex = 4;
            ListCounter.Text = "현재 대화 : ";
            
            // 
            // BtnReset
            // 
            BtnReset.BackColor = Color.IndianRed;
            BtnReset.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            BtnReset.Location = new Point(652, 339);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(113, 65);
            BtnReset.TabIndex = 5;
            BtnReset.Text = "초기화";
            BtnReset.UseVisualStyleBackColor = false;
            BtnReset.Click += BtnReset_Click;
            // 
            // BtnSelectDelete
            // 
            BtnSelectDelete.BackColor = Color.Gray;
            BtnSelectDelete.FlatStyle = FlatStyle.Popup;
            BtnSelectDelete.Font = new Font("맑은 고딕", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 129);
            BtnSelectDelete.ForeColor = Color.FromArgb(64, 0, 0);
            BtnSelectDelete.Location = new Point(615, 60);
            BtnSelectDelete.Name = "BtnSelectDelete";
            BtnSelectDelete.Size = new Size(150, 33);
            BtnSelectDelete.TabIndex = 6;
            BtnSelectDelete.Text = "선택 문자 삭제";
            BtnSelectDelete.UseVisualStyleBackColor = false;
            BtnSelectDelete.Click += BtnSelectDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(BtnSelectDelete);
            Controls.Add(BtnReset);
            Controls.Add(ListCounter);
            Controls.Add(BtnEnter);
            Controls.Add(EnterMessage);
            Controls.Add(MessageList);
            Controls.Add(MainLabel);
            Name = "Form1";
            Text = "Echo Messenger";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MainLabel;
        private ListBox MessageList;
        private TextBox EnterMessage;
        private Button BtnEnter;
        private Label ListCounter;
        private Button BtnReset;
        private Button BtnSelectDelete;
    }
}
