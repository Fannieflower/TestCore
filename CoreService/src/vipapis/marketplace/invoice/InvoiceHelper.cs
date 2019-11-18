using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.invoice{
	
	
	
	public class InvoiceHelper : TBeanSerializer<Invoice>
	{
		
		public static InvoiceHelper OBJ = new InvoiceHelper();
		
		public static InvoiceHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Invoice structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_id(value);
					}
					
					
					
					
					
					if ("order_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_status(value);
					}
					
					
					
					
					
					if ("order_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_time(value);
					}
					
					
					
					
					
					if ("invoice_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_status(value);
					}
					
					
					
					
					
					if ("invoice_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_type(value);
					}
					
					
					
					
					
					if ("invoice_title".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_title(value);
					}
					
					
					
					
					
					if ("tax_payer_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTax_payer_no(value);
					}
					
					
					
					
					
					if ("ex_pay_money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEx_pay_money(value);
					}
					
					
					
					
					
					if ("transport_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_no(value);
					}
					
					
					
					
					
					if ("invoice_url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_url(value);
					}
					
					
					
					
					
					if ("invoice_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_code(value);
					}
					
					
					
					
					
					if ("invoice_num".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_num(value);
					}
					
					
					
					
					
					if ("carrier".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier(value);
					}
					
					
					
					
					
					if ("red_punching_invoice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRed_punching_invoice(value);
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
		
		
		public void Write(Invoice structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_status() != null) {
				
				oprot.WriteFieldBegin("order_status");
				oprot.WriteString(structs.GetOrder_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_time() != null) {
				
				oprot.WriteFieldBegin("order_time");
				oprot.WriteString(structs.GetOrder_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_status() != null) {
				
				oprot.WriteFieldBegin("invoice_status");
				oprot.WriteString(structs.GetInvoice_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_type() != null) {
				
				oprot.WriteFieldBegin("invoice_type");
				oprot.WriteString(structs.GetInvoice_type());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_title() != null) {
				
				oprot.WriteFieldBegin("invoice_title");
				oprot.WriteString(structs.GetInvoice_title());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTax_payer_no() != null) {
				
				oprot.WriteFieldBegin("tax_payer_no");
				oprot.WriteString(structs.GetTax_payer_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEx_pay_money() != null) {
				
				oprot.WriteFieldBegin("ex_pay_money");
				oprot.WriteString(structs.GetEx_pay_money());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_no() != null) {
				
				oprot.WriteFieldBegin("transport_no");
				oprot.WriteString(structs.GetTransport_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_url() != null) {
				
				oprot.WriteFieldBegin("invoice_url");
				oprot.WriteString(structs.GetInvoice_url());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_code() != null) {
				
				oprot.WriteFieldBegin("invoice_code");
				oprot.WriteString(structs.GetInvoice_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_num() != null) {
				
				oprot.WriteFieldBegin("invoice_num");
				oprot.WriteString(structs.GetInvoice_num());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrier() != null) {
				
				oprot.WriteFieldBegin("carrier");
				oprot.WriteString(structs.GetCarrier());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRed_punching_invoice() != null) {
				
				oprot.WriteFieldBegin("red_punching_invoice");
				oprot.WriteString(structs.GetRed_punching_invoice());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Invoice bean){
			
			
		}
		
	}
	
}