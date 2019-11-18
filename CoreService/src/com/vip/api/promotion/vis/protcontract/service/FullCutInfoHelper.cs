using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class FullCutInfoHelper : TBeanSerializer<FullCutInfo>
	{
		
		public static FullCutInfoHelper OBJ = new FullCutInfoHelper();
		
		public static FullCutInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FullCutInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("isTop".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIsTop(value);
					}
					
					
					
					
					
					if ("buyCuts".Equals(schemeField.Trim())){
						
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
						
						structs.SetBuyCuts(value);
					}
					
					
					
					
					
					if ("discountContent".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountContent(value);
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
					
					
					
					
					
					if ("vendorBearInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.VendorBearInfo();
						com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetVendorBearInfo(value);
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
		
		
		public void Write(FullCutInfo structs, Protocol oprot){
			
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
			
			
			if(structs.GetIsTop() != null) {
				
				oprot.WriteFieldBegin("isTop");
				oprot.WriteByte((byte)structs.GetIsTop()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyCuts() != null) {
				
				oprot.WriteFieldBegin("buyCuts");
				
				oprot.WriteListBegin();
				foreach(com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfo _item0 in structs.GetBuyCuts()){
					
					
					com.vip.api.promotion.vis.protcontract.service.BuyAndCutInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountContent() != null) {
				
				oprot.WriteFieldBegin("discountContent");
				oprot.WriteString(structs.GetDiscountContent());
				
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
			
			
			if(structs.GetVendorBearInfo() != null) {
				
				oprot.WriteFieldBegin("vendorBearInfo");
				
				com.vip.api.promotion.vis.protcontract.service.VendorBearInfoHelper.getInstance().Write(structs.GetVendorBearInfo(), oprot);
				
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
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FullCutInfo bean){
			
			
		}
		
	}
	
}