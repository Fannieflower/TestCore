using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class MatchProcessResultInfoHelper : TBeanSerializer<MatchProcessResultInfo>
	{
		
		public static MatchProcessResultInfoHelper OBJ = new MatchProcessResultInfoHelper();
		
		public static MatchProcessResultInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(MatchProcessResultInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("createdOffice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCreatedOffice(value);
					}
					
					
					
					
					
					if ("custLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustLevel(value);
					}
					
					
					
					
					
					if ("isUseAlipay".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsUseAlipay(value);
					}
					
					
					
					
					
					if ("custName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustName(value);
					}
					
					
					
					
					
					if ("isAir".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsAir(value);
					}
					
					
					
					
					
					if ("custStats".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustStats(value);
					}
					
					
					
					
					
					if ("custCity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustCity(value);
					}
					
					
					
					
					
					if ("custRegion".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustRegion(value);
					}
					
					
					
					
					
					if ("custTown".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustTown(value);
					}
					
					
					
					
					
					if ("isCod".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsCod(value);
					}
					
					
					
					
					
					if ("isTownReach".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsTownReach(value);
					}
					
					
					
					
					
					if ("ruleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRuleType(value);
					}
					
					
					
					
					
					if ("levelRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetLevelRate(value);
					}
					
					
					
					
					
					if ("matchCityPercent".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMatchCityPercent(value);
					}
					
					
					
					
					
					if ("matchRegionPercent".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetMatchRegionPercent(value);
					}
					
					
					
					
					
					if ("isPos".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsPos(value);
					}
					
					
					
					
					
					if ("isSecondMatchAppraise".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsSecondMatchAppraise(value);
					}
					
					
					
					
					
					if ("isNightMatch".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsNightMatch(value);
					}
					
					
					
					
					
					if ("mergeCustCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMergeCustCode(value);
					}
					
					
					
					
					
					if ("mergeTmsOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMergeTmsOrderId(value);
					}
					
					
					
					
					
					if ("isSecondMatch".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsSecondMatch(value);
					}
					
					
					
					
					
					if ("matchPayPercent".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMatchPayPercent(value);
					}
					
					
					
					
					
					if ("matchCashPercent".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMatchCashPercent(value);
					}
					
					
					
					
					
					if ("matchPosPercent".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMatchPosPercent(value);
					}
					
					
					
					
					
					if ("isExistCrm".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsExistCrm(value);
					}
					
					
					
					
					
					if ("isMatchArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsMatchArea(value);
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
		
		
		public void Write(MatchProcessResultInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
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
			
			
			if(structs.GetCreatedOffice() != null) {
				
				oprot.WriteFieldBegin("createdOffice");
				oprot.WriteString(structs.GetCreatedOffice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustLevel() != null) {
				
				oprot.WriteFieldBegin("custLevel");
				oprot.WriteString(structs.GetCustLevel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsUseAlipay() != null) {
				
				oprot.WriteFieldBegin("isUseAlipay");
				oprot.WriteI32((int)structs.GetIsUseAlipay()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustName() != null) {
				
				oprot.WriteFieldBegin("custName");
				oprot.WriteString(structs.GetCustName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsAir() != null) {
				
				oprot.WriteFieldBegin("isAir");
				oprot.WriteI32((int)structs.GetIsAir()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustStats() != null) {
				
				oprot.WriteFieldBegin("custStats");
				oprot.WriteString(structs.GetCustStats());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustCity() != null) {
				
				oprot.WriteFieldBegin("custCity");
				oprot.WriteString(structs.GetCustCity());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustRegion() != null) {
				
				oprot.WriteFieldBegin("custRegion");
				oprot.WriteString(structs.GetCustRegion());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustTown() != null) {
				
				oprot.WriteFieldBegin("custTown");
				oprot.WriteString(structs.GetCustTown());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsCod() != null) {
				
				oprot.WriteFieldBegin("isCod");
				oprot.WriteI32((int)structs.GetIsCod()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsTownReach() != null) {
				
				oprot.WriteFieldBegin("isTownReach");
				oprot.WriteI32((int)structs.GetIsTownReach()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRuleType() != null) {
				
				oprot.WriteFieldBegin("ruleType");
				oprot.WriteI32((int)structs.GetRuleType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLevelRate() != null) {
				
				oprot.WriteFieldBegin("levelRate");
				oprot.WriteDouble((double)structs.GetLevelRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMatchCityPercent() != null) {
				
				oprot.WriteFieldBegin("matchCityPercent");
				oprot.WriteDouble((double)structs.GetMatchCityPercent());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMatchRegionPercent() != null) {
				
				oprot.WriteFieldBegin("matchRegionPercent");
				oprot.WriteDouble((double)structs.GetMatchRegionPercent());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsPos() != null) {
				
				oprot.WriteFieldBegin("isPos");
				oprot.WriteI32((int)structs.GetIsPos()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSecondMatchAppraise() != null) {
				
				oprot.WriteFieldBegin("isSecondMatchAppraise");
				oprot.WriteI32((int)structs.GetIsSecondMatchAppraise()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsNightMatch() != null) {
				
				oprot.WriteFieldBegin("isNightMatch");
				oprot.WriteBool((bool)structs.GetIsNightMatch());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isNightMatch can not be null!");
			}
			
			
			if(structs.GetMergeCustCode() != null) {
				
				oprot.WriteFieldBegin("mergeCustCode");
				oprot.WriteString(structs.GetMergeCustCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMergeTmsOrderId() != null) {
				
				oprot.WriteFieldBegin("mergeTmsOrderId");
				oprot.WriteString(structs.GetMergeTmsOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsSecondMatch() != null) {
				
				oprot.WriteFieldBegin("isSecondMatch");
				oprot.WriteBool((bool)structs.GetIsSecondMatch());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isSecondMatch can not be null!");
			}
			
			
			if(structs.GetMatchPayPercent() != null) {
				
				oprot.WriteFieldBegin("matchPayPercent");
				oprot.WriteI64((long)structs.GetMatchPayPercent()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMatchCashPercent() != null) {
				
				oprot.WriteFieldBegin("matchCashPercent");
				oprot.WriteI64((long)structs.GetMatchCashPercent()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMatchPosPercent() != null) {
				
				oprot.WriteFieldBegin("matchPosPercent");
				oprot.WriteI64((long)structs.GetMatchPosPercent()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsExistCrm() != null) {
				
				oprot.WriteFieldBegin("isExistCrm");
				oprot.WriteBool((bool)structs.GetIsExistCrm());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isExistCrm can not be null!");
			}
			
			
			if(structs.GetIsMatchArea() != null) {
				
				oprot.WriteFieldBegin("isMatchArea");
				oprot.WriteBool((bool)structs.GetIsMatchArea());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isMatchArea can not be null!");
			}
			
			
			if(structs.GetMatchBizType() != null) {
				
				oprot.WriteFieldBegin("matchBizType");
				oprot.WriteI32((int)structs.GetMatchBizType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(MatchProcessResultInfo bean){
			
			
		}
		
	}
	
}