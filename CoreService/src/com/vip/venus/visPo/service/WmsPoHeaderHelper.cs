using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class WmsPoHeaderHelper : TBeanSerializer<WmsPoHeader>
	{
		
		public static WmsPoHeaderHelper OBJ = new WmsPoHeaderHelper();
		
		public static WmsPoHeaderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WmsPoHeader structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("po_number".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo_number(value);
					}
					
					
					
					
					
					if ("created_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreated_time(value);
					}
					
					
					
					
					
					if ("update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdate_time(value);
					}
					
					
					
					
					
					if ("vendor_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendor_code(value);
					}
					
					
					
					
					
					if ("vendor_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendor_name(value);
					}
					
					
					
					
					
					if ("address1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress1(value);
					}
					
					
					
					
					
					if ("address2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress2(value);
					}
					
					
					
					
					
					if ("address3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress3(value);
					}
					
					
					
					
					
					if ("city".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity(value);
					}
					
					
					
					
					
					if ("state".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetState(value);
					}
					
					
					
					
					
					if ("zip".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetZip(value);
					}
					
					
					
					
					
					if ("email".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEmail(value);
					}
					
					
					
					
					
					if ("country".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCountry(value);
					}
					
					
					
					
					
					if ("contact_telephone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContact_telephone(value);
					}
					
					
					
					
					
					if ("contacter".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContacter(value);
					}
					
					
					
					
					
					if ("po_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo_type(value);
					}
					
					
					
					
					
					if ("buyer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("poh_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoh_id(value);
					}
					
					
					
					
					
					if ("lines_count".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLines_count(value);
					}
					
					
					
					
					
					if ("sale_area".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSale_area(value);
					}
					
					
					
					
					
					if ("brand_admin".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrand_admin(value);
					}
					
					
					
					
					
					if ("warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_code(value);
					}
					
					
					
					
					
					if ("dept".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDept(value);
					}
					
					
					
					
					
					if ("need_by_date".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNeed_by_date(value);
					}
					
					
					
					
					
					if ("is_3pl".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIs_3pl(value);
					}
					
					
					
					
					
					if ("purchase_office_1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_office_1(value);
					}
					
					
					
					
					
					if ("purchase_office_1_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_office_1_name(value);
					}
					
					
					
					
					
					if ("purchase_office".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_office(value);
					}
					
					
					
					
					
					if ("purchase_office_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_office_name(value);
					}
					
					
					
					
					
					if ("purchase_office_divide".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_office_divide(value);
					}
					
					
					
					
					
					if ("purchase_office_divide_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_office_divide_name(value);
					}
					
					
					
					
					
					if ("purchase_area".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_area(value);
					}
					
					
					
					
					
					if ("purchase_area_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_area_name(value);
					}
					
					
					
					
					
					if ("isVWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIsVWarehouse(value);
					}
					
					
					
					
					
					if ("generalTrade".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGeneralTrade(value);
					}
					
					
					
					
					
					if ("purchaseCompany".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseCompany(value);
					}
					
					
					
					
					
					if ("purchaseCompanyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseCompanyCode(value);
					}
					
					
					
					
					
					if ("createUser".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateUser(value);
					}
					
					
					
					
					
					if ("sales_site".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSales_site(value);
					}
					
					
					
					
					
					if ("store_goods_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStore_goods_status(value);
					}
					
					
					
					
					
					if ("expect_sales_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetExpect_sales_time(value);
					}
					
					
					
					
					
					if ("owner".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.venus.po.service.Owner? value;
						
						value = com.vip.venus.po.service.OwnerUtil.FindByName(iprot.ReadString());
						
						structs.SetOwner(value);
					}
					
					
					
					
					
					if ("assignChannelCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAssignChannelCode(value);
					}
					
					
					
					
					
					if ("currency".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrency(value);
					}
					
					
					
					
					
					if ("defectiveGrade".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDefectiveGrade(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(WmsPoHeader structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPo_number() != null) {
				
				oprot.WriteFieldBegin("po_number");
				oprot.WriteString(structs.GetPo_number());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreated_time() != null) {
				
				oprot.WriteFieldBegin("created_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreated_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate_time() != null) {
				
				oprot.WriteFieldBegin("update_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdate_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_code() != null) {
				
				oprot.WriteFieldBegin("vendor_code");
				oprot.WriteString(structs.GetVendor_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_name() != null) {
				
				oprot.WriteFieldBegin("vendor_name");
				oprot.WriteString(structs.GetVendor_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress1() != null) {
				
				oprot.WriteFieldBegin("address1");
				oprot.WriteString(structs.GetAddress1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress2() != null) {
				
				oprot.WriteFieldBegin("address2");
				oprot.WriteString(structs.GetAddress2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress3() != null) {
				
				oprot.WriteFieldBegin("address3");
				oprot.WriteString(structs.GetAddress3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCity() != null) {
				
				oprot.WriteFieldBegin("city");
				oprot.WriteString(structs.GetCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetState() != null) {
				
				oprot.WriteFieldBegin("state");
				oprot.WriteString(structs.GetState());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetZip() != null) {
				
				oprot.WriteFieldBegin("zip");
				oprot.WriteString(structs.GetZip());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEmail() != null) {
				
				oprot.WriteFieldBegin("email");
				oprot.WriteString(structs.GetEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCountry() != null) {
				
				oprot.WriteFieldBegin("country");
				oprot.WriteString(structs.GetCountry());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContact_telephone() != null) {
				
				oprot.WriteFieldBegin("contact_telephone");
				oprot.WriteString(structs.GetContact_telephone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContacter() != null) {
				
				oprot.WriteFieldBegin("contacter");
				oprot.WriteString(structs.GetContacter());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPo_type() != null) {
				
				oprot.WriteFieldBegin("po_type");
				oprot.WriteString(structs.GetPo_type());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer() != null) {
				
				oprot.WriteFieldBegin("buyer");
				oprot.WriteString(structs.GetBuyer());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteString(structs.GetStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoh_id() != null) {
				
				oprot.WriteFieldBegin("poh_id");
				oprot.WriteString(structs.GetPoh_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLines_count() != null) {
				
				oprot.WriteFieldBegin("lines_count");
				oprot.WriteString(structs.GetLines_count());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSale_area() != null) {
				
				oprot.WriteFieldBegin("sale_area");
				oprot.WriteString(structs.GetSale_area());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand_admin() != null) {
				
				oprot.WriteFieldBegin("brand_admin");
				oprot.WriteString(structs.GetBrand_admin());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse_code() != null) {
				
				oprot.WriteFieldBegin("warehouse_code");
				oprot.WriteString(structs.GetWarehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDept() != null) {
				
				oprot.WriteFieldBegin("dept");
				oprot.WriteString(structs.GetDept());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeed_by_date() != null) {
				
				oprot.WriteFieldBegin("need_by_date");
				oprot.WriteString(structs.GetNeed_by_date());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_3pl() != null) {
				
				oprot.WriteFieldBegin("is_3pl");
				oprot.WriteByte((byte)structs.GetIs_3pl()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_office_1() != null) {
				
				oprot.WriteFieldBegin("purchase_office_1");
				oprot.WriteString(structs.GetPurchase_office_1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_office_1_name() != null) {
				
				oprot.WriteFieldBegin("purchase_office_1_name");
				oprot.WriteString(structs.GetPurchase_office_1_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_office() != null) {
				
				oprot.WriteFieldBegin("purchase_office");
				oprot.WriteString(structs.GetPurchase_office());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_office_name() != null) {
				
				oprot.WriteFieldBegin("purchase_office_name");
				oprot.WriteString(structs.GetPurchase_office_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_office_divide() != null) {
				
				oprot.WriteFieldBegin("purchase_office_divide");
				oprot.WriteString(structs.GetPurchase_office_divide());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_office_divide_name() != null) {
				
				oprot.WriteFieldBegin("purchase_office_divide_name");
				oprot.WriteString(structs.GetPurchase_office_divide_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_area() != null) {
				
				oprot.WriteFieldBegin("purchase_area");
				oprot.WriteString(structs.GetPurchase_area());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_area_name() != null) {
				
				oprot.WriteFieldBegin("purchase_area_name");
				oprot.WriteString(structs.GetPurchase_area_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsVWarehouse() != null) {
				
				oprot.WriteFieldBegin("isVWarehouse");
				oprot.WriteString(structs.GetIsVWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGeneralTrade() != null) {
				
				oprot.WriteFieldBegin("generalTrade");
				oprot.WriteString(structs.GetGeneralTrade());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseCompany() != null) {
				
				oprot.WriteFieldBegin("purchaseCompany");
				oprot.WriteString(structs.GetPurchaseCompany());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseCompanyCode() != null) {
				
				oprot.WriteFieldBegin("purchaseCompanyCode");
				oprot.WriteString(structs.GetPurchaseCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateUser() != null) {
				
				oprot.WriteFieldBegin("createUser");
				oprot.WriteString(structs.GetCreateUser());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSales_site() != null) {
				
				oprot.WriteFieldBegin("sales_site");
				oprot.WriteString(structs.GetSales_site());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStore_goods_status() != null) {
				
				oprot.WriteFieldBegin("store_goods_status");
				oprot.WriteString(structs.GetStore_goods_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpect_sales_time() != null) {
				
				oprot.WriteFieldBegin("expect_sales_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetExpect_sales_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOwner() != null) {
				
				oprot.WriteFieldBegin("owner");
				oprot.WriteString(structs.GetOwner().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAssignChannelCode() != null) {
				
				oprot.WriteFieldBegin("assignChannelCode");
				oprot.WriteString(structs.GetAssignChannelCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCurrency() != null) {
				
				oprot.WriteFieldBegin("currency");
				oprot.WriteString(structs.GetCurrency());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDefectiveGrade() != null) {
				
				oprot.WriteFieldBegin("defectiveGrade");
				oprot.WriteI32((int)structs.GetDefectiveGrade()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WmsPoHeader bean){
			
			
		}
		
	}
	
}