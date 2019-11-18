using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class PoWarehouseReceiptHelper : TBeanSerializer<PoWarehouseReceipt>
	{
		
		public static PoWarehouseReceiptHelper OBJ = new PoWarehouseReceiptHelper();
		
		public static PoWarehouseReceiptHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoWarehouseReceipt structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompany_code(value);
					}
					
					
					
					
					
					if ("warehouse_receipt_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_receipt_no(value);
					}
					
					
					
					
					
					if ("total_line_qty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal_line_qty(value);
					}
					
					
					
					
					
					if ("receive_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceive_warehouse_code(value);
					}
					
					
					
					
					
					if ("receive_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetReceive_time(value);
					}
					
					
					
					
					
					if ("purchase_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetPurchase_type(value);
					}
					
					
					
					
					
					if ("buyer_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBuyer_name(value);
					}
					
					
					
					
					
					if ("vendor_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendor_code(value);
					}
					
					
					
					
					
					if ("vendor_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendor_name(value);
					}
					
					
					
					
					
					if ("is_whale_warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetIs_whale_warehouse(value);
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
		
		
		public void Write(PoWarehouseReceipt structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCompany_code() != null) {
				
				oprot.WriteFieldBegin("company_code");
				oprot.WriteString(structs.GetCompany_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse_receipt_no() != null) {
				
				oprot.WriteFieldBegin("warehouse_receipt_no");
				oprot.WriteString(structs.GetWarehouse_receipt_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal_line_qty() != null) {
				
				oprot.WriteFieldBegin("total_line_qty");
				oprot.WriteI32((int)structs.GetTotal_line_qty()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total_line_qty can not be null!");
			}
			
			
			if(structs.GetReceive_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("receive_warehouse_code");
				oprot.WriteString(structs.GetReceive_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceive_time() != null) {
				
				oprot.WriteFieldBegin("receive_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetReceive_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_type() != null) {
				
				oprot.WriteFieldBegin("purchase_type");
				oprot.WriteByte((byte)structs.GetPurchase_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBuyer_name() != null) {
				
				oprot.WriteFieldBegin("buyer_name");
				oprot.WriteString(structs.GetBuyer_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_code() != null) {
				
				oprot.WriteFieldBegin("vendor_code");
				oprot.WriteString(structs.GetVendor_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendor_name() != null) {
				
				oprot.WriteFieldBegin("vendor_name");
				oprot.WriteString(structs.GetVendor_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_whale_warehouse() != null) {
				
				oprot.WriteFieldBegin("is_whale_warehouse");
				oprot.WriteByte((byte)structs.GetIs_whale_warehouse()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoWarehouseReceipt bean){
			
			
		}
		
	}
	
}