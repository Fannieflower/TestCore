using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class CreateWorkflowRespHelper : TBeanSerializer<CreateWorkflowResp>
	{
		
		public static CreateWorkflowRespHelper OBJ = new CreateWorkflowRespHelper();
		
		public static CreateWorkflowRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateWorkflowResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("results".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.CreateChangeWarehouseResult> value;
						
						value = new List<vipapis.jitx.CreateChangeWarehouseResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.CreateChangeWarehouseResult elem0;
								
								elem0 = new vipapis.jitx.CreateChangeWarehouseResult();
								vipapis.jitx.CreateChangeWarehouseResultHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetResults(value);
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
		
		
		public void Write(CreateWorkflowResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total can not be null!");
			}
			
			
			if(structs.GetResults() != null) {
				
				oprot.WriteFieldBegin("results");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.CreateChangeWarehouseResult _item0 in structs.GetResults()){
					
					
					vipapis.jitx.CreateChangeWarehouseResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("results can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateWorkflowResp bean){
			
			
		}
		
	}
	
}