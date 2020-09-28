namespace RoverNavigate
{
    partial class FormRoverControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddRover = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxDirection = new System.Windows.Forms.ComboBox();
            this.numericRoverY = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericRoverX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.grbBoxMoveRover = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listViewCommandHistory = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.cmbxRover = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoverY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoverX)).BeginInit();
            this.grbBoxMoveRover.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddRover);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbxDirection);
            this.groupBox1.Controls.Add(this.numericRoverY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericRoverX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Define Rover";
            // 
            // btnAddRover
            // 
            this.btnAddRover.Location = new System.Drawing.Point(537, 30);
            this.btnAddRover.Name = "btnAddRover";
            this.btnAddRover.Size = new System.Drawing.Size(83, 23);
            this.btnAddRover.TabIndex = 4;
            this.btnAddRover.Text = "Add Rover";
            this.btnAddRover.UseVisualStyleBackColor = true;
            this.btnAddRover.Click += new System.EventHandler(this.btnAddRover_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direction :";
            // 
            // cmbxDirection
            // 
            this.cmbxDirection.FormattingEnabled = true;
            this.cmbxDirection.Location = new System.Drawing.Point(364, 30);
            this.cmbxDirection.Name = "cmbxDirection";
            this.cmbxDirection.Size = new System.Drawing.Size(121, 23);
            this.cmbxDirection.TabIndex = 2;
            // 
            // numericRoverY
            // 
            this.numericRoverY.Location = new System.Drawing.Point(178, 30);
            this.numericRoverY.Name = "numericRoverY";
            this.numericRoverY.Size = new System.Drawing.Size(86, 23);
            this.numericRoverY.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Y :";
            // 
            // numericRoverX
            // 
            this.numericRoverX.Location = new System.Drawing.Point(48, 30);
            this.numericRoverX.Name = "numericRoverX";
            this.numericRoverX.Size = new System.Drawing.Size(80, 23);
            this.numericRoverX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "X :";
            // 
            // grbBoxMoveRover
            // 
            this.grbBoxMoveRover.Controls.Add(this.label6);
            this.grbBoxMoveRover.Controls.Add(this.listViewCommandHistory);
            this.grbBoxMoveRover.Controls.Add(this.btnBack);
            this.grbBoxMoveRover.Controls.Add(this.btnDeleteCommand);
            this.grbBoxMoveRover.Controls.Add(this.btnApply);
            this.grbBoxMoveRover.Controls.Add(this.label5);
            this.grbBoxMoveRover.Controls.Add(this.txtCommand);
            this.grbBoxMoveRover.Controls.Add(this.btnMove);
            this.grbBoxMoveRover.Controls.Add(this.btnRight);
            this.grbBoxMoveRover.Controls.Add(this.btnLeft);
            this.grbBoxMoveRover.Controls.Add(this.cmbxRover);
            this.grbBoxMoveRover.Controls.Add(this.label4);
            this.grbBoxMoveRover.Location = new System.Drawing.Point(800, 24);
            this.grbBoxMoveRover.Name = "grbBoxMoveRover";
            this.grbBoxMoveRover.Size = new System.Drawing.Size(267, 608);
            this.grbBoxMoveRover.TabIndex = 1;
            this.grbBoxMoveRover.TabStop = false;
            this.grbBoxMoveRover.Text = "Move Rover";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Command History";
            // 
            // listViewCommandHistory
            // 
            this.listViewCommandHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewCommandHistory.HideSelection = false;
            this.listViewCommandHistory.Location = new System.Drawing.Point(24, 268);
            this.listViewCommandHistory.Name = "listViewCommandHistory";
            this.listViewCommandHistory.Size = new System.Drawing.Size(225, 302);
            this.listViewCommandHistory.TabIndex = 7;
            this.listViewCommandHistory.UseCompatibleStateImageBehavior = false;
            this.listViewCommandHistory.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Commands";
            this.columnHeader1.Width = 220;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(105, 188);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.Location = new System.Drawing.Point(186, 188);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(68, 23);
            this.btnDeleteCommand.TabIndex = 5;
            this.btnDeleteCommand.Text = "Delete";
            this.btnDeleteCommand.UseVisualStyleBackColor = true;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(24, 188);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(68, 23);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Command :";
            // 
            // txtCommand
            // 
            this.txtCommand.Enabled = false;
            this.txtCommand.Location = new System.Drawing.Point(6, 146);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(255, 23);
            this.txtCommand.TabIndex = 3;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(186, 79);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(68, 35);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "M";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(105, 79);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(68, 35);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "R";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(24, 79);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(68, 35);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "L";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // cmbxRover
            // 
            this.cmbxRover.FormattingEnabled = true;
            this.cmbxRover.Location = new System.Drawing.Point(86, 35);
            this.cmbxRover.Name = "cmbxRover";
            this.cmbxRover.Size = new System.Drawing.Size(136, 23);
            this.cmbxRover.TabIndex = 1;
            this.cmbxRover.SelectedIndexChanged += new System.EventHandler(this.cmbxRover_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Rover :";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(806, 659);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(261, 32);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormRoverControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 849);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grbBoxMoveRover);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormRoverControl";
            this.Text = "Rover Control";
            this.Load += new System.EventHandler(this.FormRoverControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormRoverControl_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoverY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericRoverX)).EndInit();
            this.grbBoxMoveRover.ResumeLayout(false);
            this.grbBoxMoveRover.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxDirection;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericRoverX;
        private System.Windows.Forms.NumericUpDown numericRoverY;
        private System.Windows.Forms.Button btnAddRover;
        private System.Windows.Forms.GroupBox grbBoxMoveRover;
        private System.Windows.Forms.ComboBox cmbxRover;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listViewCommandHistory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btnRefresh;
    }
}