using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Base2BaseWeb.B2B.DataLayer.Migrations
{
    public partial class Changed_StoredProcedures_UpsertPointChild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //// sp_InsertPointChild
            //StringBuilder sp_command = new StringBuilder();
            //sp_command.Append("Alter Procedure sp_InsertPointChild" + Environment.NewLine);
            //sp_command.Append("@cliGroupNumber int, @childId int, @childName nvarchar(255)" + Environment.NewLine);
            //sp_command.Append("@ind_num	nvarchar(50), @svid_num	nvarchar(50)" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);
            //sp_command.Append("" + Environment.NewLine);

            //sp_command.Append("as" + Environment.NewLine);
            //sp_command.Append("Begin" + Environment.NewLine);
            //sp_command.Append("Insert Into point(cli_group_number,ChildId,name_point,post," + Environment.NewLine);
            //sp_command.Append("ind_num,svid_num,address,telefon,fax,name_ceo_person,contact_person," + Environment.NewLine);
            //sp_command.Append("transport_pr,arenda,realis,closed,mfo,bank_account,okpo," + Environment.NewLine);
            //sp_command.Append("bank_name,client_kurs,point_comment,saldo,saldo_dol,email," + Environment.NewLine);
            //sp_command.Append("bank_from_param,name_firm_from_param,date_cli_zad,zad_activate," + Environment.NewLine);
            //sp_command.Append("nds,kredit,kredit_dol,DayZad,DayZadOn,kredit_on,driver,name_firm_from_param_fiscal," + Environment.NewLine);
            //sp_command.Append("licence_number,name_firm,name_firm_fiscal,address_fiscal," + Environment.NewLine);
            //sp_command.Append("telefon_fiscal,prof_1_person,prof_1_person_fiscal,name_1_person," + Environment.NewLine);
            //sp_command.Append("name_1_person_fiscal,prof_2_person,prof_2_person_fiscal,name_2_person," + Environment.NewLine);
            //sp_command.Append("name_2_person_fiscal,ma_otv_person,ma_otv_person_fiscal,path_to_mobile_synchro," + Environment.NewLine);
            //sp_command.Append("comm_agent,card_number,card_activated,discount_card_percent," + Environment.NewLine);
            //sp_command.Append("licence_end_date,contract_number,contract_start_date,contract_end_date," + Environment.NewLine);
            //sp_command.Append("point_type,agent_max_discount,waiter,kpp,corr_account," + Environment.NewLine);
            //sp_command.Append("agent_si_allow,agent_order_allow,agent_cash_allow,price_column_number," + Environment.NewLine);
            //sp_command.Append("discount_type,agent_use_routes,routes_by_dates,agent_only_selected_categories," + Environment.NewLine);
            //sp_command.Append("ExportDocumentToFranchiseService,si_articl_number,pis_articl_number," + Environment.NewLine);
            //sp_command.Append("co_articl_number,cash_point_number,nds_payer,last_edit_date," + Environment.NewLine);
            //sp_command.Append("name_1_person_fiscal_tax_id,name_2_person_fiscal_tax_id," + Environment.NewLine);
            //sp_command.Append("iban,Swiftcode,BankClearingNumber,Postconto)" + Environment.NewLine);
            //sp_command.Append("Values(@cliGroupNumber,@childId,@childName,0," + Environment.NewLine);
            //sp_command.Append("@ind_num,@svid_num,@address,@telefon,@fax,@name_ceo_person," + Environment.NewLine);
            //sp_command.Append("@contact_person,@transport_pr,@arenda,@realis,@closed,@mfo,@bank_account,@okpo," + Environment.NewLine);
            //sp_command.Append("@bank_name,@client_kurs,@point_comment,@saldo,@saldo_dol,@email,@bank_from_param," + Environment.NewLine);
            //sp_command.Append("@name_firm_from_param,@date_cli_zad,@zad_activate,@nds,@kredit,@kredit_dol," + Environment.NewLine);
            //sp_command.Append("@DayZad,@DayZadOn,@kredit_on,@driver,@name_firm_from_param_fiscal,@licence_number," + Environment.NewLine);
            //sp_command.Append("@name_firm,@name_firm_fiscal,@address_fiscal,@telefon_fiscal,@prof_1_person," + Environment.NewLine);
            //sp_command.Append("@prof_1_person_fiscal,@name_1_person,@name_1_person_fiscal,@prof_2_person," + Environment.NewLine);
            //sp_command.Append("@prof_2_person_fiscal,@name_2_person,@name_2_person_fiscal,@ma_otv_person," + Environment.NewLine);
            //sp_command.Append("@ma_otv_person_fiscal,@path_to_mobile_synchro,@comm_agent,@card_number," + Environment.NewLine);
            //sp_command.Append("@card_activated,@discount_card_percent,@licence_end_date,@contract_number," + Environment.NewLine);
            //sp_command.Append("@contract_start_date,@contract_end_date,@point_type,@agent_max_discount," + Environment.NewLine);
            //sp_command.Append("@waiter,@kpp,@corr_account,@agent_si_allow,@agent_order_allow,@agent_cash_allow," + Environment.NewLine);
            //sp_command.Append("@price_column_number,@discount_type,@agent_use_routes,@routes_by_dates," + Environment.NewLine);
            //sp_command.Append("@agent_only_selected_categories,@ExportDocumentToFranchiseService," + Environment.NewLine);
            //sp_command.Append("@si_articl_number,@pis_articl_number,@co_articl_number,@cash_point_number," + Environment.NewLine);
            //sp_command.Append("@nds_payer,@last_edit_date,@name_1_person_fiscal_tax_id," + Environment.NewLine);
            //sp_command.Append("@name_2_person_fiscal_tax_id,@iban,@Swiftcode,@BankClearingNumber,@Postconto)" + Environment.NewLine);
            //sp_command.Append("End" + Environment.NewLine);
            //sp_command.Append("Go" + Environment.NewLine);
            //migrationBuilder.Sql(sp_command.ToString());
            //sp_command.Clear();


            //sp_command.Append("Alter Procedure sp_UpdatePointChild" + Environment.NewLine);
            //sp_command.Append("@cliGroupNumber int, @childId int, @childName nvarchar(255)" + Environment.NewLine);
            //sp_command.Append("as" + Environment.NewLine);
            //sp_command.Append("Begin" + Environment.NewLine);
            //sp_command.Append("Update point Set name_point=@childName," + Environment.NewLine);
            //sp_command.Append("ind_num=@ind_num,svid_num=@svid_num,address=@address,telefon=@telefon,fax=@fax,name_ceo_person=@name_ceo_person,contact_person=@contact_person," + Environment.NewLine);
            //sp_command.Append("transport_pr=@transport_pr,arenda=@arenda,realis=@realis,closed=@closed,mfo=@mfo,bank_account=@bank_account,okpo=@okpo," + Environment.NewLine);
            //sp_command.Append("bank_name=@bank_name,client_kurs=@client_kurs,point_comment=@point_comment,saldo=@saldo,saldo_dol=@saldo_dol,email=@email," + Environment.NewLine);
            //sp_command.Append("bank_from_param=@bank_from_param,name_firm_from_param=@name_firm_from_param,date_cli_zad=@date_cli_zad,zad_activate=@zad_activate," + Environment.NewLine);
            //sp_command.Append("nds=@nds,kredit=@kredit,kredit_dol=@kredit_dol,DayZad=@DayZad,DayZadOn=@DayZadOn,kredit_on=@kredit_on,driver=@driver,name_firm_from_param_fiscal=@name_firm_from_param_fiscal," + Environment.NewLine);
            //sp_command.Append("licence_number=@licence_number,name_firm=@name_firm,name_firm_fiscal=@name_firm_fiscal,address_fiscal=@address_fiscal," + Environment.NewLine);
            //sp_command.Append("telefon_fiscal=@telefon_fiscal,prof_1_person=@prof_1_person,prof_1_person_fiscal=@prof_1_person_fiscal,name_1_person=@name_1_person," + Environment.NewLine);
            //sp_command.Append("name_1_person_fiscal=@name_1_person_fiscal,prof_2_person=@prof_2_person,prof_2_person_fiscal=@prof_2_person_fiscal,name_2_person=@name_2_person," + Environment.NewLine);
            //sp_command.Append("name_2_person_fiscal=@name_2_person_fiscal,ma_otv_person=@ma_otv_person,ma_otv_person_fiscal=@ma_otv_person_fiscal,path_to_mobile_synchro=@path_to_mobile_synchro," + Environment.NewLine);
            //sp_command.Append("comm_agent=@comm_agent,card_number=@card_number,card_activated=@card_activated,discount_card_percent=@discount_card_percent," + Environment.NewLine);
            //sp_command.Append("licence_end_date=@licence_end_date,contract_number=@contract_number,contract_start_date=@contract_start_date,contract_end_date=@contract_end_date," + Environment.NewLine);
            //sp_command.Append("point_type=@point_type,agent_max_discount=@agent_max_discount,waiter=@waiter,kpp=@kpp,corr_account=@corr_account," + Environment.NewLine);
            //sp_command.Append("agent_si_allow=@agent_si_allow,agent_order_allow=@agent_order_allow,agent_cash_allow=@agent_cash_allow,price_column_number=@price_column_number," + Environment.NewLine);
            //sp_command.Append("discount_type=@discount_type,agent_use_routes=@agent_use_routes,routes_by_dates=@routes_by_dates,agent_only_selected_categories=@agent_only_selected_categories," + Environment.NewLine);
            //sp_command.Append("ExportDocumentToFranchiseService=@ExportDocumentToFranchiseService,si_articl_number=@si_articl_number,pis_articl_number=@pis_articl_number," + Environment.NewLine);
            //sp_command.Append("co_articl_number=@co_articl_number,cash_point_number=@cash_point_number,nds_payer=@nds_payer,last_edit_date=@last_edit_date," + Environment.NewLine);
            //sp_command.Append("name_1_person_fiscal_tax_id=@name_1_person_fiscal_tax_id,name_2_person_fiscal_tax_id=@name_2_person_fiscal_tax_id," + Environment.NewLine);
            //sp_command.Append("iban=@iban,Swiftcode=@Swiftcode,BankClearingNumber=@BankClearingNumber,Postconto=@Postconto)" + Environment.NewLine);
            //sp_command.Append("Where cli_group_number=@cliGroupNumber and ChildId=@childId" + Environment.NewLine);
            //sp_command.Append("End" + Environment.NewLine);
            //sp_command.Append("Go" + Environment.NewLine);
            //migrationBuilder.Sql(sp_command.ToString());
            //sp_command.Clear();

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //StringBuilder sp_command = new StringBuilder();
            //sp_command.Append("IF (OBJECT_ID('sp_InsertPointChild', 'P') IS NOT NULL)" + Environment.NewLine);
            //sp_command.Append("Drop Procedure sp_InsertPointChild" + Environment.NewLine);
            //migrationBuilder.Sql(sp_command.ToString());
            //sp_command.Clear();

            //sp_command.Append("IF (OBJECT_ID('sp_UpdatePointChild', 'P') IS NOT NULL)" + Environment.NewLine);
            //sp_command.Append("Drop Procedure sp_UpdatePointChild" + Environment.NewLine);
            //migrationBuilder.Sql(sp_command.ToString());
            //sp_command.Clear();
        }
    }
}
