using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class SpecialRequestModelHelper : TBeanSerializer<SpecialRequestModel>
	{
		
		public static SpecialRequestModelHelper OBJ = new SpecialRequestModelHelper();
		
		public static SpecialRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SpecialRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("specialCoreModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.PmsSpecialCoreModel value;
						
						value = new com.vip.pms.data.service.PmsSpecialCoreModel();
						com.vip.pms.data.service.PmsSpecialCoreModelHelper.getInstance().Read(value, iprot);
						
						structs.SetSpecialCoreModel(value);
					}
					
					
					
					
					
					if ("speConditionModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.pms.data.service.PmsSpeConditionModel value;
						
						value = new com.vip.pms.data.service.PmsSpeConditionModel();
						com.vip.pms.data.service.PmsSpeConditionModelHelper.getInstance().Read(value, iprot);
						
						structs.SetSpeConditionModel(value);
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
		
		
		public void Write(SpecialRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSpecialCoreModel() != null) {
				
				oprot.WriteFieldBegin("specialCoreModel");
				
				com.vip.pms.data.service.PmsSpecialCoreModelHelper.getInstance().Write(structs.GetSpecialCoreModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("specialCoreModel can not be null!");
			}
			
			
			if(structs.GetSpeConditionModel() != null) {
				
				oprot.WriteFieldBegin("speConditionModel");
				
				com.vip.pms.data.service.PmsSpeConditionModelHelper.getInstance().Write(structs.GetSpeConditionModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SpecialRequestModel bean){
			
			
		}
		
	}
	
}