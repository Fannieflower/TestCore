using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractDiscountInfoModelHelper : TBeanSerializer<ProtContractDiscountInfoModel>
	{
		
		public static ProtContractDiscountInfoModelHelper OBJ = new ProtContractDiscountInfoModelHelper();
		
		public static ProtContractDiscountInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractDiscountInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mainId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMainId(value);
					}
					
					
					
					
					
					if ("activityType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityType(value);
					}
					
					
					
					
					
					if ("activityChildType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetActivityChildType(value);
					}
					
					
					
					
					
					if ("fullValueOne".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFullValueOne(value);
					}
					
					
					
					
					
					if ("cutsValueOne".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCutsValueOne(value);
					}
					
					
					
					
					
					if ("fullValueTwo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFullValueTwo(value);
					}
					
					
					
					
					
					if ("cutsValueTwo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCutsValueTwo(value);
					}
					
					
					
					
					
					if ("fullValueThree".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFullValueThree(value);
					}
					
					
					
					
					
					if ("cutsValueThree".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCutsValueThree(value);
					}
					
					
					
					
					
					if ("fullValueFour".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFullValueFour(value);
					}
					
					
					
					
					
					if ("cutsValueFour".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCutsValueFour(value);
					}
					
					
					
					
					
					if ("fullValueFive".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFullValueFive(value);
					}
					
					
					
					
					
					if ("cutsValueFive".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCutsValueFive(value);
					}
					
					
					
					
					
					if ("isTop".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsTop(value);
					}
					
					
					
					
					
					if ("mobileRemark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobileRemark(value);
					}
					
					
					
					
					
					if ("redMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRedMoney(value);
					}
					
					
					
					
					
					if ("redNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRedNum(value);
					}
					
					
					
					
					
					if ("fullMoney".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFullMoney(value);
					}
					
					
					
					
					
					if ("scaleValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetScaleValue(value);
					}
					
					
					
					
					
					if ("rollNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRollNum(value);
					}
					
					
					
					
					
					if ("extraValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExtraValue(value);
					}
					
					
					
					
					
					if ("bearType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetBearType(value);
					}
					
					
					
					
					
					if ("bearValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBearValue(value);
					}
					
					
					
					
					
					if ("oldDeduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldDeduction(value);
					}
					
					
					
					
					
					if ("newDeduction".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNewDeduction(value);
					}
					
					
					
					
					
					if ("preferentialType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPreferentialType(value);
					}
					
					
					
					
					
					if ("prepayType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPrepayType(value);
					}
					
					
					
					
					
					if ("prepayValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayValue(value);
					}
					
					
					
					
					
					if ("prepayPreferential".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayPreferential(value);
					}
					
					
					
					
					
					if ("spellPersonNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSpellPersonNum(value);
					}
					
					
					
					
					
					if ("spellType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetSpellType(value);
					}
					
					
					
					
					
					if ("spellPreferentialValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpellPreferentialValue(value);
					}
					
					
					
					
					
					if ("topNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTopNum(value);
					}
					
					
					
					
					
					if ("exclusivePriceDiscount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExclusivePriceDiscount(value);
					}
					
					
					
					
					
					if ("actNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActNo(value);
					}
					
					
					
					
					
					if ("actName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActName(value);
					}
					
					
					
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("buyAndCutInfos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo> value;
						
						value = new List<com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo elem0;
								
								elem0 = new com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo();
								com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetBuyAndCutInfos(value);
					}
					
					
					
					
					
					if ("oxoScaleValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOxoScaleValue(value);
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
		
		
		public void Write(ProtContractDiscountInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainId() != null) {
				
				oprot.WriteFieldBegin("mainId");
				oprot.WriteI64((long)structs.GetMainId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityType() != null) {
				
				oprot.WriteFieldBegin("activityType");
				oprot.WriteByte((byte)structs.GetActivityType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActivityChildType() != null) {
				
				oprot.WriteFieldBegin("activityChildType");
				oprot.WriteByte((byte)structs.GetActivityChildType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFullValueOne() != null) {
				
				oprot.WriteFieldBegin("fullValueOne");
				oprot.WriteString(structs.GetFullValueOne());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCutsValueOne() != null) {
				
				oprot.WriteFieldBegin("cutsValueOne");
				oprot.WriteString(structs.GetCutsValueOne());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFullValueTwo() != null) {
				
				oprot.WriteFieldBegin("fullValueTwo");
				oprot.WriteString(structs.GetFullValueTwo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCutsValueTwo() != null) {
				
				oprot.WriteFieldBegin("cutsValueTwo");
				oprot.WriteString(structs.GetCutsValueTwo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFullValueThree() != null) {
				
				oprot.WriteFieldBegin("fullValueThree");
				oprot.WriteString(structs.GetFullValueThree());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCutsValueThree() != null) {
				
				oprot.WriteFieldBegin("cutsValueThree");
				oprot.WriteString(structs.GetCutsValueThree());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFullValueFour() != null) {
				
				oprot.WriteFieldBegin("fullValueFour");
				oprot.WriteString(structs.GetFullValueFour());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCutsValueFour() != null) {
				
				oprot.WriteFieldBegin("cutsValueFour");
				oprot.WriteString(structs.GetCutsValueFour());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFullValueFive() != null) {
				
				oprot.WriteFieldBegin("fullValueFive");
				oprot.WriteString(structs.GetFullValueFive());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCutsValueFive() != null) {
				
				oprot.WriteFieldBegin("cutsValueFive");
				oprot.WriteString(structs.GetCutsValueFive());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsTop() != null) {
				
				oprot.WriteFieldBegin("isTop");
				oprot.WriteByte((byte)structs.GetIsTop()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobileRemark() != null) {
				
				oprot.WriteFieldBegin("mobileRemark");
				oprot.WriteString(structs.GetMobileRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRedMoney() != null) {
				
				oprot.WriteFieldBegin("redMoney");
				oprot.WriteString(structs.GetRedMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRedNum() != null) {
				
				oprot.WriteFieldBegin("redNum");
				oprot.WriteI32((int)structs.GetRedNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFullMoney() != null) {
				
				oprot.WriteFieldBegin("fullMoney");
				oprot.WriteString(structs.GetFullMoney());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetScaleValue() != null) {
				
				oprot.WriteFieldBegin("scaleValue");
				oprot.WriteString(structs.GetScaleValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRollNum() != null) {
				
				oprot.WriteFieldBegin("rollNum");
				oprot.WriteI32((int)structs.GetRollNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExtraValue() != null) {
				
				oprot.WriteFieldBegin("extraValue");
				oprot.WriteString(structs.GetExtraValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBearType() != null) {
				
				oprot.WriteFieldBegin("bearType");
				oprot.WriteByte((byte)structs.GetBearType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBearValue() != null) {
				
				oprot.WriteFieldBegin("bearValue");
				oprot.WriteString(structs.GetBearValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOldDeduction() != null) {
				
				oprot.WriteFieldBegin("oldDeduction");
				oprot.WriteString(structs.GetOldDeduction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNewDeduction() != null) {
				
				oprot.WriteFieldBegin("newDeduction");
				oprot.WriteString(structs.GetNewDeduction());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreferentialType() != null) {
				
				oprot.WriteFieldBegin("preferentialType");
				oprot.WriteByte((byte)structs.GetPreferentialType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayType() != null) {
				
				oprot.WriteFieldBegin("prepayType");
				oprot.WriteByte((byte)structs.GetPrepayType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayValue() != null) {
				
				oprot.WriteFieldBegin("prepayValue");
				oprot.WriteString(structs.GetPrepayValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayPreferential() != null) {
				
				oprot.WriteFieldBegin("prepayPreferential");
				oprot.WriteString(structs.GetPrepayPreferential());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpellPersonNum() != null) {
				
				oprot.WriteFieldBegin("spellPersonNum");
				oprot.WriteI32((int)structs.GetSpellPersonNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpellType() != null) {
				
				oprot.WriteFieldBegin("spellType");
				oprot.WriteByte((byte)structs.GetSpellType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpellPreferentialValue() != null) {
				
				oprot.WriteFieldBegin("spellPreferentialValue");
				oprot.WriteString(structs.GetSpellPreferentialValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTopNum() != null) {
				
				oprot.WriteFieldBegin("topNum");
				oprot.WriteI32((int)structs.GetTopNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExclusivePriceDiscount() != null) {
				
				oprot.WriteFieldBegin("exclusivePriceDiscount");
				oprot.WriteString(structs.GetExclusivePriceDiscount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActNo() != null) {
				
				oprot.WriteFieldBegin("actNo");
				oprot.WriteString(structs.GetActNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActName() != null) {
				
				oprot.WriteFieldBegin("actName");
				oprot.WriteString(structs.GetActName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyAndCutInfos() != null) {
				
				oprot.WriteFieldBegin("buyAndCutInfos");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo _item0 in structs.GetBuyAndCutInfos()){
					
					
					com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOxoScaleValue() != null) {
				
				oprot.WriteFieldBegin("oxoScaleValue");
				oprot.WriteString(structs.GetOxoScaleValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractDiscountInfoModel bean){
			
			
		}
		
	}
	
}