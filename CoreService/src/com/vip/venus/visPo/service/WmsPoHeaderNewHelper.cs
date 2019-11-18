using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class WmsPoHeaderNewHelper : TBeanSerializer<WmsPoHeaderNew>
	{
		
		public static WmsPoHeaderNewHelper OBJ = new WmsPoHeaderNewHelper();
		
		public static WmsPoHeaderNewHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WmsPoHeaderNew structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("city".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity(value);
					}
					
					
					
					
					
					if ("province".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvince(value);
					}
					
					
					
					
					
					if ("country".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCountry(value);
					}
					
					
					
					
					
					if ("contacterTelephone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContacterTelephone(value);
					}
					
					
					
					
					
					if ("contacter".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContacter(value);
					}
					
					
					
					
					
					if ("email".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEmail(value);
					}
					
					
					
					
					
					if ("purchaseTypeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseTypeName(value);
					}
					
					
					
					
					
					if ("buyerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerName(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("sellArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellArea(value);
					}
					
					
					
					
					
					if ("buyerBy".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerBy(value);
					}
					
					
					
					
					
					if ("wareHouseCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWareHouseCode(value);
					}
					
					
					
					
					
					if ("dept".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDept(value);
					}
					
					
					
					
					
					if ("needByDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNeedByDate(value);
					}
					
					
					
					
					
					if ("is3pl".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetIs3pl(value);
					}
					
					
					
					
					
					if ("purchaseOffice1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOffice1(value);
					}
					
					
					
					
					
					if ("purchaseOffice1Name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOffice1Name(value);
					}
					
					
					
					
					
					if ("purchaseOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOffice(value);
					}
					
					
					
					
					
					if ("purchaseOfficeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOfficeName(value);
					}
					
					
					
					
					
					if ("purchaseOfficeDivide".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOfficeDivide(value);
					}
					
					
					
					
					
					if ("purchaseOfficeDivideName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOfficeDivideName(value);
					}
					
					
					
					
					
					if ("purchaseArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseArea(value);
					}
					
					
					
					
					
					if ("purchaseAreaName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseAreaName(value);
					}
					
					
					
					
					
					if ("isVWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
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
					
					
					
					
					
					if ("createUserId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateUserId(value);
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
		
		
		public void Write(WmsPoHeaderNew structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				oprot.WriteString(structs.GetAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCity() != null) {
				
				oprot.WriteFieldBegin("city");
				oprot.WriteString(structs.GetCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvince() != null) {
				
				oprot.WriteFieldBegin("province");
				oprot.WriteString(structs.GetProvince());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCountry() != null) {
				
				oprot.WriteFieldBegin("country");
				oprot.WriteString(structs.GetCountry());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContacterTelephone() != null) {
				
				oprot.WriteFieldBegin("contacterTelephone");
				oprot.WriteString(structs.GetContacterTelephone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContacter() != null) {
				
				oprot.WriteFieldBegin("contacter");
				oprot.WriteString(structs.GetContacter());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEmail() != null) {
				
				oprot.WriteFieldBegin("email");
				oprot.WriteString(structs.GetEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseTypeName() != null) {
				
				oprot.WriteFieldBegin("purchaseTypeName");
				oprot.WriteString(structs.GetPurchaseTypeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerName() != null) {
				
				oprot.WriteFieldBegin("buyerName");
				oprot.WriteString(structs.GetBuyerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("status can not be null!");
			}
			
			
			if(structs.GetSellArea() != null) {
				
				oprot.WriteFieldBegin("sellArea");
				oprot.WriteString(structs.GetSellArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerBy() != null) {
				
				oprot.WriteFieldBegin("buyerBy");
				oprot.WriteString(structs.GetBuyerBy());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWareHouseCode() != null) {
				
				oprot.WriteFieldBegin("wareHouseCode");
				oprot.WriteString(structs.GetWareHouseCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDept() != null) {
				
				oprot.WriteFieldBegin("dept");
				oprot.WriteString(structs.GetDept());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedByDate() != null) {
				
				oprot.WriteFieldBegin("needByDate");
				oprot.WriteString(structs.GetNeedByDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs3pl() != null) {
				
				oprot.WriteFieldBegin("is3pl");
				oprot.WriteByte((byte)structs.GetIs3pl()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("is3pl can not be null!");
			}
			
			
			if(structs.GetPurchaseOffice1() != null) {
				
				oprot.WriteFieldBegin("purchaseOffice1");
				oprot.WriteString(structs.GetPurchaseOffice1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOffice1Name() != null) {
				
				oprot.WriteFieldBegin("purchaseOffice1Name");
				oprot.WriteString(structs.GetPurchaseOffice1Name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOffice() != null) {
				
				oprot.WriteFieldBegin("purchaseOffice");
				oprot.WriteString(structs.GetPurchaseOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOfficeName() != null) {
				
				oprot.WriteFieldBegin("purchaseOfficeName");
				oprot.WriteString(structs.GetPurchaseOfficeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOfficeDivide() != null) {
				
				oprot.WriteFieldBegin("purchaseOfficeDivide");
				oprot.WriteString(structs.GetPurchaseOfficeDivide());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOfficeDivideName() != null) {
				
				oprot.WriteFieldBegin("purchaseOfficeDivideName");
				oprot.WriteString(structs.GetPurchaseOfficeDivideName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseArea() != null) {
				
				oprot.WriteFieldBegin("purchaseArea");
				oprot.WriteString(structs.GetPurchaseArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseAreaName() != null) {
				
				oprot.WriteFieldBegin("purchaseAreaName");
				oprot.WriteString(structs.GetPurchaseAreaName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsVWarehouse() != null) {
				
				oprot.WriteFieldBegin("isVWarehouse");
				oprot.WriteI32((int)structs.GetIsVWarehouse()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isVWarehouse can not be null!");
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
			
			
			if(structs.GetCreateUserId() != null) {
				
				oprot.WriteFieldBegin("createUserId");
				oprot.WriteString(structs.GetCreateUserId());
				
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
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WmsPoHeaderNew bean){
			
			
		}
		
	}
	
}