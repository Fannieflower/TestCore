using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.visPo.service{
	
	
	
	public class WmsPoDetailNewHelper : TBeanSerializer<WmsPoDetailNew>
	{
		
		public static WmsPoDetailNewHelper OBJ = new WmsPoDetailNewHelper();
		
		public static WmsPoDetailNewHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WmsPoDetailNew structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("itemNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetItemNo(value);
					}
					
					
					
					
					
					if ("poQty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPoQty(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("tagPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTagPrice(value);
					}
					
					
					
					
					
					if ("antiTheftClasp".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAntiTheftClasp(value);
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
					
					
					
					
					
					if ("buyerGroupCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerGroupCode(value);
					}
					
					
					
					
					
					if ("poUnitPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPoUnitPrice(value);
					}
					
					
					
					
					
					if ("taxRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetTaxRate(value);
					}
					
					
					
					
					
					if ("priceWithTax".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetPriceWithTax(value);
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
		
		
		public void Write(WmsPoDetailNew structs, Protocol oprot){
			
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
			
			
			if(structs.GetItemNo() != null) {
				
				oprot.WriteFieldBegin("itemNo");
				oprot.WriteString(structs.GetItemNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoQty() != null) {
				
				oprot.WriteFieldBegin("poQty");
				oprot.WriteI32((int)structs.GetPoQty()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTagPrice() != null) {
				
				oprot.WriteFieldBegin("tagPrice");
				oprot.WriteString(structs.GetTagPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAntiTheftClasp() != null) {
				
				oprot.WriteFieldBegin("antiTheftClasp");
				oprot.WriteString(structs.GetAntiTheftClasp());
				
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
			
			
			if(structs.GetBuyerGroupCode() != null) {
				
				oprot.WriteFieldBegin("buyerGroupCode");
				oprot.WriteString(structs.GetBuyerGroupCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoUnitPrice() != null) {
				
				oprot.WriteFieldBegin("poUnitPrice");
				oprot.WriteDouble((double)structs.GetPoUnitPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxRate() != null) {
				
				oprot.WriteFieldBegin("taxRate");
				oprot.WriteDouble((double)structs.GetTaxRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPriceWithTax() != null) {
				
				oprot.WriteFieldBegin("priceWithTax");
				oprot.WriteDouble((double)structs.GetPriceWithTax());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WmsPoDetailNew bean){
			
			
		}
		
	}
	
}