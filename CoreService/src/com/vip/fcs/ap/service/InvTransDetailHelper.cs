using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.ap.service{
	
	
	
	public class InvTransDetailHelper : TBeanSerializer<InvTransDetail>
	{
		
		public static InvTransDetailHelper OBJ = new InvTransDetailHelper();
		
		public static InvTransDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InvTransDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transactionDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetTransactionDate(value);
					}
					
					
					
					
					
					if ("periodName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPeriodName(value);
					}
					
					
					
					
					
					if ("transactionTypeCommand".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionTypeCommand(value);
					}
					
					
					
					
					
					if ("transactionTypeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionTypeName(value);
					}
					
					
					
					
					
					if ("globalId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetGlobalId(value);
					}
					
					
					
					
					
					if ("lineType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLineType(value);
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
					
					
					
					
					
					if ("orgId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrgId(value);
					}
					
					
					
					
					
					if ("orgName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrgName(value);
					}
					
					
					
					
					
					if ("poNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoNo(value);
					}
					
					
					
					
					
					if ("itemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemNo(value);
					}
					
					
					
					
					
					if ("itemDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemDesc(value);
					}
					
					
					
					
					
					if ("goodsNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsNo(value);
					}
					
					
					
					
					
					if ("quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetQuantity(value);
					}
					
					
					
					
					
					if ("doc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDoc(value);
					}
					
					
					
					
					
					if ("returnReqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnReqNo(value);
					}
					
					
					
					
					
					if ("sellingMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellingMode(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("brandCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandCode(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("category1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory1(value);
					}
					
					
					
					
					
					if ("category2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory2(value);
					}
					
					
					
					
					
					if ("category3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory3(value);
					}
					
					
					
					
					
					if ("parentPoNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetParentPoNo(value);
					}
					
					
					
					
					
					if ("whType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWhType(value);
					}
					
					
					
					
					
					if ("dataGenTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDataGenTime(value);
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
		
		
		public void Write(InvTransDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransactionDate() != null) {
				
				oprot.WriteFieldBegin("transactionDate");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetTransactionDate())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPeriodName() != null) {
				
				oprot.WriteFieldBegin("periodName");
				oprot.WriteString(structs.GetPeriodName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransactionTypeCommand() != null) {
				
				oprot.WriteFieldBegin("transactionTypeCommand");
				oprot.WriteString(structs.GetTransactionTypeCommand());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransactionTypeName() != null) {
				
				oprot.WriteFieldBegin("transactionTypeName");
				oprot.WriteString(structs.GetTransactionTypeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGlobalId() != null) {
				
				oprot.WriteFieldBegin("globalId");
				oprot.WriteI64((long)structs.GetGlobalId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLineType() != null) {
				
				oprot.WriteFieldBegin("lineType");
				oprot.WriteString(structs.GetLineType());
				
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
			
			
			if(structs.GetOrgId() != null) {
				
				oprot.WriteFieldBegin("orgId");
				oprot.WriteString(structs.GetOrgId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrgName() != null) {
				
				oprot.WriteFieldBegin("orgName");
				oprot.WriteString(structs.GetOrgName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoNo() != null) {
				
				oprot.WriteFieldBegin("poNo");
				oprot.WriteString(structs.GetPoNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemNo() != null) {
				
				oprot.WriteFieldBegin("itemNo");
				oprot.WriteString(structs.GetItemNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItemDesc() != null) {
				
				oprot.WriteFieldBegin("itemDesc");
				oprot.WriteString(structs.GetItemDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsNo() != null) {
				
				oprot.WriteFieldBegin("goodsNo");
				oprot.WriteString(structs.GetGoodsNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuantity() != null) {
				
				oprot.WriteFieldBegin("quantity");
				oprot.WriteDouble((double)structs.GetQuantity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDoc() != null) {
				
				oprot.WriteFieldBegin("doc");
				oprot.WriteString(structs.GetDoc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnReqNo() != null) {
				
				oprot.WriteFieldBegin("returnReqNo");
				oprot.WriteString(structs.GetReturnReqNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellingMode() != null) {
				
				oprot.WriteFieldBegin("sellingMode");
				oprot.WriteString(structs.GetSellingMode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandCode() != null) {
				
				oprot.WriteFieldBegin("brandCode");
				oprot.WriteString(structs.GetBrandCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory1() != null) {
				
				oprot.WriteFieldBegin("category1");
				oprot.WriteString(structs.GetCategory1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory2() != null) {
				
				oprot.WriteFieldBegin("category2");
				oprot.WriteString(structs.GetCategory2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory3() != null) {
				
				oprot.WriteFieldBegin("category3");
				oprot.WriteString(structs.GetCategory3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetParentPoNo() != null) {
				
				oprot.WriteFieldBegin("parentPoNo");
				oprot.WriteString(structs.GetParentPoNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWhType() != null) {
				
				oprot.WriteFieldBegin("whType");
				oprot.WriteString(structs.GetWhType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataGenTime() != null) {
				
				oprot.WriteFieldBegin("dataGenTime");
				oprot.WriteString(structs.GetDataGenTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InvTransDetail bean){
			
			
		}
		
	}
	
}