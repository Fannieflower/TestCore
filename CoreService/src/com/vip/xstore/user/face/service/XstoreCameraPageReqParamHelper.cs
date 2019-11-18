using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraPageReqParamHelper : TBeanSerializer<XstoreCameraPageReqParam>
	{
		
		public static XstoreCameraPageReqParamHelper OBJ = new XstoreCameraPageReqParamHelper();
		
		public static XstoreCameraPageReqParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraPageReqParam structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("storeCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreCode(value);
					}
					
					
					
					
					
					if ("pageInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.user.face.service.common.PageInfo value;
						
						value = new com.vip.xstore.user.face.service.common.PageInfo();
						com.vip.xstore.user.face.service.common.PageInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetPageInfo(value);
					}
					
					
					
					
					
					if ("posCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPosCode(value);
					}
					
					
					
					
					
					if ("dzStoreCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDzStoreCode(value);
					}
					
					
					
					
					
					if ("regionCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRegionCode(value);
					}
					
					
					
					
					
					if ("cityCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCityCode(value);
					}
					
					
					
					
					
					if ("provinceCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvinceCode(value);
					}
					
					
					
					
					
					if ("deleteFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDeleteFlag(value);
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
		
		
		public void Write(XstoreCameraPageReqParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCameraCode() != null) {
				
				oprot.WriteFieldBegin("cameraCode");
				oprot.WriteString(structs.GetCameraCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreCode() != null) {
				
				oprot.WriteFieldBegin("storeCode");
				oprot.WriteString(structs.GetStoreCode());
				
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
			
			
			if(structs.GetPosCode() != null) {
				
				oprot.WriteFieldBegin("posCode");
				oprot.WriteString(structs.GetPosCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDzStoreCode() != null) {
				
				oprot.WriteFieldBegin("dzStoreCode");
				oprot.WriteString(structs.GetDzStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRegionCode() != null) {
				
				oprot.WriteFieldBegin("regionCode");
				oprot.WriteString(structs.GetRegionCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCityCode() != null) {
				
				oprot.WriteFieldBegin("cityCode");
				oprot.WriteString(structs.GetCityCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvinceCode() != null) {
				
				oprot.WriteFieldBegin("provinceCode");
				oprot.WriteString(structs.GetProvinceCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeleteFlag() != null) {
				
				oprot.WriteFieldBegin("deleteFlag");
				oprot.WriteI32((int)structs.GetDeleteFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraPageReqParam bean){
			
			
		}
		
	}
	
}