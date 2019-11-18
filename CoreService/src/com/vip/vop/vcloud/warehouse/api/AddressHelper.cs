using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.warehouse.api{
	
	
	
	public class AddressHelper : TBeanSerializer<Address>
	{
		
		public static AddressHelper OBJ = new AddressHelper();
		
		public static AddressHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Address structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
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
					
					
					
					
					
					if ("cityCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCityCode(value);
					}
					
					
					
					
					
					if ("cityName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCityName(value);
					}
					
					
					
					
					
					if ("regionCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRegionCode(value);
					}
					
					
					
					
					
					if ("regionName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRegionName(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress(value);
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
		
		
		public void Write(Address structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
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
			
			
			if(structs.GetCityCode() != null) {
				
				oprot.WriteFieldBegin("cityCode");
				oprot.WriteString(structs.GetCityCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCityName() != null) {
				
				oprot.WriteFieldBegin("cityName");
				oprot.WriteString(structs.GetCityName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRegionCode() != null) {
				
				oprot.WriteFieldBegin("regionCode");
				oprot.WriteString(structs.GetRegionCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRegionName() != null) {
				
				oprot.WriteFieldBegin("regionName");
				oprot.WriteString(structs.GetRegionName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				oprot.WriteString(structs.GetAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Address bean){
			
			
		}
		
	}
	
}