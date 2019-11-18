using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	public class ChannelInventoryReleaseHelper : TBeanSerializer<ChannelInventoryRelease>
	{
		
		public static ChannelInventoryReleaseHelper OBJ = new ChannelInventoryReleaseHelper();
		
		public static ChannelInventoryReleaseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ChannelInventoryRelease structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("holdTransId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHoldTransId(value);
					}
					
					
					
					
					
					if ("channelId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetChannelId(value);
					}
					
					
					
					
					
					if ("skuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSkuId(value);
					}
					
					
					
					
					
					if ("quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetQuantity(value);
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
					
					
					
					
					
					if ("warehouseId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetWarehouseId(value);
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
		
		
		public void Write(ChannelInventoryRelease structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransId() != null) {
				
				oprot.WriteFieldBegin("transId");
				oprot.WriteString(structs.GetTransId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHoldTransId() != null) {
				
				oprot.WriteFieldBegin("holdTransId");
				oprot.WriteString(structs.GetHoldTransId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChannelId() != null) {
				
				oprot.WriteFieldBegin("channelId");
				oprot.WriteI64((long)structs.GetChannelId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkuId() != null) {
				
				oprot.WriteFieldBegin("skuId");
				oprot.WriteI64((long)structs.GetSkuId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuantity() != null) {
				
				oprot.WriteFieldBegin("quantity");
				oprot.WriteI32((int)structs.GetQuantity()); 
				
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
			
			
			if(structs.GetWarehouseId() != null) {
				
				oprot.WriteFieldBegin("warehouseId");
				oprot.WriteI64((long)structs.GetWarehouseId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ChannelInventoryRelease bean){
			
			
		}
		
	}
	
}