namespace UserCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ouPath = "";
        string[] newUser = new string[] {
            /*1 ��������� ��� */   "newUserDisplayName",
            /*2 ����� */           "newUserLogin",
            /*3 ������� */         "newUserPass",
            /*4 ���� � ������ ����� */ "HomeDirectory"
        };

        public static void AdUserCreator(string ou, string[] newUserData)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
