using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class UpdatePoRefundRealQtyReqHelper : TBeanSerializer<UpdatePoRefundRealQtyReq>
	{
		
		public static UpdatePoRefundRealQtyReqHelper OBJ = new UpdatePoRefundRealQtyReqHelper();
		
		public static UpdatePoRefundRealQtyReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdatePoRefundRealQtyReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("refund_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_no(value);
					}
					
					
					
					
					
					if ("refund_receipt_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_receipt_no(value);
					}
					
					
					
					
					
					if ("refund_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRefund_warehouse_code(value);
					}
					
					
					
					
					
					if ("refund_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetRefund_time(value);
					}
					
					
					
					
					
					if ("total_line_qty".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal_line_qty(value);
					}
					
					
					
					
					
					if ("refund_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem> value;
						
						value = new List<vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem elem0;
								
								elem0 = new vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem();
								vipapis.xstore.cc.bulkbuying.api.PoRefundRealItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRefund_items(value);
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
		
		
		public void Write(UpdatePoRefundRealQtyReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRefund_no() != null) {
				
				oprot.WriteFieldBegin("refund_no");
				oprot.WriteString(structs.GetRefund_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_no can not be null!");
			}
			
			
			if(structs.GetRefund_receipt_no() != null) {
				
				oprot.WriteFieldBegin("refund_receipt_no");
				oprot.WriteString(structs.GetRefund_receipt_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRefund_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("refund_warehouse_code");
				oprot.WriteString(structs.GetRefund_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_warehouse_code can not be null!");
			}
			
			
			if(structs.GetRefund_time() != null) {
				
				oprot.WriteFieldBegin("refund_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetRefund_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_time can not be null!");
			}
			
			
			if(structs.GetTotal_line_qty() != null) {
				
				oprot.WriteFieldBegin("total_line_qty");
				oprot.WriteI32((int)structs.GetTotal_line_qty()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total_line_qty can not be null!");
			}
			
			
			if(structs.GetRefund_items() != null) {
				
				oprot.WriteFieldBegin("refund_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem _item0 in structs.GetRefund_items()){
					
					
					vipapis.xstore.cc.bulkbuying.api.PoRefundRealItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refund_items can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UpdatePoRefundRealQtyReq bean){
			
			
		}
		
	}
	
}