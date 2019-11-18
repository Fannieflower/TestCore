using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.asc{
	
	
	
	public class ApproveAscRequestHelper : TBeanSerializer<ApproveAscRequest>
	{
		
		public static ApproveAscRequestHelper OBJ = new ApproveAscRequestHelper();
		
		public static ApproveAscRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ApproveAscRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("asc_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAsc_sn(value);
					}
					
					
					
					
					
					if ("asc_product_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAsc_product_id(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("contact_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContact_name(value);
					}
					
					
					
					
					
					if ("contact_mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContact_mobile(value);
					}
					
					
					
					
					
					if ("zipcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetZipcode(value);
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
		
		
		public void Write(ApproveAscRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAsc_sn() != null) {
				
				oprot.WriteFieldBegin("asc_sn");
				oprot.WriteString(structs.GetAsc_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("asc_sn can not be null!");
			}
			
			
			if(structs.GetAsc_product_id() != null) {
				
				oprot.WriteFieldBegin("asc_product_id");
				oprot.WriteString(structs.GetAsc_product_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("asc_product_id can not be null!");
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				oprot.WriteString(structs.GetAddress());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("address can not be null!");
			}
			
			
			if(structs.GetContact_name() != null) {
				
				oprot.WriteFieldBegin("contact_name");
				oprot.WriteString(structs.GetContact_name());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("contact_name can not be null!");
			}
			
			
			if(structs.GetContact_mobile() != null) {
				
				oprot.WriteFieldBegin("contact_mobile");
				oprot.WriteString(structs.GetContact_mobile());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("contact_mobile can not be null!");
			}
			
			
			if(structs.GetZipcode() != null) {
				
				oprot.WriteFieldBegin("zipcode");
				oprot.WriteString(structs.GetZipcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ApproveAscRequest bean){
			
			
		}
		
	}
	
}