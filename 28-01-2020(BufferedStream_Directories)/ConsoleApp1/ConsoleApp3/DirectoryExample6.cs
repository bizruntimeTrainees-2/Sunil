using System;
using System.IO;
using System.Security.AccessControl;

namespace ConsoleApp3
{
    class DirectoryExample6
    {
        public void CreatingSecurityToDirectory()
        {
            try
            {
                String DirectoryName = "TestDirectory";
                Console.WriteLine("Adding access controle for " + DirectoryName);

                AddDirectorySecurity(DirectoryName, @"MYDOMINE\MyAccount", FileSystemRights.ReadData, AccessControlType.Allow);

                Console.WriteLine("done");

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }

        public static void AddDirectorySecurity(string FileName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(FileName);

            // Get a DirectorySecurity object that represents the 
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings. 
            dSecurity.AddAccessRule(new FileSystemAccessRule(Account,
                                                            Rights,
                                                            ControlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);
        }
    }
}
