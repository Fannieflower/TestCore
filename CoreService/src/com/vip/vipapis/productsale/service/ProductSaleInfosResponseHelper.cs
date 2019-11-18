using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vipapis.productsale.service{
	
	
	
	public class ProductSaleInfosResponseHelper : TBeanSerializer<ProductSaleInfosResponse>
	{
		
		public static ProductSaleInfosResponseHelper OBJ = new ProductSaleInfosResponseHelper();
		
		public static ProductSaleInfosResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProductSaleInfosResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("productSaleInfos".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vipapis.productsale.service.ProductSaleInfo> value;
						
						value = new List<com.vip.vipapis.productsale.service.ProductSaleInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vipapis.productsale.service.ProductSaleInfo elem0;
								
								elem0 = new com.vip.vipapis.productsale.service.ProductSaleInfo();
								com.vip.vipapis.productsale.service.ProductSaleInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetProductSaleInfos(value);
					}
					
					
					
					
					
					if ("total".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
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
		
		
		public void Write(ProductSaleInfosResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProductSaleInfos() != null) {
				
				oprot.WriteFieldBegin("productSaleInfos");
				
				oprot.WriteListBegin();
				foreach(com.vip.vipapis.productsale.service.ProductSaleInfo _item0 in structs.GetProductSaleInfos()){
					
					
					com.vip.vipapis.productsale.service.ProductSaleInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotal() != null) {
				
				oprot.WriteFieldBegin("total");
				oprot.WriteI32((int)structs.GetTotal()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("total can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProductSaleInfosResponse bean){
			
			
		}
		
	}
	
}