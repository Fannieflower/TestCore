using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class QueryPoWarehouseReceiptItemRespHelper : TBeanSerializer<QueryPoWarehouseReceiptItemResp>
	{
		
		public static QueryPoWarehouseReceiptItemRespHelper OBJ = new QueryPoWarehouseReceiptItemRespHelper();
		
		public static QueryPoWarehouseReceiptItemRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPoWarehouseReceiptItemResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
					}
					
					
					
					
					
					if ("items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem> value;
						
						value = new List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem elem0;
								
								elem0 = new vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem();
								vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItems(value);
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
		
		
		public void Write(QueryPoWarehouseReceiptItemResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total can not be null!");
			}
			
			
			if(structs.GetItems() != null) {
				
				oprot.WriteFieldBegin("items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItem _item0 in structs.GetItems()){
					
					
					vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPoWarehouseReceiptItemResp bean){
			
			
		}
		
	}
	
}