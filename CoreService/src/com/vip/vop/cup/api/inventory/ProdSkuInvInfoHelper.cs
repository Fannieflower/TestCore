using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.inventory{
	
	
	
	public class ProdSkuInvInfoHelper : TBeanSerializer<ProdSkuInvInfo>
	{
		
		public static ProdSkuInvInfoHelper OBJ = new ProdSkuInvInfoHelper();
		
		public static ProdSkuInvInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProdSkuInvInfo structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("inventory_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetInventory_info(value);
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
		
		
		public void Write(ProdSkuInvInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetProd_sku_id() != null) {
				
				oprot.WriteFieldBegin("prod_sku_id");
				oprot.WriteString(structs.GetProd_sku_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInventory_info() != null) {
				
				oprot.WriteFieldBegin("inventory_info");
				oprot.WriteI32((int)structs.GetInventory_info()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProdSkuInvInfo bean){
			
			
		}
		
	}
	
}