using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class MpInvoiceIssueResultModelHelper : TBeanSerializer<MpInvoiceIssueResultModel>
	{
		
		public static MpInvoiceIssueResultModelHelper OBJ = new MpInvoiceIssueResultModelHelper();
		
		public static MpInvoiceIssueResultModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(MpInvoiceIssueResultModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("invoiceCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceCode(value);
					}
					
					
					
					
					
					if ("invoiceNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceNo(value);
					}
					
					
					
					
					
					if ("invoiceDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceDate(value);
					}
					
					
					
					
					
					if ("pdfUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPdfUrl(value);
					}
					
					
					
					
					
					if ("taxControlCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxControlCode(value);
					}
					
					
					
					
					
					if ("invoiceCheckCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceCheckCode(value);
					}
					
					
					
					
					
					if ("invoiceQrCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceQrCode(value);
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
		
		
		public void Write(MpInvoiceIssueResultModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetInvoiceCode() != null) {
				
				oprot.WriteFieldBegin("invoiceCode");
				oprot.WriteString(structs.GetInvoiceCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("invoiceCode can not be null!");
			}
			
			
			if(structs.GetInvoiceNo() != null) {
				
				oprot.WriteFieldBegin("invoiceNo");
				oprot.WriteString(structs.GetInvoiceNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("invoiceNo can not be null!");
			}
			
			
			if(structs.GetInvoiceDate() != null) {
				
				oprot.WriteFieldBegin("invoiceDate");
				oprot.WriteString(structs.GetInvoiceDate());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("invoiceDate can not be null!");
			}
			
			
			if(structs.GetPdfUrl() != null) {
				
				oprot.WriteFieldBegin("pdfUrl");
				oprot.WriteString(structs.GetPdfUrl());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pdfUrl can not be null!");
			}
			
			
			if(structs.GetTaxControlCode() != null) {
				
				oprot.WriteFieldBegin("taxControlCode");
				oprot.WriteString(structs.GetTaxControlCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceCheckCode() != null) {
				
				oprot.WriteFieldBegin("invoiceCheckCode");
				oprot.WriteString(structs.GetInvoiceCheckCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceQrCode() != null) {
				
				oprot.WriteFieldBegin("invoiceQrCode");
				oprot.WriteString(structs.GetInvoiceQrCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(MpInvoiceIssueResultModel bean){
			
			
		}
		
	}
	
}