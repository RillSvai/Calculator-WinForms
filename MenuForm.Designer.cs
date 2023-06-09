namespace Calculator
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            pnlHeader = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            sidebar = new FlowLayoutPanel();
            btnMenu = new Button();
            pnlCalculatorsContainer = new Panel();
            btnStandartCalculator = new Button();
            btnCalculators = new Button();
            pnlConvertersContainer = new Panel();
            btnLengthConverter = new Button();
            btnConverters = new Button();
            btnInfo = new Button();
            tmrSidebar = new System.Windows.Forms.Timer(components);
            tmrCalculators = new System.Windows.Forms.Timer(components);
            tmrConverters = new System.Windows.Forms.Timer(components);
            pnlLinkBar = new Panel();
            btnDiscord = new Button();
            btnInstagram = new Button();
            btnTelegram = new Button();
            pnlMain = new Panel();
            rtfInfo = new RichTextBox();
            pnlHeader.SuspendLayout();
            sidebar.SuspendLayout();
            pnlCalculatorsContainer.SuspendLayout();
            pnlConvertersContainer.SuspendLayout();
            pnlLinkBar.SuspendLayout();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(9, 0, 64);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(600, 25);
            pnlHeader.TabIndex = 0;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            pnlHeader.MouseMove += pnlHeader_MouseMove;
            pnlHeader.MouseUp += pnlHeader_MouseUp;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.minus_16_75;
            btnMinimize.Location = new Point(540, 0);
            btnMinimize.Margin = new Padding(0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 25);
            btnMinimize.TabIndex = 1;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.close3_16_75;
            btnClose.Location = new Point(570, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 25);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(9, 0, 64);
            sidebar.Controls.Add(btnMenu);
            sidebar.Controls.Add(pnlCalculatorsContainer);
            sidebar.Controls.Add(pnlConvertersContainer);
            sidebar.Controls.Add(btnInfo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 25);
            sidebar.MaximumSize = new Size(210, 725);
            sidebar.MinimumSize = new Size(50, 725);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(210, 725);
            sidebar.TabIndex = 1;
            // 
            // btnMenu
            // 
            btnMenu.Dock = DockStyle.Top;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Cascadia Code SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenu.ForeColor = Color.White;
            btnMenu.Image = Properties.Resources.list_view1_16;
            btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(0);
            btnMenu.Name = "btnMenu";
            btnMenu.Padding = new Padding(15, 0, 0, 0);
            btnMenu.Size = new Size(210, 75);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlCalculatorsContainer
            // 
            pnlCalculatorsContainer.Controls.Add(btnStandartCalculator);
            pnlCalculatorsContainer.Controls.Add(btnCalculators);
            pnlCalculatorsContainer.Dock = DockStyle.Top;
            pnlCalculatorsContainer.Location = new Point(0, 75);
            pnlCalculatorsContainer.Margin = new Padding(0);
            pnlCalculatorsContainer.MaximumSize = new Size(210, 90);
            pnlCalculatorsContainer.MinimumSize = new Size(210, 50);
            pnlCalculatorsContainer.Name = "pnlCalculatorsContainer";
            pnlCalculatorsContainer.Size = new Size(210, 50);
            pnlCalculatorsContainer.TabIndex = 1;
            // 
            // btnStandartCalculator
            // 
            btnStandartCalculator.Dock = DockStyle.Top;
            btnStandartCalculator.FlatAppearance.BorderSize = 0;
            btnStandartCalculator.FlatStyle = FlatStyle.Flat;
            btnStandartCalculator.Font = new Font("Cascadia Code SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnStandartCalculator.ForeColor = Color.White;
            btnStandartCalculator.ImageAlign = ContentAlignment.MiddleLeft;
            btnStandartCalculator.Location = new Point(0, 50);
            btnStandartCalculator.Margin = new Padding(0);
            btnStandartCalculator.Name = "btnStandartCalculator";
            btnStandartCalculator.Padding = new Padding(15, 0, 0, 0);
            btnStandartCalculator.Size = new Size(210, 40);
            btnStandartCalculator.TabIndex = 3;
            btnStandartCalculator.TabStop = false;
            btnStandartCalculator.Text = "Standart";
            btnStandartCalculator.UseVisualStyleBackColor = true;
            btnStandartCalculator.Click += btnStandartCalculator_Click;
            // 
            // btnCalculators
            // 
            btnCalculators.Dock = DockStyle.Top;
            btnCalculators.FlatAppearance.BorderSize = 0;
            btnCalculators.FlatStyle = FlatStyle.Flat;
            btnCalculators.Font = new Font("Cascadia Code SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalculators.ForeColor = Color.White;
            btnCalculators.Image = Properties.Resources.calculator1_16;
            btnCalculators.ImageAlign = ContentAlignment.MiddleLeft;
            btnCalculators.Location = new Point(0, 0);
            btnCalculators.Margin = new Padding(0);
            btnCalculators.Name = "btnCalculators";
            btnCalculators.Padding = new Padding(15, 0, 0, 0);
            btnCalculators.Size = new Size(210, 50);
            btnCalculators.TabIndex = 2;
            btnCalculators.Text = "Calculators >";
            btnCalculators.UseVisualStyleBackColor = true;
            btnCalculators.Click += btnCalculators_Click;
            btnCalculators.MouseLeave += btnCalculators_MouseLeave;
            btnCalculators.MouseHover += btnCalculators_MouseHover;
            // 
            // pnlConvertersContainer
            // 
            pnlConvertersContainer.Controls.Add(btnLengthConverter);
            pnlConvertersContainer.Controls.Add(btnConverters);
            pnlConvertersContainer.Dock = DockStyle.Top;
            pnlConvertersContainer.Location = new Point(0, 125);
            pnlConvertersContainer.Margin = new Padding(0);
            pnlConvertersContainer.MaximumSize = new Size(210, 90);
            pnlConvertersContainer.MinimumSize = new Size(210, 50);
            pnlConvertersContainer.Name = "pnlConvertersContainer";
            pnlConvertersContainer.Size = new Size(210, 50);
            pnlConvertersContainer.TabIndex = 4;
            // 
            // btnLengthConverter
            // 
            btnLengthConverter.Dock = DockStyle.Top;
            btnLengthConverter.FlatAppearance.BorderSize = 0;
            btnLengthConverter.FlatStyle = FlatStyle.Flat;
            btnLengthConverter.Font = new Font("Cascadia Code SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnLengthConverter.ForeColor = Color.White;
            btnLengthConverter.ImageAlign = ContentAlignment.MiddleLeft;
            btnLengthConverter.Location = new Point(0, 50);
            btnLengthConverter.Margin = new Padding(0);
            btnLengthConverter.Name = "btnLengthConverter";
            btnLengthConverter.Padding = new Padding(15, 0, 0, 0);
            btnLengthConverter.Size = new Size(210, 40);
            btnLengthConverter.TabIndex = 5;
            btnLengthConverter.Text = "Length";
            btnLengthConverter.UseVisualStyleBackColor = true;
            // 
            // btnConverters
            // 
            btnConverters.Dock = DockStyle.Top;
            btnConverters.FlatAppearance.BorderSize = 0;
            btnConverters.FlatStyle = FlatStyle.Flat;
            btnConverters.Font = new Font("Cascadia Code SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConverters.ForeColor = Color.White;
            btnConverters.Image = Properties.Resources.convert1_16;
            btnConverters.ImageAlign = ContentAlignment.MiddleLeft;
            btnConverters.Location = new Point(0, 0);
            btnConverters.Margin = new Padding(0);
            btnConverters.Name = "btnConverters";
            btnConverters.Padding = new Padding(15, 0, 0, 0);
            btnConverters.Size = new Size(210, 50);
            btnConverters.TabIndex = 4;
            btnConverters.TabStop = false;
            btnConverters.Text = "Converters >";
            btnConverters.UseVisualStyleBackColor = true;
            btnConverters.Click += btnConverters_Click_1;
            btnConverters.MouseLeave += btnConverters_MouseLeave;
            btnConverters.MouseHover += btnConverters_MouseHover;
            // 
            // btnInfo
            // 
            btnInfo.Dock = DockStyle.Top;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Cascadia Code SemiLight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.White;
            btnInfo.Image = Properties.Resources.info1_16;
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(0, 175);
            btnInfo.Margin = new Padding(0);
            btnInfo.Name = "btnInfo";
            btnInfo.Padding = new Padding(15, 0, 0, 0);
            btnInfo.Size = new Size(210, 50);
            btnInfo.TabIndex = 5;
            btnInfo.Text = "About program";
            btnInfo.UseVisualStyleBackColor = true;
            btnInfo.Click += btnInfo_Click;
            btnInfo.MouseLeave += btnInfo_MouseLeave;
            btnInfo.MouseHover += btnInfo_MouseHover;
            // 
            // tmrSidebar
            // 
            tmrSidebar.Interval = 20;
            tmrSidebar.Tick += tmrSidebar_Tick;
            // 
            // tmrCalculators
            // 
            tmrCalculators.Interval = 20;
            tmrCalculators.Tick += tmrCalculators_Tick;
            // 
            // tmrConverters
            // 
            tmrConverters.Interval = 20;
            tmrConverters.Tick += tmrConverters_Tick;
            // 
            // pnlLinkBar
            // 
            pnlLinkBar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlLinkBar.Controls.Add(btnDiscord);
            pnlLinkBar.Controls.Add(btnInstagram);
            pnlLinkBar.Controls.Add(btnTelegram);
            pnlLinkBar.Location = new Point(0, 485);
            pnlLinkBar.Margin = new Padding(0);
            pnlLinkBar.MaximumSize = new Size(390, 40);
            pnlLinkBar.Name = "pnlLinkBar";
            pnlLinkBar.Size = new Size(390, 40);
            pnlLinkBar.TabIndex = 2;
            // 
            // btnDiscord
            // 
            btnDiscord.Dock = DockStyle.Right;
            btnDiscord.FlatAppearance.BorderSize = 0;
            btnDiscord.FlatStyle = FlatStyle.Flat;
            btnDiscord.Image = Properties.Resources.discord1_16;
            btnDiscord.Location = new Point(255, 0);
            btnDiscord.Margin = new Padding(0);
            btnDiscord.Name = "btnDiscord";
            btnDiscord.Size = new Size(45, 40);
            btnDiscord.TabIndex = 1;
            btnDiscord.UseVisualStyleBackColor = true;
            btnDiscord.Click += btnDiscord_Click;
            // 
            // btnInstagram
            // 
            btnInstagram.Dock = DockStyle.Right;
            btnInstagram.FlatAppearance.BorderSize = 0;
            btnInstagram.FlatStyle = FlatStyle.Flat;
            btnInstagram.Image = Properties.Resources.instagram1_16;
            btnInstagram.Location = new Point(300, 0);
            btnInstagram.Margin = new Padding(0);
            btnInstagram.Name = "btnInstagram";
            btnInstagram.Size = new Size(45, 40);
            btnInstagram.TabIndex = 2;
            btnInstagram.UseVisualStyleBackColor = true;
            btnInstagram.Click += btnInstagram_Click;
            // 
            // btnTelegram
            // 
            btnTelegram.Dock = DockStyle.Right;
            btnTelegram.FlatAppearance.BorderSize = 0;
            btnTelegram.FlatStyle = FlatStyle.Flat;
            btnTelegram.Image = (Image)resources.GetObject("btnTelegram.Image");
            btnTelegram.Location = new Point(345, 0);
            btnTelegram.Margin = new Padding(0);
            btnTelegram.Name = "btnTelegram";
            btnTelegram.Size = new Size(45, 40);
            btnTelegram.TabIndex = 3;
            btnTelegram.UseVisualStyleBackColor = true;
            btnTelegram.Click += btnTelegram_Click;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(rtfInfo);
            pnlMain.Controls.Add(pnlLinkBar);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(210, 25);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(390, 525);
            pnlMain.TabIndex = 3;
            // 
            // rtfInfo
            // 
            rtfInfo.BackColor = Color.FromArgb(12, 0, 56);
            rtfInfo.BorderStyle = BorderStyle.None;
            rtfInfo.Dock = DockStyle.Top;
            rtfInfo.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rtfInfo.ForeColor = Color.White;
            rtfInfo.Location = new Point(0, 0);
            rtfInfo.Name = "rtfInfo";
            rtfInfo.ReadOnly = true;
            rtfInfo.Size = new Size(390, 482);
            rtfInfo.TabIndex = 3;
            rtfInfo.Text = "Info about otions ...";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 0, 56);
            ClientSize = new Size(600, 550);
            Controls.Add(pnlMain);
            Controls.Add(sidebar);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            pnlHeader.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            pnlCalculatorsContainer.ResumeLayout(false);
            pnlConvertersContainer.ResumeLayout(false);
            pnlLinkBar.ResumeLayout(false);
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnClose;
        private Button btnMinimize;
        private FlowLayoutPanel sidebar;
        private Button btnMenu;
        private Panel pnlCalculatorsContainer;
        private Button btnCalculators;
        private Button btnStandartCalculator;
        private Panel pnlConvertersContainer;
        private Button btnConverters;
        private Button btnLengthConverter;
        private Button btnInfo;
        private System.Windows.Forms.Timer tmrSidebar;
        private System.Windows.Forms.Timer tmrCalculators;
        private System.Windows.Forms.Timer tmrConverters;
        private Panel pnlLinkBar;
        private Button btnTelegram;
        private Button btnDiscord;
        private Button btnInstagram;
        private Panel pnlMain;
        private RichTextBox rtfInfo;
    }
}