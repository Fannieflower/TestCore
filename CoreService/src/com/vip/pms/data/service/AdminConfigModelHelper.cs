using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class AdminConfigModelHelper : TBeanSerializer<AdminConfigModel>
	{
		
		public static AdminConfigModelHelper OBJ = new AdminConfigModelHelper();
		
		public static AdminConfigModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AdminConfigModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("configType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfigType(value);
					}
					
					
					
					
					
					if ("configKey".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfigKey(value);
					}
					
					
					
					
					
					if ("configValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetConfigValue(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTime(value);
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
		
		
		public void Write(AdminConfigModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI32((int)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetConfigType() != null) {
				
				oprot.WriteFieldBegin("configType");
				oprot.WriteString(structs.GetConfigType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("configType can not be null!");
			}
			
			
			if(structs.GetConfigKey() != null) {
				
				oprot.WriteFieldBegin("configKey");
				oprot.WriteString(structs.GetConfigKey());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("configKey can not be null!");
			}
			
			
			if(structs.GetConfigValue() != null) {
				
				oprot.WriteFieldBegin("configValue");
				oprot.WriteString(structs.GetConfigValue());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("configValue can not be null!");
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64((long)structs.GetUpdateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AdminConfigModel bean){
			
			
		}
		
	}
	
}