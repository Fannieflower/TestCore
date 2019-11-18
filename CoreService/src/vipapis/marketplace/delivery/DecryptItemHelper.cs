using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.delivery{
	
	
	
	public class DecryptItemHelper : TBeanSerializer<DecryptItem>
	{
		
		public static DecryptItemHelper OBJ = new DecryptItemHelper();
		
		public static DecryptItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(DecryptItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("encrypt_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEncrypt_code(value);
					}
					
					
					
					
					
					if ("decrypt_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDecrypt_code(value);
					}
					
					
					
					
					
					if ("state".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetState(value);
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
		
		
		public void Write(DecryptItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetEncrypt_code() != null) {
				
				oprot.WriteFieldBegin("encrypt_code");
				oprot.WriteString(structs.GetEncrypt_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("encrypt_code can not be null!");
			}
			
			
			if(structs.GetDecrypt_code() != null) {
				
				oprot.WriteFieldBegin("decrypt_code");
				oprot.WriteString(structs.GetDecrypt_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetState() != null) {
				
				oprot.WriteFieldBegin("state");
				oprot.WriteI32((int)structs.GetState()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("state can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(DecryptItem bean){
			
			
		}
		
	}
	
}