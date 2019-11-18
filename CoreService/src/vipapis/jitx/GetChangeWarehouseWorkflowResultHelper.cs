using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class GetChangeWarehouseWorkflowResultHelper : TBeanSerializer<GetChangeWarehouseWorkflowResult>
	{
		
		public static GetChangeWarehouseWorkflowResultHelper OBJ = new GetChangeWarehouseWorkflowResultHelper();
		
		public static GetChangeWarehouseWorkflowResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetChangeWarehouseWorkflowResult structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
					}
					
					
					
					
					
					if ("workflow_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWorkflow_sn(value);
					}
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("workflow_state".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWorkflow_state(value);
					}
					
					
					
					
					
					if ("old_delivery_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOld_delivery_warehouse(value);
					}
					
					
					
					
					
					if ("new_delivery_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNew_delivery_warehouse(value);
					}
					
					
					
					
					
					if ("update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdate_time(value);
					}
					
					
					
					
					
					if ("reject_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReject_remark(value);
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
		
		
		public void Write(GetChangeWarehouseWorkflowResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRequest_id() != null) {
				
				oprot.WriteFieldBegin("request_id");
				oprot.WriteString(structs.GetRequest_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendor_id can not be null!");
			}
			
			
			if(structs.GetWorkflow_sn() != null) {
				
				oprot.WriteFieldBegin("workflow_sn");
				oprot.WriteString(structs.GetWorkflow_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWorkflow_state() != null) {
				
				oprot.WriteFieldBegin("workflow_state");
				oprot.WriteString(structs.GetWorkflow_state());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOld_delivery_warehouse() != null) {
				
				oprot.WriteFieldBegin("old_delivery_warehouse");
				oprot.WriteString(structs.GetOld_delivery_warehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNew_delivery_warehouse() != null) {
				
				oprot.WriteFieldBegin("new_delivery_warehouse");
				oprot.WriteString(structs.GetNew_delivery_warehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate_time() != null) {
				
				oprot.WriteFieldBegin("update_time");
				oprot.WriteI64((long)structs.GetUpdate_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReject_remark() != null) {
				
				oprot.WriteFieldBegin("reject_remark");
				oprot.WriteString(structs.GetReject_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetChangeWarehouseWorkflowResult bean){
			
			
		}
		
	}
	
}