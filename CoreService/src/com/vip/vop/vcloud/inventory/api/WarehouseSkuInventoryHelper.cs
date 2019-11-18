using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.inventory.api{
	
	
	
	public class WarehouseSkuInventoryHelper : TBeanSerializer<WarehouseSkuInventory>
	{
		
		public static WarehouseSkuInventoryHelper OBJ = new WarehouseSkuInventoryHelper();
		
		public static WarehouseSkuInventoryHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WarehouseSkuInventory structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("warehouseId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetWarehouseId(value);
					}
					
					
					
					
					
					if ("skuId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetSkuId(value);
					}
					
					
					
					
					
					if ("holdQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetHoldQuantity(value);
					}
					
					
					
					
					
					if ("quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetQuantity(value);
					}
					
					
					
					
					
					if ("totalQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalQuantity(value);
					}
					
					
					
					
					
					if ("leavings".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetLeavings(value);
					}
					
					
					
					
					
					if ("safeQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSafeQuantity(value);
					}
					
					
					
					
					
					if ("disabled".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDisabled(value);
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
		
		
		public void Write(WarehouseSkuInventory structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWarehouseId() != null) {
				
				oprot.WriteFieldBegin("warehouseId");
				oprot.WriteI64((long)structs.GetWarehouseId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSkuId() != null) {
				
				oprot.WriteFieldBegin("skuId");
				oprot.WriteI64((long)structs.GetSkuId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHoldQuantity() != null) {
				
				oprot.WriteFieldBegin("holdQuantity");
				oprot.WriteI32((int)structs.GetHoldQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetQuantity() != null) {
				
				oprot.WriteFieldBegin("quantity");
				oprot.WriteI32((int)structs.GetQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalQuantity() != null) {
				
				oprot.WriteFieldBegin("totalQuantity");
				oprot.WriteI32((int)structs.GetTotalQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLeavings() != null) {
				
				oprot.WriteFieldBegin("leavings");
				oprot.WriteI32((int)structs.GetLeavings()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSafeQuantity() != null) {
				
				oprot.WriteFieldBegin("safeQuantity");
				oprot.WriteI32((int)structs.GetSafeQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDisabled() != null) {
				
				oprot.WriteFieldBegin("disabled");
				oprot.WriteI32((int)structs.GetDisabled()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WarehouseSkuInventory bean){
			
			
		}
		
	}
	
}