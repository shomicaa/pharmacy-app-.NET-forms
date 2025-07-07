using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.UserControls;

namespace View.FormControllers
{
    public class MainController
    {
        private FrmMain form;
        private readonly Color HoverColor = Color.FromArgb(87, 125, 181); // lighter blue than panelHeader
        private readonly Color ActiveTextColor = Color.FromArgb(255, 255, 200); // light yellowish
        private readonly Color NormalTextColor = Color.White;
        private readonly Color BoardLabelColor = Color.White;

        public MainController(FrmMain frmMain)
        {
            this.form = frmMain;
            AttachEventHandlers();
        }

        internal void Close()
        {
            Communication.Instance.Close();
        }
        private void AttachEventHandlers()
        {
            // attaching hover events for every label
            AttachHoverEvents(form.LblKorisnik);
            AttachHoverEvents(form.LblRacun);
            AttachHoverEvents(form.LblLek);
            AttachHoverEvents(form.LblLokacija);
            AttachHoverEvents(form.Lbl1);
            AttachHoverEvents(form.Lbl2);
            AttachHoverEvents(form.Lbl3);

            // attaching click events for labels from header panel
            form.LblKorisnik.Click += (s, e) => HandleHeaderLabelClick("Korisnik");
            form.LblRacun.Click += (s, e) => HandleHeaderLabelClick("Racun");
            form.LblLek.Click += (s, e) => HandleHeaderLabelClick("Lek");
            form.LblLokacija.Click += (s, e) => HandleHeaderLabelClick("Lokacija");

            // attaching click events for labels on the board panel
            form.Lbl1.Click += (s, e) => HandleBoardLabelClick(1);
            form.Lbl2.Click += (s, e) => HandleBoardLabelClick(2);
            form.Lbl3.Click += (s, e) => HandleBoardLabelClick(3);
        }
        private void AttachHoverEvents(Label label)
        {
            label.MouseEnter += (s, e) => {
                label.BackColor = HoverColor;
            };

            label.MouseLeave += (s, e) => {
                // for panelHeader labels
                if (label.Parent == form.PanelHeader)
                {
                    label.BackColor = Color.Transparent;
                    // reset text color ONLY if not active
                    if (!(label == form.LblKorisnik && form.IsKorisnikActive) &&
                        !(label == form.LblRacun && form.IsRacunActive) &&
                        !(label == form.LblLek && form.IsLekActive) &&
                        !(label == form.LblLokacija && form.IsLokacijaActive))
                    {
                        label.ForeColor = NormalTextColor;
                    }
                }
                else // for panelBoard labels
                {
                    label.BackColor = BoardLabelColor;
                }
            };
        }
        private void ResetHeaderLabelsAppearance()
        {
            form.LblKorisnik.ForeColor = NormalTextColor;
            form.LblKorisnik.BackColor = Color.Transparent;

            form.LblRacun.ForeColor = NormalTextColor;
            form.LblRacun.BackColor = Color.Transparent;

            form.LblLek.ForeColor = NormalTextColor;
            form.LblLek.BackColor = Color.Transparent;

            form.LblLokacija.ForeColor = NormalTextColor;
            form.LblLokacija.BackColor = Color.Transparent;
        }

        private void HandleHeaderLabelClick(string labelType)
        {
            // resetting every activity
            form.IsKorisnikActive = false;
            form.IsRacunActive = false;
            form.IsLekActive = false;
            form.IsLokacijaActive = false;

            ResetLabelNames();
            ResetHeaderLabelsAppearance();

            // setting the active status to clicked label
            switch (labelType)
            {
                case "Korisnik":
                    form.IsKorisnikActive = !form.IsKorisnikActive;
                    if (form.IsKorisnikActive)
                    {
                        form.LblKorisnik.ForeColor = ActiveTextColor;
                        form.LblKorisnik.BackColor = Color.White;
                        UpdateKorisnikBoardLabels();
                    }
                    break;
                case "Racun":
                    form.IsRacunActive = !form.IsRacunActive;
                    if (form.IsRacunActive)
                    {
                        form.LblRacun.ForeColor = ActiveTextColor;
                        form.LblRacun.BackColor = Color.White;
                        UpdateRacunBoardLabels();
                    }
                    break;
                case "Lek":
                    form.IsLekActive = !form.IsLekActive;
                    if (form.IsLekActive)
                    {
                        form.LblLek.ForeColor = ActiveTextColor;
                        form.LblLek.BackColor = Color.White;
                        UpdateLekBoardLabels();
                    }
                    break;
                case "Lokacija":
                    form.IsLokacijaActive = !form.IsLokacijaActive;
                    if (form.IsLokacijaActive)
                    {
                        form.LblLokacija.ForeColor = ActiveTextColor;
                        form.LblLokacija.BackColor = Color.White;
                        UpdateLokacijaBoardLabels();
                    }
                    break;
            }

            // turning visibility for labels on
            form.Lbl1.Visible = GetActiveState(form.Lbl1);
            form.Lbl2.Visible = GetActiveState(form.Lbl2);
            form.Lbl3.Visible = GetActiveState(form.Lbl3);
        }

