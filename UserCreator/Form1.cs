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
            /*0 ��������� ��� */        "newUserDisplayName",
            /*1 ����� */                "newUserLogin",
            /*2 ������ */               "newUserPass",
            /*3 ���� � ������ ����� */  "HomeDirectory",
            /*4 ����� �������� ����� */ "HomeDrive"
        };
        string[] adminData = new string[]
        {
            /*0 ����� */  "login",
            /*1 ������ */ "pass"
        };

        public static void AdUserCreator(string ouPath, string[] newUserData, string[] adminData)
        {
            DirectoryEntry connectToAd = new DirectoryEntry("LDAP://" + ouPath);
            connectToAd.Username = adminData[0];
            connectToAd.Password = adminData[1];
            DirectoryEntry newEntry = connectToAd.Children.Add("CN=" + newUserData[0], "user");
            newEntry.Properties["userPrincipalName"].Value = newUserData[1]; //��� ����� ������������
            newEntry.Properties["sAMAccountName"].Value = newUserData[1]; // ����� ���� Windows 2000
            newEntry.Properties["displayName"].Value = newUserData[0]; //��������� ���
            FolderCreator(newUserData[3]);
            SetFolderPermissions(newUserData[3], newUserData[0], FileSystemRights.Read | FileSystemRights.Write);
            newEntry.Properties["HomeDirectory"].Value = newUserData[3]; // ���� � �������� �����
            newEntry.Properties["HomeDrive"].Value = newUserData[4]; // ����� �������� ����
            newEntry.CommitChanges();
            newEntry.Invoke("SetPassword", new object[] { newUserData[2] }); //�������� ������
            newEntry.Properties["LockOutTime"].Value = 0; //������������� ��������
            newEntry.Properties["userAccountControl"].Value = "512"; //���������, ���������� ������� ������
            newEntry.Properties["pwdLastSet"].Value = 0; //���������� � ����� ������ ��� ������ �����
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

            // ������� ������� �������
            FileSystemAccessRule accessRule = new FileSystemAccessRule(
                userName,    // ��� ������������ AD
                rights,      // ����� �������
                InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit,
                PropagationFlags.None,
                AccessControlType.Allow);

            // ��������� ������� �������
            directorySecurity.AddAccessRule(accessRule);

            // ��������� ���������
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
