using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.order{
	
	
	
	public class VipmaxOrderHelper : TBeanSerializer<VipmaxOrder>
	{
		
		public static VipmaxOrderHelper OBJ = new VipmaxOrderHelper();
		
		public static VipmaxOrderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(VipmaxOrder structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("out_order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOut_order_sn(value);
					}
					
					
					
					
					
					if ("pay_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetPay_time(value);
					}
					
					
					
					
					
					if ("sales_warehouse_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						vipapis.vipmax.order.WarehouseInfo value;
						
						value = new vipapis.vipmax.order.WarehouseInfo();
						vipapis.vipmax.order.WarehouseInfoHelper.getInstance().Read(value, iprot);
						
						structs.SetSales_warehouse_info(value);
					}
					
					
					
					
					
					if ("user_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetUser_id(value);
					}
					
					
					
					
					
					if ("mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobile(value);
					}
					
					
					
					
					
					if ("order_detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.order.VipmaxOrderDetail> value;
						
						value = new List<vipapis.vipmax.order.VipmaxOrderDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.order.VipmaxOrderDetail elem1;
								
								elem1 = new vipapis.vipmax.order.VipmaxOrderDetail();
								vipapis.vipmax.order.VipmaxOrderDetailHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrder_detail(value);
					}
					
					
					
					
					
					if ("total_fee".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetTotal_fee(value);
					}
					
					
					
					
					
					if ("discount_fee".Equals(schemeField.Trim())){
						
						needSkip = false;
						double? value;
						value = iprot.ReadDouble();
						
						structs.SetDiscount_fee(value);
					}
					
					
					
					
					
					if ("payable_fee".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetPayable_fee(value);
					}
					
					
					
					
					
					if ("company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompany_code(value);
					}
					
					
					
					
					
					if ("order_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetOrder_status(value);
					}
					
					
					
					
					
					if ("refund_orders".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.vipmax.order.VipmaxRefundOrder> value;
						
						value = new List<vipapis.vipmax.order.VipmaxRefundOrder>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.vipmax.order.VipmaxRefundOrder elem3;
								
								elem3 = new vipapis.vipmax.order.VipmaxRefundOrder();
								vipapis.vipmax.order.VipmaxRefundOrderHelper.getInstance().Read(elem3, iprot);
								
								value.Add(elem3);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRefund_orders(value);
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
		
		
		public void Write(VipmaxOrder structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOut_order_sn() != null) {
				
				oprot.WriteFieldBegin("out_order_sn");
				oprot.WriteString(structs.GetOut_order_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("out_order_sn can not be null!");
			}
			
			
			if(structs.GetPay_time() != null) {
				
				oprot.WriteFieldBegin("pay_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetPay_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pay_time can not be null!");
			}
			
			
			if(structs.GetSales_warehouse_info() != null) {
				
				oprot.WriteFieldBegin("sales_warehouse_info");
				
				vipapis.vipmax.order.WarehouseInfoHelper.getInstance().Write(structs.GetSales_warehouse_info(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUser_id() != null) {
				
				oprot.WriteFieldBegin("user_id");
				oprot.WriteI64((long)structs.GetUser_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("user_id can not be null!");
			}
			
			
			if(structs.GetMobile() != null) {
				
				oprot.WriteFieldBegin("mobile");
				oprot.WriteString(structs.GetMobile());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("mobile can not be null!");
			}
			
			
			if(structs.GetOrder_detail() != null) {
				
				oprot.WriteFieldBegin("order_detail");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.order.VipmaxOrderDetail _item0 in structs.GetOrder_detail()){
					
					
					vipapis.vipmax.order.VipmaxOrderDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_detail can not be null!");
			}
			
			
			if(structs.GetTotal_fee() != null) {
				
				oprot.WriteFieldBegin("total_fee");
				oprot.WriteDouble((double)structs.GetTotal_fee());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total_fee can not be null!");
			}
			
			
			if(structs.GetDiscount_fee() != null) {
				
				oprot.WriteFieldBegin("discount_fee");
				oprot.WriteDouble((double)structs.GetDiscount_fee());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPayable_fee() != null) {
				
				oprot.WriteFieldBegin("payable_fee");
				oprot.WriteDouble((double)structs.GetPayable_fee());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payable_fee can not be null!");
			}
			
			
			if(structs.GetCompany_code() != null) {
				
				oprot.WriteFieldBegin("company_code");
				oprot.WriteString(structs.GetCompany_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("company_code can not be null!");
			}
			
			
			if(structs.GetOrder_status() != null) {
				
				oprot.WriteFieldBegin("order_status");
				oprot.WriteI32((int)structs.GetOrder_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_status can not be null!");
			}
			
			
			if(structs.GetRefund_orders() != null) {
				
				oprot.WriteFieldBegin("refund_orders");
				
				oprot.WriteListBegin();
				foreach(vipapis.vipmax.order.VipmaxRefundOrder _item0 in structs.GetRefund_orders()){
					
					
					vipapis.vipmax.order.VipmaxRefundOrderHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(VipmaxOrder bean){
			
			
		}
		
	}
	
}