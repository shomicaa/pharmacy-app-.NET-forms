using Domain;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using View.Exceptions;

namespace View.FormControllers
{
    public class LoginController
    {
        internal void Login(FrmLogin frmLogin)
        {
            string username = frmLogin.TxtUsername.Text;
            string password = frmLogin.TxtPassword.Text;
            #region username/password check
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                #region username check
                if (string.IsNullOrEmpty(username))
                {
                    frmLogin.TxtUsername.BackColor = Color.Salmon;
                }
                else { frmLogin.TxtUsername.BackColor = default; }
                #endregion
                #region password check
                if (string.IsNullOrEmpty(password))
                {
                    frmLogin.TxtPassword.BackColor = Color.Salmon;
                }
                else { frmLogin.TxtPassword.BackColor = default; }
                #endregion
                return;
            }
            else
            {
                frmLogin.TxtUsername.BackColor = default;
                frmLogin.TxtPassword.BackColor = default;
            }
            #endregion

            Farmaceut farmaceut = new Farmaceut()
            {
                KorisnickoIme = username,
                Lozinka = password,
            };

            try
            {
                Farmaceut trenutniFarmaceut = Communication.Instance.Login(farmaceut);

                if (trenutniFarmaceut != null)
                {
                    frmLogin.DialogResult = DialogResult.OK;
                    frmLogin.Close();
                }
                else
                {
                    MessageBox.Show("Try again!", "Wrong credentials!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Server error!");
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
