using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class OrderItemHelper : TBeanSerializer<OrderItem>
	{
		
		public static OrderItemHelper OBJ = new OrderItemHelper();
		
		public static OrderItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderItem structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("shipAddress".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetShipAddress(value);
					}
					
					
					
					
					
					if ("provinceCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvinceCode(value);
					}
					
					
					
					
					
					if ("cityCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCityCode(value);
					}
					
					
					
					
					
					if ("reginCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReginCode(value);
					}
					
					
					
					
					
					if ("streetCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStreetCode(value);
					}
					
					
					
					
					
					if ("storeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetStoreId(value);
					}
					
					
					
					
					
					if ("provinceName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProvinceName(value);
					}
					
					
					
					
					
					if ("cityName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCityName(value);
					}
					
					
					
					
					
					if ("reginName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReginName(value);
					}
					
					
					
					
					
					if ("streetName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStreetName(value);
					}
					
					
					
					
					
					if ("orderDetails".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.order.OrderDetail> value;
						
						value = new List<com.vip.vop.vcloud.order.OrderDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.order.OrderDetail elem0;
								
								elem0 = new com.vip.vop.vcloud.order.OrderDetail();
								com.vip.vop.vcloud.order.OrderDetailHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderDetails(value);
					}
					
					
					
					
					
					if ("officalAccount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOfficalAccount(value);
					}
					
					
					
					
					
					if ("subOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubOrderSn(value);
					}
					
					
					
					
					
					if ("channelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetChannelId(value);
					}
					
					
					
					
					
					if ("findSrcState".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetFindSrcState(value);
					}
					
					
					
					
					
					if ("orderRemark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderRemark(value);
					}
					
					
					
					
					
					if ("isConfirmed".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsConfirmed(value);
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
		
		
		public void Write(OrderItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
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
			
			
			if(structs.GetShipAddress() != null) {
				
				oprot.WriteFieldBegin("shipAddress");
				oprot.WriteString(structs.GetShipAddress());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvinceCode() != null) {
				
				oprot.WriteFieldBegin("provinceCode");
				oprot.WriteString(structs.GetProvinceCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCityCode() != null) {
				
				oprot.WriteFieldBegin("cityCode");
				oprot.WriteString(structs.GetCityCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReginCode() != null) {
				
				oprot.WriteFieldBegin("reginCode");
				oprot.WriteString(structs.GetReginCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStreetCode() != null) {
				
				oprot.WriteFieldBegin("streetCode");
				oprot.WriteString(structs.GetStreetCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStoreId() != null) {
				
				oprot.WriteFieldBegin("storeId");
				oprot.WriteI64((long)structs.GetStoreId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProvinceName() != null) {
				
				oprot.WriteFieldBegin("provinceName");
				oprot.WriteString(structs.GetProvinceName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCityName() != null) {
				
				oprot.WriteFieldBegin("cityName");
				oprot.WriteString(structs.GetCityName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReginName() != null) {
				
				oprot.WriteFieldBegin("reginName");
				oprot.WriteString(structs.GetReginName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStreetName() != null) {
				
				oprot.WriteFieldBegin("streetName");
				oprot.WriteString(structs.GetStreetName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderDetails() != null) {
				
				oprot.WriteFieldBegin("orderDetails");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.order.OrderDetail _item0 in structs.GetOrderDetails()){
					
					
					com.vip.vop.vcloud.order.OrderDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOfficalAccount() != null) {
				
				oprot.WriteFieldBegin("officalAccount");
				oprot.WriteString(structs.GetOfficalAccount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSubOrderSn() != null) {
				
				oprot.WriteFieldBegin("subOrderSn");
				oprot.WriteString(structs.GetSubOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelId() != null) {
				
				oprot.WriteFieldBegin("channelId");
				oprot.WriteI64((long)structs.GetChannelId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFindSrcState() != null) {
				
				oprot.WriteFieldBegin("findSrcState");
				oprot.WriteI32((int)structs.GetFindSrcState()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrderRemark() != null) {
				
				oprot.WriteFieldBegin("orderRemark");
				oprot.WriteString(structs.GetOrderRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsConfirmed() != null) {
				
				oprot.WriteFieldBegin("isConfirmed");
				oprot.WriteI32((int)structs.GetIsConfirmed()); 
				
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
		
		
		public void Validate(OrderItem bean){
			
			
		}
		
	}
	
}