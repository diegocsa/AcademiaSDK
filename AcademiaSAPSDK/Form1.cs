using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAPbobsCOM;

namespace AcademiaSAPSDK.DIAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SAPConnection SAPCompany = new SAPConnection();

        private void TrataMsgSAP()
        {
            int cd = 0;
            string msg = "";
            SAPConnection.oCompany.GetLastError(out cd, out msg);
            if (cd != 0)
            {
                string mensagem = string.Format("SAP [{0}] - {1}", cd, msg);
                statusBar.Text = mensagem;
            }
            else
                statusBar.Text = string.Format("Sucesso - {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
        }

        private void btnConnectar_Click(object sender, EventArgs e)
        {
            var company = SAPCompany.Conectar();
            if (company == null)
                MessageBox.Show(company.GetLastErrorDescription());
            else
            {
                statusBar.Text = string.Format("Conectado em: {0}", company.CompanyName);
                tabControl1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!SAPCompany.NewBusinessPartner())
                    TrataMsgSAP();
                else
                    statusBar.Text = "Parceiro de negócios inserido com sucesso";
            }
            catch (Exception ex)
            {
                statusBar.Text = ex.Message;
            }

        }

        private void btnItem_Click(object sender, EventArgs e)
        {



        }

        private void btnItem_Click_1(object sender, EventArgs e)
        {
            //if (
            SAPCompany.NewItem(tbItemCode.Text, tbItemName.Text);//)
            TrataMsgSAP();
            //else
            //    statusBar.Text = "Inserido com sucesso";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            SAPCompany.InsertContactEmployee();
            TrataMsgSAP();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SAPCompany.NewOrder(tbCardCode.Text, tbItemCodeOrder.Text, double.Parse(tbQuantidade.Text));
            TrataMsgSAP();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                SAPCompany.CreateInvoice();
                TrataMsgSAP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            SAPCompany.ExportToXml();
            TrataMsgSAP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRS_First.Enabled =
            btnRS_Last.Enabled =
            btnRS_Previous.Enabled =
            btnRS_Next.Enabled = false;
            btnConnectar_Click(null, null);
        }


        private Items RS_Itens = null;

        private void btnRS_Load_Click(object sender, EventArgs e)
        {

            
            RS_Itens = SAPCompany.LoadItems();
            RS_Itens.Browser.MoveFirst();
            BindItemData();

            btnRS_First.Enabled =
            btnRS_Last.Enabled = 
            btnRS_Previous.Enabled = 
            btnRS_Next.Enabled = true;
        }

        private void btnRS_First_Click(object sender, EventArgs e)
        {


            RS_Itens.Browser.MoveFirst();

            BindItemData();
        }

        private void btnRS_Last_Click(object sender, EventArgs e)
        {
            try
            {

                RS_Itens.Browser.MoveLast();
                BindItemData();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnRS_Previous_Click(object sender, EventArgs e)
        {
            lblRS_TipRegistro.Text = string.Empty;
            if (RS_Itens.Browser.BoF)
            {
                RS_Itens.Browser.MoveLast();
                lblRS_TipRegistro.Text = "Ultimo registro";
            }
            else
                RS_Itens.Browser.MovePrevious();
            BindItemData();
        }

        private void btnRS_Next_Click(object sender, EventArgs e)
        {
            lblRS_TipRegistro.Text = string.Empty;
            RS_Itens.Browser.MoveNext();
            
            if (RS_Itens.Browser.EoF)
            {
                RS_Itens.Browser.MoveFirst();
                lblRS_TipRegistro.Text = "Primeiro registro";
            }
            
                

            BindItemData();
        }

        private void BindItemData()
        {
            tbRS_Code.Text = RS_Itens.ItemCode;
            tbRS_Name.Text = RS_Itens.ItemName;
            tbRS_UnitMeasure.Text = RS_Itens.SalesUnit;
        }

        private void btnRS_LoadEnc_Click(object sender, EventArgs e)
        {
            var bob = (SBObob)SAPConnection.oCompany.GetBusinessObject(BoObjectTypes.BoBridge);
            
           
            //RS_Itens = (Items)SAPConnection.oCompany.GetBusinessObject(BoObjectTypes.op);
                

            
            RS_Itens.Browser.Recordset = bob.GetItemList();
            
            RS_Itens.Browser.MoveFirst();
            BindItemData();

            btnRS_First.Enabled =
            btnRS_Last.Enabled =
            btnRS_Previous.Enabled =
            btnRS_Next.Enabled = true;
        }

        private void btnCreateUserTable_Click(object sender, EventArgs e)
        {
            SAPCompany.CreateTables(tbUsertable.Text);
            TrataMsgSAP();
        }

        private void btnCreateField_Click(object sender, EventArgs e)
        {
            BoFieldTypes typeField = BoFieldTypes.db_Alpha;
            
            if(rbDate.Checked)
                typeField = BoFieldTypes.db_Date;

            if (rbFloat.Checked)
                typeField = BoFieldTypes.db_Float;

            if (rbMemo.Checked)
                typeField = BoFieldTypes.db_Memo;

            if (rbNumeric.Checked)
                typeField = BoFieldTypes.db_Numeric;


            SAPCompany.CreateField(tbUsertable.Text,
                tbUT_FieldName.Text, tbUT_FieldDescription.Text, typeField, int.Parse(tbUT_FieldSize.Text));

            TrataMsgSAP();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnUserValues_Click(object sender, EventArgs e)
        {
            SAPCompany.InsertData("A1", "A. 1", "c1x", "c1yyy", DateTime.Now);
            TrataMsgSAP();
            SAPCompany.InsertData("A2", "A. 2", "c2x", "c2yyy", DateTime.Now);
            TrataMsgSAP();
        }

        private void btnRegistrarUDO_Click(object sender, EventArgs e)
        {
            try
            {
                SAPCompany.RegistrarUDO();
                TrataMsgSAP();
            }
            catch (Exception ex)
            {
                statusBar.Text = string.Format("ERRO APP - {0}", ex.Message);
            }
        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            try
            {
                SAPCompany.InsertDataGeneralServices();
                TrataMsgSAP();
            }
            catch (Exception ex)
            {
                statusBar.Text = string.Format("ERRO APP - {0}", ex.Message);
            }
            
        }

        private void btnGetListUDO_Click(object sender, EventArgs e)
        {
            try
            {
                SAPCompany.GetListUDO();
                TrataMsgSAP();
            }
            catch (Exception ex)
            {
                statusBar.Text = string.Format("ERRO APP - {0}", ex.Message);
            }
        }

       

    }
}
