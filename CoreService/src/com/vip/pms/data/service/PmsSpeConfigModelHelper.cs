using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsSpeConfigModelHelper : TBeanSerializer<PmsSpeConfigModel>
	{
		
		public static PmsSpeConfigModelHelper OBJ = new PmsSpeConfigModelHelper();
		
		public static PmsSpeConfigModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsSpeConfigModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("configType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetConfigType(value);
					}
					
					
					
					
					
					if ("configValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfigValue(value);
					}
					
					
					
					
					
					if ("configDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfigDesc(value);
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
		
		
		public void Write(PmsSpeConfigModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetConfigType() != null) {
				
				oprot.WriteFieldBegin("configType");
				oprot.WriteI32((int)structs.GetConfigType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetConfigValue() != null) {
				
				oprot.WriteFieldBegin("configValue");
				oprot.WriteString(structs.GetConfigValue());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("configValue can not be null!");
			}
			
			
			if(structs.GetConfigDesc() != null) {
				
				oprot.WriteFieldBegin("configDesc");
				oprot.WriteString(structs.GetConfigDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsSpeConfigModel bean){
			
			
		}
		
	}
	
}