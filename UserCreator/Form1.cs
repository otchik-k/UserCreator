using System.DirectoryServices;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

namespace UserCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] newUserData = new string[] {
            /*0 Выводимое имя */        "newUserDisplayName",
            /*1 Логин */                "newUserLogin",
            /*2 Пароль */               "newUserPass",
            /*3 Путь к общему диску */  "HomeDirectory",
            /*4 Буква сетевого диска */ "HomeDrive"
        };
        string[] adminData = new string[]
        {
            /*0 логин */  "login",
            /*1 пароль */ "pass"
        };

        public static void AdUserCreator(string ouPath, string[] newUserData, string[] adminData)
        {
            DirectoryEntry connectToAd = new DirectoryEntry("LDAP://" + ouPath);
            connectToAd.Username = adminData[0];
            connectToAd.Password = adminData[1];
            DirectoryEntry newEntry = connectToAd.Children.Add("CN=" + newUserData[0], "user");
            newEntry.Properties["userPrincipalName"].Value = newUserData[1]; //Имя входа пользователя
            newEntry.Properties["sAMAccountName"].Value = newUserData[1]; // Логин пред Windows 2000
            newEntry.Properties["displayName"].Value = newUserData[0]; //Выводимое имя
            FolderCreator(newUserData[3]);
            SetFolderPermissions(newUserData[3], newUserData[0], FileSystemRights.Read | FileSystemRights.Write);
            newEntry.Properties["HomeDirectory"].Value = newUserData[3]; // Путь к сетевому диску
            newEntry.Properties["HomeDrive"].Value = newUserData[4]; // Буква сетевого иска
            newEntry.CommitChanges();
            newEntry.Invoke("SetPassword", new object[] { newUserData[2] }); //Задается пароль
            newEntry.Properties["LockOutTime"].Value = 0; //Разблокировка аккаунта
            newEntry.Properties["userAccountControl"].Value = "512"; //Включение, выключение учетной записи
            newEntry.Properties["pwdLastSet"].Value = 0; //требование о смене пароля при первом входе
            newEntry.CommitChanges();
        }

        public static void FolderCreator(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public static void SetFolderPermissions(string folderPath, string userName, FileSystemRights rights)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderPath);
            DirectorySecurity directorySecurity = directoryInfo.GetAccessControl();

            // Создаем правило доступа
            FileSystemAccessRule accessRule = new FileSystemAccessRule(
                userName,    // Имя пользователя AD
                rights,      // Права доступа
                InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None,
                AccessControlType.Allow);

            // Добавляем правило доступа
            directorySecurity.AddAccessRule(accessRule);

            // Применяем изменения
            directoryInfo.SetAccessControl(directorySecurity);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            for (int i = (int)numericUpDownNewUserStartNumber.Value; i <= (int)numericUpDownNewGroupCounter.Value; i++)
            {
                newUserData[0] = textBoxGroupNumber.Text + "-" + i.ToString();
                newUserData[1] = textBoxGroupNumber.Text + "-" + i.ToString();
                newUserData[2] = textBoxPass.Text;
                newUserData[3] = textBoxNetDiskAdress.Text + "\\" + newUserData[1];
                newUserData[4] = textBoxHomeDrive.Text;
                adminData[0] = textBoxAdminLogin.Text;
                adminData[1] = textBoxAdminPass.Text;

                AdUserCreator(textBoxOU.Text, newUserData, adminData);
            }
        }
    }
}
