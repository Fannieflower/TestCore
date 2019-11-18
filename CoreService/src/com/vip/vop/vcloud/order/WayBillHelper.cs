using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class WayBillHelper : TBeanSerializer<WayBill>
	{
		
		public static WayBillHelper OBJ = new WayBillHelper();
		
		public static WayBillHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WayBill structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("expressNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpressNo(value);
					}
					
					
					
					
					
					if ("deliveryTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetDeliveryTime(value);
					}
					
					
					
					
					
					if ("skuItems".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.order.SkuItem> value;
						
						value = new List<com.vip.vop.vcloud.order.SkuItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.order.SkuItem elem0;
								
								elem0 = new com.vip.vop.vcloud.order.SkuItem();
								com.vip.vop.vcloud.order.SkuItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSkuItems(value);
					}
					
					
					
					
					
					if ("subOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubOrderSn(value);
					}
					
					
					
					
					
					if ("orderRemark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderRemark(value);
					}
					
					
					
					
					
					if ("isConfirmed".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsConfirmed(value);
					}
					
					
					
					
					
					if ("warehouseId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetWarehouseId(value);
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
		
		
		public void Write(WayBill structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpressNo() != null) {
				
				oprot.WriteFieldBegin("expressNo");
				oprot.WriteString(structs.GetExpressNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryTime() != null) {
				
				oprot.WriteFieldBegin("deliveryTime");
				oprot.WriteI64((long)structs.GetDeliveryTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkuItems() != null) {
				
				oprot.WriteFieldBegin("skuItems");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.order.SkuItem _item0 in structs.GetSkuItems()){
					
					
					com.vip.vop.vcloud.order.SkuItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubOrderSn() != null) {
				
				oprot.WriteFieldBegin("subOrderSn");
				oprot.WriteString(structs.GetSubOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderRemark() != null) {
				
				oprot.WriteFieldBegin("orderRemark");
				oprot.WriteString(structs.GetOrderRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsConfirmed() != null) {
				
				oprot.WriteFieldBegin("isConfirmed");
				oprot.WriteI32((int)structs.GetIsConfirmed()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouseId() != null) {
				
				oprot.WriteFieldBegin("warehouseId");
				oprot.WriteI64((long)structs.GetWarehouseId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WayBill bean){
			
			
		}
		
	}
	
}