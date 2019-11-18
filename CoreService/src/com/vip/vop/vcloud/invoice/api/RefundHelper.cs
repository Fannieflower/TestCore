using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	public class RefundHelper : TBeanSerializer<Refund>
	{
		
		public static RefundHelper OBJ = new RefundHelper();
		
		public static RefundHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Refund structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("partnerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPartnerId(value);
					}
					
					
					
					
					
					if ("channelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetChannelId(value);
					}
					
					
					
					
					
					if ("transId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("refundTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetRefundTime(value);
					}
					
					
					
					
					
					if ("totalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTotalAmount(value);
					}
					
					
					
					
					
					if ("details".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.invoice.api.RefundDetail> value;
						
						value = new List<com.vip.vop.vcloud.invoice.api.RefundDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.invoice.api.RefundDetail elem0;
								
								elem0 = new com.vip.vop.vcloud.invoice.api.RefundDetail();
								com.vip.vop.vcloud.invoice.api.RefundDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDetails(value);
					}
					
					
					
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("dealType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetDealType(value);
					}
					
					
					
					
					
					if ("discountAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetDiscountAmount(value);
					}
					
					
					
					
					
					if ("shippingAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.vcloud.invoice.api.RefundShippingAddress value;
						
						value = new com.vip.vop.vcloud.invoice.api.RefundShippingAddress();
						com.vip.vop.vcloud.invoice.api.RefundShippingAddressHelper.getInstance().Read(value, iprot);
						
						structs.SetShippingAddress(value);
					}
					
					
					
					
					
					if ("subTotal".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetSubTotal(value);
					}
					
					
					
					
					
					if ("paymentMethod".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPaymentMethod(value);
					}
					
					
					
					
					
					if ("discountDescription".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountDescription(value);
					}
					
					
					
					
					
					if ("invoiceType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoiceType(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("returnNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnNo(value);
					}
					
					
					
					
					
					if ("returnApplicationId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnApplicationId(value);
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
		
		
		public void Write(Refund structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPartnerId() != null) {
				
				oprot.WriteFieldBegin("partnerId");
				oprot.WriteI64((long)structs.GetPartnerId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelId() != null) {
				
				oprot.WriteFieldBegin("channelId");
				oprot.WriteI64((long)structs.GetChannelId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransId() != null) {
				
				oprot.WriteFieldBegin("transId");
				oprot.WriteString(structs.GetTransId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefundTime() != null) {
				
				oprot.WriteFieldBegin("refundTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetRefundTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalAmount() != null) {
				
				oprot.WriteFieldBegin("totalAmount");
				oprot.WriteDouble((double)structs.GetTotalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("totalAmount can not be null!");
			}
			
			
			if(structs.GetDetails() != null) {
				
				oprot.WriteFieldBegin("details");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.invoice.api.RefundDetail _item0 in structs.GetDetails()){
					
					
					com.vip.vop.vcloud.invoice.api.RefundDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDealType() != null) {
				
				oprot.WriteFieldBegin("dealType");
				oprot.WriteByte((byte)structs.GetDealType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountAmount() != null) {
				
				oprot.WriteFieldBegin("discountAmount");
				oprot.WriteDouble((double)structs.GetDiscountAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("discountAmount can not be null!");
			}
			
			
			if(structs.GetShippingAddress() != null) {
				
				oprot.WriteFieldBegin("shippingAddress");
				
				com.vip.vop.vcloud.invoice.api.RefundShippingAddressHelper.getInstance().Write(structs.GetShippingAddress(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubTotal() != null) {
				
				oprot.WriteFieldBegin("subTotal");
				oprot.WriteDouble((double)structs.GetSubTotal());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("subTotal can not be null!");
			}
			
			
			if(structs.GetPaymentMethod() != null) {
				
				oprot.WriteFieldBegin("paymentMethod");
				oprot.WriteString(structs.GetPaymentMethod());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountDescription() != null) {
				
				oprot.WriteFieldBegin("discountDescription");
				oprot.WriteString(structs.GetDiscountDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceType() != null) {
				
				oprot.WriteFieldBegin("invoiceType");
				oprot.WriteString(structs.GetInvoiceType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteString(structs.GetStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnNo() != null) {
				
				oprot.WriteFieldBegin("returnNo");
				oprot.WriteString(structs.GetReturnNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnApplicationId() != null) {
				
				oprot.WriteFieldBegin("returnApplicationId");
				oprot.WriteString(structs.GetReturnApplicationId());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Refund bean){
			
			
		}
		
	}
	
}