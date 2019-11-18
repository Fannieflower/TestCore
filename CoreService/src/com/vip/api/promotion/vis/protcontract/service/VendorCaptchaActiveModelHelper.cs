using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class VendorCaptchaActiveModelHelper : TBeanSerializer<VendorCaptchaActiveModel>
	{
		
		public static VendorCaptchaActiveModelHelper OBJ = new VendorCaptchaActiveModelHelper();
		
		public static VendorCaptchaActiveModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VendorCaptchaActiveModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("captchaActive".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetCaptchaActive(value);
					}
					
					
					
					
					
					if ("vendorContactEmail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorContactEmail(value);
					}
					
					
					
					
					
					if ("vendorContactMobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorContactMobile(value);
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
		
		
		public void Write(VendorCaptchaActiveModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCaptchaActive() != null) {
				
				oprot.WriteFieldBegin("captchaActive");
				oprot.WriteBool((bool)structs.GetCaptchaActive());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("captchaActive can not be null!");
			}
			
			
			if(structs.GetVendorContactEmail() != null) {
				
				oprot.WriteFieldBegin("vendorContactEmail");
				oprot.WriteString(structs.GetVendorContactEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorContactMobile() != null) {
				
				oprot.WriteFieldBegin("vendorContactMobile");
				oprot.WriteString(structs.GetVendorContactMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VendorCaptchaActiveModel bean){
			
			
		}
		
	}
	
}