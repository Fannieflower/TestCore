using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class OrderDeliveryInfoHelper : TBeanSerializer<OrderDeliveryInfo>
	{
		
		public static OrderDeliveryInfoHelper OBJ = new OrderDeliveryInfoHelper();
		
		public static OrderDeliveryInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderDeliveryInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mainCustCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMainCustCode(value);
					}
					
					
					
					
					
					if ("mainCustName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMainCustName(value);
					}
					
					
					
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("custName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustName(value);
					}
					
					
					
					
					
					if ("expectedSignTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpectedSignTime(value);
					}
					
					
					
					
					
					if ("expectedTrunkTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpectedTrunkTime(value);
					}
					
					
					
					
					
					if ("signTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSignTime(value);
					}
					
					
					
					
					
					if ("trunkTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrunkTime(value);
					}
					
					
					
					
					
					if ("custType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCustType(value);
					}
					
					
					
					
					
					if ("timeLiness".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTimeLiness(value);
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
		
		
		public void Write(OrderDeliveryInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainCustCode() != null) {
				
				oprot.WriteFieldBegin("mainCustCode");
				oprot.WriteString(structs.GetMainCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMainCustName() != null) {
				
				oprot.WriteFieldBegin("mainCustName");
				oprot.WriteString(structs.GetMainCustName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustName() != null) {
				
				oprot.WriteFieldBegin("custName");
				oprot.WriteString(structs.GetCustName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpectedSignTime() != null) {
				
				oprot.WriteFieldBegin("expectedSignTime");
				oprot.WriteString(structs.GetExpectedSignTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpectedTrunkTime() != null) {
				
				oprot.WriteFieldBegin("expectedTrunkTime");
				oprot.WriteString(structs.GetExpectedTrunkTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignTime() != null) {
				
				oprot.WriteFieldBegin("signTime");
				oprot.WriteString(structs.GetSignTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrunkTime() != null) {
				
				oprot.WriteFieldBegin("trunkTime");
				oprot.WriteString(structs.GetTrunkTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustType() != null) {
				
				oprot.WriteFieldBegin("custType");
				oprot.WriteI32((int)structs.GetCustType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTimeLiness() != null) {
				
				oprot.WriteFieldBegin("timeLiness");
				oprot.WriteI32((int)structs.GetTimeLiness()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderDeliveryInfo bean){
			
			
		}
		
	}
	
}