using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class MobileInfoHelper : TBeanSerializer<MobileInfo>
	{
		
		public static MobileInfoHelper OBJ = new MobileInfoHelper();
		
		public static MobileInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(MobileInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("mobileRemark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobileRemark(value);
					}
					
					
					
					
					
					if ("vendorBearInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.VendorBearInfo();
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetVendorBearInfo(value);
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
		
		
		public void Write(MobileInfo structs, Protocol oprot){
			
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
			
			
			if(structs.GetMobileRemark() != null) {
				
				oprot.WriteFieldBegin("mobileRemark");
				oprot.WriteString(structs.GetMobileRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorBearInfo() != null) {
				
				oprot.WriteFieldBegin("vendorBearInfo");
				
				com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Write(structs.GetVendorBearInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(MobileInfo bean){
			
			
		}
		
	}
	
}