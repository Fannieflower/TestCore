using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.product.pool.service{
	
	
	
	public class ProdValidateRespDTOHelper : TBeanSerializer<ProdValidateRespDTO>
	{
		
		public static ProdValidateRespDTOHelper OBJ = new ProdValidateRespDTOHelper();
		
		public static ProdValidateRespDTOHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdValidateRespDTO structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("companyCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompanyCode(value);
					}
					
					
					
					
					
					if ("businessType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetBusinessType(value);
					}
					
					
					
					
					
					if ("prodPoolSkus".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel> value;
						
						value = new List<com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel elem0;
								
								elem0 = new com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel();
								com.vip.xstore.cc.product.pool.service.ProdPoolSkuModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetProdPoolSkus(value);
					}
					
					
					
					
					
					if ("errSkus".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.xstore.cc.product.pool.service.ErrorSkuModel> value;
						
						value = new List<com.vip.xstore.cc.product.pool.service.ErrorSkuModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.xstore.cc.product.pool.service.ErrorSkuModel elem2;
								
								elem2 = new com.vip.xstore.cc.product.pool.service.ErrorSkuModel();
								com.vip.xstore.cc.product.pool.service.ErrorSkuModelHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetErrSkus(value);
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
		
		
		public void Write(ProdValidateRespDTO structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCompanyCode() != null) {
				
				oprot.WriteFieldBegin("companyCode");
				oprot.WriteString(structs.GetCompanyCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBusinessType() != null) {
				
				oprot.WriteFieldBegin("businessType");
				oprot.WriteI32((int)structs.GetBusinessType()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProdPoolSkus() != null) {
				
				oprot.WriteFieldBegin("prodPoolSkus");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.product.pool.service.ProdPoolSkuModel _item0 in structs.GetProdPoolSkus()){
					
					
					com.vip.xstore.cc.product.pool.service.ProdPoolSkuModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetErrSkus() != null) {
				
				oprot.WriteFieldBegin("errSkus");
				
				oprot.WriteListBegin();
				foreach(com.vip.xstore.cc.product.pool.service.ErrorSkuModel _item0 in structs.GetErrSkus()){
					
					
					com.vip.xstore.cc.product.pool.service.ErrorSkuModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdValidateRespDTO bean){
			
			
		}
		
	}
	
}