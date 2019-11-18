using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.price.api{
	
	
	
	public class QueryStoreSalePriceChangeRespHelper : TBeanSerializer<QueryStoreSalePriceChangeResp>
	{
		
		public static QueryStoreSalePriceChangeRespHelper OBJ = new QueryStoreSalePriceChangeRespHelper();
		
		public static QueryStoreSalePriceChangeRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryStoreSalePriceChangeResp structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("prod_sale_price_change_items".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<vipapis.xstore.cc.price.api.ProdItemSalePrice> value;
						
						value = new List<vipapis.xstore.cc.price.api.ProdItemSalePrice>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								vipapis.xstore.cc.price.api.ProdItemSalePrice elem0;
								
								elem0 = new vipapis.xstore.cc.price.api.ProdItemSalePrice();
								vipapis.xstore.cc.price.api.ProdItemSalePriceHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetProd_sale_price_change_items(value);
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
		
		
		public void Write(QueryStoreSalePriceChangeResp structs, Protocol oprot){
			
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
			
			
			if(structs.GetProd_sale_price_change_items() != null) {
				
				oprot.WriteFieldBegin("prod_sale_price_change_items");
				
				oprot.WriteListBegin();
				foreach(vipapis.xstore.cc.price.api.ProdItemSalePrice _item0 in structs.GetProd_sale_price_change_items()){
					
					
					vipapis.xstore.cc.price.api.ProdItemSalePriceHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("prod_sale_price_change_items can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryStoreSalePriceChangeResp bean){
			
			
		}
		
	}
	
}