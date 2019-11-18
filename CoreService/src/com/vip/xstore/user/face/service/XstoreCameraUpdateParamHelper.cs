using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraUpdateParamHelper : TBeanSerializer<XstoreCameraUpdateParam>
	{
		
		public static XstoreCameraUpdateParamHelper OBJ = new XstoreCameraUpdateParamHelper();
		
		public static XstoreCameraUpdateParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraUpdateParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("posCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPosCode(value);
					}
					
					
					
					
					
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
					
					
					
					
					
					if ("txRegionCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTxRegionCode(value);
					}
					
					
					
					
					
					if ("txStoreCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTxStoreCode(value);
					}
					
					
					
					
					
					if ("runningState".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRunningState(value);
					}
					
					
					
					
					
					if ("provinceCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvinceCode(value);
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
		
		
		public void Write(XstoreCameraUpdateParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
			}
			
			
			if(structs.GetPosCode() != null) {
				
				oprot.WriteFieldBegin("posCode");
				oprot.WriteString(structs.GetPosCode());
				
				oprot.WriteFieldEnd();
			}
			
			
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
			
			
			if(structs.GetTxRegionCode() != null) {
				
				oprot.WriteFieldBegin("txRegionCode");
				oprot.WriteString(structs.GetTxRegionCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTxStoreCode() != null) {
				
				oprot.WriteFieldBegin("txStoreCode");
				oprot.WriteString(structs.GetTxStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRunningState() != null) {
				
				oprot.WriteFieldBegin("runningState");
				oprot.WriteI32((int)structs.GetRunningState()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvinceCode() != null) {
				
				oprot.WriteFieldBegin("provinceCode");
				oprot.WriteString(structs.GetProvinceCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraUpdateParam bean){
			
			
		}
		
	}
	
}