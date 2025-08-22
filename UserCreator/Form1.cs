using System.DirectoryServices;

namespace UserCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string newGroupNumber = "";
        int newGroupCount = 0;
        string ouPath = "";
        string[] newUserData = new string[] {
            /*0 Выводимое имя */       "newUserDisplayName",
            /*1 логин */               "newUserLogin",
            /*2 ппароль */             "newUserPass",
            /*3 Путь к общему диску */ "HomeDirectory",
            /*4 Пароль */              "SetPassword"
        };
        string[] adminData = new string[]
        {
            /*0 логин */  "login",
            /*1 пароль */ "pass"
        };

        public static void AdUserCreator(string ouPath, string[] newUserData, string[] adminData)
        {
            string fullLdapPath = "LDAP://" + ouPath;
            DirectoryEntry connectToAd = new DirectoryEntry(fullLdapPath);
            connectToAd.Username = adminData[0];
            connectToAd.Password = adminData[1];
            DirectoryEntry newEntry = connectToAd.Children.Add("CN=" + newUserData[0], "user");
            newEntry.Properties["userPrincipalName"].Value = newUserData[1]; //Имя входа пользователя
            newEntry.Properties["sAMAccountName"].Value = newUserData[1]; // Логин пред Windows 2000
            newEntry.Properties["displayName"].Value = newUserData[0]; //Выводимое имя
            newEntry.Invoke("SetPassword", new object[] { newUserData[4] }); //Задается пароль
            newEntry.Properties["LockOutTime"].Value = 0; //Разблокировка аккаунта
            newEntry.Properties["userAccountControl"].Value = "512"; //Включение, выключение учетной записи
            newEntry.Properties["pwdLastSet"].Value = 0; //требование о смене пароля при первом входе
            newEntry.CommitChanges();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            ouPath = textBoxOU.Text;
            newUserData[4] = textBoxPass.Text;
            adminData[0] = textBoxAdminLogin.Text;
            adminData[1] = textBoxAdminPass.Text;
            for (int i = (int)numericUpDownNewUserStartNumber.Value; i <= (int)numericUpDownNewGroupCounter.Value; i++)
            {
                newUserData[0] = textBoxGroupNumber.Text + "-" + i.ToString();
                
                AdUserCreator(ouPath, newUserData, adminData);
            }
        }
    }
}
