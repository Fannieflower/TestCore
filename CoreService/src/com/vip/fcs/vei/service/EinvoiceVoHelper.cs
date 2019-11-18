using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class EinvoiceVoHelper : TBeanSerializer<EinvoiceVo>
	{
		
		public static EinvoiceVoHelper OBJ = new EinvoiceVoHelper();
		
		public static EinvoiceVoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(EinvoiceVo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("fpdm".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFpdm(value);
					}
					
					
					
					
					
					if ("fphm".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFphm(value);
					}
					
					
					
					
					
					if ("pdfUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPdfUrl(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("taxRegisterNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxRegisterNo(value);
					}
					
					
					
					
					
					if ("dataType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetDataType(value);
					}
					
					
					
					
					
					if ("originFpdm".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginFpdm(value);
					}
					
					
					
					
					
					if ("originFphm".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginFphm(value);
					}
					
					
					
					
					
					if ("seqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqNo(value);
					}
					
					
					
					
					
					if ("title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTitle(value);
					}
					
					
					
					
					
					if ("buyerTaxRegisterNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerTaxRegisterNo(value);
					}
					
					
					
					
					
					if ("mobileNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobileNumber(value);
					}
					
					
					
					
					
					if ("emailAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEmailAddress(value);
					}
					
					
					
					
					
					if ("invoiceAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceAddress(value);
					}
					
					
					
					
					
					if ("invoiceBank".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceBank(value);
					}
					
					
					
					
					
					if ("invoiceBankAccount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceBankAccount(value);
					}
					
					
					
					
					
					if ("invoicePhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoicePhone(value);
					}
					
					
					
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("invoiceContentType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetInvoiceContentType(value);
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
		
		
		public void Write(EinvoiceVo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetFpdm() != null) {
				
				oprot.WriteFieldBegin("fpdm");
				oprot.WriteString(structs.GetFpdm());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFphm() != null) {
				
				oprot.WriteFieldBegin("fphm");
				oprot.WriteString(structs.GetFphm());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPdfUrl() != null) {
				
				oprot.WriteFieldBegin("pdfUrl");
				oprot.WriteString(structs.GetPdfUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetTaxRegisterNo() != null) {
				
				oprot.WriteFieldBegin("taxRegisterNo");
				oprot.WriteString(structs.GetTaxRegisterNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDataType() != null) {
				
				oprot.WriteFieldBegin("dataType");
				oprot.WriteByte((byte)structs.GetDataType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("dataType can not be null!");
			}
			
			
			if(structs.GetOriginFpdm() != null) {
				
				oprot.WriteFieldBegin("originFpdm");
				oprot.WriteString(structs.GetOriginFpdm());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginFphm() != null) {
				
				oprot.WriteFieldBegin("originFphm");
				oprot.WriteString(structs.GetOriginFphm());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeqNo() != null) {
				
				oprot.WriteFieldBegin("seqNo");
				oprot.WriteString(structs.GetSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTitle() != null) {
				
				oprot.WriteFieldBegin("title");
				oprot.WriteString(structs.GetTitle());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerTaxRegisterNo() != null) {
				
				oprot.WriteFieldBegin("buyerTaxRegisterNo");
				oprot.WriteString(structs.GetBuyerTaxRegisterNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobileNumber() != null) {
				
				oprot.WriteFieldBegin("mobileNumber");
				oprot.WriteString(structs.GetMobileNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEmailAddress() != null) {
				
				oprot.WriteFieldBegin("emailAddress");
				oprot.WriteString(structs.GetEmailAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceAddress() != null) {
				
				oprot.WriteFieldBegin("invoiceAddress");
				oprot.WriteString(structs.GetInvoiceAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceBank() != null) {
				
				oprot.WriteFieldBegin("invoiceBank");
				oprot.WriteString(structs.GetInvoiceBank());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceBankAccount() != null) {
				
				oprot.WriteFieldBegin("invoiceBankAccount");
				oprot.WriteString(structs.GetInvoiceBankAccount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoicePhone() != null) {
				
				oprot.WriteFieldBegin("invoicePhone");
				oprot.WriteString(structs.GetInvoicePhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteString(structs.GetType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceContentType() != null) {
				
				oprot.WriteFieldBegin("invoiceContentType");
				oprot.WriteI32((int)structs.GetInvoiceContentType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(EinvoiceVo bean){
			
			
		}
		
	}
	
}