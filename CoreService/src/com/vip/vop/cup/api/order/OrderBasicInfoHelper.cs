using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.order{
	
	
	
	public class OrderBasicInfoHelper : TBeanSerializer<OrderBasicInfo>
	{
		
		public static OrderBasicInfoHelper OBJ = new OrderBasicInfoHelper();
		
		public static OrderBasicInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderBasicInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("parent_order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetParent_order_sn(value);
					}
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("user_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser_code(value);
					}
					
					
					
					
					
					if ("add_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAdd_time(value);
					}
					
					
					
					
					
					if ("pay_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPay_time(value);
					}
					
					
					
					
					
					if ("money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMoney(value);
					}
					
					
					
					
					
					if ("payer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPayer(value);
					}
					
					
					
					
					
					if ("seller_money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeller_money(value);
					}
					
					
					
					
					
					if ("carriage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarriage(value);
					}
					
					
					
					
					
					if ("transport_way".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTransport_way(value);
					}
					
					
					
					
					
					if ("transport_special_req".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_special_req(value);
					}
					
					
					
					
					
					if ("transport_day".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTransport_day(value);
					}
					
					
					
					
					
					if ("transport_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTransport_time(value);
					}
					
					
					
					
					
					if ("user_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser_remark(value);
					}
					
					
					
					
					
					if ("seller_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeller_remark(value);
					}
					
					
					
					
					
					if ("update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdate_time(value);
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
		
		
		public void Write(OrderBasicInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetParent_order_sn() != null) {
				
				oprot.WriteFieldBegin("parent_order_sn");
				oprot.WriteString(structs.GetParent_order_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetUser_code() != null) {
				
				oprot.WriteFieldBegin("user_code");
				oprot.WriteString(structs.GetUser_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("user_code can not be null!");
			}
			
			
			if(structs.GetAdd_time() != null) {
				
				oprot.WriteFieldBegin("add_time");
				oprot.WriteString(structs.GetAdd_time());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("add_time can not be null!");
			}
			
			
			if(structs.GetPay_time() != null) {
				
				oprot.WriteFieldBegin("pay_time");
				oprot.WriteString(structs.GetPay_time());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pay_time can not be null!");
			}
			
			
			if(structs.GetMoney() != null) {
				
				oprot.WriteFieldBegin("money");
				oprot.WriteString(structs.GetMoney());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("money can not be null!");
			}
			
			
			if(structs.GetPayer() != null) {
				
				oprot.WriteFieldBegin("payer");
				oprot.WriteString(structs.GetPayer());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("payer can not be null!");
			}
			
			
			if(structs.GetSeller_money() != null) {
				
				oprot.WriteFieldBegin("seller_money");
				oprot.WriteString(structs.GetSeller_money());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seller_money can not be null!");
			}
			
			
			if(structs.GetCarriage() != null) {
				
				oprot.WriteFieldBegin("carriage");
				oprot.WriteString(structs.GetCarriage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("carriage can not be null!");
			}
			
			
			if(structs.GetTransport_way() != null) {
				
				oprot.WriteFieldBegin("transport_way");
				oprot.WriteI32((int)structs.GetTransport_way()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transport_way can not be null!");
			}
			
			
			if(structs.GetTransport_special_req() != null) {
				
				oprot.WriteFieldBegin("transport_special_req");
				oprot.WriteString(structs.GetTransport_special_req());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_day() != null) {
				
				oprot.WriteFieldBegin("transport_day");
				oprot.WriteI32((int)structs.GetTransport_day()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transport_day can not be null!");
			}
			
			
			if(structs.GetTransport_time() != null) {
				
				oprot.WriteFieldBegin("transport_time");
				oprot.WriteI32((int)structs.GetTransport_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transport_time can not be null!");
			}
			
			
			if(structs.GetUser_remark() != null) {
				
				oprot.WriteFieldBegin("user_remark");
				oprot.WriteString(structs.GetUser_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSeller_remark() != null) {
				
				oprot.WriteFieldBegin("seller_remark");
				oprot.WriteString(structs.GetSeller_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate_time() != null) {
				
				oprot.WriteFieldBegin("update_time");
				oprot.WriteString(structs.GetUpdate_time());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("update_time can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderBasicInfo bean){
			
			
		}
		
	}
	
}