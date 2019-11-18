using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraStateLogReqParamHelper : TBeanSerializer<XstoreCameraStateLogReqParam>
	{
		
		public static XstoreCameraStateLogReqParamHelper OBJ = new XstoreCameraStateLogReqParamHelper();
		
		public static XstoreCameraStateLogReqParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraStateLogReqParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("storeCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreCode(value);
					}
					
					
					
					
					
					if ("cameraCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraCode(value);
					}
					
					
					
					
					
					if ("startTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStartTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("runState".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.user.face.service.CameraState? value;
						
						value = com.vip.xstore.user.face.service.CameraStateUtil.FindByName(iprot.ReadString());
						
						structs.SetRunState(value);
					}
					
					
					
					
					
					if ("pageInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.user.face.service.common.PageInfo value;
						
						value = new com.vip.xstore.user.face.service.common.PageInfo();
						com.vip.xstore.user.face.service.common.PageInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetPageInfo(value);
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
		
		
		public void Write(XstoreCameraStateLogReqParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStoreCode() != null) {
				
				oprot.WriteFieldBegin("storeCode");
				oprot.WriteString(structs.GetStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCameraCode() != null) {
				
				oprot.WriteFieldBegin("cameraCode");
				oprot.WriteString(structs.GetCameraCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStartTime() != null) {
				
				oprot.WriteFieldBegin("startTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStartTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEndTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRunState() != null) {
				
				oprot.WriteFieldBegin("runState");
				oprot.WriteString(structs.GetRunState().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageInfo() != null) {
				
				oprot.WriteFieldBegin("pageInfo");
				
				com.vip.xstore.user.face.service.common.PageInfoHelper.getInstance().Write(structs.GetPageInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pageInfo can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraStateLogReqParam bean){
			
			
		}
		
	}
	
}