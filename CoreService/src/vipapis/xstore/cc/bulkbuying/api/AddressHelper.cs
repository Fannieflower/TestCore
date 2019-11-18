using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
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
					
					
					if ("contacter".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContacter(value);
					}
					
					
					
					
					
					if ("contacter_tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContacter_tel(value);
					}
					
					
					
					
					
					if ("contacter_mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContacter_mobile(value);
					}
					
					
					
					
					
					if ("country".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCountry(value);
					}
					
					
					
					
					
					if ("province_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvince_name(value);
					}
					
					
					
					
					
					if ("city_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity_name(value);
					}
					
					
					
					
					
					if ("district_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDistrict_name(value);
					}
					
					
					
					
					
					if ("detail_address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDetail_address(value);
					}
					
					
					
					
					
					if ("email".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEmail(value);
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
			
			if(structs.GetContacter() != null) {
				
				oprot.WriteFieldBegin("contacter");
				oprot.WriteString(structs.GetContacter());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContacter_tel() != null) {
				
				oprot.WriteFieldBegin("contacter_tel");
				oprot.WriteString(structs.GetContacter_tel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContacter_mobile() != null) {
				
				oprot.WriteFieldBegin("contacter_mobile");
				oprot.WriteString(structs.GetContacter_mobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCountry() != null) {
				
				oprot.WriteFieldBegin("country");
				oprot.WriteString(structs.GetCountry());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvince_name() != null) {
				
				oprot.WriteFieldBegin("province_name");
				oprot.WriteString(structs.GetProvince_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCity_name() != null) {
				
				oprot.WriteFieldBegin("city_name");
				oprot.WriteString(structs.GetCity_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistrict_name() != null) {
				
				oprot.WriteFieldBegin("district_name");
				oprot.WriteString(structs.GetDistrict_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetail_address() != null) {
				
				oprot.WriteFieldBegin("detail_address");
				oprot.WriteString(structs.GetDetail_address());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEmail() != null) {
				
				oprot.WriteFieldBegin("email");
				oprot.WriteString(structs.GetEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Address bean){
			
			
		}
		
	}
	
}