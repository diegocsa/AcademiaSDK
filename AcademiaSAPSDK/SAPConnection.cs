using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbobsCOM;
using System.Xml.Linq;

namespace AcademiaSAPSDK.DIAPI
{
    public class SAPConnection
    {

        public void CreateTables(string tableName, BoUTBTableType tableType = BoUTBTableType.bott_NoObject)
        {
            var userTables = (UserTablesMD)oCompany.GetBusinessObject(BoObjectTypes.oUserTables);

            if (userTables.GetByKey(tableName))
            {
                userTables = null;
                return;
            }
            userTables.TableType = tableType;
            userTables.TableName = tableName;
            userTables.TableDescription = string.Format("test[{0}]", tableName);
            userTables.Add();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(userTables);
            userTables = null;

        }

        public bool CampoExiste(string tableName)
        {
             var userTable = oCompany.UserTables.Item(tableName);
            
            //userTable.UserFields.Fields.Item().Name
            
                return false;
        }


        public void CreateField(string tableName, string name, string description, BoFieldTypes type, int size)
        {
            var field = (UserFieldsMD) oCompany.GetBusinessObject(BoObjectTypes.oUserFields);
            
           
            field.TableName = string.Format("@{0}", tableName);
            field.Name = name;
            field.Description = description;
            field.Type = type;
            field.EditSize = size;
            field.Add();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(field);
            field = null;

        }

        public void InsertData(string code, string name, string fieldx, string fieldyyy, DateTime xx1)
        {
            var userTable = oCompany.UserTables.Item("USER_TABLE");
            userTable.Code = code;
            userTable.Name = name;
            userTable.UserFields.Fields.Item("U_fieldx").Value = fieldx;
            userTable.UserFields.Fields.Item("U_fieldyyy").Value = fieldx;
            userTable.UserFields.Fields.Item("U_xx1").Value = xx1;
            userTable.Add();

        }

        public static Company oCompany = null;

        public Dictionary<int, string> GetLastError()
        {
            var result = new Dictionary<int, string>();

            return result;
        }

        public bool NewItem(string code, string name)
        {
            Items item = oCompany.GetBusinessObject(BoObjectTypes.oItems);
            item.ItemCode = code;
            item.ItemName = name;
            return item.Add() == 0;
        }

        public bool NewBusinessPartner()
        {
            Conectar();
            BusinessPartners bp = oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);
            bp.CardCode = "ASDK1";
            bp.CardName = "JAMES KIRK";
            bp.CardType = BoCardTypes.cCustomer;
            return bp.Add() == 0;

        }

