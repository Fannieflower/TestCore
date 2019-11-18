using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class PrepayInfoHelper : TBeanSerializer<PrepayInfo>
	{
		
		public static PrepayInfoHelper OBJ = new PrepayInfoHelper();
		
		public static PrepayInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PrepayInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mainId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMainId(value);
					}
					
					
					
					
					
					if ("activityType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityType(value);
					}
					
					
					
					
					
					if ("preferentialType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPreferentialType(value);
					}
					
					
					
					
					
					if ("prepayType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPrepayType(value);
					}
					
					
					
					
					
					if ("prepayValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayValue(value);
					}
					
					
					
					
					
					if ("prepayPreferential".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayPreferential(value);
					}
					
					
					
					
					
					if ("discountContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountContent(value);
					}
					
					
					
					
					
					if ("vendorBearInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.VendorBearInfo();
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetVendorBearInfo(value);
					}
					
					
					
					
					
					if ("actNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActNo(value);
					}
					
					
					
					
					
					if ("actName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActName(value);
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
		
		
		public void Write(PrepayInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainId() != null) {
				
				oprot.WriteFieldBegin("mainId");
				oprot.WriteI64((long)structs.GetMainId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityType() != null) {
				
				oprot.WriteFieldBegin("activityType");
				oprot.WriteByte((byte)structs.GetActivityType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreferentialType() != null) {
				
				oprot.WriteFieldBegin("preferentialType");
				oprot.WriteByte((byte)structs.GetPreferentialType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayType() != null) {
				
				oprot.WriteFieldBegin("prepayType");
				oprot.WriteByte((byte)structs.GetPrepayType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayValue() != null) {
				
				oprot.WriteFieldBegin("prepayValue");
				oprot.WriteString(structs.GetPrepayValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayPreferential() != null) {
				
				oprot.WriteFieldBegin("prepayPreferential");
				oprot.WriteString(structs.GetPrepayPreferential());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountContent() != null) {
				
				oprot.WriteFieldBegin("discountContent");
				oprot.WriteString(structs.GetDiscountContent());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorBearInfo() != null) {
				
				oprot.WriteFieldBegin("vendorBearInfo");
				
				com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Write(structs.GetVendorBearInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActNo() != null) {
				
				oprot.WriteFieldBegin("actNo");
				oprot.WriteString(structs.GetActNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActName() != null) {
				
				oprot.WriteFieldBegin("actName");
				oprot.WriteString(structs.GetActName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PrepayInfo bean){
			
			
		}
		
	}
	
}