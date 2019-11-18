using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraStateLogModelHelper : TBeanSerializer<XstoreCameraStateLogModel>
	{
		
		public static XstoreCameraStateLogModelHelper OBJ = new XstoreCameraStateLogModelHelper();
		
		public static XstoreCameraStateLogModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraStateLogModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("cameraCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraCode(value);
					}
					
					
					
					
					
					if ("cameraStateCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraStateCode(value);
					}
					
					
					
					
					
					if ("cameraPing".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraPing(value);
					}
					
					
					
					
					
					if ("cameraStateMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraStateMsg(value);
					}
					
					
					
					
					
					if ("cameraFormat".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraFormat(value);
					}
					
					
					
					
					
					if ("cameraFps".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraFps(value);
					}
					
					
					
					
					
					if ("cameraResolution".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraResolution(value);
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
		
		
		public void Write(XstoreCameraStateLogModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCameraCode() != null) {
				
				oprot.WriteFieldBegin("cameraCode");
				oprot.WriteString(structs.GetCameraCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraStateCode() != null) {
				
				oprot.WriteFieldBegin("cameraStateCode");
				oprot.WriteString(structs.GetCameraStateCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraPing() != null) {
				
				oprot.WriteFieldBegin("cameraPing");
				oprot.WriteString(structs.GetCameraPing());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraStateMsg() != null) {
				
				oprot.WriteFieldBegin("cameraStateMsg");
				oprot.WriteString(structs.GetCameraStateMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraFormat() != null) {
				
				oprot.WriteFieldBegin("cameraFormat");
				oprot.WriteString(structs.GetCameraFormat());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraFps() != null) {
				
				oprot.WriteFieldBegin("cameraFps");
				oprot.WriteString(structs.GetCameraFps());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraResolution() != null) {
				
				oprot.WriteFieldBegin("cameraResolution");
				oprot.WriteString(structs.GetCameraResolution());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraStateLogModel bean){
			
			
		}
		
	}
	
}