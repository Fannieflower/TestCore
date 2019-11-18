using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class ExternalInvoiceHandleStateHelper : TBeanSerializer<ExternalInvoiceHandleState>
	{
		
		public static ExternalInvoiceHandleStateHelper OBJ = new ExternalInvoiceHandleStateHelper();
		
		public static ExternalInvoiceHandleStateHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ExternalInvoiceHandleState structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("state".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetState(value);
					}
					
					
					
					
					
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
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("retMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.vei.service.BaseRetMsg value;
						
						value = new com.vip.fcs.vei.service.BaseRetMsg();
						com.vip.fcs.vei.service.BaseRetMsgHelper.getInstance().Read(value, iprot);
						
						structs.SetRetMsg(value);
					}
					
					
					
					
					
					if ("storeSource".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreSource(value);
					}
					
					
					
					
					
					if ("storeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreId(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("orderReturnNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderReturnNo(value);
					}
					
					
					
					
					
					if ("pdfUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPdfUrl(value);
					}
					
					
					
					
					
					if ("taxRegisterNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTaxRegisterNo(value);
					}
					
					
					
					
					
					if ("seqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqNo(value);
					}
					
					
					
					
					
					if ("invoiceAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceAmount(value);
					}
					
					
					
					
					
					if ("invoiceSeqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceSeqNo(value);
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
		
		
		public void Write(ExternalInvoiceHandleState structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetState() != null) {
				
				oprot.WriteFieldBegin("state");
				oprot.WriteString(structs.GetState());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("state can not be null!");
			}
			
			
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
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetRetMsg() != null) {
				
				oprot.WriteFieldBegin("retMsg");
				
				com.vip.fcs.vei.service.BaseRetMsgHelper.getInstance().Write(structs.GetRetMsg(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("retMsg can not be null!");
			}
			
			
			if(structs.GetStoreSource() != null) {
				
				oprot.WriteFieldBegin("storeSource");
				oprot.WriteString(structs.GetStoreSource());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreId() != null) {
				
				oprot.WriteFieldBegin("storeId");
				oprot.WriteString(structs.GetStoreId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteString(structs.GetUserId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteString(structs.GetType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderReturnNo() != null) {
				
				oprot.WriteFieldBegin("orderReturnNo");
				oprot.WriteString(structs.GetOrderReturnNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPdfUrl() != null) {
				
				oprot.WriteFieldBegin("pdfUrl");
				oprot.WriteString(structs.GetPdfUrl());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTaxRegisterNo() != null) {
				
				oprot.WriteFieldBegin("taxRegisterNo");
				oprot.WriteString(structs.GetTaxRegisterNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeqNo() != null) {
				
				oprot.WriteFieldBegin("seqNo");
				oprot.WriteString(structs.GetSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceAmount() != null) {
				
				oprot.WriteFieldBegin("invoiceAmount");
				oprot.WriteString(structs.GetInvoiceAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceSeqNo() != null) {
				
				oprot.WriteFieldBegin("invoiceSeqNo");
				oprot.WriteString(structs.GetInvoiceSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ExternalInvoiceHandleState bean){
			
			
		}
		
	}
	
}