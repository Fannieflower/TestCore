using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class TmsOrderInfoModelHelper : TBeanSerializer<TmsOrderInfoModel>
	{
		
		public static TmsOrderInfoModelHelper OBJ = new TmsOrderInfoModelHelper();
		
		public static TmsOrderInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TmsOrderInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("tmsOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOrderId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("vipClub".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVipClub(value);
					}
					
					
					
					
					
					if ("userType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetUserType(value);
					}
					
					
					
					
					
					if ("tmsOriginalOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOriginalOrderId(value);
					}
					
					
					
					
					
					if ("createdOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedOffice(value);
					}
					
					
					
					
					
					if ("buyTown".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyTown(value);
					}
					
					
					
					
					
					if ("custType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCustType(value);
					}
					
					
					
					
					
					if ("buyerAreaId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAreaId(value);
					}
					
					
					
					
					
					if ("buyerAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAddress(value);
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
					
					
					
					
					
					if ("isCod".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsCod(value);
					}
					
					
					
					
					
					if ("extPayType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetExtPayType(value);
					}
					
					
					
					
					
					if ("transportType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportType(value);
					}
					
					
					
					
					
					if ("buyerTel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerTel(value);
					}
					
					
					
					
					
					if ("mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobile(value);
					}
					
					
					
					
					
					if ("transportDay".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportDay(value);
					}
					
					
					
					
					
					if ("carriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetCarriage(value);
					}
					
					
					
					
					
					if ("money".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMoney(value);
					}
					
					
					
					
					
					if ("addTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetAddTime(value);
					}
					
					
					
					
					
					if ("buyer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer(value);
					}
					
					
					
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("isSecondMatchAppraise".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsSecondMatchAppraise(value);
					}
					
					
					
					
					
					if ("crmCustPointId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCrmCustPointId(value);
					}
					
					
					
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("customerCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomerCode(value);
					}
					
					
					
					
					
					if ("orderType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderType(value);
					}
					
					
					
					
					
					if ("pickingFinishTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetPickingFinishTime(value);
					}
					
					
					
					
					
					if ("transportTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetTransportTime(value);
					}
					
					
					
					
					
					if ("receivingWarehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceivingWarehouse(value);
					}
					
					
					
					
					
					if ("originalVipClub".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginalVipClub(value);
					}
					
					
					
					
					
					if ("serviceType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetServiceType(value);
					}
					
					
					
					
					
					if ("saleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSaleType(value);
					}
					
					
					
					
					
					if ("orderSubType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderSubType(value);
					}
					
					
					
					
					
					if ("isJitZf".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsJitZf(value);
					}
					
					
					
					
					
					if ("thirdCarrierFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetThirdCarrierFlag(value);
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
		
		
		public void Write(TmsOrderInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTmsOrderId() != null) {
				
				oprot.WriteFieldBegin("tmsOrderId");
				oprot.WriteString(structs.GetTmsOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipClub() != null) {
				
				oprot.WriteFieldBegin("vipClub");
				oprot.WriteI32((int)structs.GetVipClub()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserType() != null) {
				
				oprot.WriteFieldBegin("userType");
				oprot.WriteI32((int)structs.GetUserType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTmsOriginalOrderId() != null) {
				
				oprot.WriteFieldBegin("tmsOriginalOrderId");
				oprot.WriteString(structs.GetTmsOriginalOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreatedOffice() != null) {
				
				oprot.WriteFieldBegin("createdOffice");
				oprot.WriteString(structs.GetCreatedOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyTown() != null) {
				
				oprot.WriteFieldBegin("buyTown");
				oprot.WriteString(structs.GetBuyTown());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustType() != null) {
				
				oprot.WriteFieldBegin("custType");
				oprot.WriteI32((int)structs.GetCustType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAreaId() != null) {
				
				oprot.WriteFieldBegin("buyerAreaId");
				oprot.WriteString(structs.GetBuyerAreaId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAddress() != null) {
				
				oprot.WriteFieldBegin("buyerAddress");
				oprot.WriteString(structs.GetBuyerAddress());
				
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
			
			
			if(structs.GetIsCod() != null) {
				
				oprot.WriteFieldBegin("isCod");
				oprot.WriteI32((int)structs.GetIsCod()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtPayType() != null) {
				
				oprot.WriteFieldBegin("extPayType");
				oprot.WriteI32((int)structs.GetExtPayType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportType() != null) {
				
				oprot.WriteFieldBegin("transportType");
				oprot.WriteString(structs.GetTransportType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerTel() != null) {
				
				oprot.WriteFieldBegin("buyerTel");
				oprot.WriteString(structs.GetBuyerTel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobile() != null) {
				
				oprot.WriteFieldBegin("mobile");
				oprot.WriteString(structs.GetMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportDay() != null) {
				
				oprot.WriteFieldBegin("transportDay");
				oprot.WriteString(structs.GetTransportDay());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarriage() != null) {
				
				oprot.WriteFieldBegin("carriage");
				oprot.WriteDouble((double)structs.GetCarriage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMoney() != null) {
				
				oprot.WriteFieldBegin("money");
				oprot.WriteDouble((double)structs.GetMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddTime() != null) {
				
				oprot.WriteFieldBegin("addTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetAddTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer() != null) {
				
				oprot.WriteFieldBegin("buyer");
				oprot.WriteString(structs.GetBuyer());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSecondMatchAppraise() != null) {
				
				oprot.WriteFieldBegin("isSecondMatchAppraise");
				oprot.WriteI32((int)structs.GetIsSecondMatchAppraise()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCrmCustPointId() != null) {
				
				oprot.WriteFieldBegin("crmCustPointId");
				oprot.WriteString(structs.GetCrmCustPointId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerCode() != null) {
				
				oprot.WriteFieldBegin("customerCode");
				oprot.WriteString(structs.GetCustomerCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderType() != null) {
				
				oprot.WriteFieldBegin("orderType");
				oprot.WriteString(structs.GetOrderType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPickingFinishTime() != null) {
				
				oprot.WriteFieldBegin("pickingFinishTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetPickingFinishTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportTime() != null) {
				
				oprot.WriteFieldBegin("transportTime");
				oprot.WriteByte((byte)structs.GetTransportTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceivingWarehouse() != null) {
				
				oprot.WriteFieldBegin("receivingWarehouse");
				oprot.WriteString(structs.GetReceivingWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalVipClub() != null) {
				
				oprot.WriteFieldBegin("originalVipClub");
				oprot.WriteString(structs.GetOriginalVipClub());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetServiceType() != null) {
				
				oprot.WriteFieldBegin("serviceType");
				oprot.WriteI32((int)structs.GetServiceType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleType() != null) {
				
				oprot.WriteFieldBegin("saleType");
				oprot.WriteI32((int)structs.GetSaleType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSubType() != null) {
				
				oprot.WriteFieldBegin("orderSubType");
				oprot.WriteI32((int)structs.GetOrderSubType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsJitZf() != null) {
				
				oprot.WriteFieldBegin("isJitZf");
				oprot.WriteI32((int)structs.GetIsJitZf()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetThirdCarrierFlag() != null) {
				
				oprot.WriteFieldBegin("thirdCarrierFlag");
				oprot.WriteI32((int)structs.GetThirdCarrierFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TmsOrderInfoModel bean){
			
			
		}
		
	}
	
}