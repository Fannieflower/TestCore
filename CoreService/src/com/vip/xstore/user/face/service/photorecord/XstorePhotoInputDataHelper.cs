using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service.photorecord{
	
	
	
	public class XstorePhotoInputDataHelper : TBeanSerializer<XstorePhotoInputData>
	{
		
		public static XstorePhotoInputDataHelper OBJ = new XstorePhotoInputDataHelper();
		
		public static XstorePhotoInputDataHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstorePhotoInputData structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("photoName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPhotoName(value);
					}
					
					
					
					
					
					if ("photoBase64Data".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPhotoBase64Data(value);
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
		
		
		public void Write(XstorePhotoInputData structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPhotoName() != null) {
				
				oprot.WriteFieldBegin("photoName");
				oprot.WriteString(structs.GetPhotoName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("photoName can not be null!");
			}
			
			
			if(structs.GetPhotoBase64Data() != null) {
				
				oprot.WriteFieldBegin("photoBase64Data");
				oprot.WriteString(structs.GetPhotoBase64Data());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("photoBase64Data can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstorePhotoInputData bean){
			
			
		}
		
	}
	
}