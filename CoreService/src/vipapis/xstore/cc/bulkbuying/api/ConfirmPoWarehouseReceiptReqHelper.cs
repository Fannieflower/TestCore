using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class ConfirmPoWarehouseReceiptReqHelper : TBeanSerializer<ConfirmPoWarehouseReceiptReq>
	{
		
		public static ConfirmPoWarehouseReceiptReqHelper OBJ = new ConfirmPoWarehouseReceiptReqHelper();
		
		public static ConfirmPoWarehouseReceiptReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ConfirmPoWarehouseReceiptReq structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("outer_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOuter_no(value);
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
		
		
		public void Write(ConfirmPoWarehouseReceiptReq structs, Protocol oprot){
			
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
			
			
			if(structs.GetOuter_no() != null) {
				
				oprot.WriteFieldBegin("outer_no");
				oprot.WriteString(structs.GetOuter_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("outer_no can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ConfirmPoWarehouseReceiptReq bean){
			
			
		}
		
	}
	
}