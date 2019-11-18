using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	public class WarehouseInventoryHoldHelper : TBeanSerializer<WarehouseInventoryHold>
	{
		
		public static WarehouseInventoryHoldHelper OBJ = new WarehouseInventoryHoldHelper();
		
		public static WarehouseInventoryHoldHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WarehouseInventoryHold structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransId(value);
					}
					
					
					
					
					
					if ("partnerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPartnerId(value);
					}
					
					
					
					
					
					if ("channelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetChannelId(value);
					}
					
					
					
					
					
					if ("vipCooperationNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVipCooperationNo(value);
					}
					
					
					
					
					
					if ("vipWarehouseCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipWarehouseCode(value);
					}
					
					
					
					
					
					if ("vipCooperationType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVipCooperationType(value);
					}
					
					
					
					
					
					if ("skuList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold> value;
						
						value = new List<com.vip.vop.vcloud.inventory.api.ChannelInventoryHold>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.inventory.api.ChannelInventoryHold elem0;
								
								elem0 = new com.vip.vop.vcloud.inventory.api.ChannelInventoryHold();
								com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSkuList(value);
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
		
		
		public void Write(WarehouseInventoryHold structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransId() != null) {
				
				oprot.WriteFieldBegin("transId");
				oprot.WriteString(structs.GetTransId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPartnerId() != null) {
				
				oprot.WriteFieldBegin("partnerId");
				oprot.WriteI64((long)structs.GetPartnerId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelId() != null) {
				
				oprot.WriteFieldBegin("channelId");
				oprot.WriteI64((long)structs.GetChannelId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipCooperationNo() != null) {
				
				oprot.WriteFieldBegin("vipCooperationNo");
				oprot.WriteI32((int)structs.GetVipCooperationNo()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipWarehouseCode() != null) {
				
				oprot.WriteFieldBegin("vipWarehouseCode");
				oprot.WriteString(structs.GetVipWarehouseCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipCooperationType() != null) {
				
				oprot.WriteFieldBegin("vipCooperationType");
				oprot.WriteI32((int)structs.GetVipCooperationType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkuList() != null) {
				
				oprot.WriteFieldBegin("skuList");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.inventory.api.ChannelInventoryHold _item0 in structs.GetSkuList()){
					
					
					com.vip.vop.vcloud.inventory.api.ChannelInventoryHoldHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WarehouseInventoryHold bean){
			
			
		}
		
	}
	
}