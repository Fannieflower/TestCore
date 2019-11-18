using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class QueryPoWarehouseReceiptRespHelper : TBeanSerializer<QueryPoWarehouseReceiptResp>
	{
		
		public static QueryPoWarehouseReceiptRespHelper OBJ = new QueryPoWarehouseReceiptRespHelper();
		
		public static QueryPoWarehouseReceiptRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPoWarehouseReceiptResp structs, Protocol iprot){
			
			
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
						List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt> value;
						
						value = new List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt elem0;
								
								elem0 = new vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt();
								vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptHelper.getInstance().Read(elem0, iprot);
								
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
		
		
		public void Write(QueryPoWarehouseReceiptResp structs, Protocol oprot){
			
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
				foreach(vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceipt _item0 in structs.GetItems()){
					
					
					vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPoWarehouseReceiptResp bean){
			
			
		}
		
	}
	
}