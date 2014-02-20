using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UI = SAPbouiCOM;
using DI = SAPbobsCOM;
using System.Xml;
using System.Xml.Linq;
using System.Windows.Forms;

namespace AcademiaSAPSDK.UIAPI
{
    public class Connection
    {
        public static UI.Application SAPApplication;
        public static DI.Company SAPCompany = new DI.Company();

        public void Login()
        {
            var sboGuiApi = new UI.SboGuiApi();
            string strConnection = Environment.GetCommandLineArgs()[1];

            sboGuiApi.Connect(strConnection);

            SAPApplication = sboGuiApi.GetApplication();

            if (SAPApplication != null)
                SAPApplication.StatusBar.SetText("Hello World! Conectado via UI API", UI.BoMessageTime.bmt_Medium, UI.BoStatusBarMessageType.smt_Success);

            SingleSignON();
        }

        public void SingleSignON()
        {
            string strCookie = SAPCompany.GetContextCookie();
            string strConnec = SAPApplication.Company.GetConnectionContext(strCookie);

            if (SAPCompany.SetSboLoginContext(strConnec) == 0 && SAPCompany.Connect() == 0)
                SAPApplication.StatusBar.SetText("Conectado na DI pela UI API", UI.BoMessageTime.bmt_Medium, UI.BoStatusBarMessageType.smt_Success);
            else
                SAPApplication.StatusBar.SetText(SAPCompany.GetLastErrorDescription());

        }

        public void Form001(bool save = false)
        {
            UI.Form form;
            UI.FormCreationParams creationPackage = SAPApplication.CreateObject(UI.BoCreatableObjectType.cot_FormCreationParams);

            creationPackage.UniqueID = Guid.NewGuid().ToString().Substring(0, 10);// usado para poder manipular varios forms iguais abertos. nao deve ser fixo
            creationPackage.FormType = "F001";
            creationPackage.BorderStyle = UI.BoFormBorderStyle.fbs_Fixed;

            form = SAPApplication.Forms.AddEx(creationPackage);

            form.Title = "Hello World";

            CreateItems(form);
            if (save)
            {
                var x = new XmlDocument();
                x.LoadXml(form.GetAsXML());
                x.Save(@"C:\temp\form001");
            }
            else
            {
                form.VisibleEx = true;
            }
        }

        private void CreateItems(UI.Form form)
        {
            AddButon(form, "1", "&OK", 200, 20);
            AddButon(form, "2", "&Cancelar", 200, 95);
            AddButon(form, "BTN_3", "&Processar", 200, 170);
        }

        private void AddButon(UI.Form form, string id, string caption, int top, int left)
        {
            UI.Item item;
            UI.Button button;

            item = form.Items.Add(id, UI.BoFormItemTypes.it_BUTTON);
            button = item.Specific;
            button.Caption = caption;
            item.Top = top;
            item.Left = left;
            item.Width = 70;
            item.Height = 19;

        }

        private string saveFilePath = @"C:\temp\DCS_NotaFiscal.xml";
        public void TransformToXml(string formType)
        {
            try
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(SAPApplication.Forms.GetForm(formType, 1).GetAsXML());
                xmlDoc.Save(saveFilePath);
                SAPApplication.StatusBar.SetText("Salvou", UI.BoMessageTime.bmt_Short, UI.BoStatusBarMessageType.smt_Success);
            }
            catch (Exception ex)
            {
                SAPApplication.StatusBar.SetText(ex.Message);
            }
        }


        private string num()
        {
            return Guid.NewGuid().ToString().Substring(0, 10);
        }
        public void LoadFromXml()
        {
            var xml = new XmlDocument();
            xml.Load(saveFilePath);
            string str = xml.InnerXml.Replace("uid=\"F_13\"", "uid=\"" + num() + "\"");
            
            SAPApplication.LoadBatchActions(ref str);

            var xxx = SAPApplication.GetLastBatchResults();
        }

        public void LoadTestForm()
        {
            UI.Form form;
            UI.FormCreationParams creationPackage;
            XmlDocument xmlDoc = new XmlDocument();
            
            creationPackage = SAPApplication.CreateObject(UI.BoCreatableObjectType.cot_FormCreationParams);

            creationPackage.UniqueID = num();
            creationPackage.BorderStyle = UI.BoFormBorderStyle.fbs_Fixed;

            xmlDoc.Load(@"C:\temp\teste.srf");// gerado pelo ScreenPainter / B1 Studio

            creationPackage.XmlData = xmlDoc.InnerXml;

            form = SAPApplication.Forms.AddEx(creationPackage);

            DataSources(form);

            form.VisibleEx = true;

        }

