using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vipapis.productsale.service{
	
	
	
	public class ProductSaleInfoLogHelper : TBeanSerializer<ProductSaleInfoLog>
	{
		
		public static ProductSaleInfoLogHelper OBJ = new ProductSaleInfoLogHelper();
		
		public static ProductSaleInfoLogHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProductSaleInfoLog structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("productSaleInfoId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetProductSaleInfoId(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
					}
					
					
					
					
					
					if ("department".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDepartment(value);
					}
					
					
					
					
					
					if ("fieldName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFieldName(value);
					}
					
					
					
					
					
					if ("oldValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOldValue(value);
					}
					
					
					
					
					
					if ("newValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNewValue(value);
					}
					
					
					
					
					
					if ("createTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreateTime(value);
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
		
		
		public void Write(ProductSaleInfoLog structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProductSaleInfoId() != null) {
				
				oprot.WriteFieldBegin("productSaleInfoId");
				oprot.WriteString(structs.GetProductSaleInfoId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDepartment() != null) {
				
				oprot.WriteFieldBegin("department");
				oprot.WriteString(structs.GetDepartment());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFieldName() != null) {
				
				oprot.WriteFieldBegin("fieldName");
				oprot.WriteString(structs.GetFieldName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOldValue() != null) {
				
				oprot.WriteFieldBegin("oldValue");
				oprot.WriteString(structs.GetOldValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNewValue() != null) {
				
				oprot.WriteFieldBegin("newValue");
				oprot.WriteString(structs.GetNewValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreateTime() != null) {
				
				oprot.WriteFieldBegin("createTime");
				oprot.WriteI64((long)structs.GetCreateTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProductSaleInfoLog bean){
			
			
		}
		
	}
	
}