namespace CarRental
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
            this.components = new System.ComponentModel.Container();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.costPerMileDisplay = new System.Windows.Forms.TextBox();
            this.costPerDayDisplay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.endMilesBox = new System.Windows.Forms.TextBox();
            this.startMilesBox = new System.Windows.Forms.TextBox();
            this.daysBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.middleInitialBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.gasButtons = new System.Windows.Forms.GroupBox();
            this.emptyButton = new System.Windows.Forms.RadioButton();
            this.quarterButton = new System.Windows.Forms.RadioButton();
            this.halfButton = new System.Windows.Forms.RadioButton();
            this.threeQuartersButton = new System.Windows.Forms.RadioButton();
            this.fullButton = new System.Windows.Forms.RadioButton();
            this.discountButtons = new System.Windows.Forms.GroupBox();
            this.seniorCitizenCheck = new System.Windows.Forms.CheckBox();
            this.frequentRenterCheck = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.showBillButton = new System.Windows.Forms.Button();
            this.rentalBillDisplay = new System.Windows.Forms.RichTextBox();
            this.gasButtons.SuspendLayout();
            this.discountButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Location = new System.Drawing.Point(328, 31);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(172, 21);
            this.carComboBox.TabIndex = 1;
            this.carComboBox.SelectedIndexChanged += new System.EventHandler(this.carComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unit Rented";
            // 
            // costPerMileDisplay
            // 
            this.costPerMileDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.costPerMileDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPerMileDisplay.Location = new System.Drawing.Point(400, 84);
            this.costPerMileDisplay.Name = "costPerMileDisplay";
            this.costPerMileDisplay.ReadOnly = true;
            this.costPerMileDisplay.Size = new System.Drawing.Size(100, 20);
            this.costPerMileDisplay.TabIndex = 2;
            this.costPerMileDisplay.TabStop = false;
            // 
            // costPerDayDisplay
            // 
            this.costPerDayDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.costPerDayDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.costPerDayDisplay.Location = new System.Drawing.Point(400, 58);
            this.costPerDayDisplay.Name = "costPerDayDisplay";
            this.costPerDayDisplay.ReadOnly = true;
            this.costPerDayDisplay.Size = new System.Drawing.Size(100, 20);
            this.costPerDayDisplay.TabIndex = 3;
            this.costPerDayDisplay.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost Per Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost Per Mile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Number of Days";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Starting Mileage";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Ending Miles";
            // 
            // endMilesBox
            // 
            this.endMilesBox.Location = new System.Drawing.Point(159, 161);
            this.endMilesBox.Name = "endMilesBox";
            this.endMilesBox.Size = new System.Drawing.Size(100, 20);
            this.endMilesBox.TabIndex = 13;
            // 
            // startMilesBox
            // 
            this.startMilesBox.Location = new System.Drawing.Point(159, 135);
            this.startMilesBox.Name = "startMilesBox";
            this.startMilesBox.Size = new System.Drawing.Size(100, 20);
            this.startMilesBox.TabIndex = 11;
            // 
            // daysBox
            // 
            this.daysBox.Location = new System.Drawing.Point(159, 109);
            this.daysBox.Name = "daysBox";
            this.daysBox.Size = new System.Drawing.Size(100, 20);
            this.daysBox.TabIndex = 9;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(159, 83);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameBox.TabIndex = 7;
            // 
            // middleInitialBox
            // 
            this.middleInitialBox.Location = new System.Drawing.Point(159, 57);
            this.middleInitialBox.Name = "middleInitialBox";
            this.middleInitialBox.Size = new System.Drawing.Size(23, 20);
            this.middleInitialBox.TabIndex = 5;
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(159, 32);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameBox.TabIndex = 3;
            // 
            // gasButtons
            // 
            this.gasButtons.Controls.Add(this.emptyButton);
            this.gasButtons.Controls.Add(this.quarterButton);
            this.gasButtons.Controls.Add(this.halfButton);
            this.gasButtons.Controls.Add(this.threeQuartersButton);
            this.gasButtons.Controls.Add(this.fullButton);
            this.gasButtons.Location = new System.Drawing.Point(461, 117);
            this.gasButtons.Name = "gasButtons";
            this.gasButtons.Size = new System.Drawing.Size(125, 136);
            this.gasButtons.TabIndex = 15;
            this.gasButtons.TabStop = false;
            this.gasButtons.Text = "Gas Tank on Return";
            // 
            // emptyButton
            // 
            this.emptyButton.AutoSize = true;
            this.emptyButton.Location = new System.Drawing.Point(6, 18);
            this.emptyButton.Name = "emptyButton";
            this.emptyButton.Size = new System.Drawing.Size(82, 17);
            this.emptyButton.TabIndex = 16;
            this.emptyButton.TabStop = true;
            this.emptyButton.Text = "Empty Tank";
            this.emptyButton.UseVisualStyleBackColor = true;
            // 
            // quarterButton
            // 
            this.quarterButton.AutoSize = true;
            this.quarterButton.Location = new System.Drawing.Point(6, 41);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(61, 17);
            this.quarterButton.TabIndex = 17;
            this.quarterButton.TabStop = true;
            this.quarterButton.Text = "1/4 Full";
            this.quarterButton.UseVisualStyleBackColor = true;
            // 
            // halfButton
            // 
            this.halfButton.AutoSize = true;
            this.halfButton.Location = new System.Drawing.Point(6, 64);
            this.halfButton.Name = "halfButton";
            this.halfButton.Size = new System.Drawing.Size(61, 17);
            this.halfButton.TabIndex = 18;
            this.halfButton.TabStop = true;
            this.halfButton.Text = "1/2 Full";
            this.halfButton.UseVisualStyleBackColor = true;
            // 
            // threeQuartersButton
            // 
            this.threeQuartersButton.AutoSize = true;
            this.threeQuartersButton.Location = new System.Drawing.Point(6, 87);
            this.threeQuartersButton.Name = "threeQuartersButton";
            this.threeQuartersButton.Size = new System.Drawing.Size(61, 17);
            this.threeQuartersButton.TabIndex = 19;
            this.threeQuartersButton.TabStop = true;
            this.threeQuartersButton.Text = "3/4 Full";
            this.threeQuartersButton.UseVisualStyleBackColor = true;
            // 
            // fullButton
            // 
            this.fullButton.AutoSize = true;
            this.fullButton.Location = new System.Drawing.Point(6, 110);
            this.fullButton.Name = "fullButton";
            this.fullButton.Size = new System.Drawing.Size(69, 17);
            this.fullButton.TabIndex = 20;
            this.fullButton.TabStop = true;
            this.fullButton.Text = "Full Tank";
            this.fullButton.UseVisualStyleBackColor = true;
            // 
            // discountButtons
            // 
            this.discountButtons.Controls.Add(this.seniorCitizenCheck);
            this.discountButtons.Controls.Add(this.frequentRenterCheck);
            this.discountButtons.Location = new System.Drawing.Point(328, 117);
            this.discountButtons.Name = "discountButtons";
            this.discountButtons.Size = new System.Drawing.Size(112, 76);
            this.discountButtons.TabIndex = 14;
            this.discountButtons.TabStop = false;
            this.discountButtons.Text = "Discounts";
            // 
            // seniorCitizenCheck
            // 
            this.seniorCitizenCheck.AutoSize = true;
            this.seniorCitizenCheck.Location = new System.Drawing.Point(6, 22);
            this.seniorCitizenCheck.Name = "seniorCitizenCheck";
            this.seniorCitizenCheck.Size = new System.Drawing.Size(90, 17);
            this.seniorCitizenCheck.TabIndex = 14;
            this.seniorCitizenCheck.Text = "Senior Citizen";
            this.seniorCitizenCheck.UseVisualStyleBackColor = true;
            // 
            // frequentRenterCheck
            // 
            this.frequentRenterCheck.AutoSize = true;
            this.frequentRenterCheck.Location = new System.Drawing.Point(6, 48);
            this.frequentRenterCheck.Name = "frequentRenterCheck";
            this.frequentRenterCheck.Size = new System.Drawing.Size(103, 17);
            this.frequentRenterCheck.TabIndex = 15;
            this.frequentRenterCheck.Text = "Frequent Renter";
            this.frequentRenterCheck.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 16);
            this.label10.TabIndex = 28;
            this.label10.Text = "Rental Bill";
            // 
            // showBillButton
            // 
            this.showBillButton.Location = new System.Drawing.Point(477, 283);
            this.showBillButton.Name = "showBillButton";
            this.showBillButton.Size = new System.Drawing.Size(75, 23);
            this.showBillButton.TabIndex = 16;
            this.showBillButton.Text = "Show Bill";
            this.showBillButton.UseVisualStyleBackColor = true;
            this.showBillButton.Click += new System.EventHandler(this.showBillButton_Click);
            // 
            // rentalBillDisplay
            // 
            this.rentalBillDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.rentalBillDisplay.Location = new System.Drawing.Point(37, 249);
            this.rentalBillDisplay.MaxLength = 21;
            this.rentalBillDisplay.Name = "rentalBillDisplay";
            this.rentalBillDisplay.ReadOnly = true;
            this.rentalBillDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rentalBillDisplay.Size = new System.Drawing.Size(400, 96);
            this.rentalBillDisplay.TabIndex = 29;
            this.rentalBillDisplay.TabStop = false;
            this.rentalBillDisplay.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 357);
            this.Controls.Add(this.rentalBillDisplay);
            this.Controls.Add(this.showBillButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gasButtons);
            this.Controls.Add(this.discountButtons);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.middleInitialBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.daysBox);
            this.Controls.Add(this.startMilesBox);
            this.Controls.Add(this.endMilesBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costPerDayDisplay);
            this.Controls.Add(this.costPerMileDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carComboBox);
            this.Name = "Form1";
            this.Text = "Rental Return";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gasButtons.ResumeLayout(false);
            this.gasButtons.PerformLayout();
            this.discountButtons.ResumeLayout(false);
            this.discountButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox costPerMileDisplay;
        private System.Windows.Forms.TextBox costPerDayDisplay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox endMilesBox;
        private System.Windows.Forms.TextBox startMilesBox;
        private System.Windows.Forms.TextBox daysBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox middleInitialBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.GroupBox gasButtons;
        private System.Windows.Forms.RadioButton emptyButton;
        private System.Windows.Forms.RadioButton quarterButton;
        private System.Windows.Forms.RadioButton halfButton;
        private System.Windows.Forms.RadioButton threeQuartersButton;
        private System.Windows.Forms.RadioButton fullButton;
        private System.Windows.Forms.GroupBox discountButtons;
        private System.Windows.Forms.CheckBox seniorCitizenCheck;
        private System.Windows.Forms.CheckBox frequentRenterCheck;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button showBillButton;
        private System.Windows.Forms.RichTextBox rentalBillDisplay;
    }
}