        private void ResetLabelNames()
        {
            form.Lbl1.Text = "label1";
            form.Lbl2.Text = "label2";
            form.Lbl3.Text = "label3";
        }

        private bool GetActiveState(Label label)
        {
            // returns true if there is an active headerPanel label AND if the labels name is not default
            // (if label's name is default - for that Entity type there is no implementation for more SO in that way)

            return (form.IsKorisnikActive || form.IsRacunActive || form.IsLekActive || form.IsLokacijaActive) && 
                !(label.Text == "label1" || label.Text == "label2" || label.Text == "label3");
        }

        private void UpdateKorisnikBoardLabels()
        {
            form.Lbl1.Text = "Svi Korisnici";
            form.Lbl2.Text = "Dodaj Korisnika";
        }
        private void UpdateRacunBoardLabels()
        {
            form.Lbl1.Text = "Svi Računi";
            form.Lbl2.Text = "Dodaj Račun";
        }
        private void UpdateLekBoardLabels()
        {
            form.Lbl1.Text = "Svi Lekovi";
            form.Lbl2.Text = "Dodaj Lek";
        }
        private void UpdateLokacijaBoardLabels()
        {
            form.Lbl1.Text = "Sve Lokacije";
            form.Lbl2.Text = "Ubaci Lokaciju";
        }
        private void HandleBoardLabelClick(int labelNumber)
        {
            if (form.IsKorisnikActive)
            {
                HandleKorisnikOperation(labelNumber);
            }
            else if (form.IsRacunActive)
            {
                HandleRacunOperation(labelNumber);
            }
            else if (form.IsLekActive)
            {
                HandleLekOperation(labelNumber);
            }
            else if (form.IsLokacijaActive)
            {
                HandleLokacijaOperation(labelNumber);
            }
        }

        private void HandleKorisnikOperation(int labelNumber)
        {
            switch (labelNumber)
            {
                case 1:
                    SetPanel(new UCKorisnici());
                    break;
                case 2:
                    FrmUnosKorisnika frmUnosKorisnika = new FrmUnosKorisnika();
                    frmUnosKorisnika.ShowDialog();
                    break;
            }
        }

        // Implement similar methods for other entities (Racun, Lek, Lokacija, PromoKod)
        private void HandleRacunOperation(int labelNumber) 
        {
            switch (labelNumber)
            {
                case 1:
                    SetPanel(new UCRacuni());
                    break;
                case 2:
                    FrmUnosRacuna frmUnosRacuna = new FrmUnosRacuna();
                    frmUnosRacuna.ShowDialog();
                    break;
            }
        }
        private void HandleLekOperation(int labelNumber) 
        {
            switch (labelNumber)
            {
                case 1:
                    SetPanel(new UCLekovi());
                    break;
                case 2:
                    FrmUnosLeka frmUnosLeka = new FrmUnosLeka();
                    frmUnosLeka.ShowDialog();
                    break;
            }
        }
        private void HandleLokacijaOperation(int labelNumber)
        {
            switch (labelNumber)
            {
                case 1:
                    SetPanel(new UCLokacije());
                    break;
                case 2:
                    FrmUnosLokacije frmUnosLokacije = new FrmUnosLokacije();
                    frmUnosLokacije.ShowDialog();
                    break;
            }
        }

        internal void Init()
        {
            form.Lbl1.Visible = false;
            form.Lbl2.Visible = false;
            form.Lbl3.Visible = false;

            form.IsKorisnikActive = false;
            form.IsRacunActive = false;
            form.IsLekActive = false;
            form.IsLokacijaActive = false;
        }

        public void SetPanel(UserControl userControl)
        {
            form.PanelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            form.PanelMain.Controls.Add(userControl);
        }

    }
}
