using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraInfoModelHelper : TBeanSerializer<XstoreCameraInfoModel>
	{
		
		public static XstoreCameraInfoModelHelper OBJ = new XstoreCameraInfoModelHelper();
		
		public static XstoreCameraInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraInfoModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("deleteFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDeleteFlag(value);
					}
					
					
					
					
					
					if ("storeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreName(value);
					}
					
					
					
					
					
					if ("provinceCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvinceCode(value);
					}
					
					
					
					
					
					if ("provinceName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvinceName(value);
					}
					
					
					
					
					
					if ("cityName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCityName(value);
					}
					
					
					
					
					
					if ("districtCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDistrictCode(value);
					}
					
					
					
					
					
					if ("district".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDistrict(value);
					}
					
					
					
					
					
					if ("contact".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContact(value);
					}
					
					
					
					
					
					if ("contactTel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContactTel(value);
					}
					
					
					
					
					
					if ("contactMobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContactMobile(value);
					}
					
					
					
					
					
					if ("zipCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetZipCode(value);
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
		
		
		public void Write(XstoreCameraInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPosCode() != null) {
				
				oprot.WriteFieldBegin("posCode");
				oprot.WriteString(structs.GetPosCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("posCode can not be null!");
			}
			
			
			if(structs.GetCameraCode() != null) {
				
				oprot.WriteFieldBegin("cameraCode");
				oprot.WriteString(structs.GetCameraCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cameraCode can not be null!");
			}
			
			
			if(structs.GetStoreCode() != null) {
				
				oprot.WriteFieldBegin("storeCode");
				oprot.WriteString(structs.GetStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeCode can not be null!");
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
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteI64((long)structs.GetUpdateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeleteFlag() != null) {
				
				oprot.WriteFieldBegin("deleteFlag");
				oprot.WriteI32((int)structs.GetDeleteFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreName() != null) {
				
				oprot.WriteFieldBegin("storeName");
				oprot.WriteString(structs.GetStoreName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvinceCode() != null) {
				
				oprot.WriteFieldBegin("provinceCode");
				oprot.WriteString(structs.GetProvinceCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvinceName() != null) {
				
				oprot.WriteFieldBegin("provinceName");
				oprot.WriteString(structs.GetProvinceName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCityName() != null) {
				
				oprot.WriteFieldBegin("cityName");
				oprot.WriteString(structs.GetCityName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistrictCode() != null) {
				
				oprot.WriteFieldBegin("districtCode");
				oprot.WriteString(structs.GetDistrictCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistrict() != null) {
				
				oprot.WriteFieldBegin("district");
				oprot.WriteString(structs.GetDistrict());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContact() != null) {
				
				oprot.WriteFieldBegin("contact");
				oprot.WriteString(structs.GetContact());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContactTel() != null) {
				
				oprot.WriteFieldBegin("contactTel");
				oprot.WriteString(structs.GetContactTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContactMobile() != null) {
				
				oprot.WriteFieldBegin("contactMobile");
				oprot.WriteString(structs.GetContactMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetZipCode() != null) {
				
				oprot.WriteFieldBegin("zipCode");
				oprot.WriteString(structs.GetZipCode());
				
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
			
			else{
				throw new ArgumentException("txStoreCode can not be null!");
			}
			
			
			if(structs.GetRunningState() != null) {
				
				oprot.WriteFieldBegin("runningState");
				oprot.WriteI32((int)structs.GetRunningState()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraInfoModel bean){
			
			
		}
		
	}
	
}