        public bool InsertContactEmployee()
        {
            BusinessPartners bp = oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);
            bp.GetByKey("ASDK1");
            bp.ContactEmployees.Name = "Contato 1";
            bp.ContactEmployees.Add();
            bp.ContactEmployees.Name = "Contato 2";
            return bp.Update() == 0;
            
        }

        public Company Conectar(bool force=false)
        {

            if (oCompany != null && oCompany.Connected)
                return oCompany;

            oCompany = new Company();
            
        
            try
            {
                oCompany.language = BoSuppLangs.ln_Portuguese_Br;
                oCompany.Server = "SERVIDOR";
                oCompany.CompanyDB = "BASE";
                oCompany.DbUserName = "USUARIO_BANCO";
                oCompany.DbPassword = "SENHA_BANCO";
                oCompany.UserName = "USUARIO_SAP";
                oCompany.Password = "SENHA_SAP";
                oCompany.DbServerType = BoDataServerTypes.dst_MSSQL2008;
                if (oCompany.Connect() != 0)
                {
                    oCompany = null;
                }
                
            }
            catch (Exception)
            {
                oCompany = null;
            }

            return oCompany;
        }

        public bool NewOrder(string cardCode, string itemCode, double quantity)
        {
            try
            {
                if (!oCompany.InTransaction)
                    oCompany.StartTransaction();

                Documents oOrder = oCompany.GetBusinessObject(BoObjectTypes.oPurchaseOrders);
                oOrder.CardCode = cardCode;
                oOrder.DocDate = DateTime.Now.AddMonths(-3);

                oOrder.Lines.ItemCode = itemCode;
                oOrder.Lines.Quantity = quantity;
                oOrder.Lines.Add();
                oOrder.Lines.ItemCode = "A00002";
                oOrder.Lines.Quantity = quantity;

                var result = oOrder.Add();

                if (result == 0)
                    oCompany.EndTransaction(BoWfTransOpt.wf_Commit);
            }
            catch (Exception)
            {
                
                throw;
            }
                




                return true;

            
        }

        public bool CreateInvoice()
        {
            var docNum = "s";
            oCompany.GetNewObjectCode(out docNum); //pega o último codigo gerado na sessao, independente do tipo se é parceiro negocio ou documento ou item etc

            Documents pInv = oCompany.GetBusinessObject(BoObjectTypes.oPurchaseInvoices);

            Documents PO = oCompany.GetBusinessObject(BoObjectTypes.oPurchaseOrders);
            PO.GetByKey(int.Parse(docNum));

            pInv.CardCode = "F99999";
            pInv.DocDueDate = DateTime.Now;
            pInv.ControlAccount = "2.1.1.1.01";

            for (int i = 0; i < PO.Lines.Count; i++)
            {
                PO.Lines.SetCurrentLine(i);
                pInv.Lines.BaseType =(int) BoObjectTypes.oPurchaseOrders;
                pInv.Lines.BaseLine = i;
                pInv.Lines.BaseEntry = int.Parse(docNum);
                pInv.Lines.Usage = "13";
                pInv.Lines.TaxCode = "5403-001";
                pInv.Lines.CFOPCode = "1101";
                pInv.Lines.AccountCode = "";
                pInv.Lines.Add();
            }

            return pInv.Add() == 0;


        }

        string filePath = @"c:\temp\testeDiego.xml";

        public void ExportToXml()
        {
            BusinessPartners bp = oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);
            
            bp.GetByKey("C20000");
            oCompany.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;
            
            bp.SaveXML(filePath);

        }

        public string ImportFromXml()
        {
            try
            {
               /* BusinessPartners bp = oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);
                bp.CardCode = "ASDK1";
                bp.CardName = "JAMES KIRK";
                bp.CardType = BoCardTypes.cCustomer;
                bp.Add();*/
                BusinessPartners bp2 = oCompany.GetBusinessObject(BoObjectTypes.oBusinessPartners);
                bp2.GetByKey("C20000");
                oCompany.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;

                bp2.SaveXML(filePath);
                BusinessPartners bpout = oCompany.GetBusinessObjectFromXML(filePath, 0);
                bpout.CardCode = "SDK009";
                
                return bpout.Add().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            

        }


        public bool RegistrarUDO()
        {
            /*
            CreateTables("SDK_ARMAZEM", BoUTBTableType.bott_MasterData);
            CreateTables("SDK_ARMAZEM_LOCAL", BoUTBTableType.bott_MasterDataLines);

            CreateTables("SDK_ARMAZEM", BoUTBTableType.bott_MasterData);
            CreateTables("SDK_ARMAZEM_LOCAL", BoUTBTableType.bott_MasterDataLines);
             * */
            var udo = (UserObjectsMD)oCompany.GetBusinessObject(BoObjectTypes.oUserObjectsMD);
            string code = "NMS_PED_SALDO";
            udo.GetByKey(code);
            udo.Remove();

            udo = (UserObjectsMD)oCompany.GetBusinessObject(BoObjectTypes.oUserObjectsMD);
            udo.Code = code;
            udo.Name = "Pedido de Saldo";

            udo.ObjectType = BoUDOObjType.boud_Document;
            udo.TableName = "SDK_PEDIDO_SALDO";
            udo.ChildTables.TableName = "SDK_PED_SALDO_ITEM";

            udo.CanCancel = BoYesNoEnum.tYES;
            udo.CanClose = BoYesNoEnum.tYES;
            udo.CanCreateDefaultForm = BoYesNoEnum.tYES;
            udo.CanDelete = BoYesNoEnum.tYES;
            udo.CanFind = BoYesNoEnum.tYES;
            udo.CanLog = BoYesNoEnum.tYES;
            udo.CanYearTransfer = BoYesNoEnum.tYES;// Transferência de Execício
            udo.ManageSeries = BoYesNoEnum.tYES;

            udo.FindColumns.ColumnAlias = "DocNum";
            udo.FindColumns.ColumnDescription = "Codigo";
            udo.FindColumns.Add();

            udo.FindColumns.ColumnAlias = "U_ParceiroNegocio";
            udo.FindColumns.ColumnDescription = "PN";

            udo.FormColumns.FormColumnAlias = "DocEntry";
            udo.FormColumns.FormColumnDescription = "DocEntry";

            
            udo.FormColumns.Add();
            udo.FormColumns.FormColumnAlias = "U_ARMAZEM";
            udo.FormColumns.FormColumnDescription = "Armazem";

            udo.FormColumns.Add();
            udo.FormColumns.FormColumnAlias = "U_ParceiroNegocio";
            udo.FormColumns.FormColumnDescription = "PN";


            udo.FormColumns.SonNumber = 0;
            udo.EnableEnhancedForm = BoYesNoEnum.tYES;
            udo.EnhancedFormColumns.ChildNumber = 0;
            udo.EnhancedFormColumns.ColumnAlias = "U_Item";
            udo.EnhancedFormColumns.ColumnDescription = "DocEntry";



            udo.CanCreateDefaultForm = SAPbobsCOM.BoYesNoEnum.tYES;
            udo.EnableEnhancedForm = SAPbobsCOM.BoYesNoEnum.tYES;
            udo.CanLog = SAPbobsCOM.BoYesNoEnum.tNO;
            udo.UseUniqueFormType = SAPbobsCOM.BoYesNoEnum.tYES;

            udo.MenuItem = BoYesNoEnum.tYES;
            udo.MenuUID = "U_PEDSALDO";
            udo.Position = 16;
            udo.MenuCaption = "Teste";
            udo.FatherMenuID = 2048;
            
            return udo.Add() == 0;
        }

        public void GetListUDO()
        {
            CompanyService x = oCompany.GetCompanyService();
            oCompany.XmlExportType = BoXmlExportTypes.xet_ExportImportMode;
            var generalService = (GeneralService)x.GetGeneralService("NMS_PED_SALDO");

            //generalData.Child("SDK_PED_SALDO_ITEM");
            GeneralCollectionParams parametros = generalService.GetList();
            parametros.ToXMLFile(@"C:\temp\list.xml");


        }

        public void InsertDataGeneralServices()
        {
            CompanyService x = oCompany.GetCompanyService();

            var generalService = x.GetGeneralService("NMS_PED_SALDO");
            
            var generalData = (GeneralData) generalService.GetDataInterface(GeneralServiceDataInterfaces.gsGeneralData);/////

            generalData.SetProperty("U_ParceiroNegocio", "V&0000");
            generalData.SetProperty("U_ARMAZEM", "001");

            var linesCollection = generalData.Child("SDK_PED_SALDO_ITEM");//nome da tabela
            var generalLineData = linesCollection.Add();
            generalLineData.SetProperty("U_Item", "111");
            generalLineData.SetProperty("U_Quantidade", "11");

            generalLineData = linesCollection.Add();
            generalLineData.SetProperty("U_Item", "54321");
            generalLineData.SetProperty("U_Quantidade", "10");

            generalService.Add(generalData);

        }


        public Items LoadItems()
        {
            try
            {
                var recordSet = (Recordset)oCompany.GetBusinessObject(BoObjectTypes.BoRecordset);
                recordSet.DoQuery("SELECT ItemCode FROM OITM");

                var items = (Items)oCompany.GetBusinessObject(BoObjectTypes.oItems);
                items.Browser.Recordset = recordSet;
                return items;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        
    }
}
