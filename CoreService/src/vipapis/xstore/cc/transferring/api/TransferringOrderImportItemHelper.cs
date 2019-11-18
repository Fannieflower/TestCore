using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringOrderImportItemHelper : TBeanSerializer<TransferringOrderImportItem>
	{
		
		public static TransferringOrderImportItemHelper OBJ = new TransferringOrderImportItemHelper();
		
		public static TransferringOrderImportItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringOrderImportItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("item_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetItem_id(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("planned_item_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPlanned_item_quantity(value);
					}
					
					
					
					
					
					if ("frozen_item_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetFrozen_item_quantity(value);
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
		
		
		public void Write(TransferringOrderImportItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItem_id() != null) {
				
				oprot.WriteFieldBegin("item_id");
				oprot.WriteI64((long)structs.GetItem_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPlanned_item_quantity() != null) {
				
				oprot.WriteFieldBegin("planned_item_quantity");
				oprot.WriteI32((int)structs.GetPlanned_item_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFrozen_item_quantity() != null) {
				
				oprot.WriteFieldBegin("frozen_item_quantity");
				oprot.WriteI32((int)structs.GetFrozen_item_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringOrderImportItem bean){
			
			
		}
		
	}
	
}