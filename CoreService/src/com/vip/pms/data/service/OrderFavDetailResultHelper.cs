using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class OrderFavDetailResultHelper : TBeanSerializer<OrderFavDetailResult>
	{
		
		public static OrderFavDetailResultHelper OBJ = new OrderFavDetailResultHelper();
		
		public static OrderFavDetailResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderFavDetailResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("couponSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCouponSn(value);
					}
					
					
					
					
					
					if ("orderNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderNo(value);
					}
					
					
					
					
					
					if ("supplierNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSupplierNo(value);
					}
					
					
					
					
					
					if ("orderFavDetails".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.OrderFavDetail> value;
						
						value = new List<com.vip.pms.data.service.OrderFavDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.OrderFavDetail elem0;
								
								elem0 = new com.vip.pms.data.service.OrderFavDetail();
								com.vip.pms.data.service.OrderFavDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderFavDetails(value);
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
		
		
		public void Write(OrderFavDetailResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCouponSn() != null) {
				
				oprot.WriteFieldBegin("couponSn");
				oprot.WriteString(structs.GetCouponSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("couponSn can not be null!");
			}
			
			
			if(structs.GetOrderNo() != null) {
				
				oprot.WriteFieldBegin("orderNo");
				oprot.WriteString(structs.GetOrderNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderNo can not be null!");
			}
			
			
			if(structs.GetSupplierNo() != null) {
				
				oprot.WriteFieldBegin("supplierNo");
				oprot.WriteString(structs.GetSupplierNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("supplierNo can not be null!");
			}
			
			
			if(structs.GetOrderFavDetails() != null) {
				
				oprot.WriteFieldBegin("orderFavDetails");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.OrderFavDetail _item0 in structs.GetOrderFavDetails()){
					
					
					com.vip.pms.data.service.OrderFavDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderFavDetailResult bean){
			
			
		}
		
	}
	
}