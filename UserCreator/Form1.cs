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
            /*1 Выводимое имя */   "newUserDisplayName",
            /*2 логин */           "newUserLogin",
            /*3 ппароль */         "newUserPass",
            /*4 Путь к общему диску */ "HomeDirectory"
        };

        public static void AdUserCreator(string ou, string[] newUserData)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
