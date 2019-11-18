using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class CreateChangeWarehouseResultHelper : TBeanSerializer<CreateChangeWarehouseResult>
	{
		
		public static CreateChangeWarehouseResultHelper OBJ = new CreateChangeWarehouseResultHelper();
		
		public static CreateChangeWarehouseResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateChangeWarehouseResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("result".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResult(value);
					}
					
					
					
					
					
					if ("workflow_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWorkflow_sn(value);
					}
					
					
					
					
					
					if ("request_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRequest_id(value);
					}
					
					
					
					
					
					if ("error_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetError_code(value);
					}
					
					
					
					
					
					if ("error_msg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetError_msg(value);
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
		
		
		public void Write(CreateChangeWarehouseResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResult() != null) {
				
				oprot.WriteFieldBegin("result");
				oprot.WriteString(structs.GetResult());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWorkflow_sn() != null) {
				
				oprot.WriteFieldBegin("workflow_sn");
				oprot.WriteString(structs.GetWorkflow_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRequest_id() != null) {
				
				oprot.WriteFieldBegin("request_id");
				oprot.WriteString(structs.GetRequest_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetError_code() != null) {
				
				oprot.WriteFieldBegin("error_code");
				oprot.WriteString(structs.GetError_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetError_msg() != null) {
				
				oprot.WriteFieldBegin("error_msg");
				oprot.WriteString(structs.GetError_msg());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateChangeWarehouseResult bean){
			
			
		}
		
	}
	
}