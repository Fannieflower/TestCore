using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class ActivityRequestModelHelper : TBeanSerializer<ActivityRequestModel>
	{
		
		public static ActivityRequestModelHelper OBJ = new ActivityRequestModelHelper();
		
		public static ActivityRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActivityRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("actCoreModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.PmsActCoreModel value;
						
						value = new com.vip.pms.data.service.PmsActCoreModel();
						com.vip.pms.data.service.PmsActCoreModelHelper.getInstance().Read(value, iprot);
						
						structs.SetActCoreModel(value);
					}
					
					
					
					
					
					if ("actConditionModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.PmsActConditionModel value;
						
						value = new com.vip.pms.data.service.PmsActConditionModel();
						com.vip.pms.data.service.PmsActConditionModelHelper.getInstance().Read(value, iprot);
						
						structs.SetActConditionModel(value);
					}
					
					
					
					
					
					if ("actSiteList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActSiteModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActSiteModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActSiteModel elem3;
								
								elem3 = new com.vip.pms.data.service.PmsActSiteModel();
								com.vip.pms.data.service.PmsActSiteModelHelper.getInstance().Read(elem3, iprot);
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetActSiteList(value);
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
		
		
		public void Write(ActivityRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetActCoreModel() != null) {
				
				oprot.WriteFieldBegin("actCoreModel");
				
				com.vip.pms.data.service.PmsActCoreModelHelper.getInstance().Write(structs.GetActCoreModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actCoreModel can not be null!");
			}
			
			
			if(structs.GetActConditionModel() != null) {
				
				oprot.WriteFieldBegin("actConditionModel");
				
				com.vip.pms.data.service.PmsActConditionModelHelper.getInstance().Write(structs.GetActConditionModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actConditionModel can not be null!");
			}
			
			
			if(structs.GetActSiteList() != null) {
				
				oprot.WriteFieldBegin("actSiteList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActSiteModel _item0 in structs.GetActSiteList()){
					
					
					com.vip.pms.data.service.PmsActSiteModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actSiteList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActivityRequestModel bean){
			
			
		}
		
	}
	
}