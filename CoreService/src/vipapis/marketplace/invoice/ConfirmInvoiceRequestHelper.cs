using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.invoice{
	
	
	
	public class ConfirmInvoiceRequestHelper : TBeanSerializer<ConfirmInvoiceRequest>
	{
		
		public static ConfirmInvoiceRequestHelper OBJ = new ConfirmInvoiceRequestHelper();
		
		public static ConfirmInvoiceRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmInvoiceRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("invoice_num".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_num(value);
					}
					
					
					
					
					
					if ("invoice_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_code(value);
					}
					
					
					
					
					
					if ("invoice_url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice_url(value);
					}
					
					
					
					
					
					if ("red_punching_invoice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRed_punching_invoice(value);
					}
					
					
					
					
					
					if ("carrier".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier(value);
					}
					
					
					
					
					
					if ("transport_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_no(value);
					}
					
					
					
					
					
					if ("blue_invoice_num".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBlue_invoice_num(value);
					}
					
					
					
					
					
					if ("blue_invoice_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBlue_invoice_code(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
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
		
		
		public void Write(ConfirmInvoiceRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_id can not be null!");
			}
			
			
			if(structs.GetInvoice_type() != null) {
				
				oprot.WriteFieldBegin("invoice_type");
				oprot.WriteString(structs.GetInvoice_type());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("invoice_type can not be null!");
			}
			
			
			if(structs.GetInvoice_title() != null) {
				
				oprot.WriteFieldBegin("invoice_title");
				oprot.WriteString(structs.GetInvoice_title());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("invoice_title can not be null!");
			}
			
			
			if(structs.GetInvoice_num() != null) {
				
				oprot.WriteFieldBegin("invoice_num");
				oprot.WriteString(structs.GetInvoice_num());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_code() != null) {
				
				oprot.WriteFieldBegin("invoice_code");
				oprot.WriteString(structs.GetInvoice_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice_url() != null) {
				
				oprot.WriteFieldBegin("invoice_url");
				oprot.WriteString(structs.GetInvoice_url());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRed_punching_invoice() != null) {
				
				oprot.WriteFieldBegin("red_punching_invoice");
				oprot.WriteString(structs.GetRed_punching_invoice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrier() != null) {
				
				oprot.WriteFieldBegin("carrier");
				oprot.WriteString(structs.GetCarrier());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_no() != null) {
				
				oprot.WriteFieldBegin("transport_no");
				oprot.WriteString(structs.GetTransport_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBlue_invoice_num() != null) {
				
				oprot.WriteFieldBegin("blue_invoice_num");
				oprot.WriteString(structs.GetBlue_invoice_num());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBlue_invoice_code() != null) {
				
				oprot.WriteFieldBegin("blue_invoice_code");
				oprot.WriteString(structs.GetBlue_invoice_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("operator can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmInvoiceRequest bean){
			
			
		}
		
	}
	
}