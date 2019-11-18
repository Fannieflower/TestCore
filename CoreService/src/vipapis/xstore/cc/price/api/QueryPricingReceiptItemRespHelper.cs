using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.price.api{
	
	
	
	public class QueryPricingReceiptItemRespHelper : TBeanSerializer<QueryPricingReceiptItemResp>
	{
		
		public static QueryPricingReceiptItemRespHelper OBJ = new QueryPricingReceiptItemRespHelper();
		
		public static QueryPricingReceiptItemRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPricingReceiptItemResp structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("pricing_receipt_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.price.api.PricingReceiptItem> value;
						
						value = new List<vipapis.xstore.cc.price.api.PricingReceiptItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.price.api.PricingReceiptItem elem0;
								
								elem0 = new vipapis.xstore.cc.price.api.PricingReceiptItem();
								vipapis.xstore.cc.price.api.PricingReceiptItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPricing_receipt_items(value);
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
		
		
		public void Write(QueryPricingReceiptItemResp structs, Protocol oprot){
			
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
			
			
			if(structs.GetPricing_receipt_items() != null) {
				
				oprot.WriteFieldBegin("pricing_receipt_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.price.api.PricingReceiptItem _item0 in structs.GetPricing_receipt_items()){
					
					
					vipapis.xstore.cc.price.api.PricingReceiptItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPricingReceiptItemResp bean){
			
			
		}
		
	}
	
}