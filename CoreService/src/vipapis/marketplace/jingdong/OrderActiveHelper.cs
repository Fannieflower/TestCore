using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.jingdong{
	
	
	
	public class OrderActiveHelper : TBeanSerializer<OrderActive>
	{
		
		public static OrderActiveHelper OBJ = new OrderActiveHelper();
		
		public static OrderActiveHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderActive structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_id(value);
					}
					
					
					
					
					
					if ("active_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetActive_type(value);
					}
					
					
					
					
					
					if ("active_field".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetActive_field(value);
					}
					
					
					
					
					
					if ("active_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActive_no(value);
					}
					
					
					
					
					
					if ("active_discount_money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActive_discount_money(value);
					}
					
					
					
					
					
					if ("goods_discount_details".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.jingdong.GoodsDiscountDetail> value;
						
						value = new List<vipapis.marketplace.jingdong.GoodsDiscountDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.jingdong.GoodsDiscountDetail elem0;
								
								elem0 = new vipapis.marketplace.jingdong.GoodsDiscountDetail();
								vipapis.marketplace.jingdong.GoodsDiscountDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoods_discount_details(value);
					}
					
					
					
					
					
					if ("prom_coupons".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.marketplace.jingdong.PromCouponInfo> value;
						
						value = new List<vipapis.marketplace.jingdong.PromCouponInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.marketplace.jingdong.PromCouponInfo elem2;
								
								elem2 = new vipapis.marketplace.jingdong.PromCouponInfo();
								vipapis.marketplace.jingdong.PromCouponInfoHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetProm_coupons(value);
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
		
		
		public void Write(OrderActive structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActive_type() != null) {
				
				oprot.WriteFieldBegin("active_type");
				oprot.WriteI32((int)structs.GetActive_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActive_field() != null) {
				
				oprot.WriteFieldBegin("active_field");
				oprot.WriteI32((int)structs.GetActive_field()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActive_no() != null) {
				
				oprot.WriteFieldBegin("active_no");
				oprot.WriteString(structs.GetActive_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActive_discount_money() != null) {
				
				oprot.WriteFieldBegin("active_discount_money");
				oprot.WriteString(structs.GetActive_discount_money());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoods_discount_details() != null) {
				
				oprot.WriteFieldBegin("goods_discount_details");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.jingdong.GoodsDiscountDetail _item0 in structs.GetGoods_discount_details()){
					
					
					vipapis.marketplace.jingdong.GoodsDiscountDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProm_coupons() != null) {
				
				oprot.WriteFieldBegin("prom_coupons");
				
				oprot.WriteListBegin();
				foreach(vipapis.marketplace.jingdong.PromCouponInfo _item0 in structs.GetProm_coupons()){
					
					
					vipapis.marketplace.jingdong.PromCouponInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderActive bean){
			
			
		}
		
	}
	
}