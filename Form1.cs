namespace EchoMessenger
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 엔터키로 전송 설정
            // 폼의 AcceptButton을 btnEnter로 설정시
            // 텍스트박스에 포커스가 있을 때 Enter 키가 btnEnter 이벤트 트리거
            this.AcceptButton = BtnEnter;

            //  폼로드 후 포커스 유지
            EnterMessage.Focus();
        }

        //버튼 클릭 이벤트 핸들러 추가

        // - 메시지 리스트에 추가
        // - 입력 상자를 비움
        // - 입력 상자에 다시 포커스
        private void BtnEnter_Click(object sender, EventArgs e)
        {
            string message = EnterMessage.Text;
            string finalMessage = message.Trim();

            if (string.IsNullOrWhiteSpace(message))
            {
                EnterMessage.Clear();
                EnterMessage.Focus();
                return;
            }
            
            if (finalMessage.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이내로 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EnterMessage.Focus();
                return;
            }

            string result = $"[{DateTime.Now:yyyy-MM-dd HH:mm}] {finalMessage}";
            MessageList.Items.Add(result);
            ListCounter_Updatelbl();
            EnterMessage.Clear();
            EnterMessage.Focus();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ListCounter_Updatelbl();
            EnterMessage.Focus();
        }

        private void BtnEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string message = EnterMessage.Text;
                string finalMessage = message.Trim();

                // 입력된 메시지가 비어있거나 공백으로만 이루어진 경우 처리
                if (string.IsNullOrWhiteSpace(message))
                {
                    EnterMessage.Clear();
                    EnterMessage.Focus();

                    e.Handled = true;
                    return;
                }
                if (finalMessage.Length > 50)
                {
                    MessageBox.Show("메시지는 50자 이내로 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    EnterMessage.Focus();
                    e.Handled = true;
                    return;
                }

                string result = $"[{DateTime.Now:yyyy-MM-dd HH:mm}] {finalMessage}";
                MessageList.Items.Add(result);

                ListCounter_Updatelbl();

                EnterMessage.Clear();
                EnterMessage.Focus();

                // Enter 키 이벤트를 더 이상 처리하지 않도록 설정
                e.Handled = true;
            }
        }
        // 함수 추가: 라벨 업데이트 함수
        private void ListCounter_Updatelbl()
        {
            int count = MessageList.Items.Count;
            ListCounter.Text = $"현재대화: {count}개";
        }

        private void BtnReset_Click(object sender, EventArgs e) // 대화 초기화 버튼 클릭 이벤트 핸들러
        {
            MessageList.Items.Clear();
            ListCounter_Updatelbl();
        }

        private void BtnSelectDelete_Click(object sender, EventArgs e)
        {
            // 선택된 항목이 있는지 확인 후 삭제 (예외 처리)
            if (MessageList.SelectedIndex >= 0)
            {
                MessageList.Items.RemoveAt(MessageList.SelectedIndex);
                ListCounter_Updatelbl();
            }
            else // 선택된 항목이 없는 경우 사용자에게 알림
            {
                MessageBox.Show("삭제할 메시지를 선택해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
