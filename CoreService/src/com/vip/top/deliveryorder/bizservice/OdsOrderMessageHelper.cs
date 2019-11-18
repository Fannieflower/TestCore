using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.bizservice{
	
	
	
	public class OdsOrderMessageHelper : TBeanSerializer<OdsOrderMessage>
	{
		
		public static OdsOrderMessageHelper OBJ = new OdsOrderMessageHelper();
		
		public static OdsOrderMessageHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OdsOrderMessage structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("addLocalTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddLocalTime(value);
					}
					
					
					
					
					
					if ("addTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddTime(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("address2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress2(value);
					}
					
					
					
					
					
					if ("address3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress3(value);
					}
					
					
					
					
					
					if ("address4".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddress4(value);
					}
					
					
					
					
					
					if ("addressType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAddressType(value);
					}
					
					
					
					
					
					if ("aigo".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetAigo(value);
					}
					
					
					
					
					
					if ("areaId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAreaId(value);
					}
					
					
					
					
					
					if ("buyer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer(value);
					}
					
					
					
					
					
					if ("carriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetCarriage(value);
					}
					
					
					
					
					
					if ("city".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCity(value);
					}
					
					
					
					
					
					if ("countryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCountryId(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreateTime(value);
					}
					
					
					
					
					
					if ("currencySymbol".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrencySymbol(value);
					}
					
					
					
					
					
					if ("customerEmail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomerEmail(value);
					}
					
					
					
					
					
					if ("edbId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetEdbId(value);
					}
					
					
					
					
					
					if ("erpOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErpOrderSn(value);
					}
					
					
					
					
					
					if ("exFavMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetExFavMoney(value);
					}
					
					
					
					
					
					if ("exPayMoney1".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetExPayMoney1(value);
					}
					
					
					
					
					
					if ("exPayMoney2".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetExPayMoney2(value);
					}
					
					
					
					
					
					if ("exPayMoney3".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetExPayMoney3(value);
					}
					
					
					
					
					
					if ("extPayType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtPayType(value);
					}
					
					
					
					
					
					if ("favourableMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFavourableMoney(value);
					}
					
					
					
					
					
					if ("goodsMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetGoodsMoney(value);
					}
					
					
					
					
					
					if ("invoice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice(value);
					}
					
					
					
					
					
					if ("isHold".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsHold(value);
					}
					
					
					
					
					
					if ("isPrintingPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPrintingPrice(value);
					}
					
					
					
					
					
					if ("lastOrderTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLastOrderTime(value);
					}
					
					
					
					
					
					if ("mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobile(value);
					}
					
					
					
					
					
					if ("money".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMoney(value);
					}
					
					
					
					
					
					if ("oldOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldOrderSn(value);
					}
					
					
					
					
					
					if ("orderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOrderId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("orderType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderType(value);
					}
					
					
					
					
					
					if ("payType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayType(value);
					}
					
					
					
					
					
					if ("postCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPostCode(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("saleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSaleType(value);
					}
					
					
					
					
					
					if ("salesPlatform".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSalesPlatform(value);
					}
					
					
					
					
					
					if ("scheduledSellingId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScheduledSellingId(value);
					}
					
					
					
					
					
					if ("seqDataId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqDataId(value);
					}
					
					
					
					
					
					if ("servicePhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetServicePhone(value);
					}
					
					
					
					
					
					if ("state".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetState(value);
					}
					
					
					
					
					
					if ("surplus".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSurplus(value);
					}
					
					
					
					
					
					if ("tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTel(value);
					}
					
					
					
					
					
					if ("thirdOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetThirdOrderSn(value);
					}
					
					
					
					
					
					if ("tmsOrderStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOrderStatus(value);
					}
					
					
					
					
					
					if ("transportDay".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportDay(value);
					}
					
					
					
					
					
					if ("transportId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportId(value);
					}
					
					
					
					
					
					if ("transportTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTransportTime(value);
					}
					
					
					
					
					
					if ("transportType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportType(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("userName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserName(value);
					}
					
					
					
					
					
					if ("userType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserType(value);
					}
					
					
					
					
					
					if ("userTypeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserTypeName(value);
					}
					
					
					
					
					
					if ("vipclub".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipclub(value);
					}
					
					
					
					
					
					if ("vipclubName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipclubName(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("withdrawAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWithdrawAddress(value);
					}
					
					
					
					
					
					if ("parentOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetParentOrderSn(value);
					}
					
					
					
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail> value;
						
						value = new List<com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail elem0;
								
								elem0 = new com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail();
								com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDetail(value);
					}
					
					
					
					
					
					if ("deliveryWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryWarehouse(value);
					}
					
					
					
					
					
					if ("incoterm".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIncoterm(value);
					}
					
					
					
					
					
					if ("includeNoGood".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIncludeNoGood(value);
					}
					
					
					
					
					
					if ("exchangeBackSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExchangeBackSn(value);
					}
					
					
					
					
					
					if ("deliveryType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDeliveryType(value);
					}
					
					
					
					
					
					if ("isDelayCompensate".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsDelayCompensate(value);
					}
					
					
					
					
					
					if ("deliveryPromisedTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetDeliveryPromisedTime(value);
					}
					
					
					
					
					
					if ("productCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProductCode(value);
					}
					
					
					
					
					
					if ("senderName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderName(value);
					}
					
					
					
					
					
					if ("senderTelephone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderTelephone(value);
					}
					
					
					
					
					
					if ("senderMobilePhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderMobilePhone(value);
					}
					
					
					
					
					
					if ("senderAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderAddress(value);
					}
					
					
					
					
					
					if ("senderProvince".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderProvince(value);
					}
					
					
					
					
					
					if ("senderCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderCity(value);
					}
					
					
					
					
					
					if ("senderCountry".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderCountry(value);
					}
					
					
					
					
					
					if ("senderStreet".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderStreet(value);
					}
					
					
					
					
					
					if ("senderZipCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderZipCode(value);
					}
					
					
					
					
					
					if ("orderBizType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderBizType(value);
					}
					
					
					
					
					
					if ("isSpecialDelivery".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsSpecialDelivery(value);
					}
					
					
					
					
					
					if ("originalParentOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginalParentOrderSn(value);
					}
					
					
					
					
					
					if ("odsOrderBizFlags".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOdsOrderBizFlags(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("orderStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderStatus(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdateTime(value);
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
		
		
		public void Write(OdsOrderMessage structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAddLocalTime() != null) {
				
				oprot.WriteFieldBegin("addLocalTime");
				oprot.WriteString(structs.GetAddLocalTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddTime() != null) {
				
				oprot.WriteFieldBegin("addTime");
				oprot.WriteString(structs.GetAddTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				oprot.WriteString(structs.GetAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress2() != null) {
				
				oprot.WriteFieldBegin("address2");
				oprot.WriteString(structs.GetAddress2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress3() != null) {
				
				oprot.WriteFieldBegin("address3");
				oprot.WriteString(structs.GetAddress3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress4() != null) {
				
				oprot.WriteFieldBegin("address4");
				oprot.WriteString(structs.GetAddress4());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddressType() != null) {
				
				oprot.WriteFieldBegin("addressType");
				oprot.WriteString(structs.GetAddressType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAigo() != null) {
				
				oprot.WriteFieldBegin("aigo");
				oprot.WriteDouble((double)structs.GetAigo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAreaId() != null) {
				
				oprot.WriteFieldBegin("areaId");
				oprot.WriteString(structs.GetAreaId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer() != null) {
				
				oprot.WriteFieldBegin("buyer");
				oprot.WriteString(structs.GetBuyer());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarriage() != null) {
				
				oprot.WriteFieldBegin("carriage");
				oprot.WriteDouble((double)structs.GetCarriage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCity() != null) {
				
				oprot.WriteFieldBegin("city");
				oprot.WriteString(structs.GetCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCountryId() != null) {
				
				oprot.WriteFieldBegin("countryId");
				oprot.WriteString(structs.GetCountryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteString(structs.GetCreateTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCurrencySymbol() != null) {
				
				oprot.WriteFieldBegin("currencySymbol");
				oprot.WriteString(structs.GetCurrencySymbol());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerEmail() != null) {
				
				oprot.WriteFieldBegin("customerEmail");
				oprot.WriteString(structs.GetCustomerEmail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEdbId() != null) {
				
				oprot.WriteFieldBegin("edbId");
				oprot.WriteString(structs.GetEdbId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErpOrderSn() != null) {
				
				oprot.WriteFieldBegin("erpOrderSn");
				oprot.WriteString(structs.GetErpOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExFavMoney() != null) {
				
				oprot.WriteFieldBegin("exFavMoney");
				oprot.WriteDouble((double)structs.GetExFavMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExPayMoney1() != null) {
				
				oprot.WriteFieldBegin("exPayMoney1");
				oprot.WriteDouble((double)structs.GetExPayMoney1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExPayMoney2() != null) {
				
				oprot.WriteFieldBegin("exPayMoney2");
				oprot.WriteDouble((double)structs.GetExPayMoney2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExPayMoney3() != null) {
				
				oprot.WriteFieldBegin("exPayMoney3");
				oprot.WriteDouble((double)structs.GetExPayMoney3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtPayType() != null) {
				
				oprot.WriteFieldBegin("extPayType");
				oprot.WriteString(structs.GetExtPayType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFavourableMoney() != null) {
				
				oprot.WriteFieldBegin("favourableMoney");
				oprot.WriteDouble((double)structs.GetFavourableMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsMoney() != null) {
				
				oprot.WriteFieldBegin("goodsMoney");
				oprot.WriteDouble((double)structs.GetGoodsMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice() != null) {
				
				oprot.WriteFieldBegin("invoice");
				oprot.WriteString(structs.GetInvoice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsHold() != null) {
				
				oprot.WriteFieldBegin("isHold");
				oprot.WriteI32((int)structs.GetIsHold()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPrintingPrice() != null) {
				
				oprot.WriteFieldBegin("isPrintingPrice");
				oprot.WriteI32((int)structs.GetIsPrintingPrice()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLastOrderTime() != null) {
				
				oprot.WriteFieldBegin("lastOrderTime");
				oprot.WriteString(structs.GetLastOrderTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobile() != null) {
				
				oprot.WriteFieldBegin("mobile");
				oprot.WriteString(structs.GetMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMoney() != null) {
				
				oprot.WriteFieldBegin("money");
				oprot.WriteDouble((double)structs.GetMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOldOrderSn() != null) {
				
				oprot.WriteFieldBegin("oldOrderSn");
				oprot.WriteString(structs.GetOldOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderId() != null) {
				
				oprot.WriteFieldBegin("orderId");
				oprot.WriteI64((long)structs.GetOrderId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderType() != null) {
				
				oprot.WriteFieldBegin("orderType");
				oprot.WriteString(structs.GetOrderType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayType() != null) {
				
				oprot.WriteFieldBegin("payType");
				oprot.WriteString(structs.GetPayType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPostCode() != null) {
				
				oprot.WriteFieldBegin("postCode");
				oprot.WriteString(structs.GetPostCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleType() != null) {
				
				oprot.WriteFieldBegin("saleType");
				oprot.WriteI32((int)structs.GetSaleType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSalesPlatform() != null) {
				
				oprot.WriteFieldBegin("salesPlatform");
				oprot.WriteString(structs.GetSalesPlatform());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScheduledSellingId() != null) {
				
				oprot.WriteFieldBegin("scheduledSellingId");
				oprot.WriteString(structs.GetScheduledSellingId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeqDataId() != null) {
				
				oprot.WriteFieldBegin("seqDataId");
				oprot.WriteString(structs.GetSeqDataId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetServicePhone() != null) {
				
				oprot.WriteFieldBegin("servicePhone");
				oprot.WriteString(structs.GetServicePhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetState() != null) {
				
				oprot.WriteFieldBegin("state");
				oprot.WriteString(structs.GetState());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSurplus() != null) {
				
				oprot.WriteFieldBegin("surplus");
				oprot.WriteDouble((double)structs.GetSurplus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTel() != null) {
				
				oprot.WriteFieldBegin("tel");
				oprot.WriteString(structs.GetTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThirdOrderSn() != null) {
				
				oprot.WriteFieldBegin("thirdOrderSn");
				oprot.WriteString(structs.GetThirdOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTmsOrderStatus() != null) {
				
				oprot.WriteFieldBegin("tmsOrderStatus");
				oprot.WriteString(structs.GetTmsOrderStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportDay() != null) {
				
				oprot.WriteFieldBegin("transportDay");
				oprot.WriteString(structs.GetTransportDay());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportId() != null) {
				
				oprot.WriteFieldBegin("transportId");
				oprot.WriteString(structs.GetTransportId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportTime() != null) {
				
				oprot.WriteFieldBegin("transportTime");
				oprot.WriteI32((int)structs.GetTransportTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportType() != null) {
				
				oprot.WriteFieldBegin("transportType");
				oprot.WriteString(structs.GetTransportType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserName() != null) {
				
				oprot.WriteFieldBegin("userName");
				oprot.WriteString(structs.GetUserName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserType() != null) {
				
				oprot.WriteFieldBegin("userType");
				oprot.WriteString(structs.GetUserType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserTypeName() != null) {
				
				oprot.WriteFieldBegin("userTypeName");
				oprot.WriteString(structs.GetUserTypeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipclub() != null) {
				
				oprot.WriteFieldBegin("vipclub");
				oprot.WriteString(structs.GetVipclub());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipclubName() != null) {
				
				oprot.WriteFieldBegin("vipclubName");
				oprot.WriteString(structs.GetVipclubName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWithdrawAddress() != null) {
				
				oprot.WriteFieldBegin("withdrawAddress");
				oprot.WriteString(structs.GetWithdrawAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetParentOrderSn() != null) {
				
				oprot.WriteFieldBegin("parentOrderSn");
				oprot.WriteString(structs.GetParentOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteString(structs.GetId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetail() != null) {
				
				oprot.WriteFieldBegin("detail");
				
				oprot.WriteListBegin();
				foreach(com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetail _item0 in structs.GetDetail()){
					
					
					com.vip.top.deliveryorder.bizservice.OdsOrderMessageDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryWarehouse() != null) {
				
				oprot.WriteFieldBegin("deliveryWarehouse");
				oprot.WriteString(structs.GetDeliveryWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIncoterm() != null) {
				
				oprot.WriteFieldBegin("incoterm");
				oprot.WriteString(structs.GetIncoterm());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIncludeNoGood() != null) {
				
				oprot.WriteFieldBegin("includeNoGood");
				oprot.WriteString(structs.GetIncludeNoGood());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExchangeBackSn() != null) {
				
				oprot.WriteFieldBegin("exchangeBackSn");
				oprot.WriteString(structs.GetExchangeBackSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryType() != null) {
				
				oprot.WriteFieldBegin("deliveryType");
				oprot.WriteI32((int)structs.GetDeliveryType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsDelayCompensate() != null) {
				
				oprot.WriteFieldBegin("isDelayCompensate");
				oprot.WriteI32((int)structs.GetIsDelayCompensate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryPromisedTime() != null) {
				
				oprot.WriteFieldBegin("deliveryPromisedTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDeliveryPromisedTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProductCode() != null) {
				
				oprot.WriteFieldBegin("productCode");
				oprot.WriteString(structs.GetProductCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderName() != null) {
				
				oprot.WriteFieldBegin("senderName");
				oprot.WriteString(structs.GetSenderName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderTelephone() != null) {
				
				oprot.WriteFieldBegin("senderTelephone");
				oprot.WriteString(structs.GetSenderTelephone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderMobilePhone() != null) {
				
				oprot.WriteFieldBegin("senderMobilePhone");
				oprot.WriteString(structs.GetSenderMobilePhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderAddress() != null) {
				
				oprot.WriteFieldBegin("senderAddress");
				oprot.WriteString(structs.GetSenderAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderProvince() != null) {
				
				oprot.WriteFieldBegin("senderProvince");
				oprot.WriteString(structs.GetSenderProvince());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderCity() != null) {
				
				oprot.WriteFieldBegin("senderCity");
				oprot.WriteString(structs.GetSenderCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderCountry() != null) {
				
				oprot.WriteFieldBegin("senderCountry");
				oprot.WriteString(structs.GetSenderCountry());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderStreet() != null) {
				
				oprot.WriteFieldBegin("senderStreet");
				oprot.WriteString(structs.GetSenderStreet());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderZipCode() != null) {
				
				oprot.WriteFieldBegin("senderZipCode");
				oprot.WriteString(structs.GetSenderZipCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderBizType() != null) {
				
				oprot.WriteFieldBegin("orderBizType");
				oprot.WriteI32((int)structs.GetOrderBizType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSpecialDelivery() != null) {
				
				oprot.WriteFieldBegin("isSpecialDelivery");
				oprot.WriteI32((int)structs.GetIsSpecialDelivery()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalParentOrderSn() != null) {
				
				oprot.WriteFieldBegin("originalParentOrderSn");
				oprot.WriteString(structs.GetOriginalParentOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOdsOrderBizFlags() != null) {
				
				oprot.WriteFieldBegin("odsOrderBizFlags");
				oprot.WriteString(structs.GetOdsOrderBizFlags());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteString(structs.GetBusinessType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderStatus() != null) {
				
				oprot.WriteFieldBegin("orderStatus");
				oprot.WriteString(structs.GetOrderStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteString(structs.GetUpdateTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OdsOrderMessage bean){
			
			
		}
		
	}
	
}