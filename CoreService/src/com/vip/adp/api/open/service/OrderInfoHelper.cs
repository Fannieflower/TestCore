using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class OrderInfoHelper : TBeanSerializer<OrderInfo>
	{
		
		public static OrderInfoHelper OBJ = new OrderInfoHelper();
		
		public static OrderInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("newCustomer".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetNewCustomer(value);
					}
					
					
					
					
					
					if ("channelTag".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetChannelTag(value);
					}
					
					
					
					
					
					if ("orderTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOrderTime(value);
					}
					
					
					
					
					
					if ("signTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSignTime(value);
					}
					
					
					
					
					
					if ("settledTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSettledTime(value);
					}
					
					
					
					
					
					if ("detailList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.adp.api.open.service.OrderDetailInfo> value;
						
						value = new List<com.vip.adp.api.open.service.OrderDetailInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.adp.api.open.service.OrderDetailInfo elem0;
								
								elem0 = new com.vip.adp.api.open.service.OrderDetailInfo();
								com.vip.adp.api.open.service.OrderDetailInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDetailList(value);
					}
					
					
					
					
					
					if ("lastUpdateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetLastUpdateTime(value);
					}
					
					
					
					
					
					if ("settled".Equals(schemeField.Trim())){
						
						needSkip = false;
						short? value;
						value = iprot.ReadI16(); 
						
						structs.SetSettled(value);
					}
					
					
					
					
					
					if ("selfBuy".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSelfBuy(value);
					}
					
					
					
					
					
					if ("orderSubStatusName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSubStatusName(value);
					}
					
					
					
					
					
					if ("commission".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommission(value);
					}
					
					
					
					
					
					if ("afterSaleChangeCommission".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAfterSaleChangeCommission(value);
					}
					
					
					
					
					
					if ("afterSaleChangeGoodsCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAfterSaleChangeGoodsCount(value);
					}
					
					
					
					
					
					if ("commissionEnterTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCommissionEnterTime(value);
					}
					
					
					
					
					
					if ("orderSource".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSource(value);
					}
					
					
					
					
					
					if ("pid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPid(value);
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
		
		
		public void Write(OrderInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI16((short)structs.GetStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNewCustomer() != null) {
				
				oprot.WriteFieldBegin("newCustomer");
				oprot.WriteI16((short)structs.GetNewCustomer()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelTag() != null) {
				
				oprot.WriteFieldBegin("channelTag");
				oprot.WriteString(structs.GetChannelTag());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderTime() != null) {
				
				oprot.WriteFieldBegin("orderTime");
				oprot.WriteI64((long)structs.GetOrderTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSignTime() != null) {
				
				oprot.WriteFieldBegin("signTime");
				oprot.WriteI64((long)structs.GetSignTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettledTime() != null) {
				
				oprot.WriteFieldBegin("settledTime");
				oprot.WriteI64((long)structs.GetSettledTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDetailList() != null) {
				
				oprot.WriteFieldBegin("detailList");
				
				oprot.WriteListBegin();
				foreach(com.vip.adp.api.open.service.OrderDetailInfo _item0 in structs.GetDetailList()){
					
					
					com.vip.adp.api.open.service.OrderDetailInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLastUpdateTime() != null) {
				
				oprot.WriteFieldBegin("lastUpdateTime");
				oprot.WriteI64((long)structs.GetLastUpdateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettled() != null) {
				
				oprot.WriteFieldBegin("settled");
				oprot.WriteI16((short)structs.GetSettled()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSelfBuy() != null) {
				
				oprot.WriteFieldBegin("selfBuy");
				oprot.WriteI32((int)structs.GetSelfBuy()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSubStatusName() != null) {
				
				oprot.WriteFieldBegin("orderSubStatusName");
				oprot.WriteString(structs.GetOrderSubStatusName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommission() != null) {
				
				oprot.WriteFieldBegin("commission");
				oprot.WriteString(structs.GetCommission());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleChangeCommission() != null) {
				
				oprot.WriteFieldBegin("afterSaleChangeCommission");
				oprot.WriteString(structs.GetAfterSaleChangeCommission());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleChangeGoodsCount() != null) {
				
				oprot.WriteFieldBegin("afterSaleChangeGoodsCount");
				oprot.WriteI32((int)structs.GetAfterSaleChangeGoodsCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionEnterTime() != null) {
				
				oprot.WriteFieldBegin("commissionEnterTime");
				oprot.WriteI64((long)structs.GetCommissionEnterTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSource() != null) {
				
				oprot.WriteFieldBegin("orderSource");
				oprot.WriteString(structs.GetOrderSource());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPid() != null) {
				
				oprot.WriteFieldBegin("pid");
				oprot.WriteString(structs.GetPid());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderInfo bean){
			
			
		}
		
	}
	
}