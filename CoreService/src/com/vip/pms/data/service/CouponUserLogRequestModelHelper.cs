using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class CouponUserLogRequestModelHelper : TBeanSerializer<CouponUserLogRequestModel>
	{
		
		public static CouponUserLogRequestModelHelper OBJ = new CouponUserLogRequestModelHelper();
		
		public static CouponUserLogRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CouponUserLogRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("couponSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCouponSn(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("orderAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOrderAmount(value);
					}
					
					
					
					
					
					if ("orderFav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetOrderFav(value);
					}
					
					
					
					
					
					if ("refIdType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetRefIdType(value);
					}
					
					
					
					
					
					if ("refId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetRefId(value);
					}
					
					
					
					
					
					if ("orderGoodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.CouponPromotionOrderGoodsModel> value;
						
						value = new List<com.vip.pms.data.service.CouponPromotionOrderGoodsModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.CouponPromotionOrderGoodsModel elem0;
								
								elem0 = new com.vip.pms.data.service.CouponPromotionOrderGoodsModel();
								com.vip.pms.data.service.CouponPromotionOrderGoodsModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderGoodsList(value);
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
		
		
		public void Write(CouponUserLogRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userId can not be null!");
			}
			
			
			if(structs.GetCouponSn() != null) {
				
				oprot.WriteFieldBegin("couponSn");
				oprot.WriteString(structs.GetCouponSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponSn can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetOrderAmount() != null) {
				
				oprot.WriteFieldBegin("orderAmount");
				oprot.WriteDouble((double)structs.GetOrderAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderAmount can not be null!");
			}
			
			
			if(structs.GetOrderFav() != null) {
				
				oprot.WriteFieldBegin("orderFav");
				oprot.WriteDouble((double)structs.GetOrderFav());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderFav can not be null!");
			}
			
			
			if(structs.GetRefIdType() != null) {
				
				oprot.WriteFieldBegin("refIdType");
				oprot.WriteByte((byte)structs.GetRefIdType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refIdType can not be null!");
			}
			
			
			if(structs.GetRefId() != null) {
				
				oprot.WriteFieldBegin("refId");
				oprot.WriteI64((long)structs.GetRefId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refId can not be null!");
			}
			
			
			if(structs.GetOrderGoodsList() != null) {
				
				oprot.WriteFieldBegin("orderGoodsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.CouponPromotionOrderGoodsModel _item0 in structs.GetOrderGoodsList()){
					
					
					com.vip.pms.data.service.CouponPromotionOrderGoodsModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderGoodsList can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CouponUserLogRequestModel bean){
			
			
		}
		
	}
	
}