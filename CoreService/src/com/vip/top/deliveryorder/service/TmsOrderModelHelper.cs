using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.service{
	
	
	
	public class TmsOrderModelHelper : TBeanSerializer<TmsOrderModel>
	{
		
		public static TmsOrderModelHelper OBJ = new TmsOrderModelHelper();
		
		public static TmsOrderModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("recId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetRecId(value);
					}
					
					
					
					
					
					if ("tmsOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOrderId(value);
					}
					
					
					
					
					
					if ("returnBoxTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetReturnBoxTime(value);
					}
					
					
					
					
					
					if ("purchaseOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseOrderId(value);
					}
					
					
					
					
					
					if ("isCountFee".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsCountFee(value);
					}
					
					
					
					
					
					if ("easybreak".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetEasybreak(value);
					}
					
					
					
					
					
					if ("vipClubName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipClubName(value);
					}
					
					
					
					
					
					if ("userTypeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserTypeName(value);
					}
					
					
					
					
					
					if ("transportTypeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportTypeName(value);
					}
					
					
					
					
					
					if ("surplus".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetSurplus(value);
					}
					
					
					
					
					
					if ("carriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetCarriage(value);
					}
					
					
					
					
					
					if ("joinTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetJoinTime(value);
					}
					
					
					
					
					
					if ("totalPack".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetTotalPack(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("isPay".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPay(value);
					}
					
					
					
					
					
					if ("orderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderNo(value);
					}
					
					
					
					
					
					if ("isCod".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsCod(value);
					}
					
					
					
					
					
					if ("resendType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetResendType(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("buyer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("vendorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorName(value);
					}
					
					
					
					
					
					if ("buyerAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAddress(value);
					}
					
					
					
					
					
					if ("postCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPostCode(value);
					}
					
					
					
					
					
					if ("buyerAreaId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAreaId(value);
					}
					
					
					
					
					
					if ("buyerAddress2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAddress2(value);
					}
					
					
					
					
					
					if ("buyerAddress3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAddress3(value);
					}
					
					
					
					
					
					if ("buyerCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerCity(value);
					}
					
					
					
					
					
					if ("buyerState".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerState(value);
					}
					
					
					
					
					
					if ("buyerCountryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerCountryId(value);
					}
					
					
					
					
					
					if ("buyerTel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerTel(value);
					}
					
					
					
					
					
					if ("poType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPoType(value);
					}
					
					
					
					
					
					if ("poPeriodValid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoPeriodValid(value);
					}
					
					
					
					
					
					if ("poBuyer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPoBuyer(value);
					}
					
					
					
					
					
					if ("mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobile(value);
					}
					
					
					
					
					
					if ("transportId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTransportId(value);
					}
					
					
					
					
					
					if ("transportType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportType(value);
					}
					
					
					
					
					
					if ("addTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAddTime(value);
					}
					
					
					
					
					
					if ("payType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayType(value);
					}
					
					
					
					
					
					if ("transportDay".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportDay(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("orderType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderType(value);
					}
					
					
					
					
					
					if ("vipClub".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVipClub(value);
					}
					
					
					
					
					
					if ("invoice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInvoice(value);
					}
					
					
					
					
					
					if ("goodsMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetGoodsMoney(value);
					}
					
					
					
					
					
					if ("money".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMoney(value);
					}
					
					
					
					
					
					if ("aigo".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetAigo(value);
					}
					
					
					
					
					
					if ("favourableMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetFavourableMoney(value);
					}
					
					
					
					
					
					if ("exFavMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetExFavMoney(value);
					}
					
					
					
					
					
					if ("userType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetUserType(value);
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
					
					
					
					
					
					if ("isHold".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsHold(value);
					}
					
					
					
					
					
					if ("oldOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldOrderSn(value);
					}
					
					
					
					
					
					if ("iudFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIudFlag(value);
					}
					
					
					
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("originalServiceLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetOriginalServiceLevel(value);
					}
					
					
					
					
					
					if ("originalVolume".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetOriginalVolume(value);
					}
					
					
					
					
					
					if ("originalVolumeUnit".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginalVolumeUnit(value);
					}
					
					
					
					
					
					if ("originalWeight".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetOriginalWeight(value);
					}
					
					
					
					
					
					if ("originalWeightUnit".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginalWeightUnit(value);
					}
					
					
					
					
					
					if ("originalAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetOriginalAmount(value);
					}
					
					
					
					
					
					if ("transportWorkerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportWorkerName(value);
					}
					
					
					
					
					
					if ("amountUnit".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAmountUnit(value);
					}
					
					
					
					
					
					if ("orderSubType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderSubType(value);
					}
					
					
					
					
					
					if ("orderStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderStatus(value);
					}
					
					
					
					
					
					if ("signInMan".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSignInMan(value);
					}
					
					
					
					
					
					if ("isAutopicked".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsAutopicked(value);
					}
					
					
					
					
					
					if ("jionCustWorker".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetJionCustWorker(value);
					}
					
					
					
					
					
					if ("acceptManipulatMatcTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAcceptManipulatMatcTime(value);
					}
					
					
					
					
					
					if ("custNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCustNumber(value);
					}
					
					
					
					
					
					if ("isTrack".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsTrack(value);
					}
					
					
					
					
					
					if ("isExceptional".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsExceptional(value);
					}
					
					
					
					
					
					if ("isInsurance".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsInsurance(value);
					}
					
					
					
					
					
					if ("closeMan".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCloseMan(value);
					}
					
					
					
					
					
					if ("rejectionTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetRejectionTime(value);
					}
					
					
					
					
					
					if ("signInTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSignInTime(value);
					}
					
					
					
					
					
					if ("isClosed".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsClosed(value);
					}
					
					
					
					
					
					if ("circularWorkerName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCircularWorkerName(value);
					}
					
					
					
					
					
					if ("closeTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCloseTime(value);
					}
					
					
					
					
					
					if ("closeManCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCloseManCode(value);
					}
					
					
					
					
					
					if ("isCircular".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsCircular(value);
					}
					
					
					
					
					
					if ("circularWorker".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCircularWorker(value);
					}
					
					
					
					
					
					if ("eta".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetEta(value);
					}
					
					
					
					
					
					if ("atd".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAtd(value);
					}
					
					
					
					
					
					if ("circularTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCircularTime(value);
					}
					
					
					
					
					
					if ("oriCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriCity(value);
					}
					
					
					
					
					
					if ("tmsOriginalOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOriginalOrderId(value);
					}
					
					
					
					
					
					if ("returnType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetReturnType(value);
					}
					
					
					
					
					
					if ("returnno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnno(value);
					}
					
					
					
					
					
					if ("createdByUser".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedByUser(value);
					}
					
					
					
					
					
					if ("createdOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedOffice(value);
					}
					
					
					
					
					
					if ("createdDtmLoc".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreatedDtmLoc(value);
					}
					
					
					
					
					
					if ("createdTimeZone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedTimeZone(value);
					}
					
					
					
					
					
					if ("updatedOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdatedOffice(value);
					}
					
					
					
					
					
					if ("updatedByUser".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdatedByUser(value);
					}
					
					
					
					
					
					if ("updatedDtmLoc".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUpdatedDtmLoc(value);
					}
					
					
					
					
					
					if ("isRefuce".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsRefuce(value);
					}
					
					
					
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("currentDeliveryPoint".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCurrentDeliveryPoint(value);
					}
					
					
					
					
					
					if ("deliveryPoint".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliveryPoint(value);
					}
					
					
					
					
					
					if ("updatedTimeZone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdatedTimeZone(value);
					}
					
					
					
					
					
					if ("recordVersion".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetRecordVersion(value);
					}
					
					
					
					
					
					if ("custType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCustType(value);
					}
					
					
					
					
					
					if ("isDelete".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsDelete(value);
					}
					
					
					
					
					
					if ("aux1".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAux1(value);
					}
					
					
					
					
					
					if ("aux2".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAux2(value);
					}
					
					
					
					
					
					if ("aux3".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAux3(value);
					}
					
					
					
					
					
					if ("aux4".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAux4(value);
					}
					
					
					
					
					
					if ("aux5".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAux5(value);
					}
					
					
					
					
					
					if ("isFeedBack".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsFeedBack(value);
					}
					
					
					
					
					
					if ("autoFreight".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAutoFreight(value);
					}
					
					
					
					
					
					if ("fiscalYear".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFiscalYear(value);
					}
					
					
					
					
					
					if ("isUpdate".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsUpdate(value);
					}
					
					
					
					
					
					if ("isSpecialReturn".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsSpecialReturn(value);
					}
					
					
					
					
					
					if ("custCounterAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetCustCounterAmount(value);
					}
					
					
					
					
					
					if ("custClaimAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetCustClaimAmount(value);
					}
					
					
					
					
					
					if ("insuranceClaimAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetInsuranceClaimAmount(value);
					}
					
					
					
					
					
					if ("oqcDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOqcDate(value);
					}
					
					
					
					
					
					if ("returnGoodsContact".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnGoodsContact(value);
					}
					
					
					
					
					
					if ("returnGoodsPhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnGoodsPhone(value);
					}
					
					
					
					
					
					if ("returnGoodsType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetReturnGoodsType(value);
					}
					
					
					
					
					
					if ("brand".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrand(value);
					}
					
					
					
					
					
					if ("merchantsInterface".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMerchantsInterface(value);
					}
					
					
					
					
					
					if ("merchantsInterfacePhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMerchantsInterfacePhone(value);
					}
					
					
					
					
					
					if ("returnSpecialRequirements".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnSpecialRequirements(value);
					}
					
					
					
					
					
					if ("payment".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPayment(value);
					}
					
					
					
					
					
					if ("returnVendorContact".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReturnVendorContact(value);
					}
					
					
					
					
					
					if ("deliveryMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDeliveryMode(value);
					}
					
					
					
					
					
					if ("receivedUnit".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceivedUnit(value);
					}
					
					
					
					
					
					if ("transportMode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTransportMode(value);
					}
					
					
					
					
					
					if ("deliverGoodsManLink".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliverGoodsManLink(value);
					}
					
					
					
					
					
					if ("deliverGoodsManPhone".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliverGoodsManPhone(value);
					}
					
					
					
					
					
					if ("isInStation".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsInStation(value);
					}
					
					
					
					
					
					if ("buyTown".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyTown(value);
					}
					
					
					
					
					
					if ("cancelStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCancelStatus(value);
					}
					
					
					
					
					
					if ("wayOfSettlement".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWayOfSettlement(value);
					}
					
					
					
					
					
					if ("ldpJoinTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetLdpJoinTime(value);
					}
					
					
					
					
					
					if ("reBillingRemark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReBillingRemark(value);
					}
					
					
					
					
					
					if ("extPayType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetExtPayType(value);
					}
					
					
					
					
					
					if ("appraisedTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAppraisedTime(value);
					}
					
					
					
					
					
					if ("orderBatchNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderBatchNo(value);
					}
					
					
					
					
					
					if ("orderMainCust".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderMainCust(value);
					}
					
					
					
					
					
					if ("b2cUserName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetB2cUserName(value);
					}
					
					
					
					
					
					if ("mergeOrderSns".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMergeOrderSns(value);
					}
					
					
					
					
					
					if ("mergeParentOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMergeParentOrderSn(value);
					}
					
					
					
					
					
					if ("mergeParentOrderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMergeParentOrderNo(value);
					}
					
					
					
					
					
					if ("mergeFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetMergeFlag(value);
					}
					
					
					
					
					
					if ("isSecondMatch".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetIsSecondMatch(value);
					}
					
					
					
					
					
					if ("isSecondMatchAppraise".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsSecondMatchAppraise(value);
					}
					
					
					
					
					
					if ("secondMatchAppraiseTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSecondMatchAppraiseTime(value);
					}
					
					
					
					
					
					if ("isIntercept".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsIntercept(value);
					}
					
					
					
					
					
					if ("interceptOperator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInterceptOperator(value);
					}
					
					
					
					
					
					if ("interceptTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetInterceptTime(value);
					}
					
					
					
					
					
					if ("crmCustPointId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCrmCustPointId(value);
					}
					
					
					
					
					
					if ("isPrint".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsPrint(value);
					}
					
					
					
					
					
					if ("serviceType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetServiceType(value);
					}
					
					
					
					
					
					if ("customerCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomerCode(value);
					}
					
					
					
					
					
					if ("sendAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSendAddress(value);
					}
					
					
					
					
					
					if ("dispatchStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetDispatchStatus(value);
					}
					
					
					
					
					
					if ("dispatchDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetDispatchDate(value);
					}
					
					
					
					
					
					if ("mbpCompensationAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMbpCompensationAmount(value);
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
		
		
		public void Write(TmsOrderModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRecId() != null) {
				
				oprot.WriteFieldBegin("recId");
				oprot.WriteI64((long)structs.GetRecId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTmsOrderId() != null) {
				
				oprot.WriteFieldBegin("tmsOrderId");
				oprot.WriteString(structs.GetTmsOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnBoxTime() != null) {
				
				oprot.WriteFieldBegin("returnBoxTime");
				oprot.WriteI64((long)structs.GetReturnBoxTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchaseOrderId() != null) {
				
				oprot.WriteFieldBegin("purchaseOrderId");
				oprot.WriteString(structs.GetPurchaseOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsCountFee() != null) {
				
				oprot.WriteFieldBegin("isCountFee");
				oprot.WriteI32((int)structs.GetIsCountFee()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEasybreak() != null) {
				
				oprot.WriteFieldBegin("easybreak");
				oprot.WriteI32((int)structs.GetEasybreak()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipClubName() != null) {
				
				oprot.WriteFieldBegin("vipClubName");
				oprot.WriteString(structs.GetVipClubName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserTypeName() != null) {
				
				oprot.WriteFieldBegin("userTypeName");
				oprot.WriteString(structs.GetUserTypeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportTypeName() != null) {
				
				oprot.WriteFieldBegin("transportTypeName");
				oprot.WriteString(structs.GetTransportTypeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSurplus() != null) {
				
				oprot.WriteFieldBegin("surplus");
				oprot.WriteDouble((double)structs.GetSurplus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarriage() != null) {
				
				oprot.WriteFieldBegin("carriage");
				oprot.WriteDouble((double)structs.GetCarriage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetJoinTime() != null) {
				
				oprot.WriteFieldBegin("joinTime");
				oprot.WriteI64((long)structs.GetJoinTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalPack() != null) {
				
				oprot.WriteFieldBegin("totalPack");
				oprot.WriteI64((long)structs.GetTotalPack()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPay() != null) {
				
				oprot.WriteFieldBegin("isPay");
				oprot.WriteI32((int)structs.GetIsPay()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderNo() != null) {
				
				oprot.WriteFieldBegin("orderNo");
				oprot.WriteString(structs.GetOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsCod() != null) {
				
				oprot.WriteFieldBegin("isCod");
				oprot.WriteI32((int)structs.GetIsCod()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResendType() != null) {
				
				oprot.WriteFieldBegin("resendType");
				oprot.WriteI32((int)structs.GetResendType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteString(structs.GetUserId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer() != null) {
				
				oprot.WriteFieldBegin("buyer");
				oprot.WriteString(structs.GetBuyer());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorName() != null) {
				
				oprot.WriteFieldBegin("vendorName");
				oprot.WriteString(structs.GetVendorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAddress() != null) {
				
				oprot.WriteFieldBegin("buyerAddress");
				oprot.WriteString(structs.GetBuyerAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPostCode() != null) {
				
				oprot.WriteFieldBegin("postCode");
				oprot.WriteString(structs.GetPostCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAreaId() != null) {
				
				oprot.WriteFieldBegin("buyerAreaId");
				oprot.WriteString(structs.GetBuyerAreaId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAddress2() != null) {
				
				oprot.WriteFieldBegin("buyerAddress2");
				oprot.WriteString(structs.GetBuyerAddress2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAddress3() != null) {
				
				oprot.WriteFieldBegin("buyerAddress3");
				oprot.WriteString(structs.GetBuyerAddress3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerCity() != null) {
				
				oprot.WriteFieldBegin("buyerCity");
				oprot.WriteString(structs.GetBuyerCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerState() != null) {
				
				oprot.WriteFieldBegin("buyerState");
				oprot.WriteString(structs.GetBuyerState());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerCountryId() != null) {
				
				oprot.WriteFieldBegin("buyerCountryId");
				oprot.WriteString(structs.GetBuyerCountryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerTel() != null) {
				
				oprot.WriteFieldBegin("buyerTel");
				oprot.WriteString(structs.GetBuyerTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoType() != null) {
				
				oprot.WriteFieldBegin("poType");
				oprot.WriteI32((int)structs.GetPoType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoPeriodValid() != null) {
				
				oprot.WriteFieldBegin("poPeriodValid");
				oprot.WriteString(structs.GetPoPeriodValid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPoBuyer() != null) {
				
				oprot.WriteFieldBegin("poBuyer");
				oprot.WriteString(structs.GetPoBuyer());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobile() != null) {
				
				oprot.WriteFieldBegin("mobile");
				oprot.WriteString(structs.GetMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportId() != null) {
				
				oprot.WriteFieldBegin("transportId");
				oprot.WriteI32((int)structs.GetTransportId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportType() != null) {
				
				oprot.WriteFieldBegin("transportType");
				oprot.WriteString(structs.GetTransportType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddTime() != null) {
				
				oprot.WriteFieldBegin("addTime");
				oprot.WriteI64((long)structs.GetAddTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayType() != null) {
				
				oprot.WriteFieldBegin("payType");
				oprot.WriteString(structs.GetPayType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportDay() != null) {
				
				oprot.WriteFieldBegin("transportDay");
				oprot.WriteString(structs.GetTransportDay());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderType() != null) {
				
				oprot.WriteFieldBegin("orderType");
				oprot.WriteString(structs.GetOrderType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipClub() != null) {
				
				oprot.WriteFieldBegin("vipClub");
				oprot.WriteI32((int)structs.GetVipClub()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoice() != null) {
				
				oprot.WriteFieldBegin("invoice");
				oprot.WriteString(structs.GetInvoice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsMoney() != null) {
				
				oprot.WriteFieldBegin("goodsMoney");
				oprot.WriteDouble((double)structs.GetGoodsMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMoney() != null) {
				
				oprot.WriteFieldBegin("money");
				oprot.WriteDouble((double)structs.GetMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAigo() != null) {
				
				oprot.WriteFieldBegin("aigo");
				oprot.WriteDouble((double)structs.GetAigo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFavourableMoney() != null) {
				
				oprot.WriteFieldBegin("favourableMoney");
				oprot.WriteDouble((double)structs.GetFavourableMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExFavMoney() != null) {
				
				oprot.WriteFieldBegin("exFavMoney");
				oprot.WriteDouble((double)structs.GetExFavMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserType() != null) {
				
				oprot.WriteFieldBegin("userType");
				oprot.WriteI32((int)structs.GetUserType()); 
				
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
			
			
			if(structs.GetIsHold() != null) {
				
				oprot.WriteFieldBegin("isHold");
				oprot.WriteI32((int)structs.GetIsHold()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOldOrderSn() != null) {
				
				oprot.WriteFieldBegin("oldOrderSn");
				oprot.WriteString(structs.GetOldOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIudFlag() != null) {
				
				oprot.WriteFieldBegin("iudFlag");
				oprot.WriteI32((int)structs.GetIudFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalServiceLevel() != null) {
				
				oprot.WriteFieldBegin("originalServiceLevel");
				oprot.WriteDouble((double)structs.GetOriginalServiceLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalVolume() != null) {
				
				oprot.WriteFieldBegin("originalVolume");
				oprot.WriteDouble((double)structs.GetOriginalVolume());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalVolumeUnit() != null) {
				
				oprot.WriteFieldBegin("originalVolumeUnit");
				oprot.WriteString(structs.GetOriginalVolumeUnit());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalWeight() != null) {
				
				oprot.WriteFieldBegin("originalWeight");
				oprot.WriteDouble((double)structs.GetOriginalWeight());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalWeightUnit() != null) {
				
				oprot.WriteFieldBegin("originalWeightUnit");
				oprot.WriteString(structs.GetOriginalWeightUnit());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalAmount() != null) {
				
				oprot.WriteFieldBegin("originalAmount");
				oprot.WriteDouble((double)structs.GetOriginalAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportWorkerName() != null) {
				
				oprot.WriteFieldBegin("transportWorkerName");
				oprot.WriteString(structs.GetTransportWorkerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAmountUnit() != null) {
				
				oprot.WriteFieldBegin("amountUnit");
				oprot.WriteString(structs.GetAmountUnit());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSubType() != null) {
				
				oprot.WriteFieldBegin("orderSubType");
				oprot.WriteI32((int)structs.GetOrderSubType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderStatus() != null) {
				
				oprot.WriteFieldBegin("orderStatus");
				oprot.WriteI32((int)structs.GetOrderStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignInMan() != null) {
				
				oprot.WriteFieldBegin("signInMan");
				oprot.WriteString(structs.GetSignInMan());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsAutopicked() != null) {
				
				oprot.WriteFieldBegin("isAutopicked");
				oprot.WriteI32((int)structs.GetIsAutopicked()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetJionCustWorker() != null) {
				
				oprot.WriteFieldBegin("jionCustWorker");
				oprot.WriteString(structs.GetJionCustWorker());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAcceptManipulatMatcTime() != null) {
				
				oprot.WriteFieldBegin("acceptManipulatMatcTime");
				oprot.WriteI64((long)structs.GetAcceptManipulatMatcTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustNumber() != null) {
				
				oprot.WriteFieldBegin("custNumber");
				oprot.WriteI64((long)structs.GetCustNumber()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsTrack() != null) {
				
				oprot.WriteFieldBegin("isTrack");
				oprot.WriteI32((int)structs.GetIsTrack()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsExceptional() != null) {
				
				oprot.WriteFieldBegin("isExceptional");
				oprot.WriteI32((int)structs.GetIsExceptional()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsInsurance() != null) {
				
				oprot.WriteFieldBegin("isInsurance");
				oprot.WriteI32((int)structs.GetIsInsurance()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCloseMan() != null) {
				
				oprot.WriteFieldBegin("closeMan");
				oprot.WriteString(structs.GetCloseMan());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRejectionTime() != null) {
				
				oprot.WriteFieldBegin("rejectionTime");
				oprot.WriteI64((long)structs.GetRejectionTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignInTime() != null) {
				
				oprot.WriteFieldBegin("signInTime");
				oprot.WriteI64((long)structs.GetSignInTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsClosed() != null) {
				
				oprot.WriteFieldBegin("isClosed");
				oprot.WriteI32((int)structs.GetIsClosed()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCircularWorkerName() != null) {
				
				oprot.WriteFieldBegin("circularWorkerName");
				oprot.WriteString(structs.GetCircularWorkerName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCloseTime() != null) {
				
				oprot.WriteFieldBegin("closeTime");
				oprot.WriteI64((long)structs.GetCloseTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCloseManCode() != null) {
				
				oprot.WriteFieldBegin("closeManCode");
				oprot.WriteString(structs.GetCloseManCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsCircular() != null) {
				
				oprot.WriteFieldBegin("isCircular");
				oprot.WriteI32((int)structs.GetIsCircular()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCircularWorker() != null) {
				
				oprot.WriteFieldBegin("circularWorker");
				oprot.WriteString(structs.GetCircularWorker());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEta() != null) {
				
				oprot.WriteFieldBegin("eta");
				oprot.WriteI64((long)structs.GetEta()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAtd() != null) {
				
				oprot.WriteFieldBegin("atd");
				oprot.WriteI64((long)structs.GetAtd()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCircularTime() != null) {
				
				oprot.WriteFieldBegin("circularTime");
				oprot.WriteI64((long)structs.GetCircularTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriCity() != null) {
				
				oprot.WriteFieldBegin("oriCity");
				oprot.WriteString(structs.GetOriCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTmsOriginalOrderId() != null) {
				
				oprot.WriteFieldBegin("tmsOriginalOrderId");
				oprot.WriteString(structs.GetTmsOriginalOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnType() != null) {
				
				oprot.WriteFieldBegin("returnType");
				oprot.WriteI32((int)structs.GetReturnType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnno() != null) {
				
				oprot.WriteFieldBegin("returnno");
				oprot.WriteString(structs.GetReturnno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedByUser() != null) {
				
				oprot.WriteFieldBegin("createdByUser");
				oprot.WriteString(structs.GetCreatedByUser());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedOffice() != null) {
				
				oprot.WriteFieldBegin("createdOffice");
				oprot.WriteString(structs.GetCreatedOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedDtmLoc() != null) {
				
				oprot.WriteFieldBegin("createdDtmLoc");
				oprot.WriteI64((long)structs.GetCreatedDtmLoc()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedTimeZone() != null) {
				
				oprot.WriteFieldBegin("createdTimeZone");
				oprot.WriteString(structs.GetCreatedTimeZone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedOffice() != null) {
				
				oprot.WriteFieldBegin("updatedOffice");
				oprot.WriteString(structs.GetUpdatedOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedByUser() != null) {
				
				oprot.WriteFieldBegin("updatedByUser");
				oprot.WriteString(structs.GetUpdatedByUser());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedDtmLoc() != null) {
				
				oprot.WriteFieldBegin("updatedDtmLoc");
				oprot.WriteI64((long)structs.GetUpdatedDtmLoc()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsRefuce() != null) {
				
				oprot.WriteFieldBegin("isRefuce");
				oprot.WriteI32((int)structs.GetIsRefuce()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCurrentDeliveryPoint() != null) {
				
				oprot.WriteFieldBegin("currentDeliveryPoint");
				oprot.WriteString(structs.GetCurrentDeliveryPoint());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryPoint() != null) {
				
				oprot.WriteFieldBegin("deliveryPoint");
				oprot.WriteString(structs.GetDeliveryPoint());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdatedTimeZone() != null) {
				
				oprot.WriteFieldBegin("updatedTimeZone");
				oprot.WriteString(structs.GetUpdatedTimeZone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecordVersion() != null) {
				
				oprot.WriteFieldBegin("recordVersion");
				oprot.WriteI64((long)structs.GetRecordVersion()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustType() != null) {
				
				oprot.WriteFieldBegin("custType");
				oprot.WriteI32((int)structs.GetCustType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsDelete() != null) {
				
				oprot.WriteFieldBegin("isDelete");
				oprot.WriteI32((int)structs.GetIsDelete()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAux1() != null) {
				
				oprot.WriteFieldBegin("aux1");
				oprot.WriteString(structs.GetAux1());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAux2() != null) {
				
				oprot.WriteFieldBegin("aux2");
				oprot.WriteString(structs.GetAux2());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAux3() != null) {
				
				oprot.WriteFieldBegin("aux3");
				oprot.WriteString(structs.GetAux3());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAux4() != null) {
				
				oprot.WriteFieldBegin("aux4");
				oprot.WriteString(structs.GetAux4());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAux5() != null) {
				
				oprot.WriteFieldBegin("aux5");
				oprot.WriteString(structs.GetAux5());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsFeedBack() != null) {
				
				oprot.WriteFieldBegin("isFeedBack");
				oprot.WriteI32((int)structs.GetIsFeedBack()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAutoFreight() != null) {
				
				oprot.WriteFieldBegin("autoFreight");
				oprot.WriteI32((int)structs.GetAutoFreight()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFiscalYear() != null) {
				
				oprot.WriteFieldBegin("fiscalYear");
				oprot.WriteString(structs.GetFiscalYear());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsUpdate() != null) {
				
				oprot.WriteFieldBegin("isUpdate");
				oprot.WriteI32((int)structs.GetIsUpdate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSpecialReturn() != null) {
				
				oprot.WriteFieldBegin("isSpecialReturn");
				oprot.WriteI32((int)structs.GetIsSpecialReturn()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCounterAmount() != null) {
				
				oprot.WriteFieldBegin("custCounterAmount");
				oprot.WriteDouble((double)structs.GetCustCounterAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustClaimAmount() != null) {
				
				oprot.WriteFieldBegin("custClaimAmount");
				oprot.WriteDouble((double)structs.GetCustClaimAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInsuranceClaimAmount() != null) {
				
				oprot.WriteFieldBegin("insuranceClaimAmount");
				oprot.WriteDouble((double)structs.GetInsuranceClaimAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOqcDate() != null) {
				
				oprot.WriteFieldBegin("oqcDate");
				oprot.WriteI64((long)structs.GetOqcDate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnGoodsContact() != null) {
				
				oprot.WriteFieldBegin("returnGoodsContact");
				oprot.WriteString(structs.GetReturnGoodsContact());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnGoodsPhone() != null) {
				
				oprot.WriteFieldBegin("returnGoodsPhone");
				oprot.WriteString(structs.GetReturnGoodsPhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnGoodsType() != null) {
				
				oprot.WriteFieldBegin("returnGoodsType");
				oprot.WriteI32((int)structs.GetReturnGoodsType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrand() != null) {
				
				oprot.WriteFieldBegin("brand");
				oprot.WriteString(structs.GetBrand());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMerchantsInterface() != null) {
				
				oprot.WriteFieldBegin("merchantsInterface");
				oprot.WriteString(structs.GetMerchantsInterface());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMerchantsInterfacePhone() != null) {
				
				oprot.WriteFieldBegin("merchantsInterfacePhone");
				oprot.WriteString(structs.GetMerchantsInterfacePhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnSpecialRequirements() != null) {
				
				oprot.WriteFieldBegin("returnSpecialRequirements");
				oprot.WriteString(structs.GetReturnSpecialRequirements());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayment() != null) {
				
				oprot.WriteFieldBegin("payment");
				oprot.WriteI32((int)structs.GetPayment()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReturnVendorContact() != null) {
				
				oprot.WriteFieldBegin("returnVendorContact");
				oprot.WriteString(structs.GetReturnVendorContact());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryMode() != null) {
				
				oprot.WriteFieldBegin("deliveryMode");
				oprot.WriteI32((int)structs.GetDeliveryMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceivedUnit() != null) {
				
				oprot.WriteFieldBegin("receivedUnit");
				oprot.WriteString(structs.GetReceivedUnit());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportMode() != null) {
				
				oprot.WriteFieldBegin("transportMode");
				oprot.WriteI32((int)structs.GetTransportMode()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliverGoodsManLink() != null) {
				
				oprot.WriteFieldBegin("deliverGoodsManLink");
				oprot.WriteString(structs.GetDeliverGoodsManLink());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliverGoodsManPhone() != null) {
				
				oprot.WriteFieldBegin("deliverGoodsManPhone");
				oprot.WriteString(structs.GetDeliverGoodsManPhone());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsInStation() != null) {
				
				oprot.WriteFieldBegin("isInStation");
				oprot.WriteI32((int)structs.GetIsInStation()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyTown() != null) {
				
				oprot.WriteFieldBegin("buyTown");
				oprot.WriteString(structs.GetBuyTown());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCancelStatus() != null) {
				
				oprot.WriteFieldBegin("cancelStatus");
				oprot.WriteI32((int)structs.GetCancelStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWayOfSettlement() != null) {
				
				oprot.WriteFieldBegin("wayOfSettlement");
				oprot.WriteString(structs.GetWayOfSettlement());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLdpJoinTime() != null) {
				
				oprot.WriteFieldBegin("ldpJoinTime");
				oprot.WriteI64((long)structs.GetLdpJoinTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReBillingRemark() != null) {
				
				oprot.WriteFieldBegin("reBillingRemark");
				oprot.WriteString(structs.GetReBillingRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtPayType() != null) {
				
				oprot.WriteFieldBegin("extPayType");
				oprot.WriteI32((int)structs.GetExtPayType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAppraisedTime() != null) {
				
				oprot.WriteFieldBegin("appraisedTime");
				oprot.WriteI64((long)structs.GetAppraisedTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderBatchNo() != null) {
				
				oprot.WriteFieldBegin("orderBatchNo");
				oprot.WriteString(structs.GetOrderBatchNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderMainCust() != null) {
				
				oprot.WriteFieldBegin("orderMainCust");
				oprot.WriteString(structs.GetOrderMainCust());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetB2cUserName() != null) {
				
				oprot.WriteFieldBegin("b2cUserName");
				oprot.WriteString(structs.GetB2cUserName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMergeOrderSns() != null) {
				
				oprot.WriteFieldBegin("mergeOrderSns");
				oprot.WriteString(structs.GetMergeOrderSns());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMergeParentOrderSn() != null) {
				
				oprot.WriteFieldBegin("mergeParentOrderSn");
				oprot.WriteString(structs.GetMergeParentOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMergeParentOrderNo() != null) {
				
				oprot.WriteFieldBegin("mergeParentOrderNo");
				oprot.WriteString(structs.GetMergeParentOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMergeFlag() != null) {
				
				oprot.WriteFieldBegin("mergeFlag");
				oprot.WriteI32((int)structs.GetMergeFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSecondMatch() != null) {
				
				oprot.WriteFieldBegin("isSecondMatch");
				oprot.WriteI16((short)structs.GetIsSecondMatch()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSecondMatchAppraise() != null) {
				
				oprot.WriteFieldBegin("isSecondMatchAppraise");
				oprot.WriteI32((int)structs.GetIsSecondMatchAppraise()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSecondMatchAppraiseTime() != null) {
				
				oprot.WriteFieldBegin("secondMatchAppraiseTime");
				oprot.WriteI64((long)structs.GetSecondMatchAppraiseTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsIntercept() != null) {
				
				oprot.WriteFieldBegin("isIntercept");
				oprot.WriteI32((int)structs.GetIsIntercept()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInterceptOperator() != null) {
				
				oprot.WriteFieldBegin("interceptOperator");
				oprot.WriteString(structs.GetInterceptOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInterceptTime() != null) {
				
				oprot.WriteFieldBegin("interceptTime");
				oprot.WriteI64((long)structs.GetInterceptTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCrmCustPointId() != null) {
				
				oprot.WriteFieldBegin("crmCustPointId");
				oprot.WriteString(structs.GetCrmCustPointId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPrint() != null) {
				
				oprot.WriteFieldBegin("isPrint");
				oprot.WriteByte((byte)structs.GetIsPrint()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetServiceType() != null) {
				
				oprot.WriteFieldBegin("serviceType");
				oprot.WriteByte((byte)structs.GetServiceType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerCode() != null) {
				
				oprot.WriteFieldBegin("customerCode");
				oprot.WriteString(structs.GetCustomerCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSendAddress() != null) {
				
				oprot.WriteFieldBegin("sendAddress");
				oprot.WriteString(structs.GetSendAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDispatchStatus() != null) {
				
				oprot.WriteFieldBegin("dispatchStatus");
				oprot.WriteByte((byte)structs.GetDispatchStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDispatchDate() != null) {
				
				oprot.WriteFieldBegin("dispatchDate");
				oprot.WriteI64((long)structs.GetDispatchDate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMbpCompensationAmount() != null) {
				
				oprot.WriteFieldBegin("mbpCompensationAmount");
				oprot.WriteDouble((double)structs.GetMbpCompensationAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderModel bean){
			
			
		}
		
	}
	
}