using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsSpeConditionModelHelper : TBeanSerializer<PmsSpeConditionModel>
	{
		
		public static PmsSpeConditionModelHelper OBJ = new PmsSpeConditionModelHelper();
		
		public static PmsSpeConditionModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsSpeConditionModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("customerTagList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsSpeConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsSpeConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsSpeConfigModel elem0;
								
								elem0 = new com.vip.pms.data.service.PmsSpeConfigModel();
								com.vip.pms.data.service.PmsSpeConfigModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCustomerTagList(value);
					}
					
					
					
					
					
					if ("customerSrcList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsSpeConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsSpeConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsSpeConfigModel elem2;
								
								elem2 = new com.vip.pms.data.service.PmsSpeConfigModel();
								com.vip.pms.data.service.PmsSpeConfigModelHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCustomerSrcList(value);
					}
					
					
					
					
					
					if ("customerPageConfigList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsCustomerPageConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsCustomerPageConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsCustomerPageConfigModel elem4;
								
								elem4 = new com.vip.pms.data.service.PmsCustomerPageConfigModel();
								com.vip.pms.data.service.PmsCustomerPageConfigModelHelper.getInstance().Read(elem4, iprot);
								
								value.Add(elem4);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCustomerPageConfigList(value);
					}
					
					
					
					
					
					if ("audienceConfigList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.PmsActAudienceConfigModel> value;
						
						value = new List<com.vip.pms.data.service.PmsActAudienceConfigModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.PmsActAudienceConfigModel elem6;
								
								elem6 = new com.vip.pms.data.service.PmsActAudienceConfigModel();
								com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Read(elem6, iprot);
								
								value.Add(elem6);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAudienceConfigList(value);
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
		
		
		public void Write(PmsSpeConditionModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCustomerTagList() != null) {
				
				oprot.WriteFieldBegin("customerTagList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsSpeConfigModel _item0 in structs.GetCustomerTagList()){
					
					
					com.vip.pms.data.service.PmsSpeConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerSrcList() != null) {
				
				oprot.WriteFieldBegin("customerSrcList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsSpeConfigModel _item0 in structs.GetCustomerSrcList()){
					
					
					com.vip.pms.data.service.PmsSpeConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerPageConfigList() != null) {
				
				oprot.WriteFieldBegin("customerPageConfigList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsCustomerPageConfigModel _item0 in structs.GetCustomerPageConfigList()){
					
					
					com.vip.pms.data.service.PmsCustomerPageConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAudienceConfigList() != null) {
				
				oprot.WriteFieldBegin("audienceConfigList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.PmsActAudienceConfigModel _item0 in structs.GetAudienceConfigList()){
					
					
					com.vip.pms.data.service.PmsActAudienceConfigModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsSpeConditionModel bean){
			
			
		}
		
	}
	
}