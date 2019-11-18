using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vipapis.productsale.service{
	
	
	
	public class ProductSaleInfoModelResponseHelper : TBeanSerializer<ProductSaleInfoModelResponse>
	{
		
		public static ProductSaleInfoModelResponseHelper OBJ = new ProductSaleInfoModelResponseHelper();
		
		public static ProductSaleInfoModelResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProductSaleInfoModelResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("roductSaleInfoModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vipapis.productsale.service.ProductSaleInfoModel> value;
						
						value = new List<com.vip.vipapis.productsale.service.ProductSaleInfoModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vipapis.productsale.service.ProductSaleInfoModel elem0;
								
								elem0 = new com.vip.vipapis.productsale.service.ProductSaleInfoModel();
								com.vip.vipapis.productsale.service.ProductSaleInfoModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRoductSaleInfoModel(value);
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
		
		
		public void Write(ProductSaleInfoModelResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRoductSaleInfoModel() != null) {
				
				oprot.WriteFieldBegin("roductSaleInfoModel");
				
				oprot.WriteListBegin();
				foreach(com.vip.vipapis.productsale.service.ProductSaleInfoModel _item0 in structs.GetRoductSaleInfoModel()){
					
					
					com.vip.vipapis.productsale.service.ProductSaleInfoModelHelper.getInstance().Write(_item0, oprot);
					
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
		
		
		public void Validate(ProductSaleInfoModelResponse bean){
			
			
		}
		
	}
	
}