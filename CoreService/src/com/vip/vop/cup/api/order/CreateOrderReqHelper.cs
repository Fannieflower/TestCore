using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.order{
	
	
	
	public class CreateOrderReqHelper : TBeanSerializer<CreateOrderReq>
	{
		
		public static CreateOrderReqHelper OBJ = new CreateOrderReqHelper();
		
		public static CreateOrderReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CreateOrderReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_basic_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.order.OrderBasicInfo value;
						
						value = new com.vip.vop.cup.api.order.OrderBasicInfo();
						com.vip.vop.cup.api.order.OrderBasicInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetOrder_basic_info(value);
					}
					
					
					
					
					
					if ("order_goods_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.order.OrderGoodsInfo> value;
						
						value = new List<com.vip.vop.cup.api.order.OrderGoodsInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.order.OrderGoodsInfo elem1;
								
								elem1 = new com.vip.vop.cup.api.order.OrderGoodsInfo();
								com.vip.vop.cup.api.order.OrderGoodsInfoHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrder_goods_list(value);
					}
					
					
					
					
					
					if ("order_consignee_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.order.OrderConsigneeInfo value;
						
						value = new com.vip.vop.cup.api.order.OrderConsigneeInfo();
						com.vip.vop.cup.api.order.OrderConsigneeInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetOrder_consignee_info(value);
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
		
		
		public void Write(CreateOrderReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_basic_info() != null) {
				
				oprot.WriteFieldBegin("order_basic_info");
				
				com.vip.vop.cup.api.order.OrderBasicInfoHelper.getInstance().Write(structs.GetOrder_basic_info(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_basic_info can not be null!");
			}
			
			
			if(structs.GetOrder_goods_list() != null) {
				
				oprot.WriteFieldBegin("order_goods_list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.order.OrderGoodsInfo _item0 in structs.GetOrder_goods_list()){
					
					
					com.vip.vop.cup.api.order.OrderGoodsInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_goods_list can not be null!");
			}
			
			
			if(structs.GetOrder_consignee_info() != null) {
				
				oprot.WriteFieldBegin("order_consignee_info");
				
				com.vip.vop.cup.api.order.OrderConsigneeInfoHelper.getInstance().Write(structs.GetOrder_consignee_info(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_consignee_info can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CreateOrderReq bean){
			
			
		}
		
	}
	
}