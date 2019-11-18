using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class ActivityUserLogRequestModelHelper : TBeanSerializer<ActivityUserLogRequestModel>
	{
		
		public static ActivityUserLogRequestModelHelper OBJ = new ActivityUserLogRequestModelHelper();
		
		public static ActivityUserLogRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActivityUserLogRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("baseRequestModels".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.UserLogRequestModel> value;
						
						value = new List<com.vip.pms.data.service.UserLogRequestModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.UserLogRequestModel elem0;
								
								elem0 = new com.vip.pms.data.service.UserLogRequestModel();
								com.vip.pms.data.service.UserLogRequestModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBaseRequestModels(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
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
		
		
		public void Write(ActivityUserLogRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBaseRequestModels() != null) {
				
				oprot.WriteFieldBegin("baseRequestModels");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.UserLogRequestModel _item0 in structs.GetBaseRequestModels()){
					
					
					com.vip.pms.data.service.UserLogRequestModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("baseRequestModels can not be null!");
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActivityUserLogRequestModel bean){
			
			
		}
		
	}
	
}