using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	public class WarehouseInventoryForceHoldHelper : TBeanSerializer<WarehouseInventoryForceHold>
	{
		
		public static WarehouseInventoryForceHoldHelper OBJ = new WarehouseInventoryForceHoldHelper();
		
		public static WarehouseInventoryForceHoldHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WarehouseInventoryForceHold structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("warehouseId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetWarehouseId(value);
					}
					
					
					
					
					
					if ("skuQuantityMap".Equals(schemeField.Trim())){
						
						needSkip = false;
						Dictionary<long?, int?> value;
						
						value = new Dictionary<long?, int?>();
						iprot.ReadMapBegin();
						while(true){
							
							try{
								
								long _key0;
								int _val0;
								_key0 = iprot.ReadI64(); 
								
								_val0 = iprot.ReadI32(); 
								
								value.Add(_key0, _val0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadMapEnd();
						
						structs.SetSkuQuantityMap(value);
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
		
		
		public void Write(WarehouseInventoryForceHold structs, Protocol oprot){
			
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
			
			
			if(structs.GetWarehouseId() != null) {
				
				oprot.WriteFieldBegin("warehouseId");
				oprot.WriteI64((long)structs.GetWarehouseId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkuQuantityMap() != null) {
				
				oprot.WriteFieldBegin("skuQuantityMap");
				
				oprot.WriteMapBegin();
				foreach(KeyValuePair< long?, int? > _ir0 in structs.GetSkuQuantityMap()){
					
					long? _key0 = _ir0.Key;
					int? _value0 = _ir0.Value;
					oprot.WriteI64((long)_key0); 
					
					oprot.WriteI32((int)_value0); 
					
				}
				
				oprot.WriteMapEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("skuQuantityMap can not be null!");
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
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WarehouseInventoryForceHold bean){
			
			
		}
		
	}
	
}