using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
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
					
					
					if ("channelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetChannelId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("orderTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetOrderTime(value);
					}
					
					
					
					
					
					if ("status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetStatus(value);
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
					
					
					
					
					
					if ("storeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetStoreId(value);
					}
					
					
					
					
					
					if ("subOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubOrderSn(value);
					}
					
					
					
					
					
					if ("expressCompany".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpressCompany(value);
					}
					
					
					
					
					
					if ("expressNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExpressNo(value);
					}
					
					
					
					
					
					if ("deliveryTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetDeliveryTime(value);
					}
					
					
					
					
					
					if ("orderSaleType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOrderSaleType(value);
					}
					
					
					
					
					
					if ("preOrderReleaseDate".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPreOrderReleaseDate(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
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
			
			if(structs.GetChannelId() != null) {
				
				oprot.WriteFieldBegin("channelId");
				oprot.WriteI64((long)structs.GetChannelId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderTime() != null) {
				
				oprot.WriteFieldBegin("orderTime");
				oprot.WriteI64((long)structs.GetOrderTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStatus() != null) {
				
				oprot.WriteFieldBegin("status");
				oprot.WriteI32((int)structs.GetStatus()); 
				
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
			
			
			if(structs.GetStoreId() != null) {
				
				oprot.WriteFieldBegin("storeId");
				oprot.WriteI64((long)structs.GetStoreId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubOrderSn() != null) {
				
				oprot.WriteFieldBegin("subOrderSn");
				oprot.WriteString(structs.GetSubOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpressCompany() != null) {
				
				oprot.WriteFieldBegin("expressCompany");
				oprot.WriteString(structs.GetExpressCompany());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpressNo() != null) {
				
				oprot.WriteFieldBegin("expressNo");
				oprot.WriteString(structs.GetExpressNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDeliveryTime() != null) {
				
				oprot.WriteFieldBegin("deliveryTime");
				oprot.WriteI64((long)structs.GetDeliveryTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderSaleType() != null) {
				
				oprot.WriteFieldBegin("orderSaleType");
				oprot.WriteI32((int)structs.GetOrderSaleType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPreOrderReleaseDate() != null) {
				
				oprot.WriteFieldBegin("preOrderReleaseDate");
				oprot.WriteI64((long)structs.GetPreOrderReleaseDate()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Order bean){
			
			
		}
		
	}
	
}