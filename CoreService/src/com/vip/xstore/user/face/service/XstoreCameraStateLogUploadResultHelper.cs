using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraStateLogUploadResultHelper : TBeanSerializer<XstoreCameraStateLogUploadResult>
	{
		
		public static XstoreCameraStateLogUploadResultHelper OBJ = new XstoreCameraStateLogUploadResultHelper();
		
		public static XstoreCameraStateLogUploadResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraStateLogUploadResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("returnCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetReturnCode(value);
					}
					
					
					
					
					
					if ("returnMessage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnMessage(value);
					}
					
					
					
					
					
					if ("successCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSuccessCount(value);
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
		
		
		public void Write(XstoreCameraStateLogUploadResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReturnCode() != null) {
				
				oprot.WriteFieldBegin("returnCode");
				oprot.WriteI32((int)structs.GetReturnCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnMessage() != null) {
				
				oprot.WriteFieldBegin("returnMessage");
				oprot.WriteString(structs.GetReturnMessage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuccessCount() != null) {
				
				oprot.WriteFieldBegin("successCount");
				oprot.WriteI32((int)structs.GetSuccessCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraStateLogUploadResult bean){
			
			
		}
		
	}
	
}