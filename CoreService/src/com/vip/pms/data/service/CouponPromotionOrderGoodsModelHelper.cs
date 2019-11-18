using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponPromotionOrderGoodsModelHelper : TBeanSerializer<CouponPromotionOrderGoodsModel>
	{
		
		public static CouponPromotionOrderGoodsModelHelper OBJ = new CouponPromotionOrderGoodsModelHelper();
		
		public static CouponPromotionOrderGoodsModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponPromotionOrderGoodsModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsId(value);
					}
					
					
					
					
					
					if ("sizeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSizeId(value);
					}
					
					
					
					
					
					if ("goodsNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetGoodsNumber(value);
					}
					
					
					
					
					
					if ("favAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetFavAmount(value);
					}
					
					
					
					
					
					if ("totalFavAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTotalFavAmount(value);
					}
					
					
					
					
					
					if ("couponSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCouponSn(value);
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
		
		
		public void Write(CouponPromotionOrderGoodsModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goodsId can not be null!");
			}
			
			
			if(structs.GetSizeId() != null) {
				
				oprot.WriteFieldBegin("sizeId");
				oprot.WriteString(structs.GetSizeId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sizeId can not be null!");
			}
			
			
			if(structs.GetGoodsNumber() != null) {
				
				oprot.WriteFieldBegin("goodsNumber");
				oprot.WriteDouble((double)structs.GetGoodsNumber());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goodsNumber can not be null!");
			}
			
			
			if(structs.GetFavAmount() != null) {
				
				oprot.WriteFieldBegin("favAmount");
				oprot.WriteDouble((double)structs.GetFavAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("favAmount can not be null!");
			}
			
			
			if(structs.GetTotalFavAmount() != null) {
				
				oprot.WriteFieldBegin("totalFavAmount");
				oprot.WriteDouble((double)structs.GetTotalFavAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("totalFavAmount can not be null!");
			}
			
			
			if(structs.GetCouponSn() != null) {
				
				oprot.WriteFieldBegin("couponSn");
				oprot.WriteString(structs.GetCouponSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponPromotionOrderGoodsModel bean){
			
			
		}
		
	}
	
}