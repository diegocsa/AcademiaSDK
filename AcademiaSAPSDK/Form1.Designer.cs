namespace AcademiaSAPSDK.DIAPI
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
            this.btnConnectar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbItemCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnItem = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbQuantidade = new System.Windows.Forms.TextBox();
            this.tbItemCodeOrder = new System.Windows.Forms.TextBox();
            this.tbCardCode = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRS_LoadEnc = new System.Windows.Forms.Button();
            this.tbRS_UnitMeasure = new System.Windows.Forms.TextBox();
            this.lblRS_TipRegistro = new System.Windows.Forms.Label();
            this.tbRS_Name = new System.Windows.Forms.TextBox();
            this.tbRS_Code = new System.Windows.Forms.TextBox();
            this.btnRS_Load = new System.Windows.Forms.Button();
            this.btnRS_Last = new System.Windows.Forms.Button();
            this.btnRS_Next = new System.Windows.Forms.Button();
            this.btnRS_Previous = new System.Windows.Forms.Button();
            this.btnRS_First = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tbUsertable = new System.Windows.Forms.TextBox();
            this.btnCreateUserTable = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnUserValues = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFloat = new System.Windows.Forms.RadioButton();
            this.rbNumeric = new System.Windows.Forms.RadioButton();
            this.rbMemo = new System.Windows.Forms.RadioButton();
            this.rbDate = new System.Windows.Forms.RadioButton();
            this.rbAlpha = new System.Windows.Forms.RadioButton();
            this.tbUT_FieldSize = new System.Windows.Forms.TextBox();
            this.tbUT_FieldDescription = new System.Windows.Forms.TextBox();
            this.tbUT_FieldName = new System.Windows.Forms.TextBox();
            this.btnCreateField = new System.Windows.Forms.Button();
            this.btnRegistrarUDO = new System.Windows.Forms.Button();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.btnGetListUDO = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnectar
            // 
            this.btnConnectar.Location = new System.Drawing.Point(12, 9);
            this.btnConnectar.Name = "btnConnectar";
            this.btnConnectar.Size = new System.Drawing.Size(75, 23);
            this.btnConnectar.TabIndex = 0;
            this.btnConnectar.Text = "Connect";
            this.btnConnectar.UseVisualStyleBackColor = true;
            this.btnConnectar.Click += new System.EventHandler(this.btnConnectar_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(662, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 300);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnXml);
            this.tabPage1.Controls.Add(this.btnAtualizar);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Parceiro de Negócios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnXml
            // 
            this.btnXml.Location = new System.Drawing.Point(158, 245);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(75, 23);
            this.btnXml.TabIndex = 4;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(309, 245);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 3;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbItemName);
            this.tabPage2.Controls.Add(this.tbItemCode);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnItem);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(459, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Item";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item Name";
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(78, 51);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(212, 20);
            this.tbItemName.TabIndex = 6;
            // 
            // tbItemCode
            // 
            this.tbItemCode.Location = new System.Drawing.Point(78, 18);
            this.tbItemCode.Name = "tbItemCode";
            this.tbItemCode.Size = new System.Drawing.Size(75, 20);
            this.tbItemCode.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item code";
            // 
            // btnItem
            // 
            this.btnItem.Location = new System.Drawing.Point(390, 245);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(63, 23);
            this.btnItem.TabIndex = 3;
            this.btnItem.Text = "Add";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnInvoice);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tbQuantidade);
            this.tabPage3.Controls.Add(this.tbItemCodeOrder);
            this.tabPage3.Controls.Add(this.tbCardCode);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 274);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pedido venda";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(115, 128);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(66, 23);
            this.btnInvoice.TabIndex = 7;
            this.btnInvoice.Text = "Create invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forncedor";
            // 
            // tbQuantidade
            // 
            this.tbQuantidade.Location = new System.Drawing.Point(81, 58);
            this.tbQuantidade.Name = "tbQuantidade";
            this.tbQuantidade.Size = new System.Drawing.Size(100, 20);
            this.tbQuantidade.TabIndex = 3;
            // 
            // tbItemCodeOrder
            // 
            this.tbItemCodeOrder.Location = new System.Drawing.Point(81, 32);
            this.tbItemCodeOrder.Name = "tbItemCodeOrder";
            this.tbItemCodeOrder.Size = new System.Drawing.Size(100, 20);
            this.tbItemCodeOrder.TabIndex = 2;
            // 
            // tbCardCode
            // 
            this.tbCardCode.Location = new System.Drawing.Point(81, 6);
            this.tbCardCode.Name = "tbCardCode";
            this.tbCardCode.Size = new System.Drawing.Size(100, 20);
            this.tbCardCode.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Insert +1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRS_LoadEnc);
            this.tabPage4.Controls.Add(this.tbRS_UnitMeasure);
            this.tabPage4.Controls.Add(this.lblRS_TipRegistro);
            this.tabPage4.Controls.Add(this.tbRS_Name);
            this.tabPage4.Controls.Add(this.tbRS_Code);
            this.tabPage4.Controls.Add(this.btnRS_Load);
            this.tabPage4.Controls.Add(this.btnRS_Last);
            this.tabPage4.Controls.Add(this.btnRS_Next);
            this.tabPage4.Controls.Add(this.btnRS_Previous);
            this.tabPage4.Controls.Add(this.btnRS_First);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(459, 274);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "RecordSet";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRS_LoadEnc
            // 
            this.btnRS_LoadEnc.Location = new System.Drawing.Point(157, 176);
            this.btnRS_LoadEnc.Name = "btnRS_LoadEnc";
            this.btnRS_LoadEnc.Size = new System.Drawing.Size(163, 23);
            this.btnRS_LoadEnc.TabIndex = 9;
            this.btnRS_LoadEnc.Text = "Load Encapsulated";
            this.btnRS_LoadEnc.UseVisualStyleBackColor = true;
            this.btnRS_LoadEnc.Click += new System.EventHandler(this.btnRS_LoadEnc_Click);
            // 
            // tbRS_UnitMeasure
            // 
            this.tbRS_UnitMeasure.Location = new System.Drawing.Point(327, 87);
            this.tbRS_UnitMeasure.Name = "tbRS_UnitMeasure";
            this.tbRS_UnitMeasure.Size = new System.Drawing.Size(100, 20);
            this.tbRS_UnitMeasure.TabIndex = 8;
            // 
            // lblRS_TipRegistro
            // 
            this.lblRS_TipRegistro.AutoSize = true;
            this.lblRS_TipRegistro.Location = new System.Drawing.Point(101, 68);
            this.lblRS_TipRegistro.Name = "lblRS_TipRegistro";
            this.lblRS_TipRegistro.Size = new System.Drawing.Size(10, 13);
            this.lblRS_TipRegistro.TabIndex = 7;
            this.lblRS_TipRegistro.Text = "-";
            // 
            // tbRS_Name
            // 
            this.tbRS_Name.Location = new System.Drawing.Point(157, 87);
            this.tbRS_Name.Name = "tbRS_Name";
            this.tbRS_Name.Size = new System.Drawing.Size(163, 20);
            this.tbRS_Name.TabIndex = 6;
            // 
            // tbRS_Code
            // 
            this.tbRS_Code.Location = new System.Drawing.Point(101, 87);
            this.tbRS_Code.Name = "tbRS_Code";
            this.tbRS_Code.Size = new System.Drawing.Size(52, 20);
            this.tbRS_Code.TabIndex = 5;
            // 
            // btnRS_Load
            // 
            this.btnRS_Load.Location = new System.Drawing.Point(157, 146);
            this.btnRS_Load.Name = "btnRS_Load";
            this.btnRS_Load.Size = new System.Drawing.Size(163, 23);
            this.btnRS_Load.TabIndex = 4;
            this.btnRS_Load.Text = "Load";
            this.btnRS_Load.UseVisualStyleBackColor = true;
            this.btnRS_Load.Click += new System.EventHandler(this.btnRS_Load_Click);
            // 
            // btnRS_Last
            // 
            this.btnRS_Last.Location = new System.Drawing.Point(286, 116);
            this.btnRS_Last.Name = "btnRS_Last";
            this.btnRS_Last.Size = new System.Drawing.Size(34, 23);
            this.btnRS_Last.TabIndex = 3;
            this.btnRS_Last.Text = ">>|";
            this.btnRS_Last.UseVisualStyleBackColor = true;
            this.btnRS_Last.Click += new System.EventHandler(this.btnRS_Last_Click);
            // 
            // btnRS_Next
            // 
            this.btnRS_Next.Location = new System.Drawing.Point(246, 116);
            this.btnRS_Next.Name = "btnRS_Next";
            this.btnRS_Next.Size = new System.Drawing.Size(34, 23);
            this.btnRS_Next.TabIndex = 2;
            this.btnRS_Next.Text = ">";
            this.btnRS_Next.UseVisualStyleBackColor = true;
            this.btnRS_Next.Click += new System.EventHandler(this.btnRS_Next_Click);
            // 
            // btnRS_Previous
            // 
            this.btnRS_Previous.Location = new System.Drawing.Point(197, 116);
            this.btnRS_Previous.Name = "btnRS_Previous";
            this.btnRS_Previous.Size = new System.Drawing.Size(34, 23);
            this.btnRS_Previous.TabIndex = 1;
            this.btnRS_Previous.Text = "<";
            this.btnRS_Previous.UseVisualStyleBackColor = true;
            this.btnRS_Previous.Click += new System.EventHandler(this.btnRS_Previous_Click);
            // 
            // btnRS_First
            // 
            this.btnRS_First.Location = new System.Drawing.Point(157, 116);
            this.btnRS_First.Name = "btnRS_First";
            this.btnRS_First.Size = new System.Drawing.Size(34, 23);
            this.btnRS_First.TabIndex = 0;
            this.btnRS_First.Text = "|<<";
            this.btnRS_First.UseVisualStyleBackColor = true;
            this.btnRS_First.Click += new System.EventHandler(this.btnRS_First_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.btnUserValues);
            this.tabPage5.Controls.Add(this.btnCreateUserTable);
            this.tabPage5.Controls.Add(this.tbUsertable);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(459, 274);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Criar User table";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tbUsertable
            // 
            this.tbUsertable.Location = new System.Drawing.Point(95, 7);
            this.tbUsertable.Name = "tbUsertable";
            this.tbUsertable.Size = new System.Drawing.Size(100, 20);
            this.tbUsertable.TabIndex = 0;
            // 
            // btnCreateUserTable
            // 
            this.btnCreateUserTable.Location = new System.Drawing.Point(201, 7);
            this.btnCreateUserTable.Name = "btnCreateUserTable";
            this.btnCreateUserTable.Size = new System.Drawing.Size(75, 23);
            this.btnCreateUserTable.TabIndex = 1;
            this.btnCreateUserTable.Text = "Criar tabela";
            this.btnCreateUserTable.UseVisualStyleBackColor = true;
            this.btnCreateUserTable.Click += new System.EventHandler(this.btnCreateUserTable_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnGetListUDO);
            this.tabPage6.Controls.Add(this.btnInsertData);
            this.tabPage6.Controls.Add(this.btnRegistrarUDO);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(630, 274);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Registrar UDO";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnUserValues
            // 
            this.btnUserValues.Location = new System.Drawing.Point(9, 245);
            this.btnUserValues.Name = "btnUserValues";
            this.btnUserValues.Size = new System.Drawing.Size(133, 23);
            this.btnUserValues.TabIndex = 11;
            this.btnUserValues.Text = "ValoresUsuario";
            this.btnUserValues.UseVisualStyleBackColor = true;
            this.btnUserValues.Click += new System.EventHandler(this.btnUserValues_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nome da Tabela";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.tbUT_FieldSize);
            this.groupBox2.Controls.Add(this.tbUT_FieldDescription);
            this.groupBox2.Controls.Add(this.tbUT_FieldName);
            this.groupBox2.Controls.Add(this.btnCreateField);
            this.groupBox2.Location = new System.Drawing.Point(9, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 163);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campos de usuário";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tamanho";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(251, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Descrição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Nome campo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFloat);
            this.groupBox1.Controls.Add(this.rbNumeric);
            this.groupBox1.Controls.Add(this.rbMemo);
            this.groupBox1.Controls.Add(this.rbDate);
            this.groupBox1.Controls.Add(this.rbAlpha);
            this.groupBox1.Location = new System.Drawing.Point(108, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 47);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do Campo";
            // 
            // rbFloat
            // 
            this.rbFloat.AutoSize = true;
            this.rbFloat.Location = new System.Drawing.Point(249, 17);
            this.rbFloat.Name = "rbFloat";
            this.rbFloat.Size = new System.Drawing.Size(48, 17);
            this.rbFloat.TabIndex = 14;
            this.rbFloat.TabStop = true;
            this.rbFloat.Text = "Float";
            this.rbFloat.UseVisualStyleBackColor = true;
            // 
            // rbNumeric
            // 
            this.rbNumeric.AutoSize = true;
            this.rbNumeric.Location = new System.Drawing.Point(179, 17);
            this.rbNumeric.Name = "rbNumeric";
            this.rbNumeric.Size = new System.Drawing.Size(64, 17);
            this.rbNumeric.TabIndex = 13;
            this.rbNumeric.TabStop = true;
            this.rbNumeric.Text = "Numeric";
            this.rbNumeric.UseVisualStyleBackColor = true;
            // 
            // rbMemo
            // 
            this.rbMemo.AutoSize = true;
            this.rbMemo.Location = new System.Drawing.Point(119, 17);
            this.rbMemo.Name = "rbMemo";
            this.rbMemo.Size = new System.Drawing.Size(54, 17);
            this.rbMemo.TabIndex = 12;
            this.rbMemo.TabStop = true;
            this.rbMemo.Text = "Memo";
            this.rbMemo.UseVisualStyleBackColor = true;
            // 
            // rbDate
            // 
            this.rbDate.AutoSize = true;
            this.rbDate.Location = new System.Drawing.Point(65, 17);
            this.rbDate.Name = "rbDate";
            this.rbDate.Size = new System.Drawing.Size(48, 17);
            this.rbDate.TabIndex = 11;
            this.rbDate.TabStop = true;
            this.rbDate.Text = "Date";
            this.rbDate.UseVisualStyleBackColor = true;
            // 
            // rbAlpha
            // 
            this.rbAlpha.AutoSize = true;
            this.rbAlpha.Location = new System.Drawing.Point(7, 17);
            this.rbAlpha.Name = "rbAlpha";
            this.rbAlpha.Size = new System.Drawing.Size(52, 17);
            this.rbAlpha.TabIndex = 10;
            this.rbAlpha.TabStop = true;
            this.rbAlpha.Text = "Alpha";
            this.rbAlpha.UseVisualStyleBackColor = true;
            // 
            // tbUT_FieldSize
            // 
            this.tbUT_FieldSize.Location = new System.Drawing.Point(114, 48);
            this.tbUT_FieldSize.Name = "tbUT_FieldSize";
            this.tbUT_FieldSize.Size = new System.Drawing.Size(100, 20);
            this.tbUT_FieldSize.TabIndex = 27;
            // 
            // tbUT_FieldDescription
            // 
            this.tbUT_FieldDescription.Location = new System.Drawing.Point(312, 19);
            this.tbUT_FieldDescription.Name = "tbUT_FieldDescription";
            this.tbUT_FieldDescription.Size = new System.Drawing.Size(100, 20);
            this.tbUT_FieldDescription.TabIndex = 26;
            // 
            // tbUT_FieldName
            // 
            this.tbUT_FieldName.Location = new System.Drawing.Point(114, 19);
            this.tbUT_FieldName.Name = "tbUT_FieldName";
            this.tbUT_FieldName.Size = new System.Drawing.Size(100, 20);
            this.tbUT_FieldName.TabIndex = 25;
            // 
            // btnCreateField
            // 
            this.btnCreateField.Location = new System.Drawing.Point(115, 127);
            this.btnCreateField.Name = "btnCreateField";
            this.btnCreateField.Size = new System.Drawing.Size(75, 23);
            this.btnCreateField.TabIndex = 24;
            this.btnCreateField.Text = "Criar campo";
            this.btnCreateField.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarUDO
            // 
            this.btnRegistrarUDO.Location = new System.Drawing.Point(6, 6);
            this.btnRegistrarUDO.Name = "btnRegistrarUDO";
            this.btnRegistrarUDO.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarUDO.TabIndex = 0;
            this.btnRegistrarUDO.Text = "Registrar UDO";
            this.btnRegistrarUDO.UseVisualStyleBackColor = true;
            this.btnRegistrarUDO.Click += new System.EventHandler(this.btnRegistrarUDO_Click);
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(105, 47);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(75, 23);
            this.btnInsertData.TabIndex = 1;
            this.btnInsertData.Text = "Inserir dados";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Click += new System.EventHandler(this.btnInsertData_Click);
            // 
            // btnGetListUDO
            // 
            this.btnGetListUDO.Location = new System.Drawing.Point(188, 122);
            this.btnGetListUDO.Name = "btnGetListUDO";
            this.btnGetListUDO.Size = new System.Drawing.Size(75, 23);
            this.btnGetListUDO.TabIndex = 2;
            this.btnGetListUDO.Text = "Get List UDO";
            this.btnGetListUDO.UseVisualStyleBackColor = true;
            this.btnGetListUDO.Click += new System.EventHandler(this.btnGetListUDO_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 381);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConnectar);
            this.Name = "Form1";
            this.Text = "Academia SDK";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectar;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbQuantidade;
        private System.Windows.Forms.TextBox tbItemCodeOrder;
        private System.Windows.Forms.TextBox tbCardCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnRS_Previous;
        private System.Windows.Forms.Button btnRS_First;
        private System.Windows.Forms.TextBox tbRS_Code;
        private System.Windows.Forms.Button btnRS_Load;
        private System.Windows.Forms.Button btnRS_Last;
        private System.Windows.Forms.Button btnRS_Next;
        private System.Windows.Forms.TextBox tbRS_Name;
        private System.Windows.Forms.Label lblRS_TipRegistro;
        private System.Windows.Forms.TextBox tbRS_UnitMeasure;
        private System.Windows.Forms.Button btnRS_LoadEnc;
        private System.Windows.Forms.TextBox tbUsertable;
        private System.Windows.Forms.Button btnCreateUserTable;
        private System.Windows.Forms.Button btnUserValues;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFloat;
        private System.Windows.Forms.RadioButton rbNumeric;
        private System.Windows.Forms.RadioButton rbMemo;
        private System.Windows.Forms.RadioButton rbDate;
        private System.Windows.Forms.RadioButton rbAlpha;
        private System.Windows.Forms.TextBox tbUT_FieldSize;
        private System.Windows.Forms.TextBox tbUT_FieldDescription;
        private System.Windows.Forms.TextBox tbUT_FieldName;
        private System.Windows.Forms.Button btnCreateField;
        private System.Windows.Forms.Button btnRegistrarUDO;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.Button btnGetListUDO;
    }
}

