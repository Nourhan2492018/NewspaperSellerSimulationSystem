namespace NewspaperSellerSimulation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomNewsDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewsDayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RandomDemand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LostProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScrapProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyNetProfit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxTestCase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Aqua;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Day,
            this.RandomNewsDayType,
            this.NewsDayType,
            this.RandomDemand,
            this.Demand,
            this.DailyCost,
            this.SalesProfit,
            this.LostProfit,
            this.ScrapProfit,
            this.DailyNetProfit});
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dataGridView1.Location = new System.Drawing.Point(1, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1095, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Day
            // 
            this.Day.HeaderText = "Day";
            this.Day.Name = "Day";
            // 
            // RandomNewsDayType
            // 
            this.RandomNewsDayType.HeaderText = "RandomNewsDayType";
            this.RandomNewsDayType.Name = "RandomNewsDayType";
            this.RandomNewsDayType.Width = 150;
            // 
            // NewsDayType
            // 
            this.NewsDayType.HeaderText = "NewsDayType";
            this.NewsDayType.Name = "NewsDayType";
            // 
            // RandomDemand
            // 
            this.RandomDemand.HeaderText = "RandomDemand";
            this.RandomDemand.Name = "RandomDemand";
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // DailyCost
            // 
            this.DailyCost.HeaderText = "DailyCost";
            this.DailyCost.Name = "DailyCost";
            // 
            // SalesProfit
            // 
            this.SalesProfit.HeaderText = "SalesProfit";
            this.SalesProfit.Name = "SalesProfit";
            // 
            // LostProfit
            // 
            this.LostProfit.HeaderText = "LostProfit";
            this.LostProfit.Name = "LostProfit";
            // 
            // ScrapProfit
            // 
            this.ScrapProfit.HeaderText = "ScrapProfit";
            this.ScrapProfit.Name = "ScrapProfit";
            // 
            // DailyNetProfit
            // 
            this.DailyNetProfit.HeaderText = "DailyNetProfit";
            this.DailyNetProfit.Name = "DailyNetProfit";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(144, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "SimulateTable";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonSimulationClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Aqua;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(366, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(440, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Display Performance Measures";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonMeauresClick);
            // 
            // comboBoxTestCase
            // 
            this.comboBoxTestCase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTestCase.FormattingEnabled = true;
            this.comboBoxTestCase.Location = new System.Drawing.Point(305, 46);
            this.comboBoxTestCase.Name = "comboBoxTestCase";
            this.comboBoxTestCase.Size = new System.Drawing.Size(501, 21);
            this.comboBoxTestCase.TabIndex = 3;
            this.comboBoxTestCase.Text = "Choose Test Case ";
            this.comboBoxTestCase.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTestCase_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 512);
            this.Controls.Add(this.comboBoxTestCase);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomNewsDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsDayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn RandomDemand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn LostProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScrapProfit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyNetProfit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBoxTestCase;
    }
}