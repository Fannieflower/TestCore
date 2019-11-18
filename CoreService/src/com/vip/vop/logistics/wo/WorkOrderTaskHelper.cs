using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class WorkOrderTaskHelper : TBeanSerializer<WorkOrderTask>
	{
		
		public static WorkOrderTaskHelper OBJ = new WorkOrderTaskHelper();
		
		public static WorkOrderTaskHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WorkOrderTask structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("task_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTask_id(value);
					}
					
					
					
					
					
					if ("task_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTask_type(value);
					}
					
					
					
					
					
					if ("task_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTask_name(value);
					}
					
					
					
					
					
					if ("process_content".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProcess_content(value);
					}
					
					
					
					
					
					if ("task_state_desc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTask_state_desc(value);
					}
					
					
					
					
					
					if ("expire_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetExpire_time(value);
					}
					
					
					
					
					
					if ("ext_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExt_info(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreate_time(value);
					}
					
					
					
					
					
					if ("work_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWork_order_no(value);
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
		
		
		public void Write(WorkOrderTask structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTask_id() != null) {
				
				oprot.WriteFieldBegin("task_id");
				oprot.WriteI32((int)structs.GetTask_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTask_type() != null) {
				
				oprot.WriteFieldBegin("task_type");
				oprot.WriteI32((int)structs.GetTask_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTask_name() != null) {
				
				oprot.WriteFieldBegin("task_name");
				oprot.WriteString(structs.GetTask_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcess_content() != null) {
				
				oprot.WriteFieldBegin("process_content");
				oprot.WriteString(structs.GetProcess_content());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTask_state_desc() != null) {
				
				oprot.WriteFieldBegin("task_state_desc");
				oprot.WriteString(structs.GetTask_state_desc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpire_time() != null) {
				
				oprot.WriteFieldBegin("expire_time");
				oprot.WriteI64((long)structs.GetExpire_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExt_info() != null) {
				
				oprot.WriteFieldBegin("ext_info");
				oprot.WriteString(structs.GetExt_info());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64((long)structs.GetCreate_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWork_order_no() != null) {
				
				oprot.WriteFieldBegin("work_order_no");
				oprot.WriteString(structs.GetWork_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WorkOrderTask bean){
			
			
		}
		
	}
	
}