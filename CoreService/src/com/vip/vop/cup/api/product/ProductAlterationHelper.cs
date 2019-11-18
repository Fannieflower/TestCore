using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class ProductAlterationHelper : TBeanSerializer<ProductAlteration>
	{
		
		public static ProductAlterationHelper OBJ = new ProductAlterationHelper();
		
		public static ProductAlterationHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProductAlteration structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("message_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMessage_id(value);
					}
					
					
					
					
					
					if ("prod_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProd_id(value);
					}
					
					
					
					
					
					if ("event_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.product.EventType? value;
						
						value = com.vip.vop.cup.api.product.EventTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetEvent_type(value);
					}
					
					
					
					
					
					if ("product_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.product.ProductType? value;
						
						value = com.vip.vop.cup.api.product.ProductTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetProduct_type(value);
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
		
		
		public void Write(ProductAlteration structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMessage_id() != null) {
				
				oprot.WriteFieldBegin("message_id");
				oprot.WriteI64((long)structs.GetMessage_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProd_id() != null) {
				
				oprot.WriteFieldBegin("prod_id");
				oprot.WriteString(structs.GetProd_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetEvent_type() != null) {
				
				oprot.WriteFieldBegin("event_type");
				oprot.WriteString(structs.GetEvent_type().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProduct_type() != null) {
				
				oprot.WriteFieldBegin("product_type");
				oprot.WriteString(structs.GetProduct_type().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProductAlteration bean){
			
			
		}
		
	}
	
}