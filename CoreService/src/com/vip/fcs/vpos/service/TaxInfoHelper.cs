using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vpos.service{
	
	
	
	public class TaxInfoHelper : TBeanSerializer<TaxInfo>
	{
		
		public static TaxInfoHelper OBJ = new TaxInfoHelper();
		
		public static TaxInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TaxInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("platformCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPlatformCode(value);
					}
					
					
					
					
					
					if ("message".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMessage(value);
					}
					
					
					
					
					
					if ("notifyType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNotifyType(value);
					}
					
					
					
					
					
					if ("notifyTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNotifyTime(value);
					}
					
					
					
					
					
					if ("orderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderId(value);
					}
					
					
					
					
					
					if ("ticketSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTicketSn(value);
					}
					
					
					
					
					
					if ("ticketCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTicketCode(value);
					}
					
					
					
					
					
					if ("ticketDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTicketDate(value);
					}
					
					
					
					
					
					if ("ticketStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTicketStatus(value);
					}
					
					
					
					
					
					if ("amountHasTax".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAmountHasTax(value);
					}
					
					
					
					
					
					if ("amountNoTax".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAmountNoTax(value);
					}
					
					
					
					
					
					if ("ticketTaxAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTicketTaxAmount(value);
					}
					
					
					
					
					
					if ("checkCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCheckCode(value);
					}
					
					
					
					
					
					if ("pdfUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPdfUrl(value);
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
		
		
		public void Write(TaxInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPlatformCode() != null) {
				
				oprot.WriteFieldBegin("platformCode");
				oprot.WriteString(structs.GetPlatformCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMessage() != null) {
				
				oprot.WriteFieldBegin("message");
				oprot.WriteString(structs.GetMessage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("message can not be null!");
			}
			
			
			if(structs.GetNotifyType() != null) {
				
				oprot.WriteFieldBegin("notifyType");
				oprot.WriteString(structs.GetNotifyType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("notifyType can not be null!");
			}
			
			
			if(structs.GetNotifyTime() != null) {
				
				oprot.WriteFieldBegin("notifyTime");
				oprot.WriteString(structs.GetNotifyTime());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("notifyTime can not be null!");
			}
			
			
			if(structs.GetOrderId() != null) {
				
				oprot.WriteFieldBegin("orderId");
				oprot.WriteString(structs.GetOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderId can not be null!");
			}
			
			
			if(structs.GetTicketSn() != null) {
				
				oprot.WriteFieldBegin("ticketSn");
				oprot.WriteString(structs.GetTicketSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTicketCode() != null) {
				
				oprot.WriteFieldBegin("ticketCode");
				oprot.WriteString(structs.GetTicketCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTicketDate() != null) {
				
				oprot.WriteFieldBegin("ticketDate");
				oprot.WriteString(structs.GetTicketDate());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ticketDate can not be null!");
			}
			
			
			if(structs.GetTicketStatus() != null) {
				
				oprot.WriteFieldBegin("ticketStatus");
				oprot.WriteI32((int)structs.GetTicketStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ticketStatus can not be null!");
			}
			
			
			if(structs.GetAmountHasTax() != null) {
				
				oprot.WriteFieldBegin("amountHasTax");
				oprot.WriteString(structs.GetAmountHasTax());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAmountNoTax() != null) {
				
				oprot.WriteFieldBegin("amountNoTax");
				oprot.WriteString(structs.GetAmountNoTax());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTicketTaxAmount() != null) {
				
				oprot.WriteFieldBegin("ticketTaxAmount");
				oprot.WriteString(structs.GetTicketTaxAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCheckCode() != null) {
				
				oprot.WriteFieldBegin("checkCode");
				oprot.WriteString(structs.GetCheckCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPdfUrl() != null) {
				
				oprot.WriteFieldBegin("pdfUrl");
				oprot.WriteString(structs.GetPdfUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TaxInfo bean){
			
			
		}
		
	}
	
}