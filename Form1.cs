namespace EchoMessenger
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //버튼 클릭 이벤트 핸들러 추가
        // - 입력 상자에서 텍스트를 읽고
        // - 메시지 리스트에 추가한 뒤
        // - 입력 상자를 비운다
        private void btnEnter_Click(object sender, EventArgs e)
        {
            string message = EnterMessage.Text;

            MessageList.Items.Add(message);
            EnterMessage.Clear();
        }

        private void MessageList_DataContextChanged(object sender, EventArgs e)
        {

        }

        private void MessageList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
