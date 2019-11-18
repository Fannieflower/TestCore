using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class CategoryHelper : TBeanSerializer<Category>
	{
		
		public static CategoryHelper OBJ = new CategoryHelper();
		
		public static CategoryHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Category structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("category_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory_id(value);
					}
					
					
					
					
					
					if ("category_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCategory_name(value);
					}
					
					
					
					
					
					if ("children".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.Category> value;
						
						value = new List<com.vip.vop.cup.api.product.Category>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.Category elem0;
								
								elem0 = new com.vip.vop.cup.api.product.Category();
								com.vip.vop.cup.api.product.CategoryHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetChildren(value);
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
		
		
		public void Write(Category structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCategory_id() != null) {
				
				oprot.WriteFieldBegin("category_id");
				oprot.WriteString(structs.GetCategory_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCategory_name() != null) {
				
				oprot.WriteFieldBegin("category_name");
				oprot.WriteString(structs.GetCategory_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetChildren() != null) {
				
				oprot.WriteFieldBegin("children");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.product.Category _item0 in structs.GetChildren()){
					
					
					com.vip.vop.cup.api.product.CategoryHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Category bean){
			
			
		}
		
	}
	
}