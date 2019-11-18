using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class OrderQueryRequestHelper : TBeanSerializer<OrderQueryRequest>
	{
		
		public static OrderQueryRequestHelper OBJ = new OrderQueryRequestHelper();
		
		public static OrderQueryRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderQueryRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("partnerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPartnerId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("channelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetChannelId(value);
					}
					
					
					
					
					
					if ("warehouses".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<long?> value;
						
						value = new List<long?>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								long elem1;
								elem1 = iprot.ReadI64(); 
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetWarehouses(value);
					}
					
					
					
					
					
					if ("recipients".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRecipients(value);
					}
					
					
					
					
					
					if ("mobileNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMobileNo(value);
					}
					
					
					
					
					
					if ("expressNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpressNo(value);
					}
					
					
					
					
					
					if ("startTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetStartTime(value);
					}
					
					
					
					
					
					if ("endTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetEndTime(value);
					}
					
					
					
					
					
					if ("orderType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderType(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("includeOrderDetail".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIncludeOrderDetail(value);
					}
					
					
					
					
					
					if ("orderSaleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderSaleType(value);
					}
					
					
					
					
					
					if ("startDeliveryTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetStartDeliveryTime(value);
					}
					
					
					
					
					
					if ("endDeliveryTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetEndDeliveryTime(value);
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
		
		
		public void Write(OrderQueryRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPartnerId() != null) {
				
				oprot.WriteFieldBegin("partnerId");
				oprot.WriteI64((long)structs.GetPartnerId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelId() != null) {
				
				oprot.WriteFieldBegin("channelId");
				oprot.WriteI64((long)structs.GetChannelId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouses() != null) {
				
				oprot.WriteFieldBegin("warehouses");
				
				oprot.WriteListBegin();
				foreach(long _item0 in structs.GetWarehouses()){
					
					oprot.WriteI64((long)_item0); 
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecipients() != null) {
				
				oprot.WriteFieldBegin("recipients");
				oprot.WriteString(structs.GetRecipients());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMobileNo() != null) {
				
				oprot.WriteFieldBegin("mobileNo");
				oprot.WriteString(structs.GetMobileNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpressNo() != null) {
				
				oprot.WriteFieldBegin("expressNo");
				oprot.WriteString(structs.GetExpressNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStartTime() != null) {
				
				oprot.WriteFieldBegin("startTime");
				oprot.WriteI64((long)structs.GetStartTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndTime() != null) {
				
				oprot.WriteFieldBegin("endTime");
				oprot.WriteI64((long)structs.GetEndTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderType() != null) {
				
				oprot.WriteFieldBegin("orderType");
				oprot.WriteI32((int)structs.GetOrderType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIncludeOrderDetail() != null) {
				
				oprot.WriteFieldBegin("includeOrderDetail");
				oprot.WriteBool((bool)structs.GetIncludeOrderDetail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSaleType() != null) {
				
				oprot.WriteFieldBegin("orderSaleType");
				oprot.WriteI32((int)structs.GetOrderSaleType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStartDeliveryTime() != null) {
				
				oprot.WriteFieldBegin("startDeliveryTime");
				oprot.WriteI64((long)structs.GetStartDeliveryTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEndDeliveryTime() != null) {
				
				oprot.WriteFieldBegin("endDeliveryTime");
				oprot.WriteI64((long)structs.GetEndDeliveryTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderQueryRequest bean){
			
			
		}
		
	}
	
}