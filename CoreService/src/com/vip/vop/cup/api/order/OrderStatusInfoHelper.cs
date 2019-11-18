using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.order{
	
	
	
	public class OrderStatusInfoHelper : TBeanSerializer<OrderStatusInfo>
	{
		
		public static OrderStatusInfoHelper OBJ = new OrderStatusInfoHelper();
		
		public static OrderStatusInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderStatusInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("user_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser_code(value);
					}
					
					
					
					
					
					if ("scenario_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScenario_code(value);
					}
					
					
					
					
					
					if ("order_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrder_status(value);
					}
					
					
					
					
					
					if ("biz_update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBiz_update_time(value);
					}
					
					
					
					
					
					if ("update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdate_time(value);
					}
					
					
					
					
					
					if ("extra_data".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtra_data(value);
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
		
		
		public void Write(OrderStatusInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUser_code() != null) {
				
				oprot.WriteFieldBegin("user_code");
				oprot.WriteString(structs.GetUser_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScenario_code() != null) {
				
				oprot.WriteFieldBegin("scenario_code");
				oprot.WriteString(structs.GetScenario_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_status() != null) {
				
				oprot.WriteFieldBegin("order_status");
				oprot.WriteI32((int)structs.GetOrder_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBiz_update_time() != null) {
				
				oprot.WriteFieldBegin("biz_update_time");
				oprot.WriteString(structs.GetBiz_update_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate_time() != null) {
				
				oprot.WriteFieldBegin("update_time");
				oprot.WriteString(structs.GetUpdate_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtra_data() != null) {
				
				oprot.WriteFieldBegin("extra_data");
				oprot.WriteString(structs.GetExtra_data());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderStatusInfo bean){
			
			
		}
		
	}
	
}