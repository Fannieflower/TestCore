using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class RegisteredCarrierModelModelHelper : TBeanSerializer<RegisteredCarrierModelModel>
	{
		
		public static RegisteredCarrierModelModelHelper OBJ = new RegisteredCarrierModelModelHelper();
		
		public static RegisteredCarrierModelModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RegisteredCarrierModelModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("custName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustName(value);
					}
					
					
					
					
					
					if ("custCnname".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCnname(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("contact".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContact(value);
					}
					
					
					
					
					
					if ("tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTel(value);
					}
					
					
					
					
					
					if ("url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUrl(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("active".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetActive(value);
					}
					
					
					
					
					
					if ("custType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCustType(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("custNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCustNo(value);
					}
					
					
					
					
					
					if ("isPjGroup".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPjGroup(value);
					}
					
					
					
					
					
					if ("eiqGroup".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEiqGroup(value);
					}
					
					
					
					
					
					if ("custStandardName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustStandardName(value);
					}
					
					
					
					
					
					if ("custUncode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustUncode(value);
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
		
		
		public void Write(RegisteredCarrierModelModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustName() != null) {
				
				oprot.WriteFieldBegin("custName");
				oprot.WriteString(structs.GetCustName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCnname() != null) {
				
				oprot.WriteFieldBegin("custCnname");
				oprot.WriteString(structs.GetCustCnname());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				oprot.WriteString(structs.GetAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContact() != null) {
				
				oprot.WriteFieldBegin("contact");
				oprot.WriteString(structs.GetContact());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTel() != null) {
				
				oprot.WriteFieldBegin("tel");
				oprot.WriteString(structs.GetTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUrl() != null) {
				
				oprot.WriteFieldBegin("url");
				oprot.WriteString(structs.GetUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActive() != null) {
				
				oprot.WriteFieldBegin("active");
				oprot.WriteI32((int)structs.GetActive()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustType() != null) {
				
				oprot.WriteFieldBegin("custType");
				oprot.WriteI32((int)structs.GetCustType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteString(structs.GetBusinessType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustNo() != null) {
				
				oprot.WriteFieldBegin("custNo");
				oprot.WriteI64((long)structs.GetCustNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPjGroup() != null) {
				
				oprot.WriteFieldBegin("isPjGroup");
				oprot.WriteI32((int)structs.GetIsPjGroup()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEiqGroup() != null) {
				
				oprot.WriteFieldBegin("eiqGroup");
				oprot.WriteString(structs.GetEiqGroup());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustStandardName() != null) {
				
				oprot.WriteFieldBegin("custStandardName");
				oprot.WriteString(structs.GetCustStandardName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustUncode() != null) {
				
				oprot.WriteFieldBegin("custUncode");
				oprot.WriteString(structs.GetCustUncode());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RegisteredCarrierModelModel bean){
			
			
		}
		
	}
	
}