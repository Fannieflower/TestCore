using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class WorkOrderHelper : TBeanSerializer<WorkOrder>
	{
		
		public static WorkOrderHelper OBJ = new WorkOrderHelper();
		
		public static WorkOrderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WorkOrder structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("work_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWork_order_no(value);
					}
					
					
					
					
					
					if ("process_state".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetProcess_state(value);
					}
					
					
					
					
					
					if ("expire_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetExpire_time(value);
					}
					
					
					
					
					
					if ("problem_desc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProblem_desc(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreate_time(value);
					}
					
					
					
					
					
					if ("action_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAction_type(value);
					}
					
					
					
					
					
					if ("work_order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWork_order_id(value);
					}
					
					
					
					
					
					if ("pc3_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPc3_code(value);
					}
					
					
					
					
					
					if ("pc3_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPc3_name(value);
					}
					
					
					
					
					
					if ("state_appendix_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.logistics.wo.StateAppendixInfo value;
						
						value = new com.vip.vop.logistics.wo.StateAppendixInfo();
						com.vip.vop.logistics.wo.StateAppendixInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetState_appendix_info(value);
					}
					
					
					
					
					
					if ("logistics_nos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetLogistics_nos(value);
					}
					
					
					
					
					
					if ("recheck_results".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.wo.RecheckResult> value;
						
						value = new List<com.vip.vop.logistics.wo.RecheckResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.wo.RecheckResult elem2;
								
								elem2 = new com.vip.vop.logistics.wo.RecheckResult();
								com.vip.vop.logistics.wo.RecheckResultHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRecheck_results(value);
					}
					
					
					
					
					
					if ("attachments".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.wo.Attachment> value;
						
						value = new List<com.vip.vop.logistics.wo.Attachment>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.wo.Attachment elem4;
								
								elem4 = new com.vip.vop.logistics.wo.Attachment();
								com.vip.vop.logistics.wo.AttachmentHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAttachments(value);
					}
					
					
					
					
					
					if ("work_order_tasks".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.wo.WorkOrderTask> value;
						
						value = new List<com.vip.vop.logistics.wo.WorkOrderTask>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.wo.WorkOrderTask elem6;
								
								elem6 = new com.vip.vop.logistics.wo.WorkOrderTask();
								com.vip.vop.logistics.wo.WorkOrderTaskHelper.getInstance().Read(elem6, iprot);
								
								value.Add(elem6);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetWork_order_tasks(value);
					}
					
					
					
					
					
					if ("option_appendix_infos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.wo.OptionAppendixInfo> value;
						
						value = new List<com.vip.vop.logistics.wo.OptionAppendixInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.wo.OptionAppendixInfo elem8;
								
								elem8 = new com.vip.vop.logistics.wo.OptionAppendixInfo();
								com.vip.vop.logistics.wo.OptionAppendixInfoHelper.getInstance().Read(elem8, iprot);
								
								value.Add(elem8);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOption_appendix_infos(value);
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
		
		
		public void Write(WorkOrder structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWork_order_no() != null) {
				
				oprot.WriteFieldBegin("work_order_no");
				oprot.WriteString(structs.GetWork_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProcess_state() != null) {
				
				oprot.WriteFieldBegin("process_state");
				oprot.WriteI32((int)structs.GetProcess_state()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpire_time() != null) {
				
				oprot.WriteFieldBegin("expire_time");
				oprot.WriteI64((long)structs.GetExpire_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProblem_desc() != null) {
				
				oprot.WriteFieldBegin("problem_desc");
				oprot.WriteString(structs.GetProblem_desc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64((long)structs.GetCreate_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAction_type() != null) {
				
				oprot.WriteFieldBegin("action_type");
				oprot.WriteString(structs.GetAction_type());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWork_order_id() != null) {
				
				oprot.WriteFieldBegin("work_order_id");
				oprot.WriteString(structs.GetWork_order_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPc3_code() != null) {
				
				oprot.WriteFieldBegin("pc3_code");
				oprot.WriteString(structs.GetPc3_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPc3_name() != null) {
				
				oprot.WriteFieldBegin("pc3_name");
				oprot.WriteString(structs.GetPc3_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetState_appendix_info() != null) {
				
				oprot.WriteFieldBegin("state_appendix_info");
				
				com.vip.vop.logistics.wo.StateAppendixInfoHelper.getInstance().Write(structs.GetState_appendix_info(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLogistics_nos() != null) {
				
				oprot.WriteFieldBegin("logistics_nos");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetLogistics_nos()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecheck_results() != null) {
				
				oprot.WriteFieldBegin("recheck_results");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.wo.RecheckResult _item0 in structs.GetRecheck_results()){
					
					
					com.vip.vop.logistics.wo.RecheckResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAttachments() != null) {
				
				oprot.WriteFieldBegin("attachments");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.wo.Attachment _item0 in structs.GetAttachments()){
					
					
					com.vip.vop.logistics.wo.AttachmentHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWork_order_tasks() != null) {
				
				oprot.WriteFieldBegin("work_order_tasks");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.wo.WorkOrderTask _item0 in structs.GetWork_order_tasks()){
					
					
					com.vip.vop.logistics.wo.WorkOrderTaskHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOption_appendix_infos() != null) {
				
				oprot.WriteFieldBegin("option_appendix_infos");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.wo.OptionAppendixInfo _item0 in structs.GetOption_appendix_infos()){
					
					
					com.vip.vop.logistics.wo.OptionAppendixInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WorkOrder bean){
			
			
		}
		
	}
	
}