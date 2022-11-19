namespace Coffee_Calculator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toAMPM = new System.Windows.Forms.ComboBox();
            this.fromAMPM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gumLbl = new System.Windows.Forms.Label();
            this.coffeeLbl = new System.Windows.Forms.Label();
            this.fromHours = new System.Windows.Forms.NumericUpDown();
            this.fromMinutes = new System.Windows.Forms.NumericUpDown();
            this.toHours = new System.Windows.Forms.NumericUpDown();
            this.toMinutes = new System.Windows.Forms.NumericUpDown();
            this.consumedcoffeeLbl = new System.Windows.Forms.Label();
            this.consumedgumLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.useCurrentTime = new System.Windows.Forms.CheckBox();
            this.minuteCounter = new System.Windows.Forms.Label();
            this.coffeeNotify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fromHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Shift Details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Joe Will Need:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "cups of coffee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "To:";
            // 
            // toAMPM
            // 
            this.toAMPM.FormattingEnabled = true;
            this.toAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.toAMPM.Location = new System.Drawing.Point(128, 66);
            this.toAMPM.Name = "toAMPM";
            this.toAMPM.Size = new System.Drawing.Size(47, 21);
            this.toAMPM.TabIndex = 5;
            this.toAMPM.SelectedIndexChanged += new System.EventHandler(this.toAMPM_SelectedIndexChanged);
            // 
            // fromAMPM
            // 
            this.fromAMPM.FormattingEnabled = true;
            this.fromAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.fromAMPM.Location = new System.Drawing.Point(128, 40);
            this.fromAMPM.Name = "fromAMPM";
            this.fromAMPM.Size = new System.Drawing.Size(47, 21);
            this.fromAMPM.TabIndex = 2;
            this.fromAMPM.SelectedIndexChanged += new System.EventHandler(this.fromAMPM_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "pieces of gum";
            // 
            // gumLbl
            // 
            this.gumLbl.AutoSize = true;
            this.gumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumLbl.Location = new System.Drawing.Point(4, 190);
            this.gumLbl.Name = "gumLbl";
            this.gumLbl.Size = new System.Drawing.Size(25, 25);
            this.gumLbl.TabIndex = 12;
            this.gumLbl.Text = "0";
            // 
            // coffeeLbl
            // 
            this.coffeeLbl.AutoSize = true;
            this.coffeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeLbl.Location = new System.Drawing.Point(4, 135);
            this.coffeeLbl.Name = "coffeeLbl";
            this.coffeeLbl.Size = new System.Drawing.Size(25, 25);
            this.coffeeLbl.TabIndex = 13;
            this.coffeeLbl.Text = "0";
            // 
            // fromHours
            // 
            this.fromHours.InterceptArrowKeys = false;
            this.fromHours.Location = new System.Drawing.Point(47, 40);
            this.fromHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.fromHours.Name = "fromHours";
            this.fromHours.Size = new System.Drawing.Size(35, 20);
            this.fromHours.TabIndex = 0;
            this.fromHours.ValueChanged += new System.EventHandler(this.fromHours_ValueChanged);
            this.fromHours.Click += new System.EventHandler(this.fromHours_Click);
            // 
            // fromMinutes
            // 
            this.fromMinutes.Location = new System.Drawing.Point(89, 40);
            this.fromMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.fromMinutes.Name = "fromMinutes";
            this.fromMinutes.Size = new System.Drawing.Size(35, 20);
            this.fromMinutes.TabIndex = 1;
            this.fromMinutes.ValueChanged += new System.EventHandler(this.fromMinutes_ValueChanged);
            this.fromMinutes.Click += new System.EventHandler(this.fromMinutes_Click);
            // 
            // toHours
            // 
            this.toHours.Location = new System.Drawing.Point(46, 66);
            this.toHours.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.toHours.Name = "toHours";
            this.toHours.Size = new System.Drawing.Size(35, 20);
            this.toHours.TabIndex = 3;
            this.toHours.ValueChanged += new System.EventHandler(this.toHours_ValueChanged);
            this.toHours.Click += new System.EventHandler(this.toHours_Click);
            // 
            // toMinutes
            // 
            this.toMinutes.Location = new System.Drawing.Point(88, 66);
            this.toMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.toMinutes.Name = "toMinutes";
            this.toMinutes.Size = new System.Drawing.Size(35, 20);
            this.toMinutes.TabIndex = 4;
            this.toMinutes.ValueChanged += new System.EventHandler(this.toMinutes_ValueChanged);
            this.toMinutes.Click += new System.EventHandler(this.toMinutes_Click);
            // 
            // consumedcoffeeLbl
            // 
            this.consumedcoffeeLbl.AllowDrop = true;
            this.consumedcoffeeLbl.AutoSize = true;
            this.consumedcoffeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumedcoffeeLbl.Location = new System.Drawing.Point(4, 270);
            this.consumedcoffeeLbl.Name = "consumedcoffeeLbl";
            this.consumedcoffeeLbl.Size = new System.Drawing.Size(25, 25);
            this.consumedcoffeeLbl.TabIndex = 26;
            this.consumedcoffeeLbl.Text = "0";
            // 
            // consumedgumLbl
            // 
            this.consumedgumLbl.AutoSize = true;
            this.consumedgumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consumedgumLbl.Location = new System.Drawing.Point(4, 322);
            this.consumedgumLbl.Name = "consumedgumLbl";
            this.consumedgumLbl.Size = new System.Drawing.Size(25, 25);
            this.consumedgumLbl.TabIndex = 25;
            this.consumedgumLbl.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "pieces of gum";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "cups of coffee";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Joe Has Consumed:";
            // 
            // useCurrentTime
            // 
            this.useCurrentTime.AutoSize = true;
            this.useCurrentTime.Location = new System.Drawing.Point(48, 93);
            this.useCurrentTime.Name = "useCurrentTime";
            this.useCurrentTime.Size = new System.Drawing.Size(108, 17);
            this.useCurrentTime.TabIndex = 6;
            this.useCurrentTime.Text = "Use Current Time";
            this.useCurrentTime.UseVisualStyleBackColor = true;
            this.useCurrentTime.CheckedChanged += new System.EventHandler(this.useCurrentTime_CheckedChanged);
            // 
            // minuteCounter
            // 
            this.minuteCounter.AutoSize = true;
            this.minuteCounter.Location = new System.Drawing.Point(130, 14);
            this.minuteCounter.Name = "minuteCounter";
            this.minuteCounter.Size = new System.Drawing.Size(19, 13);
            this.minuteCounter.TabIndex = 27;
            this.minuteCounter.Text = "00";
            // 
            // coffeeNotify
            // 
            this.coffeeNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("coffeeNotify.Icon")));
            this.coffeeNotify.Text = "Coffee Calculator";
            this.coffeeNotify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(199, 369);
            this.Controls.Add(this.minuteCounter);
            this.Controls.Add(this.useCurrentTime);
            this.Controls.Add(this.consumedcoffeeLbl);
            this.Controls.Add(this.consumedgumLbl);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.toMinutes);
            this.Controls.Add(this.toHours);
            this.Controls.Add(this.fromMinutes);
            this.Controls.Add(this.fromHours);
            this.Controls.Add(this.coffeeLbl);
            this.Controls.Add(this.gumLbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fromAMPM);
            this.Controls.Add(this.toAMPM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(215, 408);
            this.MinimumSize = new System.Drawing.Size(215, 408);
            this.Name = "Form1";
            this.Text = "Coffee Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fromHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox toAMPM;
        private System.Windows.Forms.ComboBox fromAMPM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label gumLbl;
        private System.Windows.Forms.Label coffeeLbl;
        private System.Windows.Forms.NumericUpDown fromHours;
        private System.Windows.Forms.NumericUpDown fromMinutes;
        private System.Windows.Forms.NumericUpDown toHours;
        private System.Windows.Forms.NumericUpDown toMinutes;
        private System.Windows.Forms.Label consumedcoffeeLbl;
        private System.Windows.Forms.Label consumedgumLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox useCurrentTime;
        private System.Windows.Forms.Label minuteCounter;
        private System.Windows.Forms.NotifyIcon coffeeNotify;
    }
}

