using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PayRequestModelHelper : TBeanSerializer<PayRequestModel>
	{
		
		public static PayRequestModelHelper OBJ = new PayRequestModelHelper();
		
		public static PayRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PayRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("payCoreModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.PmsPayCoreModel value;
						
						value = new com.vip.pms.data.service.PmsPayCoreModel();
						com.vip.pms.data.service.PmsPayCoreModelHelper.getInstance().Read(value, iprot);
						
						structs.SetPayCoreModel(value);
					}
					
					
					
					
					
					if ("priorityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPriorityLevel(value);
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
		
		
		public void Write(PayRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPayCoreModel() != null) {
				
				oprot.WriteFieldBegin("payCoreModel");
				
				com.vip.pms.data.service.PmsPayCoreModelHelper.getInstance().Write(structs.GetPayCoreModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payCoreModel can not be null!");
			}
			
			
			if(structs.GetPriorityLevel() != null) {
				
				oprot.WriteFieldBegin("priorityLevel");
				oprot.WriteI32((int)structs.GetPriorityLevel()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("priorityLevel can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PayRequestModel bean){
			
			
		}
		
	}
	
}