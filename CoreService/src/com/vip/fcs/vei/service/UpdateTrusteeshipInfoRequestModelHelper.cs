using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class UpdateTrusteeshipInfoRequestModelHelper : TBeanSerializer<UpdateTrusteeshipInfoRequestModel>
	{
		
		public static UpdateTrusteeshipInfoRequestModelHelper OBJ = new UpdateTrusteeshipInfoRequestModelHelper();
		
		public static UpdateTrusteeshipInfoRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdateTrusteeshipInfoRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("storeSource".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetStoreSource(value);
					}
					
					
					
					
					
					if ("storeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreId(value);
					}
					
					
					
					
					
					if ("taxRegisterNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxRegisterNo(value);
					}
					
					
					
					
					
					if ("trusteeshipStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetTrusteeshipStatus(value);
					}
					
					
					
					
					
					if ("signTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSignTime(value);
					}
					
					
					
					
					
					if ("trusteeshipStartTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetTrusteeshipStartTime(value);
					}
					
					
					
					
					
					if ("trusteeshipEndTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetTrusteeshipEndTime(value);
					}
					
					
					
					
					
					if ("trusteeshipPlatform".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrusteeshipPlatform(value);
					}
					
					
					
					
					
					if ("trusteeshipType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetTrusteeshipType(value);
					}
					
					
					
					
					
					if ("singleInvoiceAmountLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSingleInvoiceAmountLimit(value);
					}
					
					
					
					
					
					if ("invoiceType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceType(value);
					}
					
					
					
					
					
					if ("sellerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSellerName(value);
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
		
		
		public void Write(UpdateTrusteeshipInfoRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetStoreSource() != null) {
				
				oprot.WriteFieldBegin("storeSource");
				oprot.WriteByte((byte)structs.GetStoreSource()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeSource can not be null!");
			}
			
			
			if(structs.GetStoreId() != null) {
				
				oprot.WriteFieldBegin("storeId");
				oprot.WriteString(structs.GetStoreId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeId can not be null!");
			}
			
			
			if(structs.GetTaxRegisterNo() != null) {
				
				oprot.WriteFieldBegin("taxRegisterNo");
				oprot.WriteString(structs.GetTaxRegisterNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("taxRegisterNo can not be null!");
			}
			
			
			if(structs.GetTrusteeshipStatus() != null) {
				
				oprot.WriteFieldBegin("trusteeshipStatus");
				oprot.WriteByte((byte)structs.GetTrusteeshipStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignTime() != null) {
				
				oprot.WriteFieldBegin("signTime");
				oprot.WriteI64((long)structs.GetSignTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrusteeshipStartTime() != null) {
				
				oprot.WriteFieldBegin("trusteeshipStartTime");
				oprot.WriteI64((long)structs.GetTrusteeshipStartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrusteeshipEndTime() != null) {
				
				oprot.WriteFieldBegin("trusteeshipEndTime");
				oprot.WriteI64((long)structs.GetTrusteeshipEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrusteeshipPlatform() != null) {
				
				oprot.WriteFieldBegin("trusteeshipPlatform");
				oprot.WriteString(structs.GetTrusteeshipPlatform());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trusteeshipPlatform can not be null!");
			}
			
			
			if(structs.GetTrusteeshipType() != null) {
				
				oprot.WriteFieldBegin("trusteeshipType");
				oprot.WriteByte((byte)structs.GetTrusteeshipType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSingleInvoiceAmountLimit() != null) {
				
				oprot.WriteFieldBegin("singleInvoiceAmountLimit");
				oprot.WriteString(structs.GetSingleInvoiceAmountLimit());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceType() != null) {
				
				oprot.WriteFieldBegin("invoiceType");
				oprot.WriteString(structs.GetInvoiceType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSellerName() != null) {
				
				oprot.WriteFieldBegin("sellerName");
				oprot.WriteString(structs.GetSellerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UpdateTrusteeshipInfoRequestModel bean){
			
			
		}
		
	}
	
}