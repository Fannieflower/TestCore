using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class GetChangeWarehouseWorkflowRespHelper : TBeanSerializer<GetChangeWarehouseWorkflowResp>
	{
		
		public static GetChangeWarehouseWorkflowRespHelper OBJ = new GetChangeWarehouseWorkflowRespHelper();
		
		public static GetChangeWarehouseWorkflowRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetChangeWarehouseWorkflowResp structs, Protocol iprot){
			
			
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
						List<vipapis.jitx.GetChangeWarehouseWorkflowResult> value;
						
						value = new List<vipapis.jitx.GetChangeWarehouseWorkflowResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.GetChangeWarehouseWorkflowResult elem0;
								
								elem0 = new vipapis.jitx.GetChangeWarehouseWorkflowResult();
								vipapis.jitx.GetChangeWarehouseWorkflowResultHelper.getInstance().Read(elem0, iprot);
								
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
		
		
		public void Write(GetChangeWarehouseWorkflowResp structs, Protocol oprot){
			
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
				foreach(vipapis.jitx.GetChangeWarehouseWorkflowResult _item0 in structs.GetResults()){
					
					
					vipapis.jitx.GetChangeWarehouseWorkflowResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetChangeWarehouseWorkflowResp bean){
			
			
		}
		
	}
	
}