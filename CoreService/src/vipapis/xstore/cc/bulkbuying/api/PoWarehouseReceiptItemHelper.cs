using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class PoWarehouseReceiptItemHelper : TBeanSerializer<PoWarehouseReceiptItem>
	{
		
		public static PoWarehouseReceiptItemHelper OBJ = new PoWarehouseReceiptItemHelper();
		
		public static PoWarehouseReceiptItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoWarehouseReceiptItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("receive_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetReceive_quantity(value);
					}
					
					
					
					
					
					if ("cost_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetCost_price(value);
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
		
		
		public void Write(PoWarehouseReceiptItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteString(structs.GetId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			if(structs.GetReceive_quantity() != null) {
				
				oprot.WriteFieldBegin("receive_quantity");
				oprot.WriteI32((int)structs.GetReceive_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("receive_quantity can not be null!");
			}
			
			
			if(structs.GetCost_price() != null) {
				
				oprot.WriteFieldBegin("cost_price");
				oprot.WriteDouble((double)structs.GetCost_price());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cost_price can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoWarehouseReceiptItem bean){
			
			
		}
		
	}
	
}