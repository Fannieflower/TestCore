using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.price.api{
	
	
	
	public class QueryPricingReceiptRespHelper : TBeanSerializer<QueryPricingReceiptResp>
	{
		
		public static QueryPricingReceiptRespHelper OBJ = new QueryPricingReceiptRespHelper();
		
		public static QueryPricingReceiptRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryPricingReceiptResp structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("pricing_receipts".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.price.api.PricingReceipt> value;
						
						value = new List<vipapis.xstore.cc.price.api.PricingReceipt>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.price.api.PricingReceipt elem0;
								
								elem0 = new vipapis.xstore.cc.price.api.PricingReceipt();
								vipapis.xstore.cc.price.api.PricingReceiptHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetPricing_receipts(value);
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
		
		
		public void Write(QueryPricingReceiptResp structs, Protocol oprot){
			
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
			
			
			if(structs.GetPricing_receipts() != null) {
				
				oprot.WriteFieldBegin("pricing_receipts");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.price.api.PricingReceipt _item0 in structs.GetPricing_receipts()){
					
					
					vipapis.xstore.cc.price.api.PricingReceiptHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryPricingReceiptResp bean){
			
			
		}
		
	}
	
}