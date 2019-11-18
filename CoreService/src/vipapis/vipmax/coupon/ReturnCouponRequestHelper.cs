using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.coupon{
	
	
	
	public class ReturnCouponRequestHelper : TBeanSerializer<ReturnCouponRequest>
	{
		
		public static ReturnCouponRequestHelper OBJ = new ReturnCouponRequestHelper();
		
		public static ReturnCouponRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ReturnCouponRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("cancelled_skus".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.coupon.CancelledSkus> value;
						
						value = new List<vipapis.vipmax.coupon.CancelledSkus>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.coupon.CancelledSkus elem1;
								
								elem1 = new vipapis.vipmax.coupon.CancelledSkus();
								vipapis.vipmax.coupon.CancelledSkusHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetCancelled_skus(value);
					}
					
					
					
					
					
					if ("coupon_sns".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem3;
								elem3 = iprot.ReadString();
								
								value.Add(elem3);
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
		
		
		public void Write(ReturnCouponRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetCancelled_skus() != null) {
				
				oprot.WriteFieldBegin("cancelled_skus");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.coupon.CancelledSkus _item0 in structs.GetCancelled_skus()){
					
					
					vipapis.vipmax.coupon.CancelledSkusHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cancelled_skus can not be null!");
			}
			
			
			if(structs.GetCoupon_sns() != null) {
				
				oprot.WriteFieldBegin("coupon_sns");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetCoupon_sns()){
					
					oprot.WriteString(_item0);
					
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
		
		
		public void Validate(ReturnCouponRequest bean){
			
			
		}
		
	}
	
}