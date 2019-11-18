using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.common.process.template{
	
	
	
	public class CreateProcessTemplateReqHelper : TBeanSerializer<CreateProcessTemplateReq>
	{
		
		public static CreateProcessTemplateReqHelper OBJ = new CreateProcessTemplateReqHelper();
		
		public static CreateProcessTemplateReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateProcessTemplateReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("opUserId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpUserId(value);
					}
					
					
					
					
					
					if ("opUserName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpUserName(value);
					}
					
					
					
					
					
					if ("app".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApp(value);
					}
					
					
					
					
					
					if ("bizType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBizType(value);
					}
					
					
					
					
					
					if ("templateName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTemplateName(value);
					}
					
					
					
					
					
					if ("templateVersion".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetTemplateVersion(value);
					}
					
					
					
					
					
					if ("templateContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTemplateContent(value);
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
		
		
		public void Write(CreateProcessTemplateReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOpUserId() != null) {
				
				oprot.WriteFieldBegin("opUserId");
				oprot.WriteString(structs.GetOpUserId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOpUserName() != null) {
				
				oprot.WriteFieldBegin("opUserName");
				oprot.WriteString(structs.GetOpUserName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApp() != null) {
				
				oprot.WriteFieldBegin("app");
				oprot.WriteString(structs.GetApp());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBizType() != null) {
				
				oprot.WriteFieldBegin("bizType");
				oprot.WriteString(structs.GetBizType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTemplateName() != null) {
				
				oprot.WriteFieldBegin("templateName");
				oprot.WriteString(structs.GetTemplateName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTemplateVersion() != null) {
				
				oprot.WriteFieldBegin("templateVersion");
				oprot.WriteI16((short)structs.GetTemplateVersion()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTemplateContent() != null) {
				
				oprot.WriteFieldBegin("templateContent");
				oprot.WriteString(structs.GetTemplateContent());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateProcessTemplateReq bean){
			
			
		}
		
	}
	
}