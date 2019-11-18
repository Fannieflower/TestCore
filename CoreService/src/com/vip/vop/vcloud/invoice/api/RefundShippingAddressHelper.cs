using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	public class RefundShippingAddressHelper : TBeanSerializer<RefundShippingAddress>
	{
		
		public static RefundShippingAddressHelper OBJ = new RefundShippingAddressHelper();
		
		public static RefundShippingAddressHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefundShippingAddress structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("refundId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetRefundId(value);
					}
					
					
					
					
					
					if ("customerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCustomerId(value);
					}
					
					
					
					
					
					if ("firstname".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFirstname(value);
					}
					
					
					
					
					
					if ("lastname".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLastname(value);
					}
					
					
					
					
					
					if ("telephone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTelephone(value);
					}
					
					
					
					
					
					if ("email".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEmail(value);
					}
					
					
					
					
					
					if ("region".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRegion(value);
					}
					
					
					
					
					
					if ("city".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity(value);
					}
					
					
					
					
					
					if ("district".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDistrict(value);
					}
					
					
					
					
					
					if ("street".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStreet(value);
					}
					
					
					
					
					
					if ("postcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPostcode(value);
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
		
		
		public void Write(RefundShippingAddress structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRefundId() != null) {
				
				oprot.WriteFieldBegin("refundId");
				oprot.WriteI64((long)structs.GetRefundId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerId() != null) {
				
				oprot.WriteFieldBegin("customerId");
				oprot.WriteI64((long)structs.GetCustomerId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFirstname() != null) {
				
				oprot.WriteFieldBegin("firstname");
				oprot.WriteString(structs.GetFirstname());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLastname() != null) {
				
				oprot.WriteFieldBegin("lastname");
				oprot.WriteString(structs.GetLastname());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTelephone() != null) {
				
				oprot.WriteFieldBegin("telephone");
				oprot.WriteString(structs.GetTelephone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEmail() != null) {
				
				oprot.WriteFieldBegin("email");
				oprot.WriteString(structs.GetEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRegion() != null) {
				
				oprot.WriteFieldBegin("region");
				oprot.WriteString(structs.GetRegion());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCity() != null) {
				
				oprot.WriteFieldBegin("city");
				oprot.WriteString(structs.GetCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistrict() != null) {
				
				oprot.WriteFieldBegin("district");
				oprot.WriteString(structs.GetDistrict());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStreet() != null) {
				
				oprot.WriteFieldBegin("street");
				oprot.WriteString(structs.GetStreet());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPostcode() != null) {
				
				oprot.WriteFieldBegin("postcode");
				oprot.WriteString(structs.GetPostcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefundShippingAddress bean){
			
			
		}
		
	}
	
}