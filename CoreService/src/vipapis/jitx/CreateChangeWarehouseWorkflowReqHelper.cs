using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class CreateChangeWarehouseWorkflowReqHelper : TBeanSerializer<CreateChangeWarehouseWorkflowReq>
	{
		
		public static CreateChangeWarehouseWorkflowReqHelper OBJ = new CreateChangeWarehouseWorkflowReqHelper();
		
		public static CreateChangeWarehouseWorkflowReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateChangeWarehouseWorkflowReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
					}
					
					
					
					
					
					if ("workflows".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.CreateWorkflow> value;
						
						value = new List<vipapis.jitx.CreateWorkflow>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.CreateWorkflow elem0;
								
								elem0 = new vipapis.jitx.CreateWorkflow();
								vipapis.jitx.CreateWorkflowHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetWorkflows(value);
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
		
		
		public void Write(CreateChangeWarehouseWorkflowReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendor_id can not be null!");
			}
			
			
			if(structs.GetWorkflows() != null) {
				
				oprot.WriteFieldBegin("workflows");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.CreateWorkflow _item0 in structs.GetWorkflows()){
					
					
					vipapis.jitx.CreateWorkflowHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("workflows can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateChangeWarehouseWorkflowReq bean){
			
			
		}
		
	}
	
}