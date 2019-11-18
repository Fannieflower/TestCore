using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.order{
	
	
	
	public class UpdateOrderStatusReqHelper : TBeanSerializer<UpdateOrderStatusReq>
	{
		
		public static UpdateOrderStatusReqHelper OBJ = new UpdateOrderStatusReqHelper();
		
		public static UpdateOrderStatusReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdateOrderStatusReq structs, Protocol iprot){
			
			
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
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOrder_status(value);
					}
					
					
					
					
					
					if ("extra_data".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtra_data(value);
					}
					
					
					
					
					
					if ("update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdate_time(value);
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
		
		
		public void Write(UpdateOrderStatusReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetUser_code() != null) {
				
				oprot.WriteFieldBegin("user_code");
				oprot.WriteString(structs.GetUser_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("user_code can not be null!");
			}
			
			
			if(structs.GetScenario_code() != null) {
				
				oprot.WriteFieldBegin("scenario_code");
				oprot.WriteString(structs.GetScenario_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("scenario_code can not be null!");
			}
			
			
			if(structs.GetOrder_status() != null) {
				
				oprot.WriteFieldBegin("order_status");
				oprot.WriteI32((int)structs.GetOrder_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_status can not be null!");
			}
			
			
			if(structs.GetExtra_data() != null) {
				
				oprot.WriteFieldBegin("extra_data");
				oprot.WriteString(structs.GetExtra_data());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate_time() != null) {
				
				oprot.WriteFieldBegin("update_time");
				oprot.WriteString(structs.GetUpdate_time());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("update_time can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UpdateOrderStatusReq bean){
			
			
		}
		
	}
	
}