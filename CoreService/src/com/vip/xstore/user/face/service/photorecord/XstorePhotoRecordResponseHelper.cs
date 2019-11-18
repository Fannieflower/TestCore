using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service.photorecord{
	
	
	
	public class XstorePhotoRecordResponseHelper : TBeanSerializer<XstorePhotoRecordResponse>
	{
		
		public static XstorePhotoRecordResponseHelper OBJ = new XstorePhotoRecordResponseHelper();
		
		public static XstorePhotoRecordResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstorePhotoRecordResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("isSuccess".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsSuccess(value);
					}
					
					
					
					
					
					if ("errorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorCode(value);
					}
					
					
					
					
					
					if ("errorDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorDesc(value);
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
		
		
		public void Write(XstorePhotoRecordResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetIsSuccess() != null) {
				
				oprot.WriteFieldBegin("isSuccess");
				oprot.WriteBool((bool)structs.GetIsSuccess());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isSuccess can not be null!");
			}
			
			
			if(structs.GetErrorCode() != null) {
				
				oprot.WriteFieldBegin("errorCode");
				oprot.WriteString(structs.GetErrorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrorDesc() != null) {
				
				oprot.WriteFieldBegin("errorDesc");
				oprot.WriteString(structs.GetErrorDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstorePhotoRecordResponse bean){
			
			
		}
		
	}
	
}