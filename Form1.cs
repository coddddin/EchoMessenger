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
            string result = $"[{DateTime.Now:yyyy-MM-dd HH:mm}] {finalMessage}";

            if (string.IsNullOrWhiteSpace(message))
            {
                EnterMessage.Clear();
                EnterMessage.Focus();
                return;
            }

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
                string result = $"[{DateTime.Now:yyyy-MM-dd HH:mm}] {finalMessage}";

                if (string.IsNullOrWhiteSpace(message))
                {
                    EnterMessage.Clear();
                    EnterMessage.Focus();
                    
                    e.Handled = true;
                    return;
                }

                MessageList.Items.Add(result);

                ListCounter_Updatelbl();
                
                EnterMessage.Clear();
                EnterMessage.Focus();

                // Enter 키 이벤트를 더 이상 처리하지 않도록 설정
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 함수 추가: 라벨 업데이트 함수
        private void ListCounter_Updatelbl()
        {
            int count = MessageList.Items.Count;
            ListCounter.Text = $"현재대화: {count}개";
        }
    }
}
