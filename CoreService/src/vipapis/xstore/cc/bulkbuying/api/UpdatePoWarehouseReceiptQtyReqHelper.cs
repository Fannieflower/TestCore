using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class UpdatePoWarehouseReceiptQtyReqHelper : TBeanSerializer<UpdatePoWarehouseReceiptQtyReq>
	{
		
		public static UpdatePoWarehouseReceiptQtyReqHelper OBJ = new UpdatePoWarehouseReceiptQtyReqHelper();
		
		public static UpdatePoWarehouseReceiptQtyReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdatePoWarehouseReceiptQtyReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("warehouse_receipt_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_receipt_no(value);
					}
					
					
					
					
					
					if ("purchase_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_no(value);
					}
					
					
					
					
					
					if ("out_purchase_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOut_purchase_no(value);
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
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetReceive_time(value);
					}
					
					
					
					
					
					if ("receive_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty> value;
						
						value = new List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty elem0;
								
								elem0 = new vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty();
								vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQtyHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetReceive_items(value);
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
		
		
		public void Write(UpdatePoWarehouseReceiptQtyReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWarehouse_receipt_no() != null) {
				
				oprot.WriteFieldBegin("warehouse_receipt_no");
				oprot.WriteString(structs.GetWarehouse_receipt_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse_receipt_no can not be null!");
			}
			
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchase_no can not be null!");
			}
			
			
			if(structs.GetOut_purchase_no() != null) {
				
				oprot.WriteFieldBegin("out_purchase_no");
				oprot.WriteString(structs.GetOut_purchase_no());
				
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
			
			else{
				throw new ArgumentException("receive_warehouse_code can not be null!");
			}
			
			
			if(structs.GetReceive_time() != null) {
				
				oprot.WriteFieldBegin("receive_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetReceive_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("receive_time can not be null!");
			}
			
			
			if(structs.GetReceive_items() != null) {
				
				oprot.WriteFieldBegin("receive_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty _item0 in structs.GetReceive_items()){
					
					
					vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQtyHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("receive_items can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UpdatePoWarehouseReceiptQtyReq bean){
			
			
		}
		
	}
	
}