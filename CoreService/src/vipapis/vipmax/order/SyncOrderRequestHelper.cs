using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.order{
	
	
	
	public class SyncOrderRequestHelper : TBeanSerializer<SyncOrderRequest>
	{
		
		public static SyncOrderRequestHelper OBJ = new SyncOrderRequestHelper();
		
		public static SyncOrderRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SyncOrderRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("sales_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSales_warehouse(value);
					}
					
					
					
					
					
					if ("open_uid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpen_uid(value);
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
								
								vipapis.vipmax.order.VipmaxOrderDetail elem0;
								
								elem0 = new vipapis.vipmax.order.VipmaxOrderDetail();
								vipapis.vipmax.order.VipmaxOrderDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
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
		
		
		public void Write(SyncOrderRequest structs, Protocol oprot){
			
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
			
			
			if(structs.GetSales_warehouse() != null) {
				
				oprot.WriteFieldBegin("sales_warehouse");
				oprot.WriteString(structs.GetSales_warehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sales_warehouse can not be null!");
			}
			
			
			if(structs.GetOpen_uid() != null) {
				
				oprot.WriteFieldBegin("open_uid");
				oprot.WriteString(structs.GetOpen_uid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobile() != null) {
				
				oprot.WriteFieldBegin("mobile");
				oprot.WriteString(structs.GetMobile());
				
				oprot.WriteFieldEnd();
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
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SyncOrderRequest bean){
			
			
		}
		
	}
	
}