        private void DataSources(UI.Form form)
        {
            UI.DBDataSource dbDataSources = null;
            UI.EditText editText = null;

            dbDataSources = form.DataSources.DBDataSources.Add("OCRD");

            editText = (UI.EditText)form.Items.Item("descricao").Specific;
            editText.DataBind.SetBound(true, "OCRD", "CardName");

            editText = (UI.EditText) form.Items.Item("codigo").Specific;
            editText.DataBind.SetBound(true, "OCRD", "CardCode");
            
            dbDataSources = form.DataSources.DBDataSources.Item("OCRD");
            dbDataSources.Query(null);
            form.DataBrowser.BrowseBy = "codigo";

            /////////////////////////////////// COMBO BOX

            UI.UserDataSource userDataSource = null;
            userDataSource = form.DataSources.UserDataSources.Add("optYes", UI.BoDataType.dt_LONG_TEXT, 2);
            userDataSource = form.DataSources.UserDataSources.Add("optNo", UI.BoDataType.dt_LONG_TEXT, 2);

            UI.OptionBtn radio = form.Items.Item("rd1").Specific;
            radio.ValOn = "Y";
            radio.ValOff = "N";
            radio.GroupWith("rd2");
            radio.DataBind.SetBound(true, "", "optYes");

            radio = form.Items.Item("rd2").Specific;
            radio.ValOn = "Y";
            radio.ValOff = "N";
            radio.GroupWith("rd1");
            radio.DataBind.SetBound(true, "", "optNo");
            ///////////////////////////////////////////////////////
            userDataSource = null;
            userDataSource = form.DataSources.UserDataSources.Add("optYes", UI.BoDataType.dt_LONG_TEXT, 2);
            userDataSource = form.DataSources.UserDataSources.Add("optNo", UI.BoDataType.dt_LONG_TEXT, 2);

            UI.EditText qtde = form.Items.Item("etQtde").Specific;
            qtde.DataBind.SetBound(true, "", "Qtde");

            ///////////////////////////////////////////////

            dbDataSources = form.DataSources.DBDataSources.Add("INV1");
            var matrix = (UI.Matrix)form.Items.Item("NMS_Matrix").Specific;

            var column = matrix.Columns.Item("dCol0");
            column.DataBind.SetBound(true, "INV1", "Quantity");

            column = matrix.Columns.Item("dCol1");
            column.DataBind.SetBound(true, "INV1", "itemcode");

            column = matrix.Columns.Item("dCol2");
            column.DataBind.SetBound(true, "INV1", "Dscription");

            dbDataSources = form.DataSources.DBDataSources.Item("INV1");
            dbDataSources.Query(CreateConditions());
            matrix.LoadFromDataSourceEx(true);

        }

        private UI.Conditions CreateConditions()
        {
            var listaCondicoes = (UI.Conditions)SAPApplication.CreateObject(UI.BoCreatableObjectType.cot_Conditions);
            var condicao = listaCondicoes.Add();
            condicao.Alias = "Quantity";
            condicao.Operation = UI.BoConditionOperation.co_GRATER_EQUAL;
            condicao.CondVal = "5";

            return listaCondicoes;
        }

        public void SetupEventHandlers()
        {
            SAPApplication.AppEvent += new UI._IApplicationEvents_AppEventEventHandler(SAPApplication_AppEvent);
            SAPApplication.ItemEvent += new UI._IApplicationEvents_ItemEventEventHandler(SAPApplication_ItemEvent);
            SAPApplication.MenuEvent += new UI._IApplicationEvents_MenuEventEventHandler(SAPApplication_MenuEvent);
            SetupFilters();
        }

        #region Filtros

        public void SetupFilters()
        {
            var listaFiltros = new UI.EventFilters();
            var filtro = listaFiltros.Add(UI.BoEventTypes.et_FORM_LOAD);
            filtro.AddEx("133");

            filtro = listaFiltros.Add(UI.BoEventTypes.et_MENU_CLICK);
            filtro.AddEx("sub123");

            SAPApplication.SetFilter(listaFiltros);
        }

        #endregion

        public void SAPApplication_MenuEvent(ref UI.MenuEvent pVal, out bool BubbleEvent)
        {
            if(pVal.BeforeAction && pVal.MenuUID=="sub123")
                LoadTestForm();
            BubbleEvent = true;
        }

        public void AddMenu()
        {
            SAPApplication.Menus.RemoveEx("sub123");
            SAPApplication.Menus.RemoveEx("Menu123");

            var menu = SAPApplication.Menus;
            var creationPackage = (UI.MenuCreationParams)SAPApplication.CreateObject(UI.BoCreatableObjectType.cot_MenuCreationParams);
            var menuItem = SAPApplication.Menus.Item("43520");

            creationPackage.Type = UI.BoMenuType.mt_POPUP;
            creationPackage.UniqueID = "Menu123";
            creationPackage.String = "Label Menu";
            creationPackage.Enabled = true;
            creationPackage.Position = 15;//SAPApplication.Menus.Count;

            menu = menuItem.SubMenus;

            try
            {
                menu.AddEx(creationPackage);

                menuItem = SAPApplication.Menus.Item("Menu123");
                creationPackage.Type = UI.BoMenuType.mt_STRING;
                creationPackage.UniqueID = "sub123";
                creationPackage.String = "Item Menu";
                creationPackage.Enabled = true;
                menu = menuItem.SubMenus;
                menu.AddEx(creationPackage);
            }
            catch (Exception)
            {
                SAPApplication.MessageBox("Menu ja existe");

            }
        }

        //o nome é indiferente
        public void SAPApplication_ItemEvent(string FormUID, ref UI.ItemEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;

            if (pVal.FormTypeEx == "133" && pVal.EventType == UI.BoEventTypes.et_FORM_LOAD && pVal.Before_Action)
            {
                SAPApplication.MessageBox("Você não é bem vindo na nota fiscal");
                BubbleEvent = false;
            }

            if (pVal.FormTypeEx == "133" && pVal.EventType == UI.BoEventTypes.et_CLICK && pVal.Before_Action)
            {
                SAPApplication.MessageBox("Você não é bem vindo na nota fiscal");
                BubbleEvent = false;
            }
        }

        public void SAPApplication_AppEvent(UI.BoAppEventTypes EventType)
        {
            switch (EventType)
            {
                case SAPbouiCOM.BoAppEventTypes.aet_CompanyChanged:
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_FontChanged:
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_LanguageChanged:
                    break;
                case SAPbouiCOM.BoAppEventTypes.aet_ServerTerminition:
                case SAPbouiCOM.BoAppEventTypes.aet_ShutDown:
                    SAPApplication.Menus.RemoveEx("Menu123");
                    Application.Exit();
                    break;
                default:
                    break;
            }


        }
    }
}
