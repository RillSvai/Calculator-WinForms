namespace Calculator
{
    partial class StandartCalculatorForm
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
            pnlHeader = new Panel();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            pnlSubHeader = new Panel();
            lblName = new Label();
            button1 = new Button();
            pnlMain = new Panel();
            fpnlControls = new FlowLayoutPanel();
            btnPercent = new Button();
            btnSquareRoot = new Button();
            btnRaiseSquare = new Button();
            btnInverse = new Button();
            btnClear = new Button();
            btnFullClear = new Button();
            btnDelete = new Button();
            btnDivide = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnMultiply = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnMinus = new Button();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnPlus = new Button();
            btnPlusMinus = new Button();
            btnZero = new Button();
            btnComma = new Button();
            btnEqual = new Button();
            pnlMemory = new Panel();
            btnMemory6 = new Button();
            btnMemory5 = new Button();
            btnMemory4 = new Button();
            btnMemory3 = new Button();
            btnMemory2 = new Button();
            btnMemory1 = new Button();
            Display = new TextBox();
            subDisplay = new TextBox();
            pnlHeader.SuspendLayout();
            pnlSubHeader.SuspendLayout();
            pnlMain.SuspendLayout();
            fpnlControls.SuspendLayout();
            pnlMemory.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(33, 0, 70);
            pnlHeader.Controls.Add(btnMinimize);
            pnlHeader.Controls.Add(btnMaximize);
            pnlHeader.Controls.Add(btnClose);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(390, 25);
            pnlHeader.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Image = Properties.Resources.minus_16_75;
            btnMinimize.Location = new Point(300, 0);
            btnMinimize.Margin = new Padding(0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(30, 25);
            btnMinimize.TabIndex = 4;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Image = Properties.Resources.square1_16_75;
            btnMaximize.Location = new Point(330, 0);
            btnMaximize.Margin = new Padding(0);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(30, 25);
            btnMaximize.TabIndex = 3;
            btnMaximize.UseVisualStyleBackColor = true;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Image = Properties.Resources.close3_16_75;
            btnClose.Location = new Point(360, 0);
            btnClose.Margin = new Padding(0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 25);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pnlSubHeader
            // 
            pnlSubHeader.BackColor = Color.FromArgb(33, 0, 70);
            pnlSubHeader.Controls.Add(lblName);
            pnlSubHeader.Controls.Add(button1);
            pnlSubHeader.Dock = DockStyle.Top;
            pnlSubHeader.Location = new Point(0, 25);
            pnlSubHeader.Margin = new Padding(0);
            pnlSubHeader.Name = "pnlSubHeader";
            pnlSubHeader.Size = new Size(390, 30);
            pnlSubHeader.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Left;
            lblName.FlatStyle = FlatStyle.Flat;
            lblName.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(0, 0);
            lblName.Margin = new Padding(0);
            lblName.Name = "lblName";
            lblName.Size = new Size(181, 21);
            lblName.TabIndex = 5;
            lblName.Text = "Standart Calculator";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.history1_16;
            button1.Location = new Point(360, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(33, 0, 70);
            pnlMain.Controls.Add(fpnlControls);
            pnlMain.Controls.Add(pnlMemory);
            pnlMain.Controls.Add(Display);
            pnlMain.Controls.Add(subDisplay);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 55);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(390, 515);
            pnlMain.TabIndex = 2;
            // 
            // fpnlControls
            // 
            fpnlControls.Controls.Add(btnPercent);
            fpnlControls.Controls.Add(btnSquareRoot);
            fpnlControls.Controls.Add(btnRaiseSquare);
            fpnlControls.Controls.Add(btnInverse);
            fpnlControls.Controls.Add(btnClear);
            fpnlControls.Controls.Add(btnFullClear);
            fpnlControls.Controls.Add(btnDelete);
            fpnlControls.Controls.Add(btnDivide);
            fpnlControls.Controls.Add(btnSeven);
            fpnlControls.Controls.Add(btnEight);
            fpnlControls.Controls.Add(btnNine);
            fpnlControls.Controls.Add(btnMultiply);
            fpnlControls.Controls.Add(btnFour);
            fpnlControls.Controls.Add(btnFive);
            fpnlControls.Controls.Add(btnSix);
            fpnlControls.Controls.Add(btnMinus);
            fpnlControls.Controls.Add(btnOne);
            fpnlControls.Controls.Add(btnTwo);
            fpnlControls.Controls.Add(btnThree);
            fpnlControls.Controls.Add(btnPlus);
            fpnlControls.Controls.Add(btnPlusMinus);
            fpnlControls.Controls.Add(btnZero);
            fpnlControls.Controls.Add(btnComma);
            fpnlControls.Controls.Add(btnEqual);
            fpnlControls.Dock = DockStyle.Fill;
            fpnlControls.Location = new Point(0, 145);
            fpnlControls.Name = "fpnlControls";
            fpnlControls.Size = new Size(390, 370);
            fpnlControls.TabIndex = 3;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.FromArgb(33, 0, 55);
            btnPercent.FlatAppearance.BorderSize = 0;
            btnPercent.FlatStyle = FlatStyle.Flat;
            btnPercent.Font = new Font("Cascadia Code SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPercent.ForeColor = Color.White;
            btnPercent.Location = new Point(3, 3);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(91, 55);
            btnPercent.TabIndex = 4;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnSquareRoot
            // 
            btnSquareRoot.BackColor = Color.FromArgb(33, 0, 55);
            btnSquareRoot.Dock = DockStyle.Bottom;
            btnSquareRoot.FlatAppearance.BorderSize = 0;
            btnSquareRoot.FlatStyle = FlatStyle.Flat;
            btnSquareRoot.Font = new Font("Cascadia Code SemiLight", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSquareRoot.ForeColor = Color.White;
            btnSquareRoot.Image = Properties.Resources.square_root_16;
            btnSquareRoot.Location = new Point(100, 3);
            btnSquareRoot.Name = "btnSquareRoot";
            btnSquareRoot.Size = new Size(91, 55);
            btnSquareRoot.TabIndex = 5;
            btnSquareRoot.UseVisualStyleBackColor = false;
            // 
            // btnRaiseSquare
            // 
            btnRaiseSquare.BackColor = Color.FromArgb(33, 0, 55);
            btnRaiseSquare.Dock = DockStyle.Bottom;
            btnRaiseSquare.FlatAppearance.BorderSize = 0;
            btnRaiseSquare.FlatStyle = FlatStyle.Flat;
            btnRaiseSquare.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnRaiseSquare.ForeColor = Color.White;
            btnRaiseSquare.Location = new Point(197, 3);
            btnRaiseSquare.Name = "btnRaiseSquare";
            btnRaiseSquare.Size = new Size(91, 55);
            btnRaiseSquare.TabIndex = 6;
            btnRaiseSquare.Text = "x^2";
            btnRaiseSquare.UseVisualStyleBackColor = false;
            // 
            // btnInverse
            // 
            btnInverse.BackColor = Color.FromArgb(33, 0, 55);
            btnInverse.Dock = DockStyle.Bottom;
            btnInverse.FlatAppearance.BorderSize = 0;
            btnInverse.FlatStyle = FlatStyle.Flat;
            btnInverse.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnInverse.ForeColor = Color.White;
            btnInverse.Location = new Point(294, 3);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(91, 55);
            btnInverse.TabIndex = 7;
            btnInverse.Text = "1/x";
            btnInverse.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(33, 0, 55);
            btnClear.Dock = DockStyle.Bottom;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(3, 64);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(91, 55);
            btnClear.TabIndex = 8;
            btnClear.Text = "CE";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnFullClear
            // 
            btnFullClear.BackColor = Color.FromArgb(33, 0, 55);
            btnFullClear.Dock = DockStyle.Bottom;
            btnFullClear.FlatAppearance.BorderSize = 0;
            btnFullClear.FlatStyle = FlatStyle.Flat;
            btnFullClear.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFullClear.ForeColor = Color.White;
            btnFullClear.Location = new Point(100, 64);
            btnFullClear.Name = "btnFullClear";
            btnFullClear.Size = new Size(91, 55);
            btnFullClear.TabIndex = 9;
            btnFullClear.Text = "C";
            btnFullClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(33, 0, 55);
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Image = Properties.Resources.delete_24;
            btnDelete.Location = new Point(197, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(91, 55);
            btnDelete.TabIndex = 10;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(33, 0, 55);
            btnDivide.Dock = DockStyle.Bottom;
            btnDivide.FlatAppearance.BorderSize = 0;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(294, 64);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(91, 55);
            btnDivide.TabIndex = 11;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.FromArgb(33, 0, 45);
            btnSeven.Dock = DockStyle.Bottom;
            btnSeven.FlatAppearance.BorderSize = 0;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSeven.ForeColor = Color.White;
            btnSeven.Location = new Point(3, 125);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(91, 55);
            btnSeven.TabIndex = 12;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.FromArgb(33, 0, 45);
            btnEight.Dock = DockStyle.Bottom;
            btnEight.FlatAppearance.BorderSize = 0;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEight.ForeColor = Color.White;
            btnEight.Location = new Point(100, 125);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(91, 55);
            btnEight.TabIndex = 13;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.FromArgb(33, 0, 45);
            btnNine.Dock = DockStyle.Bottom;
            btnNine.FlatAppearance.BorderSize = 0;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNine.ForeColor = Color.White;
            btnNine.Location = new Point(197, 125);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(91, 55);
            btnNine.TabIndex = 14;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(33, 0, 55);
            btnMultiply.Dock = DockStyle.Bottom;
            btnMultiply.FlatAppearance.BorderSize = 0;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(294, 125);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(91, 55);
            btnMultiply.TabIndex = 15;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = false;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.FromArgb(33, 0, 45);
            btnFour.Dock = DockStyle.Bottom;
            btnFour.FlatAppearance.BorderSize = 0;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFour.ForeColor = Color.White;
            btnFour.Location = new Point(3, 186);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(91, 55);
            btnFour.TabIndex = 16;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.FromArgb(33, 0, 45);
            btnFive.Dock = DockStyle.Bottom;
            btnFive.FlatAppearance.BorderSize = 0;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFive.ForeColor = Color.White;
            btnFive.Location = new Point(100, 186);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(91, 55);
            btnFive.TabIndex = 17;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.FromArgb(33, 0, 45);
            btnSix.Dock = DockStyle.Bottom;
            btnSix.FlatAppearance.BorderSize = 0;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnSix.ForeColor = Color.White;
            btnSix.Location = new Point(197, 186);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(91, 55);
            btnSix.TabIndex = 18;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(33, 0, 55);
            btnMinus.Dock = DockStyle.Bottom;
            btnMinus.FlatAppearance.BorderSize = 0;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinus.ForeColor = Color.White;
            btnMinus.Location = new Point(294, 186);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(91, 55);
            btnMinus.TabIndex = 19;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.FromArgb(33, 0, 45);
            btnOne.Dock = DockStyle.Bottom;
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnOne.ForeColor = Color.White;
            btnOne.Location = new Point(3, 247);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(91, 55);
            btnOne.TabIndex = 20;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.FromArgb(33, 0, 45);
            btnTwo.Dock = DockStyle.Bottom;
            btnTwo.FlatAppearance.BorderSize = 0;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnTwo.ForeColor = Color.White;
            btnTwo.Location = new Point(100, 247);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(91, 55);
            btnTwo.TabIndex = 21;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.FromArgb(33, 0, 45);
            btnThree.Dock = DockStyle.Bottom;
            btnThree.FlatAppearance.BorderSize = 0;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnThree.ForeColor = Color.White;
            btnThree.Location = new Point(197, 247);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(91, 55);
            btnThree.TabIndex = 22;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(33, 0, 55);
            btnPlus.Dock = DockStyle.Bottom;
            btnPlus.FlatAppearance.BorderSize = 0;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlus.ForeColor = Color.White;
            btnPlus.Location = new Point(294, 247);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(91, 55);
            btnPlus.TabIndex = 23;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.FromArgb(33, 0, 55);
            btnPlusMinus.Dock = DockStyle.Bottom;
            btnPlusMinus.FlatAppearance.BorderSize = 0;
            btnPlusMinus.FlatStyle = FlatStyle.Flat;
            btnPlusMinus.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlusMinus.ForeColor = Color.White;
            btnPlusMinus.Image = Properties.Resources.positive_and_negative_16;
            btnPlusMinus.Location = new Point(3, 308);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(91, 55);
            btnPlusMinus.TabIndex = 26;
            btnPlusMinus.UseVisualStyleBackColor = false;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(33, 0, 45);
            btnZero.Dock = DockStyle.Bottom;
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnZero.ForeColor = Color.White;
            btnZero.Location = new Point(100, 308);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(91, 55);
            btnZero.TabIndex = 27;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            // 
            // btnComma
            // 
            btnComma.BackColor = Color.FromArgb(33, 0, 55);
            btnComma.Dock = DockStyle.Bottom;
            btnComma.FlatAppearance.BorderSize = 0;
            btnComma.FlatStyle = FlatStyle.Flat;
            btnComma.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnComma.ForeColor = Color.White;
            btnComma.Location = new Point(197, 308);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(91, 55);
            btnComma.TabIndex = 28;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = false;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.FromArgb(33, 0, 55);
            btnEqual.Dock = DockStyle.Bottom;
            btnEqual.FlatAppearance.BorderSize = 0;
            btnEqual.FlatStyle = FlatStyle.Flat;
            btnEqual.Font = new Font("Cascadia Code SemiLight", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.ForeColor = Color.White;
            btnEqual.Location = new Point(294, 308);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(91, 55);
            btnEqual.TabIndex = 29;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // pnlMemory
            // 
            pnlMemory.BackColor = Color.FromArgb(33, 0, 70);
            pnlMemory.Controls.Add(btnMemory6);
            pnlMemory.Controls.Add(btnMemory5);
            pnlMemory.Controls.Add(btnMemory4);
            pnlMemory.Controls.Add(btnMemory3);
            pnlMemory.Controls.Add(btnMemory2);
            pnlMemory.Controls.Add(btnMemory1);
            pnlMemory.Dock = DockStyle.Top;
            pnlMemory.Font = new Font("Cascadia Code SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            pnlMemory.ForeColor = Color.White;
            pnlMemory.Location = new Point(0, 110);
            pnlMemory.Margin = new Padding(0);
            pnlMemory.Name = "pnlMemory";
            pnlMemory.Size = new Size(390, 35);
            pnlMemory.TabIndex = 2;
            // 
            // btnMemory6
            // 
            btnMemory6.Dock = DockStyle.Right;
            btnMemory6.FlatAppearance.BorderSize = 0;
            btnMemory6.FlatStyle = FlatStyle.Flat;
            btnMemory6.Location = new Point(0, 0);
            btnMemory6.Margin = new Padding(0);
            btnMemory6.Name = "btnMemory6";
            btnMemory6.Size = new Size(65, 35);
            btnMemory6.TabIndex = 7;
            btnMemory6.Text = "MC";
            btnMemory6.UseVisualStyleBackColor = true;
            // 
            // btnMemory5
            // 
            btnMemory5.Dock = DockStyle.Right;
            btnMemory5.FlatAppearance.BorderSize = 0;
            btnMemory5.FlatStyle = FlatStyle.Flat;
            btnMemory5.Location = new Point(65, 0);
            btnMemory5.Margin = new Padding(0);
            btnMemory5.Name = "btnMemory5";
            btnMemory5.Size = new Size(65, 35);
            btnMemory5.TabIndex = 6;
            btnMemory5.Text = "MR";
            btnMemory5.UseVisualStyleBackColor = true;
            // 
            // btnMemory4
            // 
            btnMemory4.Dock = DockStyle.Right;
            btnMemory4.FlatAppearance.BorderSize = 0;
            btnMemory4.FlatStyle = FlatStyle.Flat;
            btnMemory4.Location = new Point(130, 0);
            btnMemory4.Margin = new Padding(0);
            btnMemory4.Name = "btnMemory4";
            btnMemory4.Size = new Size(65, 35);
            btnMemory4.TabIndex = 5;
            btnMemory4.Text = "M-";
            btnMemory4.UseVisualStyleBackColor = true;
            // 
            // btnMemory3
            // 
            btnMemory3.Dock = DockStyle.Right;
            btnMemory3.FlatAppearance.BorderSize = 0;
            btnMemory3.FlatStyle = FlatStyle.Flat;
            btnMemory3.Location = new Point(195, 0);
            btnMemory3.Margin = new Padding(0);
            btnMemory3.Name = "btnMemory3";
            btnMemory3.Size = new Size(65, 35);
            btnMemory3.TabIndex = 4;
            btnMemory3.Text = "M+";
            btnMemory3.UseVisualStyleBackColor = true;
            // 
            // btnMemory2
            // 
            btnMemory2.Dock = DockStyle.Right;
            btnMemory2.FlatAppearance.BorderSize = 0;
            btnMemory2.FlatStyle = FlatStyle.Flat;
            btnMemory2.Location = new Point(260, 0);
            btnMemory2.Margin = new Padding(0);
            btnMemory2.Name = "btnMemory2";
            btnMemory2.Size = new Size(65, 35);
            btnMemory2.TabIndex = 3;
            btnMemory2.Text = "MS";
            btnMemory2.UseVisualStyleBackColor = true;
            // 
            // btnMemory1
            // 
            btnMemory1.Dock = DockStyle.Right;
            btnMemory1.FlatAppearance.BorderSize = 0;
            btnMemory1.FlatStyle = FlatStyle.Flat;
            btnMemory1.Location = new Point(325, 0);
            btnMemory1.Margin = new Padding(0);
            btnMemory1.Name = "btnMemory1";
            btnMemory1.Size = new Size(65, 35);
            btnMemory1.TabIndex = 2;
            btnMemory1.Text = "M^";
            btnMemory1.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            Display.BackColor = Color.FromArgb(33, 0, 70);
            Display.BorderStyle = BorderStyle.None;
            Display.Dock = DockStyle.Top;
            Display.Font = new Font("Cascadia Mono SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Display.ForeColor = Color.White;
            Display.Location = new Point(0, 30);
            Display.Margin = new Padding(0);
            Display.Multiline = true;
            Display.Name = "Display";
            Display.ReadOnly = true;
            Display.Size = new Size(390, 80);
            Display.TabIndex = 1;
            Display.Text = "322323";
            Display.TextAlign = HorizontalAlignment.Right;
            // 
            // subDisplay
            // 
            subDisplay.BackColor = Color.FromArgb(33, 0, 70);
            subDisplay.BorderStyle = BorderStyle.None;
            subDisplay.Dock = DockStyle.Top;
            subDisplay.Font = new Font("Cascadia Code SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            subDisplay.ForeColor = Color.Gray;
            subDisplay.Location = new Point(0, 0);
            subDisplay.Margin = new Padding(0);
            subDisplay.Multiline = true;
            subDisplay.Name = "subDisplay";
            subDisplay.ReadOnly = true;
            subDisplay.Size = new Size(390, 30);
            subDisplay.TabIndex = 0;
            subDisplay.Text = "322323";
            subDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // StandartCalculatorForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(390, 570);
            Controls.Add(pnlMain);
            Controls.Add(pnlSubHeader);
            Controls.Add(pnlHeader);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "StandartCalculatorForm";
            Text = "Standart сalculator";
            FormClosed += StandartCalculatorForm_FormClosed;
            Load += StandartCalculatorForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlSubHeader.ResumeLayout(false);
            pnlSubHeader.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            fpnlControls.ResumeLayout(false);
            pnlMemory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Panel pnlSubHeader;
        private Label lblName;
        private Button button1;
        private Panel pnlMain;
        private Panel pnlMemory;
        private Button btnMemory6;
        private Button btnMemory5;
        private Button btnMemory4;
        private Button btnMemory3;
        private Button btnMemory2;
        private Button btnMemory1;
        private TextBox Display;
        private TextBox subDisplay;
        private FlowLayoutPanel fpnlControls;
        private Button btnPercent;
        private Button btnSquareRoot;
        private Button btnRaiseSquare;
        private Button btnInverse;
        private Button btnClear;
        private Button btnFullClear;
        private Button btnDelete;
        private Button btnDivide;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnMultiply;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnMinus;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnPlus;
        private Button btnPlusMinus;
        private Button btnZero;
        private Button btnComma;
        private Button btnEqual;
    }
}