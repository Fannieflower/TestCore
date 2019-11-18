using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class CreateWorkflowHelper : TBeanSerializer<CreateWorkflow>
	{
		
		public static CreateWorkflowHelper OBJ = new CreateWorkflowHelper();
		
		public static CreateWorkflowHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateWorkflow structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("request_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRequest_id(value);
					}
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("new_delivery_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNew_delivery_warehouse(value);
					}
					
					
					
					
					
					if ("reason_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReason_code(value);
					}
					
					
					
					
					
					if ("reason_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReason_remark(value);
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
		
		
		public void Write(CreateWorkflow structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRequest_id() != null) {
				
				oprot.WriteFieldBegin("request_id");
				oprot.WriteString(structs.GetRequest_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("request_id can not be null!");
			}
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetNew_delivery_warehouse() != null) {
				
				oprot.WriteFieldBegin("new_delivery_warehouse");
				oprot.WriteString(structs.GetNew_delivery_warehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("new_delivery_warehouse can not be null!");
			}
			
			
			if(structs.GetReason_code() != null) {
				
				oprot.WriteFieldBegin("reason_code");
				oprot.WriteString(structs.GetReason_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("reason_code can not be null!");
			}
			
			
			if(structs.GetReason_remark() != null) {
				
				oprot.WriteFieldBegin("reason_remark");
				oprot.WriteString(structs.GetReason_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateWorkflow bean){
			
			
		}
		
	}
	
}