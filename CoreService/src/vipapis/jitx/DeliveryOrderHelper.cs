using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.jitx{
	
	
	
	public class DeliveryOrderHelper : TBeanSerializer<DeliveryOrder>
	{
		
		public static DeliveryOrderHelper OBJ = new DeliveryOrderHelper();
		
		public static DeliveryOrderHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(DeliveryOrder structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("available_warehouses".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem0;
								elem0 = iprot.ReadString();
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetAvailable_warehouses(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus(value);
					}
					
					
					
					
					
					if ("status_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStatus_remark(value);
					}
					
					
					
					
					
					if ("buyer_address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_address(value);
					}
					
					
					
					
					
					if ("update_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdate_time(value);
					}
					
					
					
					
					
					if ("delivery_order_details".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.jitx.DeliveryOrderDetail> value;
						
						value = new List<vipapis.jitx.DeliveryOrderDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.jitx.DeliveryOrderDetail elem1;
								
								elem1 = new vipapis.jitx.DeliveryOrderDetail();
								vipapis.jitx.DeliveryOrderDetailHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetDelivery_order_details(value);
					}
					
					
					
					
					
					if ("vendor_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_id(value);
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
		
		
		public void Write(DeliveryOrder structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAvailable_warehouses() != null) {
				
				oprot.WriteFieldBegin("available_warehouses");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetAvailable_warehouses()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteString(structs.GetStatus());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus_remark() != null) {
				
				oprot.WriteFieldBegin("status_remark");
				oprot.WriteString(structs.GetStatus_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_address() != null) {
				
				oprot.WriteFieldBegin("buyer_address");
				oprot.WriteString(structs.GetBuyer_address());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdate_time() != null) {
				
				oprot.WriteFieldBegin("update_time");
				oprot.WriteString(structs.GetUpdate_time());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_order_details() != null) {
				
				oprot.WriteFieldBegin("delivery_order_details");
				
				oprot.WriteListBegin();
				foreach(vipapis.jitx.DeliveryOrderDetail _item0 in structs.GetDelivery_order_details()){
					
					
					vipapis.jitx.DeliveryOrderDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_id() != null) {
				
				oprot.WriteFieldBegin("vendor_id");
				oprot.WriteI32((int)structs.GetVendor_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(DeliveryOrder bean){
			
			
		}
		
	}
	
}