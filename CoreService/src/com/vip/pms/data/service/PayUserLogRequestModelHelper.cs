using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PayUserLogRequestModelHelper : TBeanSerializer<PayUserLogRequestModel>
	{
		
		public static PayUserLogRequestModelHelper OBJ = new PayUserLogRequestModelHelper();
		
		public static PayUserLogRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PayUserLogRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("logModels".Equals(schemeField.Trim())){
						
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
						
						structs.SetLogModels(value);
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
		
		
		public void Write(PayUserLogRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLogModels() != null) {
				
				oprot.WriteFieldBegin("logModels");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.UserLogRequestModel _item0 in structs.GetLogModels()){
					
					
					com.vip.pms.data.service.UserLogRequestModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("logModels can not be null!");
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PayUserLogRequestModel bean){
			
			
		}
		
	}
	
}