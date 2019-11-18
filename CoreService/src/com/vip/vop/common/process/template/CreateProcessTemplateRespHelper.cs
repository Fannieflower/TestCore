using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.common.process.template{
	
	
	
	public class CreateProcessTemplateRespHelper : TBeanSerializer<CreateProcessTemplateResp>
	{
		
		public static CreateProcessTemplateRespHelper OBJ = new CreateProcessTemplateRespHelper();
		
		public static CreateProcessTemplateRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateProcessTemplateResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("resultCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetResultCode(value);
					}
					
					
					
					
					
					if ("message".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMessage(value);
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
		
		
		public void Write(CreateProcessTemplateResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResultCode() != null) {
				
				oprot.WriteFieldBegin("resultCode");
				oprot.WriteI32((int)structs.GetResultCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("resultCode can not be null!");
			}
			
			
			if(structs.GetMessage() != null) {
				
				oprot.WriteFieldBegin("message");
				oprot.WriteString(structs.GetMessage());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateProcessTemplateResp bean){
			
			
		}
		
	}
	
}