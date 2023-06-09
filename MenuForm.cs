using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.Design.AxImporter;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class MenuForm : Form
    {
        private bool _IsSidebarExpanded = true;
        private bool _IsCalculatorsCollapsed = true;
        private bool _IsConvertersCollapsed = true;
        private const string c_telegramURL = "https://telegram.org/";
        private const string c_instagramURL = "https://www.instagram.com/";
        private const string c_discordURL = "https://discord.com/";
        private const string c_prompt = "Simple application that provides two options:\n1) Calculators\n2) Converters\nYou can choose anything according to needs";
        private bool _isDragging = false;
        private Point _offset;
        private Point _startPoint;
        public MenuForm()
        {
            InitializeComponent();
        }

        private void tmrSidebar_Tick(object sender, EventArgs e)
        {
            if (_IsSidebarExpanded)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= sidebar.MinimumSize.Width)
                {
                    tmrSidebar.Stop();
                    _IsSidebarExpanded = false;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= sidebar.MaximumSize.Width)
                {
                    tmrSidebar.Stop();
                    _IsSidebarExpanded = true;
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (!_IsCalculatorsCollapsed) btnCalculators_Click(sender, e);
            if (!_IsConvertersCollapsed) btnConverters_Click_1(sender, e);
            tmrSidebar.Start();
        }

        private void tmrCalculators_Tick(object sender, EventArgs e)
        {
            if (_IsCalculatorsCollapsed)
            {
                pnlCalculatorsContainer.Height += 10;
                if (pnlCalculatorsContainer.Height >= pnlCalculatorsContainer.MaximumSize.Height)
                {
                    _IsCalculatorsCollapsed = false;
                    tmrCalculators.Stop();
                }
            }
            else
            {
                pnlCalculatorsContainer.Height -= 10;
                if (pnlCalculatorsContainer.Height <= pnlCalculatorsContainer.MinimumSize.Height)
                {
                    _IsCalculatorsCollapsed = true;
                    tmrCalculators.Stop();
                }
            }
        }


        private void tmrConverters_Tick(object sender, EventArgs e)
        {
            if (_IsConvertersCollapsed)
            {
                pnlConvertersContainer.Height += 10;
                if (pnlConvertersContainer.Height >= pnlConvertersContainer.MaximumSize.Height)
                {
                    _IsConvertersCollapsed = false;
                    tmrConverters.Stop();
                }
            }
            else
            {
                pnlConvertersContainer.Height -= 10;
                if (pnlConvertersContainer.Height <= pnlConvertersContainer.MinimumSize.Height)
                {
                    _IsConvertersCollapsed = true;
                    tmrConverters.Stop();
                }
            }
        }

        private void btnCalculators_Click(object sender, EventArgs e)
        {
            if (!_IsSidebarExpanded) return; // TODO
            tmrCalculators.Start();
        }

        private void btnConverters_Click_1(object sender, EventArgs e)
        {
            if (!_IsSidebarExpanded) return; // TODO
            tmrConverters.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTelegram_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe", c_telegramURL + " --new- window");
            }
            catch (Exception)
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", c_telegramURL + " --new- window");
            }
        }

        private void btnInstagram_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe", c_instagramURL + " --new- window");
            }
            catch (Exception)
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", c_instagramURL + " --new- window");
            }
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("chrome.exe", c_discordURL + " --new- window");
            }
            catch (Exception)
            {
                Process.Start(@"C:\Program Files\Google\Chrome\Application\chrome.exe", c_discordURL + " --new- window");
            }
        }

        private void pnlLinkBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalculators_MouseHover(object sender, EventArgs e)
        {
            rtfInfo.Text = !_IsSidebarExpanded ? "It Opens default calculator" : "Show all available calculators";
        }

        private void btnCalculators_MouseLeave(object sender, EventArgs e)
        {
            rtfInfo.Text = "";
        }

        private void btnConverters_MouseHover(object sender, EventArgs e)
        {
            rtfInfo.Text = !_IsSidebarExpanded ? "It Opens default converter" : "Show all available converters";
        }

        private void btnConverters_MouseLeave(object sender, EventArgs e)
        {
            rtfInfo.Text = "";
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            rtfInfo.Text = c_prompt;
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            rtfInfo.Text = "Click on it";
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            if (rtfInfo.Text == c_prompt) return;
            rtfInfo.Text = "";
        }

        private void btnStandartCalculator_Click(object sender, EventArgs e)
        {

            Form childForm = new StandartCalculatorForm();
            childForm.ShowDialog();

        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _startPoint = new(e.X, e.Y);
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new(p.X - _startPoint.X, p.Y - _startPoint.Y);
            }
        }
        private void CloseChildForms(Form currentForm)
        {

            //foreach (Form form in MdiChildren)
            //{

            //    form.Dispose();
            //    form.Close();
            //}
        }

    }
}
