using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.coupon{
	
	
	
	public class SubmitCouponInfoRequestHelper : TBeanSerializer<SubmitCouponInfoRequest>
	{
		
		public static SubmitCouponInfoRequestHelper OBJ = new SubmitCouponInfoRequestHelper();
		
		public static SubmitCouponInfoRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SubmitCouponInfoRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("open_uid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpen_uid(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("order_skus".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.coupon.OrderSku> value;
						
						value = new List<vipapis.vipmax.coupon.OrderSku>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.coupon.OrderSku elem0;
								
								elem0 = new vipapis.vipmax.coupon.OrderSku();
								vipapis.vipmax.coupon.OrderSkuHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrder_skus(value);
					}
					
					
					
					
					
					if ("coupon_sns".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.coupon.CouponInfo> value;
						
						value = new List<vipapis.vipmax.coupon.CouponInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.coupon.CouponInfo elem2;
								
								elem2 = new vipapis.vipmax.coupon.CouponInfo();
								vipapis.vipmax.coupon.CouponInfoHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCoupon_sns(value);
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
		
		
		public void Write(SubmitCouponInfoRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOpen_uid() != null) {
				
				oprot.WriteFieldBegin("open_uid");
				oprot.WriteString(structs.GetOpen_uid());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("open_uid can not be null!");
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse can not be null!");
			}
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetOrder_skus() != null) {
				
				oprot.WriteFieldBegin("order_skus");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.coupon.OrderSku _item0 in structs.GetOrder_skus()){
					
					
					vipapis.vipmax.coupon.OrderSkuHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_skus can not be null!");
			}
			
			
			if(structs.GetCoupon_sns() != null) {
				
				oprot.WriteFieldBegin("coupon_sns");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.coupon.CouponInfo _item0 in structs.GetCoupon_sns()){
					
					
					vipapis.vipmax.coupon.CouponInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("coupon_sns can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SubmitCouponInfoRequest bean){
			
			
		}
		
	}
	
}