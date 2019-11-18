using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.newretail{
	
	
	
	public class OrderDetailHelper : TBeanSerializer<OrderDetail>
	{
		
		public static OrderDetailHelper OBJ = new OrderDetailHelper();
		
		public static OrderDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderDetail structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("out_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOut_time(value);
					}
					
					
					
					
					
					if ("goods_infos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.newretail.GoodsInfo> value;
						
						value = new List<com.vip.vop.cup.api.newretail.GoodsInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.newretail.GoodsInfo elem1;
								
								elem1 = new com.vip.vop.cup.api.newretail.GoodsInfo();
								com.vip.vop.cup.api.newretail.GoodsInfoHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoods_infos(value);
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
		
		
		public void Write(OrderDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOut_time() != null) {
				
				oprot.WriteFieldBegin("out_time");
				oprot.WriteI64((long)structs.GetOut_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoods_infos() != null) {
				
				oprot.WriteFieldBegin("goods_infos");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.newretail.GoodsInfo _item0 in structs.GetGoods_infos()){
					
					
					com.vip.vop.cup.api.newretail.GoodsInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderDetail bean){
			
			
		}
		
	}
	
}