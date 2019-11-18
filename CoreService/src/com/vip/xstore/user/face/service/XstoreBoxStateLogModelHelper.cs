using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreBoxStateLogModelHelper : TBeanSerializer<XstoreBoxStateLogModel>
	{
		
		public static XstoreBoxStateLogModelHelper OBJ = new XstoreBoxStateLogModelHelper();
		
		public static XstoreBoxStateLogModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreBoxStateLogModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("boxMacAddr".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBoxMacAddr(value);
					}
					
					
					
					
					
					if ("boxTemperature".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBoxTemperature(value);
					}
					
					
					
					
					
					if ("boxPing".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBoxPing(value);
					}
					
					
					
					
					
					if ("boxSoftwareVersion".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBoxSoftwareVersion(value);
					}
					
					
					
					
					
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
					
					
					
					
					
					if ("stateLogTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStateLogTime(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("deleteFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDeleteFlag(value);
					}
					
					
					
					
					
					if ("storeCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreCode(value);
					}
					
					
					
					
					
					if ("posCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPosCode(value);
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
		
		
		public void Write(XstoreBoxStateLogModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBoxMacAddr() != null) {
				
				oprot.WriteFieldBegin("boxMacAddr");
				oprot.WriteString(structs.GetBoxMacAddr());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBoxTemperature() != null) {
				
				oprot.WriteFieldBegin("boxTemperature");
				oprot.WriteString(structs.GetBoxTemperature());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBoxPing() != null) {
				
				oprot.WriteFieldBegin("boxPing");
				oprot.WriteString(structs.GetBoxPing());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBoxSoftwareVersion() != null) {
				
				oprot.WriteFieldBegin("boxSoftwareVersion");
				oprot.WriteString(structs.GetBoxSoftwareVersion());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraCode() != null) {
				
				oprot.WriteFieldBegin("cameraCode");
				oprot.WriteString(structs.GetCameraCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cameraCode can not be null!");
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
			
			
			if(structs.GetStateLogTime() != null) {
				
				oprot.WriteFieldBegin("stateLogTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStateLogTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetUpdateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeleteFlag() != null) {
				
				oprot.WriteFieldBegin("deleteFlag");
				oprot.WriteI32((int)structs.GetDeleteFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreCode() != null) {
				
				oprot.WriteFieldBegin("storeCode");
				oprot.WriteString(structs.GetStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPosCode() != null) {
				
				oprot.WriteFieldBegin("posCode");
				oprot.WriteString(structs.GetPosCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreBoxStateLogModel bean){
			
			
		}
		
	}
	
}