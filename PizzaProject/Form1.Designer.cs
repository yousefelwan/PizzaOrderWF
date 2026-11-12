namespace PizzaProject
{
    partial class Form1
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
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rblarge = new System.Windows.Forms.RadioButton();
            this.rbmedium = new System.Windows.Forms.RadioButton();
            this.rbsmall = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPappers = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkExtraChees = new System.Windows.Forms.CheckBox();
            this.gbWhere = new System.Windows.Forms.GroupBox();
            this.rbEatOut = new System.Windows.Forms.RadioButton();
            this.rbEatin = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnRestForm = new System.Windows.Forms.Button();
            this.lbsummary = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbSizeres = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbToppingsres = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbCrustTyperes = new System.Windows.Forms.Label();
            this.lbWhereEat = new System.Windows.Forms.Label();
            this.lbWhereEatres = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.lbPriceres = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhere.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rblarge);
            this.gbSize.Controls.Add(this.rbmedium);
            this.gbSize.Controls.Add(this.rbsmall);
            this.gbSize.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.Red;
            this.gbSize.Location = new System.Drawing.Point(36, 80);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(110, 133);
            this.gbSize.TabIndex = 0;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rblarge
            // 
            this.rblarge.AutoSize = true;
            this.rblarge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rblarge.ForeColor = System.Drawing.Color.White;
            this.rblarge.Location = new System.Drawing.Point(6, 98);
            this.rblarge.Name = "rblarge";
            this.rblarge.Size = new System.Drawing.Size(81, 28);
            this.rblarge.TabIndex = 2;
            this.rblarge.Tag = "40";
            this.rblarge.Text = "Large";
            this.rblarge.UseVisualStyleBackColor = true;
            this.rblarge.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbmedium
            // 
            this.rbmedium.AutoSize = true;
            this.rbmedium.Checked = true;
            this.rbmedium.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmedium.ForeColor = System.Drawing.Color.White;
            this.rbmedium.Location = new System.Drawing.Point(6, 68);
            this.rbmedium.Name = "rbmedium";
            this.rbmedium.Size = new System.Drawing.Size(101, 28);
            this.rbmedium.TabIndex = 0;
            this.rbmedium.TabStop = true;
            this.rbmedium.Tag = "30";
            this.rbmedium.Text = "Medium";
            this.rbmedium.UseVisualStyleBackColor = true;
            this.rbmedium.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // rbsmall
            // 
            this.rbsmall.AutoSize = true;
            this.rbsmall.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbsmall.ForeColor = System.Drawing.Color.White;
            this.rbsmall.Location = new System.Drawing.Point(6, 34);
            this.rbsmall.Name = "rbsmall";
            this.rbsmall.Size = new System.Drawing.Size(80, 28);
            this.rbsmall.TabIndex = 1;
            this.rbsmall.Tag = "20";
            this.rbsmall.Text = "Small";
            this.rbsmall.UseVisualStyleBackColor = true;
            this.rbsmall.CheckedChanged += new System.EventHandler(this.rbSize_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Make Your Pizza";
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rbThink);
            this.gbCrust.Controls.Add(this.rbThin);
            this.gbCrust.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.Red;
            this.gbCrust.Location = new System.Drawing.Point(33, 265);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(113, 133);
            this.gbCrust.TabIndex = 2;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "CrustType";
            // 
            // rbThink
            // 
            this.rbThink.AutoSize = true;
            this.rbThink.BackColor = System.Drawing.Color.Transparent;
            this.rbThink.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThink.ForeColor = System.Drawing.Color.White;
            this.rbThink.Location = new System.Drawing.Point(3, 102);
            this.rbThink.Name = "rbThink";
            this.rbThink.Size = new System.Drawing.Size(115, 25);
            this.rbThink.TabIndex = 2;
            this.rbThink.Tag = "10";
            this.rbThink.Text = "Think Crust";
            this.rbThink.UseVisualStyleBackColor = false;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbCruxt_CheckedChanged);
            // 
            // rbThin
            // 
            this.rbThin.AutoSize = true;
            this.rbThin.Checked = true;
            this.rbThin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThin.ForeColor = System.Drawing.Color.White;
            this.rbThin.Location = new System.Drawing.Point(6, 34);
            this.rbThin.Name = "rbThin";
            this.rbThin.Size = new System.Drawing.Size(107, 25);
            this.rbThin.TabIndex = 0;
            this.rbThin.TabStop = true;
            this.rbThin.Tag = "0";
            this.rbThin.Text = "Thin Crust";
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbCruxt_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkGreenPappers);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkExtraChees);
            this.gbToppings.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.Red;
            this.gbToppings.Location = new System.Drawing.Point(270, 60);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(300, 146);
            this.gbToppings.TabIndex = 3;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPappers
            // 
            this.chkGreenPappers.AutoSize = true;
            this.chkGreenPappers.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPappers.ForeColor = System.Drawing.Color.White;
            this.chkGreenPappers.Location = new System.Drawing.Point(152, 106);
            this.chkGreenPappers.Name = "chkGreenPappers";
            this.chkGreenPappers.Size = new System.Drawing.Size(140, 25);
            this.chkGreenPappers.TabIndex = 5;
            this.chkGreenPappers.Tag = "5";
            this.chkGreenPappers.Text = "Green Pappers";
            this.chkGreenPappers.UseVisualStyleBackColor = true;
            this.chkGreenPappers.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.ForeColor = System.Drawing.Color.White;
            this.chkTomatoes.Location = new System.Drawing.Point(6, 106);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(106, 25);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.ForeColor = System.Drawing.Color.White;
            this.chkOlives.Location = new System.Drawing.Point(152, 70);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(77, 25);
            this.chkOlives.TabIndex = 3;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.ForeColor = System.Drawing.Color.White;
            this.chkMushrooms.Location = new System.Drawing.Point(6, 70);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(117, 25);
            this.chkMushrooms.TabIndex = 2;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.ForeColor = System.Drawing.Color.White;
            this.chkOnion.Location = new System.Drawing.Point(152, 34);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(75, 25);
            this.chkOnion.TabIndex = 1;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // chkExtraChees
            // 
            this.chkExtraChees.AutoSize = true;
            this.chkExtraChees.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChees.ForeColor = System.Drawing.Color.White;
            this.chkExtraChees.Location = new System.Drawing.Point(6, 34);
            this.chkExtraChees.Name = "chkExtraChees";
            this.chkExtraChees.Size = new System.Drawing.Size(121, 25);
            this.chkExtraChees.TabIndex = 0;
            this.chkExtraChees.Tag = "5";
            this.chkExtraChees.Text = "Extra Chees";
            this.chkExtraChees.UseVisualStyleBackColor = true;
            this.chkExtraChees.CheckedChanged += new System.EventHandler(this.chkToppings_CheckedChanged);
            // 
            // gbWhere
            // 
            this.gbWhere.BackColor = System.Drawing.Color.Transparent;
            this.gbWhere.Controls.Add(this.rbEatOut);
            this.gbWhere.Controls.Add(this.rbEatin);
            this.gbWhere.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhere.ForeColor = System.Drawing.Color.Red;
            this.gbWhere.Location = new System.Drawing.Point(270, 265);
            this.gbWhere.Name = "gbWhere";
            this.gbWhere.Size = new System.Drawing.Size(200, 100);
            this.gbWhere.TabIndex = 4;
            this.gbWhere.TabStop = false;
            this.gbWhere.Text = "Where To Eat";
            // 
            // rbEatOut
            // 
            this.rbEatOut.AutoSize = true;
            this.rbEatOut.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatOut.ForeColor = System.Drawing.Color.White;
            this.rbEatOut.Location = new System.Drawing.Point(106, 48);
            this.rbEatOut.Name = "rbEatOut";
            this.rbEatOut.Size = new System.Drawing.Size(88, 25);
            this.rbEatOut.TabIndex = 6;
            this.rbEatOut.Text = "Eat Out";
            this.rbEatOut.UseVisualStyleBackColor = true;
            this.rbEatOut.CheckedChanged += new System.EventHandler(this.rbWhere_CheckedChanged);
            // 
            // rbEatin
            // 
            this.rbEatin.AutoSize = true;
            this.rbEatin.Checked = true;
            this.rbEatin.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatin.ForeColor = System.Drawing.Color.White;
            this.rbEatin.Location = new System.Drawing.Point(6, 48);
            this.rbEatin.Name = "rbEatin";
            this.rbEatin.Size = new System.Drawing.Size(76, 25);
            this.rbEatin.TabIndex = 5;
            this.rbEatin.TabStop = true;
            this.rbEatin.Text = "Eat In";
            this.rbEatin.UseVisualStyleBackColor = true;
            this.rbEatin.CheckedChanged += new System.EventHandler(this.rbWhere_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderPizza.Location = new System.Drawing.Point(229, 404);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(123, 44);
            this.btnOrderPizza.TabIndex = 5;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnRestForm
            // 
            this.btnRestForm.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestForm.Location = new System.Drawing.Point(408, 404);
            this.btnRestForm.Name = "btnRestForm";
            this.btnRestForm.Size = new System.Drawing.Size(123, 44);
            this.btnRestForm.TabIndex = 6;
            this.btnRestForm.Text = "Rest Form";
            this.btnRestForm.UseVisualStyleBackColor = true;
            this.btnRestForm.Click += new System.EventHandler(this.btnRestForm_Click);
            // 
            // lbsummary
            // 
            this.lbsummary.AutoSize = true;
            this.lbsummary.BackColor = System.Drawing.Color.Transparent;
            this.lbsummary.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsummary.ForeColor = System.Drawing.Color.White;
            this.lbsummary.Location = new System.Drawing.Point(626, 67);
            this.lbsummary.Name = "lbsummary";
            this.lbsummary.Size = new System.Drawing.Size(150, 24);
            this.lbsummary.TabIndex = 7;
            this.lbsummary.Text = "Order Summary";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.BackColor = System.Drawing.Color.Black;
            this.lbSize.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.White;
            this.lbSize.Location = new System.Drawing.Point(638, 101);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(53, 24);
            this.lbSize.TabIndex = 8;
            this.lbSize.Text = "Size:";
            // 
            // lbSizeres
            // 
            this.lbSizeres.AutoSize = true;
            this.lbSizeres.BackColor = System.Drawing.Color.Transparent;
            this.lbSizeres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSizeres.ForeColor = System.Drawing.Color.White;
            this.lbSizeres.Location = new System.Drawing.Point(696, 135);
            this.lbSizeres.Name = "lbSizeres";
            this.lbSizeres.Size = new System.Drawing.Size(80, 24);
            this.lbSizeres.TabIndex = 9;
            this.lbSizeres.Text = "Medium";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.BackColor = System.Drawing.Color.Black;
            this.lbToppings.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.ForeColor = System.Drawing.Color.White;
            this.lbToppings.Location = new System.Drawing.Point(638, 169);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(98, 24);
            this.lbToppings.TabIndex = 10;
            this.lbToppings.Text = "Toppings:";
            // 
            // lbToppingsres
            // 
            this.lbToppingsres.AutoSize = true;
            this.lbToppingsres.BackColor = System.Drawing.Color.Transparent;
            this.lbToppingsres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppingsres.ForeColor = System.Drawing.Color.White;
            this.lbToppingsres.Location = new System.Drawing.Point(676, 203);
            this.lbToppingsres.Name = "lbToppingsres";
            this.lbToppingsres.Size = new System.Drawing.Size(121, 24);
            this.lbToppingsres.TabIndex = 11;
            this.lbToppingsres.Text = "No Toppings";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.BackColor = System.Drawing.Color.Black;
            this.lbCrustType.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.ForeColor = System.Drawing.Color.White;
            this.lbCrustType.Location = new System.Drawing.Point(638, 237);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(107, 24);
            this.lbCrustType.TabIndex = 12;
            this.lbCrustType.Text = "CrustType:";
            // 
            // lbCrustTyperes
            // 
            this.lbCrustTyperes.AutoSize = true;
            this.lbCrustTyperes.BackColor = System.Drawing.Color.Transparent;
            this.lbCrustTyperes.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustTyperes.ForeColor = System.Drawing.Color.White;
            this.lbCrustTyperes.Location = new System.Drawing.Point(696, 271);
            this.lbCrustTyperes.Name = "lbCrustTyperes";
            this.lbCrustTyperes.Size = new System.Drawing.Size(101, 24);
            this.lbCrustTyperes.TabIndex = 13;
            this.lbCrustTyperes.Text = "Thin Crust";
            // 
            // lbWhereEat
            // 
            this.lbWhereEat.AutoSize = true;
            this.lbWhereEat.BackColor = System.Drawing.Color.Black;
            this.lbWhereEat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereEat.ForeColor = System.Drawing.Color.White;
            this.lbWhereEat.Location = new System.Drawing.Point(638, 305);
            this.lbWhereEat.Name = "lbWhereEat";
            this.lbWhereEat.Size = new System.Drawing.Size(139, 24);
            this.lbWhereEat.TabIndex = 14;
            this.lbWhereEat.Text = "Where To Eat:";
            // 
            // lbWhereEatres
            // 
            this.lbWhereEatres.AutoSize = true;
            this.lbWhereEatres.BackColor = System.Drawing.Color.Transparent;
            this.lbWhereEatres.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWhereEatres.ForeColor = System.Drawing.Color.White;
            this.lbWhereEatres.Location = new System.Drawing.Point(703, 339);
            this.lbWhereEatres.Name = "lbWhereEatres";
            this.lbWhereEatres.Size = new System.Drawing.Size(63, 24);
            this.lbWhereEatres.TabIndex = 15;
            this.lbWhereEatres.Text = "Eat In";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.BackColor = System.Drawing.Color.Black;
            this.lbPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(639, 373);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(106, 24);
            this.lbPrice.TabIndex = 16;
            this.lbPrice.Text = "TotalPrice:";
            // 
            // lbPriceres
            // 
            this.lbPriceres.AutoSize = true;
            this.lbPriceres.BackColor = System.Drawing.Color.Transparent;
            this.lbPriceres.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbPriceres.Location = new System.Drawing.Point(703, 407);
            this.lbPriceres.Name = "lbPriceres";
            this.lbPriceres.Size = new System.Drawing.Size(47, 36);
            this.lbPriceres.TabIndex = 17;
            this.lbPriceres.Text = "0$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(949, 489);
            this.Controls.Add(this.lbPriceres);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbWhereEatres);
            this.Controls.Add(this.lbWhereEat);
            this.Controls.Add(this.lbCrustTyperes);
            this.Controls.Add(this.lbCrustType);
            this.Controls.Add(this.lbToppingsres);
            this.Controls.Add(this.lbToppings);
            this.Controls.Add(this.lbSizeres);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbsummary);
            this.Controls.Add(this.btnRestForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbWhere);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbSize);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "PizzaOrder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhere.ResumeLayout(false);
            this.gbWhere.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbsmall;
        private System.Windows.Forms.RadioButton rblarge;
        private System.Windows.Forms.RadioButton rbmedium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPappers;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkExtraChees;
        private System.Windows.Forms.GroupBox gbWhere;
        private System.Windows.Forms.RadioButton rbEatOut;
        private System.Windows.Forms.RadioButton rbEatin;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnRestForm;
        private System.Windows.Forms.Label lbsummary;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbSizeres;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbToppingsres;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbCrustTyperes;
        private System.Windows.Forms.Label lbWhereEat;
        private System.Windows.Forms.Label lbWhereEatres;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbPriceres;
    }
}

