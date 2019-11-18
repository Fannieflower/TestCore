using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class PurchaseOrderItemHelper : TBeanSerializer<PurchaseOrderItem>
	{
		
		public static PurchaseOrderItemHelper OBJ = new PurchaseOrderItemHelper();
		
		public static PurchaseOrderItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PurchaseOrderItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("purchase_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_no(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("purchase_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPurchase_quantity(value);
					}
					
					
					
					
					
					if ("cost_price".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCost_price(value);
					}
					
					
					
					
					
					if ("barcode_origin".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode_origin(value);
					}
					
					
					
					
					
					if ("template_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetTemplate_type(value);
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
		
		
		public void Write(PurchaseOrderItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_quantity() != null) {
				
				oprot.WriteFieldBegin("purchase_quantity");
				oprot.WriteI32((int)structs.GetPurchase_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCost_price() != null) {
				
				oprot.WriteFieldBegin("cost_price");
				oprot.WriteString(structs.GetCost_price());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode_origin() != null) {
				
				oprot.WriteFieldBegin("barcode_origin");
				oprot.WriteString(structs.GetBarcode_origin());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTemplate_type() != null) {
				
				oprot.WriteFieldBegin("template_type");
				oprot.WriteByte((byte)structs.GetTemplate_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PurchaseOrderItem bean){
			
			
		}
		
	}
	
}