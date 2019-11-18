using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics{
	
	
	
	public class ExtendFieldHelper : TBeanSerializer<ExtendField>
	{
		
		public static ExtendFieldHelper OBJ = new ExtendFieldHelper();
		
		public static ExtendFieldHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ExtendField structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("key".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKey(value);
					}
					
					
					
					
					
					if ("value".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetValue(value);
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
		
		
		public void Write(ExtendField structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetKey() != null) {
				
				oprot.WriteFieldBegin("key");
				oprot.WriteString(structs.GetKey());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetValue() != null) {
				
				oprot.WriteFieldBegin("value");
				oprot.WriteString(structs.GetValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ExtendField bean){
			
			
		}
		
	}
	
}