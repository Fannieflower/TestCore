using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class SpuHelper : TBeanSerializer<Spu>
	{
		
		public static SpuHelper OBJ = new SpuHelper();
		
		public static SpuHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Spu structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("prod_spu_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProd_spu_id(value);
					}
					
					
					
					
					
					if ("spu_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetSpu_status(value);
					}
					
					
					
					
					
					if ("prod_sku_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.ProdSkuInfo> value;
						
						value = new List<com.vip.vop.cup.api.product.ProdSkuInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.ProdSkuInfo elem1;
								
								elem1 = new com.vip.vop.cup.api.product.ProdSkuInfo();
								com.vip.vop.cup.api.product.ProdSkuInfoHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetProd_sku_list(value);
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
		
		
		public void Write(Spu structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProd_spu_id() != null) {
				
				oprot.WriteFieldBegin("prod_spu_id");
				oprot.WriteString(structs.GetProd_spu_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSpu_status() != null) {
				
				oprot.WriteFieldBegin("spu_status");
				oprot.WriteBool((bool)structs.GetSpu_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProd_sku_list() != null) {
				
				oprot.WriteFieldBegin("prod_sku_list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.product.ProdSkuInfo _item0 in structs.GetProd_sku_list()){
					
					
					com.vip.vop.cup.api.product.ProdSkuInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Spu bean){
			
			
		}
		
	}
	
}