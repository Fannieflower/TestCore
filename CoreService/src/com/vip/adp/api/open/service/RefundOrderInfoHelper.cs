using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class RefundOrderInfoHelper : TBeanSerializer<RefundOrderInfo>
	{
		
		public static RefundOrderInfoHelper OBJ = new RefundOrderInfoHelper();
		
		public static RefundOrderInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RefundOrderInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("applyTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetApplyTime(value);
					}
					
					
					
					
					
					if ("refundType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRefundType(value);
					}
					
					
					
					
					
					if ("commissionTotalCost".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommissionTotalCost(value);
					}
					
					
					
					
					
					if ("commission".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommission(value);
					}
					
					
					
					
					
					if ("goodsCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsCount(value);
					}
					
					
					
					
					
					if ("commissionEnterTxn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCommissionEnterTxn(value);
					}
					
					
					
					
					
					if ("commissionEnterTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCommissionEnterTime(value);
					}
					
					
					
					
					
					if ("commissionSettledTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCommissionSettledTime(value);
					}
					
					
					
					
					
					if ("refundOrderDetails".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.adp.api.open.service.RefundOrderDetail> value;
						
						value = new List<com.vip.adp.api.open.service.RefundOrderDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.adp.api.open.service.RefundOrderDetail elem0;
								
								elem0 = new com.vip.adp.api.open.service.RefundOrderDetail();
								com.vip.adp.api.open.service.RefundOrderDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRefundOrderDetails(value);
					}
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("orderTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOrderTime(value);
					}
					
					
					
					
					
					if ("originCommEnterTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOriginCommEnterTime(value);
					}
					
					
					
					
					
					if ("originCommEnterTxn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOriginCommEnterTxn(value);
					}
					
					
					
					
					
					if ("settled".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSettled(value);
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
		
		
		public void Write(RefundOrderInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApplyTime() != null) {
				
				oprot.WriteFieldBegin("applyTime");
				oprot.WriteI64((long)structs.GetApplyTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefundType() != null) {
				
				oprot.WriteFieldBegin("refundType");
				oprot.WriteI32((int)structs.GetRefundType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionTotalCost() != null) {
				
				oprot.WriteFieldBegin("commissionTotalCost");
				oprot.WriteString(structs.GetCommissionTotalCost());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommission() != null) {
				
				oprot.WriteFieldBegin("commission");
				oprot.WriteString(structs.GetCommission());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodsCount() != null) {
				
				oprot.WriteFieldBegin("goodsCount");
				oprot.WriteI32((int)structs.GetGoodsCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionEnterTxn() != null) {
				
				oprot.WriteFieldBegin("commissionEnterTxn");
				oprot.WriteString(structs.GetCommissionEnterTxn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionEnterTime() != null) {
				
				oprot.WriteFieldBegin("commissionEnterTime");
				oprot.WriteI64((long)structs.GetCommissionEnterTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCommissionSettledTime() != null) {
				
				oprot.WriteFieldBegin("commissionSettledTime");
				oprot.WriteI64((long)structs.GetCommissionSettledTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefundOrderDetails() != null) {
				
				oprot.WriteFieldBegin("refundOrderDetails");
				
				oprot.WriteListBegin();
				foreach(com.vip.adp.api.open.service.RefundOrderDetail _item0 in structs.GetRefundOrderDetails()){
					
					
					com.vip.adp.api.open.service.RefundOrderDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderTime() != null) {
				
				oprot.WriteFieldBegin("orderTime");
				oprot.WriteI64((long)structs.GetOrderTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginCommEnterTime() != null) {
				
				oprot.WriteFieldBegin("originCommEnterTime");
				oprot.WriteI64((long)structs.GetOriginCommEnterTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOriginCommEnterTxn() != null) {
				
				oprot.WriteFieldBegin("originCommEnterTxn");
				oprot.WriteString(structs.GetOriginCommEnterTxn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSettled() != null) {
				
				oprot.WriteFieldBegin("settled");
				oprot.WriteI32((int)structs.GetSettled()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RefundOrderInfo bean){
			
			
		}
		
	}
	
}