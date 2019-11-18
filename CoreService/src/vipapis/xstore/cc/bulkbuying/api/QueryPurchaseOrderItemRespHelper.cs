using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	public class QueryPurchaseOrderItemRespHelper : TBeanSerializer<QueryPurchaseOrderItemResp>
	{
		
		public static QueryPurchaseOrderItemRespHelper OBJ = new QueryPurchaseOrderItemRespHelper();
		
		public static QueryPurchaseOrderItemRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPurchaseOrderItemResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem> value;
						
						value = new List<vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem elem0;
								
								elem0 = new vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem();
								vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetItems(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotal(value);
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
		
		
		public void Write(QueryPurchaseOrderItemResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetItems() != null) {
				
				oprot.WriteFieldBegin("items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItem _item0 in structs.GetItems()){
					
					
					vipapis.xstore.cc.bulkbuying.api.PurchaseOrderItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPurchaseOrderItemResp bean){
			
			
		}
		
	}
	
}