using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraStateLogParamHelper : TBeanSerializer<XstoreCameraStateLogParam>
	{
		
		public static XstoreCameraStateLogParamHelper OBJ = new XstoreCameraStateLogParamHelper();
		
		public static XstoreCameraStateLogParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraStateLogParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
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
					
					
					
					
					
					if ("cameraStateLogs".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.user.face.service.XstoreCameraStateLogModel> value;
						
						value = new List<com.vip.xstore.user.face.service.XstoreCameraStateLogModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.user.face.service.XstoreCameraStateLogModel elem0;
								
								elem0 = new com.vip.xstore.user.face.service.XstoreCameraStateLogModel();
								com.vip.xstore.user.face.service.XstoreCameraStateLogModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCameraStateLogs(value);
					}
					
					
					
					
					
					if ("stateLogTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStateLogTime(value);
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
		
		
		public void Write(XstoreCameraStateLogParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
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
			
			
			if(structs.GetCameraStateLogs() != null) {
				
				oprot.WriteFieldBegin("cameraStateLogs");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.user.face.service.XstoreCameraStateLogModel _item0 in structs.GetCameraStateLogs()){
					
					
					com.vip.xstore.user.face.service.XstoreCameraStateLogModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStateLogTime() != null) {
				
				oprot.WriteFieldBegin("stateLogTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStateLogTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraStateLogParam bean){
			
			
		}
		
	}
	
}