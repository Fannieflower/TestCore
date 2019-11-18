using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class WmsPoLineHelper : TBeanSerializer<WmsPoLine>
	{
		
		public static WmsPoLineHelper OBJ = new WmsPoLineHelper();
		
		public static WmsPoLineHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WmsPoLine structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("po_line_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo_line_id(value);
					}
					
					
					
					
					
					if ("line_num".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLine_num(value);
					}
					
					
					
					
					
					if ("item_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItem_code(value);
					}
					
					
					
					
					
					if ("quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetQuantity(value);
					}
					
					
					
					
					
					if ("volume_qty".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVolume_qty(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("update".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdate(value);
					}
					
					
					
					
					
					if ("selling_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSelling_price(value);
					}
					
					
					
					
					
					if ("anti_theft_clasp".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAnti_theft_clasp(value);
					}
					
					
					
					
					
					if ("productionDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProductionDate(value);
					}
					
					
					
					
					
					if ("expireDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpireDate(value);
					}
					
					
					
					
					
					if ("approval".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApproval(value);
					}
					
					
					
					
					
					if ("approvalTerm".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApprovalTerm(value);
					}
					
					
					
					
					
					if ("priceWithTax".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPriceWithTax(value);
					}
					
					
					
					
					
					if ("brandSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandSn(value);
					}
					
					
					
					
					
					if ("brandName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandName(value);
					}
					
					
					
					
					
					if ("brandNameEn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandNameEn(value);
					}
					
					
					
					
					
					if ("tagGroupName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTagGroupName(value);
					}
					
					
					
					
					
					if ("oldItemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldItemNo(value);
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
		
		
		public void Write(WmsPoLine structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPo_line_id() != null) {
				
				oprot.WriteFieldBegin("po_line_id");
				oprot.WriteString(structs.GetPo_line_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLine_num() != null) {
				
				oprot.WriteFieldBegin("line_num");
				oprot.WriteString(structs.GetLine_num());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetItem_code() != null) {
				
				oprot.WriteFieldBegin("item_code");
				oprot.WriteString(structs.GetItem_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuantity() != null) {
				
				oprot.WriteFieldBegin("quantity");
				oprot.WriteString(structs.GetQuantity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVolume_qty() != null) {
				
				oprot.WriteFieldBegin("volume_qty");
				oprot.WriteString(structs.GetVolume_qty());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteString(structs.GetStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate() != null) {
				
				oprot.WriteFieldBegin("update");
				oprot.WriteString(structs.GetUpdate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSelling_price() != null) {
				
				oprot.WriteFieldBegin("selling_price");
				oprot.WriteString(structs.GetSelling_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAnti_theft_clasp() != null) {
				
				oprot.WriteFieldBegin("anti_theft_clasp");
				oprot.WriteString(structs.GetAnti_theft_clasp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProductionDate() != null) {
				
				oprot.WriteFieldBegin("productionDate");
				oprot.WriteString(structs.GetProductionDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpireDate() != null) {
				
				oprot.WriteFieldBegin("expireDate");
				oprot.WriteString(structs.GetExpireDate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApproval() != null) {
				
				oprot.WriteFieldBegin("approval");
				oprot.WriteString(structs.GetApproval());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApprovalTerm() != null) {
				
				oprot.WriteFieldBegin("approvalTerm");
				oprot.WriteString(structs.GetApprovalTerm());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPriceWithTax() != null) {
				
				oprot.WriteFieldBegin("priceWithTax");
				oprot.WriteString(structs.GetPriceWithTax());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandSn() != null) {
				
				oprot.WriteFieldBegin("brandSn");
				oprot.WriteString(structs.GetBrandSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandName() != null) {
				
				oprot.WriteFieldBegin("brandName");
				oprot.WriteString(structs.GetBrandName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandNameEn() != null) {
				
				oprot.WriteFieldBegin("brandNameEn");
				oprot.WriteString(structs.GetBrandNameEn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTagGroupName() != null) {
				
				oprot.WriteFieldBegin("tagGroupName");
				oprot.WriteString(structs.GetTagGroupName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOldItemNo() != null) {
				
				oprot.WriteFieldBegin("oldItemNo");
				oprot.WriteString(structs.GetOldItemNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WmsPoLine bean){
			
			
		}
		
	}
	
}