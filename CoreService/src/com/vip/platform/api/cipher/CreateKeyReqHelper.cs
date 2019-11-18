using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.platform.api.cipher{
	
	
	
	public class CreateKeyReqHelper : TBeanSerializer<CreateKeyReq>
	{
		
		public static CreateKeyReqHelper OBJ = new CreateKeyReqHelper();
		
		public static CreateKeyReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateKeyReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("keyCategory".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKeyCategory(value);
					}
					
					
					
					
					
					if ("keyName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKeyName(value);
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
		
		
		public void Write(CreateKeyReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetKeyCategory() != null) {
				
				oprot.WriteFieldBegin("keyCategory");
				oprot.WriteString(structs.GetKeyCategory());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("keyCategory can not be null!");
			}
			
			
			if(structs.GetKeyName() != null) {
				
				oprot.WriteFieldBegin("keyName");
				oprot.WriteString(structs.GetKeyName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateKeyReq bean){
			
			
		}
		
	}
	
}