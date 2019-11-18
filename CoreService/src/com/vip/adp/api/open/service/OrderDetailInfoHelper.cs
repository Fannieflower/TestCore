using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class OrderDetailInfoHelper : TBeanSerializer<OrderDetailInfo>
	{
		
		public static OrderDetailInfoHelper OBJ = new OrderDetailInfoHelper();
		
		public static OrderDetailInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderDetailInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("goodsName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsName(value);
					}
					
					
					
					
					
					if ("goodsThumb".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodsThumb(value);
					}
					
					
					
					
					
					if ("goodsCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsCount(value);
					}
					
					
					
					
					
					if ("commissionTotalCost".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommissionTotalCost(value);
					}
					
					
					
					
					
					if ("commissionRate".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommissionRate(value);
					}
					
					
					
					
					
					if ("commission".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommission(value);
					}
					
					
					
					
					
					if ("commCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommCode(value);
					}
					
					
					
					
					
					if ("commName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommName(value);
					}
					
					
					
					
					
					if ("orderSource".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSource(value);
					}
					
					
					
					
					
					if ("afterSaleInfo".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.adp.api.open.service.AfterSaleDetailInfo> value;
						
						value = new List<com.vip.adp.api.open.service.AfterSaleDetailInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.adp.api.open.service.AfterSaleDetailInfo elem0;
								
								elem0 = new com.vip.adp.api.open.service.AfterSaleDetailInfo();
								com.vip.adp.api.open.service.AfterSaleDetailInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAfterSaleInfo(value);
					}
					
					
					
					
					
					if ("sizeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSizeId(value);
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
		
		
		public void Write(OrderDetailInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsId() != null) {
				
				oprot.WriteFieldBegin("goodsId");
				oprot.WriteString(structs.GetGoodsId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsName() != null) {
				
				oprot.WriteFieldBegin("goodsName");
				oprot.WriteString(structs.GetGoodsName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsThumb() != null) {
				
				oprot.WriteFieldBegin("goodsThumb");
				oprot.WriteString(structs.GetGoodsThumb());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsCount() != null) {
				
				oprot.WriteFieldBegin("goodsCount");
				oprot.WriteI32((int)structs.GetGoodsCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionTotalCost() != null) {
				
				oprot.WriteFieldBegin("commissionTotalCost");
				oprot.WriteString(structs.GetCommissionTotalCost());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionRate() != null) {
				
				oprot.WriteFieldBegin("commissionRate");
				oprot.WriteString(structs.GetCommissionRate());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommission() != null) {
				
				oprot.WriteFieldBegin("commission");
				oprot.WriteString(structs.GetCommission());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommCode() != null) {
				
				oprot.WriteFieldBegin("commCode");
				oprot.WriteString(structs.GetCommCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommName() != null) {
				
				oprot.WriteFieldBegin("commName");
				oprot.WriteString(structs.GetCommName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSource() != null) {
				
				oprot.WriteFieldBegin("orderSource");
				oprot.WriteString(structs.GetOrderSource());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAfterSaleInfo() != null) {
				
				oprot.WriteFieldBegin("afterSaleInfo");
				
				oprot.WriteListBegin();
				foreach(com.vip.adp.api.open.service.AfterSaleDetailInfo _item0 in structs.GetAfterSaleInfo()){
					
					
					com.vip.adp.api.open.service.AfterSaleDetailInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSizeId() != null) {
				
				oprot.WriteFieldBegin("sizeId");
				oprot.WriteString(structs.GetSizeId());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderDetailInfo bean){
			
			
		}
		
	}
	
}