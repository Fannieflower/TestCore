using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.oto{
	
	
	
	public class SpuIdAndSkuIdHelper : TBeanSerializer<SpuIdAndSkuId>
	{
		
		public static SpuIdAndSkuIdHelper OBJ = new SpuIdAndSkuIdHelper();
		
		public static SpuIdAndSkuIdHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SpuIdAndSkuId structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("vendor_Id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetVendor_Id(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("v_spu_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetV_spu_id(value);
					}
					
					
					
					
					
					if ("v_sku_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetV_sku_id(value);
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
		
		
		public void Write(SpuIdAndSkuId structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVendor_Id() != null) {
				
				oprot.WriteFieldBegin("vendor_Id");
				oprot.WriteI32((int)structs.GetVendor_Id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetV_spu_id() != null) {
				
				oprot.WriteFieldBegin("v_spu_id");
				oprot.WriteI64((long)structs.GetV_spu_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetV_sku_id() != null) {
				
				oprot.WriteFieldBegin("v_sku_id");
				oprot.WriteI64((long)structs.GetV_sku_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SpuIdAndSkuId bean){
			
			
		}
		
	}
	
}