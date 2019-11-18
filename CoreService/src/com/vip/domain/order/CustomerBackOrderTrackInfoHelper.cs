using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.domain.order{
	
	
	
	public class CustomerBackOrderTrackInfoHelper : TBeanSerializer<CustomerBackOrderTrackInfo>
	{
		
		public static CustomerBackOrderTrackInfoHelper OBJ = new CustomerBackOrderTrackInfoHelper();
		
		public static CustomerBackOrderTrackInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CustomerBackOrderTrackInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("erp_back_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErp_back_sn(value);
					}
					
					
					
					
					
					if ("transport_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_code(value);
					}
					
					
					
					
					
					if ("transport_detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_detail(value);
					}
					
					
					
					
					
					if ("ab_reason".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAb_reason(value);
					}
					
					
					
					
					
					if ("ab_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAb_remark(value);
					}
					
					
					
					
					
					if ("action_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAction_time(value);
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
		
		
		public void Write(CustomerBackOrderTrackInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetErp_back_sn() != null) {
				
				oprot.WriteFieldBegin("erp_back_sn");
				oprot.WriteString(structs.GetErp_back_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_code() != null) {
				
				oprot.WriteFieldBegin("transport_code");
				oprot.WriteString(structs.GetTransport_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_detail() != null) {
				
				oprot.WriteFieldBegin("transport_detail");
				oprot.WriteString(structs.GetTransport_detail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAb_reason() != null) {
				
				oprot.WriteFieldBegin("ab_reason");
				oprot.WriteString(structs.GetAb_reason());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAb_remark() != null) {
				
				oprot.WriteFieldBegin("ab_remark");
				oprot.WriteString(structs.GetAb_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAction_time() != null) {
				
				oprot.WriteFieldBegin("action_time");
				oprot.WriteString(structs.GetAction_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CustomerBackOrderTrackInfo bean){
			
			
		}
		
	}
	
}