using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class OrderStoreReqHelper : TBeanSerializer<OrderStoreReq>
	{
		
		public static OrderStoreReqHelper OBJ = new OrderStoreReqHelper();
		
		public static OrderStoreReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderStoreReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("channelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetChannelId(value);
					}
					
					
					
					
					
					if ("partnerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetPartnerId(value);
					}
					
					
					
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("subOrderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSubOrderSn(value);
					}
					
					
					
					
					
					if ("account".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAccount(value);
					}
					
					
					
					
					
					if ("remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRemark(value);
					}
					
					
					
					
					
					if ("appointToStoreId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetAppointToStoreId(value);
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
		
		
		public void Write(OrderStoreReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetChannelId() != null) {
				
				oprot.WriteFieldBegin("channelId");
				oprot.WriteI64((long)structs.GetChannelId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("channelId can not be null!");
			}
			
			
			if(structs.GetPartnerId() != null) {
				
				oprot.WriteFieldBegin("partnerId");
				oprot.WriteI64((long)structs.GetPartnerId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("partnerId can not be null!");
			}
			
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetSubOrderSn() != null) {
				
				oprot.WriteFieldBegin("subOrderSn");
				oprot.WriteString(structs.GetSubOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("subOrderSn can not be null!");
			}
			
			
			if(structs.GetAccount() != null) {
				
				oprot.WriteFieldBegin("account");
				oprot.WriteString(structs.GetAccount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("account can not be null!");
			}
			
			
			if(structs.GetRemark() != null) {
				
				oprot.WriteFieldBegin("remark");
				oprot.WriteString(structs.GetRemark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAppointToStoreId() != null) {
				
				oprot.WriteFieldBegin("appointToStoreId");
				oprot.WriteI64((long)structs.GetAppointToStoreId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderStoreReq bean){
			
			
		}
		
	}
	
}