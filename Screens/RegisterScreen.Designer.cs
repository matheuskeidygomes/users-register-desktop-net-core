namespace Projeto_Windows_Form_02_Cadastro_de_clientes.Screens
{
    partial class RegisterScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientLabel = new System.Windows.Forms.Label();
            this.selectClient = new System.Windows.Forms.ComboBox();
            this.editClientBtn = new System.Windows.Forms.Button();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.clientCodeLabel = new System.Windows.Forms.Label();
            this.clientCPFLabel = new System.Windows.Forms.Label();
            this.clientBirthdateLabel = new System.Windows.Forms.Label();
            this.clientCompleteNameLabel = new System.Windows.Forms.Label();
            this.clientNacionalityLabel = new System.Windows.Forms.Label();
            this.clientBirthdate = new System.Windows.Forms.DateTimePicker();
            this.maritalStatusRadioGroup = new System.Windows.Forms.GroupBox();
            this.maritalStatusDivorceRadio = new System.Windows.Forms.RadioButton();
            this.maritalStatusMarriedRadio = new System.Windows.Forms.RadioButton();
            this.maritalStatusSingleRadio = new System.Windows.Forms.RadioButton();
            this.clientIncomeLabel = new System.Windows.Forms.Label();
            this.clientIncome = new System.Windows.Forms.NumericUpDown();
            this.clientNacionality = new System.Windows.Forms.ComboBox();
            this.clientCode = new System.Windows.Forms.TextBox();
            this.clientName = new System.Windows.Forms.TextBox();
            this.clientCPF = new System.Windows.Forms.MaskedTextBox();
            this.clientVehicleLabel = new System.Windows.Forms.Label();
            this.clientChildren = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clientVehicle = new System.Windows.Forms.MaskedTextBox();
            this.maritalStatusRadioGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(14, 30);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(61, 20);
            this.clientLabel.TabIndex = 0;
            this.clientLabel.Text = "Clientes";
            // 
            // selectClient
            // 
            this.selectClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectClient.FormattingEnabled = true;
            this.selectClient.Location = new System.Drawing.Point(14, 58);
            this.selectClient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selectClient.Name = "selectClient";
            this.selectClient.Size = new System.Drawing.Size(352, 28);
            this.selectClient.TabIndex = 1;
            this.selectClient.SelectedIndexChanged += new System.EventHandler(this.SelectClient_SelectedIndexChanged);
            // 
            // editClientBtn
            // 
            this.editClientBtn.Location = new System.Drawing.Point(372, 56);
            this.editClientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editClientBtn.Name = "editClientBtn";
            this.editClientBtn.Size = new System.Drawing.Size(67, 31);
            this.editClientBtn.TabIndex = 3;
            this.editClientBtn.Text = "Editar";
            this.editClientBtn.UseVisualStyleBackColor = true;
            this.editClientBtn.Click += new System.EventHandler(this.EditClientBtn_Click);
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(445, 55);
            this.addClientBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(69, 31);
            this.addClientBtn.TabIndex = 4;
            this.addClientBtn.Text = "Novo";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(14, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 1);
            this.label2.TabIndex = 5;
            // 
            // clientCodeLabel
            // 
            this.clientCodeLabel.AutoSize = true;
            this.clientCodeLabel.Location = new System.Drawing.Point(14, 130);
            this.clientCodeLabel.Name = "clientCodeLabel";
            this.clientCodeLabel.Size = new System.Drawing.Size(58, 20);
            this.clientCodeLabel.TabIndex = 6;
            this.clientCodeLabel.Text = "Código";
            // 
            // clientCPFLabel
            // 
            this.clientCPFLabel.AutoSize = true;
            this.clientCPFLabel.Location = new System.Drawing.Point(357, 131);
            this.clientCPFLabel.Name = "clientCPFLabel";
            this.clientCPFLabel.Size = new System.Drawing.Size(33, 20);
            this.clientCPFLabel.TabIndex = 7;
            this.clientCPFLabel.Text = "CPF";
            // 
            // clientBirthdateLabel
            // 
            this.clientBirthdateLabel.AutoSize = true;
            this.clientBirthdateLabel.Location = new System.Drawing.Point(10, 205);
            this.clientBirthdateLabel.Name = "clientBirthdateLabel";
            this.clientBirthdateLabel.Size = new System.Drawing.Size(145, 20);
            this.clientBirthdateLabel.TabIndex = 9;
            this.clientBirthdateLabel.Text = "Data de Nascimento";
            // 
            // clientCompleteNameLabel
            // 
            this.clientCompleteNameLabel.AutoSize = true;
            this.clientCompleteNameLabel.Location = new System.Drawing.Point(116, 130);
            this.clientCompleteNameLabel.Name = "clientCompleteNameLabel";
            this.clientCompleteNameLabel.Size = new System.Drawing.Size(120, 20);
            this.clientCompleteNameLabel.TabIndex = 10;
            this.clientCompleteNameLabel.Text = "Nome Completo";
            // 
            // clientNacionalityLabel
            // 
            this.clientNacionalityLabel.AutoSize = true;
            this.clientNacionalityLabel.Location = new System.Drawing.Point(14, 278);
            this.clientNacionalityLabel.Name = "clientNacionalityLabel";
            this.clientNacionalityLabel.Size = new System.Drawing.Size(106, 20);
            this.clientNacionalityLabel.TabIndex = 11;
            this.clientNacionalityLabel.Text = "Nacionalidade";
            // 
            // clientBirthdate
            // 
            this.clientBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.clientBirthdate.Location = new System.Drawing.Point(14, 231);
            this.clientBirthdate.Name = "clientBirthdate";
            this.clientBirthdate.Size = new System.Drawing.Size(145, 27);
            this.clientBirthdate.TabIndex = 12;
            // 
            // maritalStatusRadioGroup
            // 
            this.maritalStatusRadioGroup.Controls.Add(this.maritalStatusDivorceRadio);
            this.maritalStatusRadioGroup.Controls.Add(this.maritalStatusMarriedRadio);
            this.maritalStatusRadioGroup.Controls.Add(this.maritalStatusSingleRadio);
            this.maritalStatusRadioGroup.Location = new System.Drawing.Point(362, 205);
            this.maritalStatusRadioGroup.Name = "maritalStatusRadioGroup";
            this.maritalStatusRadioGroup.Size = new System.Drawing.Size(152, 140);
            this.maritalStatusRadioGroup.TabIndex = 13;
            this.maritalStatusRadioGroup.TabStop = false;
            this.maritalStatusRadioGroup.Text = "Estado Civil";
            // 
            // maritalStatusDivorceRadio
            // 
            this.maritalStatusDivorceRadio.AutoSize = true;
            this.maritalStatusDivorceRadio.Location = new System.Drawing.Point(20, 100);
            this.maritalStatusDivorceRadio.Name = "maritalStatusDivorceRadio";
            this.maritalStatusDivorceRadio.Size = new System.Drawing.Size(103, 24);
            this.maritalStatusDivorceRadio.TabIndex = 30;
            this.maritalStatusDivorceRadio.TabStop = true;
            this.maritalStatusDivorceRadio.Text = "Divorciado";
            this.maritalStatusDivorceRadio.UseVisualStyleBackColor = true;
            // 
            // maritalStatusMarriedRadio
            // 
            this.maritalStatusMarriedRadio.AutoSize = true;
            this.maritalStatusMarriedRadio.Location = new System.Drawing.Point(20, 70);
            this.maritalStatusMarriedRadio.Name = "maritalStatusMarriedRadio";
            this.maritalStatusMarriedRadio.Size = new System.Drawing.Size(79, 24);
            this.maritalStatusMarriedRadio.TabIndex = 29;
            this.maritalStatusMarriedRadio.TabStop = true;
            this.maritalStatusMarriedRadio.Text = "Casado";
            this.maritalStatusMarriedRadio.UseVisualStyleBackColor = true;
            // 
            // maritalStatusSingleRadio
            // 
            this.maritalStatusSingleRadio.AutoSize = true;
            this.maritalStatusSingleRadio.Location = new System.Drawing.Point(20, 40);
            this.maritalStatusSingleRadio.Name = "maritalStatusSingleRadio";
            this.maritalStatusSingleRadio.Size = new System.Drawing.Size(82, 24);
            this.maritalStatusSingleRadio.TabIndex = 28;
            this.maritalStatusSingleRadio.TabStop = true;
            this.maritalStatusSingleRadio.Text = "Solteiro";
            this.maritalStatusSingleRadio.UseVisualStyleBackColor = true;
            // 
            // clientIncomeLabel
            // 
            this.clientIncomeLabel.AutoSize = true;
            this.clientIncomeLabel.Location = new System.Drawing.Point(180, 205);
            this.clientIncomeLabel.Name = "clientIncomeLabel";
            this.clientIncomeLabel.Size = new System.Drawing.Size(102, 20);
            this.clientIncomeLabel.TabIndex = 14;
            this.clientIncomeLabel.Text = "Renda Mensal";
            // 
            // clientIncome
            // 
            this.clientIncome.Location = new System.Drawing.Point(184, 231);
            this.clientIncome.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.clientIncome.Name = "clientIncome";
            this.clientIncome.Size = new System.Drawing.Size(133, 27);
            this.clientIncome.TabIndex = 15;
            // 
            // clientNacionality
            // 
            this.clientNacionality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clientNacionality.FormattingEnabled = true;
            this.clientNacionality.Location = new System.Drawing.Point(14, 302);
            this.clientNacionality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clientNacionality.Name = "clientNacionality";
            this.clientNacionality.Size = new System.Drawing.Size(145, 28);
            this.clientNacionality.Sorted = true;
            this.clientNacionality.TabIndex = 16;
            // 
            // clientCode
            // 
            this.clientCode.Enabled = false;
            this.clientCode.Location = new System.Drawing.Point(14, 154);
            this.clientCode.Name = "clientCode";
            this.clientCode.ReadOnly = true;
            this.clientCode.Size = new System.Drawing.Size(81, 27);
            this.clientCode.TabIndex = 17;
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(116, 154);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(228, 27);
            this.clientName.TabIndex = 18;
            // 
            // clientCPF
            // 
            this.clientCPF.Location = new System.Drawing.Point(362, 154);
            this.clientCPF.Mask = "000,000,000-00";
            this.clientCPF.Name = "clientCPF";
            this.clientCPF.Size = new System.Drawing.Size(152, 27);
            this.clientCPF.TabIndex = 19;
            // 
            // clientVehicleLabel
            // 
            this.clientVehicleLabel.AutoSize = true;
            this.clientVehicleLabel.Location = new System.Drawing.Point(180, 278);
            this.clientVehicleLabel.Name = "clientVehicleLabel";
            this.clientVehicleLabel.Size = new System.Drawing.Size(118, 20);
            this.clientVehicleLabel.TabIndex = 21;
            this.clientVehicleLabel.Text = "Placa do Veículo";
            // 
            // clientChildren
            // 
            this.clientChildren.AutoSize = true;
            this.clientChildren.Location = new System.Drawing.Point(14, 352);
            this.clientChildren.Name = "clientChildren";
            this.clientChildren.Size = new System.Drawing.Size(111, 24);
            this.clientChildren.TabIndex = 22;
            this.clientChildren.Text = "Possui filhos";
            this.clientChildren.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Location = new System.Drawing.Point(14, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(500, 1);
            this.label10.TabIndex = 23;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(320, 422);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(94, 29);
            this.cancelBtn.TabIndex = 24;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(10, 422);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(94, 29);
            this.closeBtn.TabIndex = 25;
            this.closeBtn.Text = "Fechar";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtnClick);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(420, 422);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(94, 29);
            this.saveBtn.TabIndex = 26;
            this.saveBtn.Text = "Salvar";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // clientVehicle
            // 
            this.clientVehicle.Location = new System.Drawing.Point(184, 303);
            this.clientVehicle.Mask = "AAA-0000";
            this.clientVehicle.Name = "clientVehicle";
            this.clientVehicle.Size = new System.Drawing.Size(152, 27);
            this.clientVehicle.TabIndex = 27;
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(541, 486);
            this.Controls.Add(this.clientVehicle);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.clientChildren);
            this.Controls.Add(this.clientVehicleLabel);
            this.Controls.Add(this.clientCPF);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.clientCode);
            this.Controls.Add(this.clientNacionality);
            this.Controls.Add(this.clientIncome);
            this.Controls.Add(this.clientIncomeLabel);
            this.Controls.Add(this.maritalStatusRadioGroup);
            this.Controls.Add(this.clientBirthdate);
            this.Controls.Add(this.clientNacionalityLabel);
            this.Controls.Add(this.clientCompleteNameLabel);
            this.Controls.Add(this.clientBirthdateLabel);
            this.Controls.Add(this.clientCPFLabel);
            this.Controls.Add(this.clientCodeLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.editClientBtn);
            this.Controls.Add(this.selectClient);
            this.Controls.Add(this.clientLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "RegisterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterScreenCloseWarning);
            this.maritalStatusRadioGroup.ResumeLayout(false);
            this.maritalStatusRadioGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientIncome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label clientLabel;
        private ComboBox selectClient;
        private Button editClientBtn;
        private Button addClientBtn;
        private Label label2;
        private Label clientCodeLabel;
        private Label clientCPFLabel;
        private Label clientBirthdateLabel;
        private Label clientCompleteNameLabel;
        private Label clientNacionalityLabel;
        private DateTimePicker clientBirthdate;
        private GroupBox maritalStatusRadioGroup;
        private Label clientIncomeLabel;
        private NumericUpDown clientIncome;
        private ComboBox clientNacionality;
        private TextBox clientCode;
        private TextBox clientName;
        private MaskedTextBox clientCPF;
        private Label clientVehicleLabel;
        private CheckBox clientChildren;
        private Label label10;
        private Button cancelBtn;
        private Button closeBtn;
        private Button saveBtn;
        private MaskedTextBox clientVehicle;
        private RadioButton maritalStatusDivorceRadio;
        private RadioButton maritalStatusMarriedRadio;
        private RadioButton maritalStatusSingleRadio;
    }
}