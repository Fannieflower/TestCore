using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class MatchResultInfoHelper : TBeanSerializer<MatchResultInfo>
	{
		
		public static MatchResultInfoHelper OBJ = new MatchResultInfoHelper();
		
		public static MatchResultInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(MatchResultInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("matchOrderType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetMatchOrderType(value);
					}
					
					
					
					
					
					if ("tmsOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOrderId(value);
					}
					
					
					
					
					
					if ("custId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustId(value);
					}
					
					
					
					
					
					if ("custCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCode(value);
					}
					
					
					
					
					
					if ("custType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetCustType(value);
					}
					
					
					
					
					
					if ("infCust".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfCust(value);
					}
					
					
					
					
					
					if ("infCustPointId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfCustPointId(value);
					}
					
					
					
					
					
					if ("infCustPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfCustPointCode(value);
					}
					
					
					
					
					
					if ("infCustPointName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfCustPointName(value);
					}
					
					
					
					
					
					if ("infCustPickupGoodsTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfCustPickupGoodsTime(value);
					}
					
					
					
					
					
					if ("infOrderOrginCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfOrderOrginCode(value);
					}
					
					
					
					
					
					if ("infOrderDestinationCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetInfOrderDestinationCode(value);
					}
					
					
					
					
					
					if ("payType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayType(value);
					}
					
					
					
					
					
					if ("orderDeliveryBatch".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderDeliveryBatch(value);
					}
					
					
					
					
					
					if ("templateCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTemplateCode(value);
					}
					
					
					
					
					
					if ("pickingCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPickingCode(value);
					}
					
					
					
					
					
					if ("pickingLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPickingLevel(value);
					}
					
					
					
					
					
					if ("destAccepter".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDestAccepter(value);
					}
					
					
					
					
					
					if ("distributeDeclareOrder".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDistributeDeclareOrder(value);
					}
					
					
					
					
					
					if ("originalServiceLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetOriginalServiceLevel(value);
					}
					
					
					
					
					
					if ("acceptManipulatMatchTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetAcceptManipulatMatchTime(value);
					}
					
					
					
					
					
					if ("matchFlag".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetMatchFlag(value);
					}
					
					
					
					
					
					if ("matchMemo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMatchMemo(value);
					}
					
					
					
					
					
					if ("deliverPointCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDeliverPointCode(value);
					}
					
					
					
					
					
					if ("custPrintName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustPrintName(value);
					}
					
					
					
					
					
					if ("buyerAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAddress(value);
					}
					
					
					
					
					
					if ("buyerCountryId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerCountryId(value);
					}
					
					
					
					
					
					if ("buyerState".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerState(value);
					}
					
					
					
					
					
					if ("buyerCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerCity(value);
					}
					
					
					
					
					
					if ("buyerAreaId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyerAreaId(value);
					}
					
					
					
					
					
					if ("buyTown".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyTown(value);
					}
					
					
					
					
					
					if ("transportNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransportNo(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("crmCustPointId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCrmCustPointId(value);
					}
					
					
					
					
					
					if ("orderType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderType(value);
					}
					
					
					
					
					
					if ("sendMatchControl".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSendMatchControl(value);
					}
					
					
					
					
					
					if ("isSecondMatchAppraise".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsSecondMatchAppraise(value);
					}
					
					
					
					
					
					if ("wareHouseArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWareHouseArea(value);
					}
					
					
					
					
					
					if ("isPjDistribution".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPjDistribution(value);
					}
					
					
					
					
					
					if ("isPjGroup".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPjGroup(value);
					}
					
					
					
					
					
					if ("subMailnoModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSubMailnoModel(value);
					}
					
					
					
					
					
					if ("matchBizType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetMatchBizType(value);
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
		
		
		public void Write(MatchResultInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMatchOrderType() != null) {
				
				oprot.WriteFieldBegin("matchOrderType");
				oprot.WriteI32((int)structs.GetMatchOrderType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTmsOrderId() != null) {
				
				oprot.WriteFieldBegin("tmsOrderId");
				oprot.WriteString(structs.GetTmsOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustId() != null) {
				
				oprot.WriteFieldBegin("custId");
				oprot.WriteString(structs.GetCustId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCode() != null) {
				
				oprot.WriteFieldBegin("custCode");
				oprot.WriteString(structs.GetCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustType() != null) {
				
				oprot.WriteFieldBegin("custType");
				oprot.WriteI32((int)structs.GetCustType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfCust() != null) {
				
				oprot.WriteFieldBegin("infCust");
				oprot.WriteString(structs.GetInfCust());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfCustPointId() != null) {
				
				oprot.WriteFieldBegin("infCustPointId");
				oprot.WriteString(structs.GetInfCustPointId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfCustPointCode() != null) {
				
				oprot.WriteFieldBegin("infCustPointCode");
				oprot.WriteString(structs.GetInfCustPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfCustPointName() != null) {
				
				oprot.WriteFieldBegin("infCustPointName");
				oprot.WriteString(structs.GetInfCustPointName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfCustPickupGoodsTime() != null) {
				
				oprot.WriteFieldBegin("infCustPickupGoodsTime");
				oprot.WriteString(structs.GetInfCustPickupGoodsTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfOrderOrginCode() != null) {
				
				oprot.WriteFieldBegin("infOrderOrginCode");
				oprot.WriteString(structs.GetInfOrderOrginCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInfOrderDestinationCode() != null) {
				
				oprot.WriteFieldBegin("infOrderDestinationCode");
				oprot.WriteString(structs.GetInfOrderDestinationCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayType() != null) {
				
				oprot.WriteFieldBegin("payType");
				oprot.WriteString(structs.GetPayType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderDeliveryBatch() != null) {
				
				oprot.WriteFieldBegin("orderDeliveryBatch");
				oprot.WriteI32((int)structs.GetOrderDeliveryBatch()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTemplateCode() != null) {
				
				oprot.WriteFieldBegin("templateCode");
				oprot.WriteString(structs.GetTemplateCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPickingCode() != null) {
				
				oprot.WriteFieldBegin("pickingCode");
				oprot.WriteString(structs.GetPickingCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPickingLevel() != null) {
				
				oprot.WriteFieldBegin("pickingLevel");
				oprot.WriteString(structs.GetPickingLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDestAccepter() != null) {
				
				oprot.WriteFieldBegin("destAccepter");
				oprot.WriteString(structs.GetDestAccepter());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDistributeDeclareOrder() != null) {
				
				oprot.WriteFieldBegin("distributeDeclareOrder");
				oprot.WriteI32((int)structs.GetDistributeDeclareOrder()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginalServiceLevel() != null) {
				
				oprot.WriteFieldBegin("originalServiceLevel");
				oprot.WriteDouble((double)structs.GetOriginalServiceLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAcceptManipulatMatchTime() != null) {
				
				oprot.WriteFieldBegin("acceptManipulatMatchTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetAcceptManipulatMatchTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMatchFlag() != null) {
				
				oprot.WriteFieldBegin("matchFlag");
				oprot.WriteBool((bool)structs.GetMatchFlag());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("matchFlag can not be null!");
			}
			
			
			if(structs.GetMatchMemo() != null) {
				
				oprot.WriteFieldBegin("matchMemo");
				oprot.WriteString(structs.GetMatchMemo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliverPointCode() != null) {
				
				oprot.WriteFieldBegin("deliverPointCode");
				oprot.WriteString(structs.GetDeliverPointCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustPrintName() != null) {
				
				oprot.WriteFieldBegin("custPrintName");
				oprot.WriteString(structs.GetCustPrintName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAddress() != null) {
				
				oprot.WriteFieldBegin("buyerAddress");
				oprot.WriteString(structs.GetBuyerAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerCountryId() != null) {
				
				oprot.WriteFieldBegin("buyerCountryId");
				oprot.WriteString(structs.GetBuyerCountryId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerState() != null) {
				
				oprot.WriteFieldBegin("buyerState");
				oprot.WriteString(structs.GetBuyerState());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerCity() != null) {
				
				oprot.WriteFieldBegin("buyerCity");
				oprot.WriteString(structs.GetBuyerCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyerAreaId() != null) {
				
				oprot.WriteFieldBegin("buyerAreaId");
				oprot.WriteString(structs.GetBuyerAreaId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyTown() != null) {
				
				oprot.WriteFieldBegin("buyTown");
				oprot.WriteString(structs.GetBuyTown());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransportNo() != null) {
				
				oprot.WriteFieldBegin("transportNo");
				oprot.WriteString(structs.GetTransportNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCrmCustPointId() != null) {
				
				oprot.WriteFieldBegin("crmCustPointId");
				oprot.WriteString(structs.GetCrmCustPointId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderType() != null) {
				
				oprot.WriteFieldBegin("orderType");
				oprot.WriteString(structs.GetOrderType());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSendMatchControl() != null) {
				
				oprot.WriteFieldBegin("sendMatchControl");
				oprot.WriteI32((int)structs.GetSendMatchControl()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSecondMatchAppraise() != null) {
				
				oprot.WriteFieldBegin("isSecondMatchAppraise");
				oprot.WriteI32((int)structs.GetIsSecondMatchAppraise()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWareHouseArea() != null) {
				
				oprot.WriteFieldBegin("wareHouseArea");
				oprot.WriteString(structs.GetWareHouseArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPjDistribution() != null) {
				
				oprot.WriteFieldBegin("isPjDistribution");
				oprot.WriteI32((int)structs.GetIsPjDistribution()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPjGroup() != null) {
				
				oprot.WriteFieldBegin("isPjGroup");
				oprot.WriteI32((int)structs.GetIsPjGroup()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubMailnoModel() != null) {
				
				oprot.WriteFieldBegin("subMailnoModel");
				oprot.WriteI32((int)structs.GetSubMailnoModel()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMatchBizType() != null) {
				
				oprot.WriteFieldBegin("matchBizType");
				oprot.WriteI32((int)structs.GetMatchBizType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(MatchResultInfo bean){
			
			
		}
		
	}
	
}