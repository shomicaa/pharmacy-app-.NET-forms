using System.Diagnostics;
using System.Net.Sockets;
using View.Exceptions;

namespace View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                try
                {
                    FrmLogin frmLogin = new FrmLogin();
                    DialogResult result = frmLogin.ShowDialog();
                    frmLogin.Dispose();

                    if (result == DialogResult.OK)
                    {
                        Application.Run(new FrmMain());
                    }
                    if (result == DialogResult.Cancel)
                    {
                        break;
                    }
                }
                catch (ServerCommunicationException ex)
                {
                    MessageBox.Show("Connection to server lost. Please log in again.");
                    continue;

                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Connection to server lost. Please log in again.");
                    continue;

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Unexpected error. Please log in again.");
                    Debug.WriteLine($"Message in KorisnickiInterfejs.Program.cs - Exception ex: {ex.Message}");
                    continue;
                }
            }
        }
    }
}