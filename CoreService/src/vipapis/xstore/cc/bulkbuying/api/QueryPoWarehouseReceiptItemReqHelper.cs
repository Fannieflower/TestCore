using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class QueryPoWarehouseReceiptItemReqHelper : TBeanSerializer<QueryPoWarehouseReceiptItemReq>
	{
		
		public static QueryPoWarehouseReceiptItemReqHelper OBJ = new QueryPoWarehouseReceiptItemReqHelper();
		
		public static QueryPoWarehouseReceiptItemReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPoWarehouseReceiptItemReq structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("warehouse_receipt_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_receipt_no(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("page_size".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPage_size(value);
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
		
		
		public void Write(QueryPoWarehouseReceiptItemReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchase_no can not be null!");
			}
			
			
			if(structs.GetWarehouse_receipt_no() != null) {
				
				oprot.WriteFieldBegin("warehouse_receipt_no");
				oprot.WriteString(structs.GetWarehouse_receipt_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse_receipt_no can not be null!");
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPage_size() != null) {
				
				oprot.WriteFieldBegin("page_size");
				oprot.WriteI32((int)structs.GetPage_size()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPoWarehouseReceiptItemReq bean){
			
			
		}
		
	}
	
}