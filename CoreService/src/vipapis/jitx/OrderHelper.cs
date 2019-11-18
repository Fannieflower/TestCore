using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class OrderHelper : TBeanSerializer<Order>
	{
		
		public static OrderHelper OBJ = new OrderHelper();
		
		public static OrderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Order structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("delivery_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDelivery_warehouse(value);
					}
					
					
					
					
					
					if ("add_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAdd_time(value);
					}
					
					
					
					
					
					if ("buyer".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer(value);
					}
					
					
					
					
					
					if ("buyer_address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_address(value);
					}
					
					
					
					
					
					if ("buyer_mobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_mobile(value);
					}
					
					
					
					
					
					if ("buyer_tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_tel(value);
					}
					
					
					
					
					
					if ("buyer_postcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_postcode(value);
					}
					
					
					
					
					
					if ("buyer_city".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_city(value);
					}
					
					
					
					
					
					if ("buyer_province".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_province(value);
					}
					
					
					
					
					
					if ("buyer_county".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_county(value);
					}
					
					
					
					
					
					if ("buyer_country_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_country_id(value);
					}
					
					
					
					
					
					if ("pay_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPay_type(value);
					}
					
					
					
					
					
					if ("cod_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCod_type(value);
					}
					
					
					
					
					
					if ("cod_money".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCod_money(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("transport_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_time(value);
					}
					
					
					
					
					
					if ("transport_day".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_day(value);
					}
					
					
					
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
					}
					
					
					
					
					
					if ("vendor_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendor_name(value);
					}
					
					
					
					
					
					if ("transport_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransport_no(value);
					}
					
					
					
					
					
					if ("carrier_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier_code(value);
					}
					
					
					
					
					
					if ("carrier_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCarrier_name(value);
					}
					
					
					
					
					
					if ("order_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_status(value);
					}
					
					
					
					
					
					if ("last_update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLast_update_time(value);
					}
					
					
					
					
					
					if ("package_received_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPackage_received_time(value);
					}
					
					
					
					
					
					if ("order_goods".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.OrderGood> value;
						
						value = new List<vipapis.jitx.OrderGood>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.OrderGood elem1;
								
								elem1 = new vipapis.jitx.OrderGood();
								vipapis.jitx.OrderGoodHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrder_goods(value);
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
		
		
		public void Write(Order structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_warehouse() != null) {
				
				oprot.WriteFieldBegin("delivery_warehouse");
				oprot.WriteString(structs.GetDelivery_warehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAdd_time() != null) {
				
				oprot.WriteFieldBegin("add_time");
				oprot.WriteString(structs.GetAdd_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer() != null) {
				
				oprot.WriteFieldBegin("buyer");
				oprot.WriteString(structs.GetBuyer());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_address() != null) {
				
				oprot.WriteFieldBegin("buyer_address");
				oprot.WriteString(structs.GetBuyer_address());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_mobile() != null) {
				
				oprot.WriteFieldBegin("buyer_mobile");
				oprot.WriteString(structs.GetBuyer_mobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_tel() != null) {
				
				oprot.WriteFieldBegin("buyer_tel");
				oprot.WriteString(structs.GetBuyer_tel());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_postcode() != null) {
				
				oprot.WriteFieldBegin("buyer_postcode");
				oprot.WriteString(structs.GetBuyer_postcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_city() != null) {
				
				oprot.WriteFieldBegin("buyer_city");
				oprot.WriteString(structs.GetBuyer_city());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_province() != null) {
				
				oprot.WriteFieldBegin("buyer_province");
				oprot.WriteString(structs.GetBuyer_province());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_county() != null) {
				
				oprot.WriteFieldBegin("buyer_county");
				oprot.WriteString(structs.GetBuyer_county());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_country_id() != null) {
				
				oprot.WriteFieldBegin("buyer_country_id");
				oprot.WriteString(structs.GetBuyer_country_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPay_type() != null) {
				
				oprot.WriteFieldBegin("pay_type");
				oprot.WriteString(structs.GetPay_type());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCod_type() != null) {
				
				oprot.WriteFieldBegin("cod_type");
				oprot.WriteString(structs.GetCod_type());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCod_money() != null) {
				
				oprot.WriteFieldBegin("cod_money");
				oprot.WriteString(structs.GetCod_money());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_time() != null) {
				
				oprot.WriteFieldBegin("transport_time");
				oprot.WriteString(structs.GetTransport_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_day() != null) {
				
				oprot.WriteFieldBegin("transport_day");
				oprot.WriteString(structs.GetTransport_day());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_name() != null) {
				
				oprot.WriteFieldBegin("vendor_name");
				oprot.WriteString(structs.GetVendor_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransport_no() != null) {
				
				oprot.WriteFieldBegin("transport_no");
				oprot.WriteString(structs.GetTransport_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrier_code() != null) {
				
				oprot.WriteFieldBegin("carrier_code");
				oprot.WriteString(structs.GetCarrier_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCarrier_name() != null) {
				
				oprot.WriteFieldBegin("carrier_name");
				oprot.WriteString(structs.GetCarrier_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_status() != null) {
				
				oprot.WriteFieldBegin("order_status");
				oprot.WriteString(structs.GetOrder_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLast_update_time() != null) {
				
				oprot.WriteFieldBegin("last_update_time");
				oprot.WriteString(structs.GetLast_update_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPackage_received_time() != null) {
				
				oprot.WriteFieldBegin("package_received_time");
				oprot.WriteString(structs.GetPackage_received_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_goods() != null) {
				
				oprot.WriteFieldBegin("order_goods");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.OrderGood _item0 in structs.GetOrder_goods()){
					
					
					vipapis.jitx.OrderGoodHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Order bean){
			
			
		}
		
	}
	
}