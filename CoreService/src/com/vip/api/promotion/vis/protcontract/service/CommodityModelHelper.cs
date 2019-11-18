using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class CommodityModelHelper : TBeanSerializer<CommodityModel>
	{
		
		public static CommodityModelHelper OBJ = new CommodityModelHelper();
		
		public static CommodityModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CommodityModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMid(value);
					}
					
					
					
					
					
					if ("commodityNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommodityNo(value);
					}
					
					
					
					
					
					if ("barCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarCode(value);
					}
					
					
					
					
					
					if ("commodityName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommodityName(value);
					}
					
					
					
					
					
					if ("brandId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBrandId(value);
					}
					
					
					
					
					
					if ("spellTypeDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpellTypeDesc(value);
					}
					
					
					
					
					
					if ("spellTypeFullDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSpellTypeFullDesc(value);
					}
					
					
					
					
					
					if ("spellPersonNum".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSpellPersonNum(value);
					}
					
					
					
					
					
					if ("spellNumLimit".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSpellNumLimit(value);
					}
					
					
					
					
					
					if ("preferentialTypeDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPreferentialTypeDesc(value);
					}
					
					
					
					
					
					if ("prepayPreferential".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayPreferential(value);
					}
					
					
					
					
					
					if ("prepayTypeDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayTypeDesc(value);
					}
					
					
					
					
					
					if ("prepayValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPrepayValue(value);
					}
					
					
					
					
					
					if ("discountValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDiscountValue(value);
					}
					
					
					
					
					
					if ("actPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActPrice(value);
					}
					
					
					
					
					
					if ("userHelpCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserHelpCount(value);
					}
					
					
					
					
					
					if ("floorPrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFloorPrice(value);
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
		
		
		public void Write(CommodityModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMid() != null) {
				
				oprot.WriteFieldBegin("mid");
				oprot.WriteString(structs.GetMid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommodityNo() != null) {
				
				oprot.WriteFieldBegin("commodityNo");
				oprot.WriteString(structs.GetCommodityNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarCode() != null) {
				
				oprot.WriteFieldBegin("barCode");
				oprot.WriteString(structs.GetBarCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommodityName() != null) {
				
				oprot.WriteFieldBegin("commodityName");
				oprot.WriteString(structs.GetCommodityName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBrandId() != null) {
				
				oprot.WriteFieldBegin("brandId");
				oprot.WriteString(structs.GetBrandId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpellTypeDesc() != null) {
				
				oprot.WriteFieldBegin("spellTypeDesc");
				oprot.WriteString(structs.GetSpellTypeDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpellTypeFullDesc() != null) {
				
				oprot.WriteFieldBegin("spellTypeFullDesc");
				oprot.WriteString(structs.GetSpellTypeFullDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpellPersonNum() != null) {
				
				oprot.WriteFieldBegin("spellPersonNum");
				oprot.WriteI32((int)structs.GetSpellPersonNum()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpellNumLimit() != null) {
				
				oprot.WriteFieldBegin("spellNumLimit");
				oprot.WriteI32((int)structs.GetSpellNumLimit()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreferentialTypeDesc() != null) {
				
				oprot.WriteFieldBegin("preferentialTypeDesc");
				oprot.WriteString(structs.GetPreferentialTypeDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayPreferential() != null) {
				
				oprot.WriteFieldBegin("prepayPreferential");
				oprot.WriteString(structs.GetPrepayPreferential());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayTypeDesc() != null) {
				
				oprot.WriteFieldBegin("prepayTypeDesc");
				oprot.WriteString(structs.GetPrepayTypeDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayValue() != null) {
				
				oprot.WriteFieldBegin("prepayValue");
				oprot.WriteString(structs.GetPrepayValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDiscountValue() != null) {
				
				oprot.WriteFieldBegin("discountValue");
				oprot.WriteString(structs.GetDiscountValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActPrice() != null) {
				
				oprot.WriteFieldBegin("actPrice");
				oprot.WriteString(structs.GetActPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserHelpCount() != null) {
				
				oprot.WriteFieldBegin("userHelpCount");
				oprot.WriteString(structs.GetUserHelpCount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFloorPrice() != null) {
				
				oprot.WriteFieldBegin("floorPrice");
				oprot.WriteString(structs.GetFloorPrice());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CommodityModel bean){
			
			
		}
		
	}
	
}