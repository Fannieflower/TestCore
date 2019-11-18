using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class OrderCouponRequestHelper : TBeanSerializer<OrderCouponRequest>
	{
		
		public static OrderCouponRequestHelper OBJ = new OrderCouponRequestHelper();
		
		public static OrderCouponRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderCouponRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserId(value);
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
		
		
		public void Write(OrderCouponRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteString(structs.GetUserId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userId can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderCouponRequest bean){
			
			
		}
		
	}
	
}