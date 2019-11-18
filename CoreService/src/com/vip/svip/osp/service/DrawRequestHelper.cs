using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class DrawRequestHelper : TBeanSerializer<DrawRequest>
	{
		
		public static DrawRequestHelper OBJ = new DrawRequestHelper();
		
		public static DrawRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(DrawRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("bizCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizCode(value);
					}
					
					
					
					
					
					if ("encryptPhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEncryptPhone(value);
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
		
		
		public void Write(DrawRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBizCode() != null) {
				
				oprot.WriteFieldBegin("bizCode");
				oprot.WriteString(structs.GetBizCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEncryptPhone() != null) {
				
				oprot.WriteFieldBegin("encryptPhone");
				oprot.WriteString(structs.GetEncryptPhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(DrawRequest bean){
			
			
		}
		
	}
	
}