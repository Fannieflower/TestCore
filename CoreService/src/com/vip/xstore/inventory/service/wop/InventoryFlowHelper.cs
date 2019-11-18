using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.inventory.service.wop{
	
	
	
	public class InventoryFlowHelper : TBeanSerializer<InventoryFlow>
	{
		
		public static InventoryFlowHelper OBJ = new InventoryFlowHelper();
		
		public static InventoryFlowHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InventoryFlow structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transactionId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionId(value);
					}
					
					
					
					
					
					if ("actionType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActionType(value);
					}
					
					
					
					
					
					if ("warehouseCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouseCode(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("purchaseNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchaseNo(value);
					}
					
					
					
					
					
					if ("stockProps".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStockProps(value);
					}
					
					
					
					
					
					if ("disabilityLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDisabilityLevel(value);
					}
					
					
					
					
					
					if ("salableState".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetSalableState(value);
					}
					
					
					
					
					
					if ("quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetQuantity(value);
					}
					
					
					
					
					
					if ("actionTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActionTime(value);
					}
					
					
					
					
					
					if ("billNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBillNo(value);
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
		
		
		public void Write(InventoryFlow structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransactionId() != null) {
				
				oprot.WriteFieldBegin("transactionId");
				oprot.WriteString(structs.GetTransactionId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("transactionId can not be null!");
			}
			
			
			if(structs.GetActionType() != null) {
				
				oprot.WriteFieldBegin("actionType");
				oprot.WriteString(structs.GetActionType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actionType can not be null!");
			}
			
			
			if(structs.GetWarehouseCode() != null) {
				
				oprot.WriteFieldBegin("warehouseCode");
				oprot.WriteString(structs.GetWarehouseCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouseCode can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			if(structs.GetPurchaseNo() != null) {
				
				oprot.WriteFieldBegin("purchaseNo");
				oprot.WriteString(structs.GetPurchaseNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchaseNo can not be null!");
			}
			
			
			if(structs.GetStockProps() != null) {
				
				oprot.WriteFieldBegin("stockProps");
				oprot.WriteString(structs.GetStockProps());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("stockProps can not be null!");
			}
			
			
			if(structs.GetDisabilityLevel() != null) {
				
				oprot.WriteFieldBegin("disabilityLevel");
				oprot.WriteString(structs.GetDisabilityLevel());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("disabilityLevel can not be null!");
			}
			
			
			if(structs.GetSalableState() != null) {
				
				oprot.WriteFieldBegin("salableState");
				oprot.WriteI32((int)structs.GetSalableState()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("salableState can not be null!");
			}
			
			
			if(structs.GetQuantity() != null) {
				
				oprot.WriteFieldBegin("quantity");
				oprot.WriteI32((int)structs.GetQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("quantity can not be null!");
			}
			
			
			if(structs.GetActionTime() != null) {
				
				oprot.WriteFieldBegin("actionTime");
				oprot.WriteString(structs.GetActionTime());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actionTime can not be null!");
			}
			
			
			if(structs.GetBillNo() != null) {
				
				oprot.WriteFieldBegin("billNo");
				oprot.WriteString(structs.GetBillNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InventoryFlow bean){
			
			
		}
		
	}
	
}