using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class DiscountInfoModelHelper : TBeanSerializer<DiscountInfoModel>
	{
		
		public static DiscountInfoModelHelper OBJ = new DiscountInfoModelHelper();
		
		public static DiscountInfoModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(DiscountInfoModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("fullCutInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.FullCutInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.FullCutInfo();
						com.vip.api.promotion.vis.protcontract.service.FullCutInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetFullCutInfo(value);
					}
					
					
					
					
					
					if ("mobileInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.MobileInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.MobileInfo();
						com.vip.api.promotion.vis.protcontract.service.MobileInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetMobileInfo(value);
					}
					
					
					
					
					
					if ("couponInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.CouponInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.CouponInfo();
						com.vip.api.promotion.vis.protcontract.service.CouponInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetCouponInfo(value);
					}
					
					
					
					
					
					if ("prepayInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.PrepayInfo value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.PrepayInfo();
						com.vip.api.promotion.vis.protcontract.service.PrepayInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetPrepayInfo(value);
					}
					
					
					
					
					
					if ("exclusivePrice".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.ExclusivePrice value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.ExclusivePrice();
						com.vip.api.promotion.vis.protcontract.service.ExclusivePriceHelper.getInstance().Read(value, iprot);
						
						structs.SetExclusivePrice(value);
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
		
		
		public void Write(DiscountInfoModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetFullCutInfo() != null) {
				
				oprot.WriteFieldBegin("fullCutInfo");
				
				com.vip.api.promotion.vis.protcontract.service.FullCutInfoHelper.getInstance().Write(structs.GetFullCutInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobileInfo() != null) {
				
				oprot.WriteFieldBegin("mobileInfo");
				
				com.vip.api.promotion.vis.protcontract.service.MobileInfoHelper.getInstance().Write(structs.GetMobileInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCouponInfo() != null) {
				
				oprot.WriteFieldBegin("couponInfo");
				
				com.vip.api.promotion.vis.protcontract.service.CouponInfoHelper.getInstance().Write(structs.GetCouponInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPrepayInfo() != null) {
				
				oprot.WriteFieldBegin("prepayInfo");
				
				com.vip.api.promotion.vis.protcontract.service.PrepayInfoHelper.getInstance().Write(structs.GetPrepayInfo(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExclusivePrice() != null) {
				
				oprot.WriteFieldBegin("exclusivePrice");
				
				com.vip.api.promotion.vis.protcontract.service.ExclusivePriceHelper.getInstance().Write(structs.GetExclusivePrice(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(DiscountInfoModel bean){
			
			
		}
		
	}
	
}