using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service.photorecord{
	
	
	
	public class XstorePhotoRecordRequestHelper : TBeanSerializer<XstorePhotoRecordRequest>
	{
		
		public static XstorePhotoRecordRequestHelper OBJ = new XstorePhotoRecordRequestHelper();
		
		public static XstorePhotoRecordRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstorePhotoRecordRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("seqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqNo(value);
					}
					
					
					
					
					
					if ("cameraCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraCode(value);
					}
					
					
					
					
					
					if ("originPhoto".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData value;
						
						value = new com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData();
						com.vip.xstore.user.face.service.photorecord.XstorePhotoInputDataHelper.getInstance().Read(value, iprot);
						
						structs.SetOriginPhoto(value);
					}
					
					
					
					
					
					if ("cutPhotos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData> value;
						
						value = new List<com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData elem1;
								
								elem1 = new com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData();
								com.vip.xstore.user.face.service.photorecord.XstorePhotoInputDataHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCutPhotos(value);
					}
					
					
					
					
					
					if ("cutPhotoTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetCutPhotoTime(value);
					}
					
					
					
					
					
					if ("originPhotoTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetOriginPhotoTime(value);
					}
					
					
					
					
					
					if ("sendTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetSendTime(value);
					}
					
					
					
					
					
					if ("resendFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetResendFlag(value);
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
		
		
		public void Write(XstorePhotoRecordRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSeqNo() != null) {
				
				oprot.WriteFieldBegin("seqNo");
				oprot.WriteString(structs.GetSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seqNo can not be null!");
			}
			
			
			if(structs.GetCameraCode() != null) {
				
				oprot.WriteFieldBegin("cameraCode");
				oprot.WriteString(structs.GetCameraCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cameraCode can not be null!");
			}
			
			
			if(structs.GetOriginPhoto() != null) {
				
				oprot.WriteFieldBegin("originPhoto");
				
				com.vip.xstore.user.face.service.photorecord.XstorePhotoInputDataHelper.getInstance().Write(structs.GetOriginPhoto(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("originPhoto can not be null!");
			}
			
			
			if(structs.GetCutPhotos() != null) {
				
				oprot.WriteFieldBegin("cutPhotos");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.user.face.service.photorecord.XstorePhotoInputData _item0 in structs.GetCutPhotos()){
					
					
					com.vip.xstore.user.face.service.photorecord.XstorePhotoInputDataHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cutPhotos can not be null!");
			}
			
			
			if(structs.GetCutPhotoTime() != null) {
				
				oprot.WriteFieldBegin("cutPhotoTime");
				oprot.WriteI64((long)structs.GetCutPhotoTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cutPhotoTime can not be null!");
			}
			
			
			if(structs.GetOriginPhotoTime() != null) {
				
				oprot.WriteFieldBegin("originPhotoTime");
				oprot.WriteI64((long)structs.GetOriginPhotoTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("originPhotoTime can not be null!");
			}
			
			
			if(structs.GetSendTime() != null) {
				
				oprot.WriteFieldBegin("sendTime");
				oprot.WriteI64((long)structs.GetSendTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sendTime can not be null!");
			}
			
			
			if(structs.GetResendFlag() != null) {
				
				oprot.WriteFieldBegin("resendFlag");
				oprot.WriteI32((int)structs.GetResendFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("resendFlag can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstorePhotoRecordRequest bean){
			
			
		}
		
	}
	
}