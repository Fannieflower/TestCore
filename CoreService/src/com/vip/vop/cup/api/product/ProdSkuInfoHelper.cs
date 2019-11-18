using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class ProdSkuInfoHelper : TBeanSerializer<ProdSkuInfo>
	{
		
		public static ProdSkuInfoHelper OBJ = new ProdSkuInfoHelper();
		
		public static ProdSkuInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdSkuInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("prod_sku_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProd_sku_id(value);
					}
					
					
					
					
					
					if ("sku_state".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetSku_state(value);
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
		
		
		public void Write(ProdSkuInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProd_sku_id() != null) {
				
				oprot.WriteFieldBegin("prod_sku_id");
				oprot.WriteString(structs.GetProd_sku_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSku_state() != null) {
				
				oprot.WriteFieldBegin("sku_state");
				oprot.WriteBool((bool)structs.GetSku_state());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdSkuInfo bean){
			
			
		}
		
	}
	
}