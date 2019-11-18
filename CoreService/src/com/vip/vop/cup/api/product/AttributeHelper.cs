using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class AttributeHelper : TBeanSerializer<Attribute>
	{
		
		public static AttributeHelper OBJ = new AttributeHelper();
		
		public static AttributeHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Attribute structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("attribute_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAttribute_id(value);
					}
					
					
					
					
					
					if ("attribute_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAttribute_name(value);
					}
					
					
					
					
					
					if ("foreign_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetForeign_name(value);
					}
					
					
					
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.product.AttributeType? value;
						
						value = com.vip.vop.cup.api.product.AttributeTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("data_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.product.DataType? value;
						
						value = com.vip.vop.cup.api.product.DataTypeUtil.FindByName(iprot.ReadString());
						
						structs.SetData_type(value);
					}
					
					
					
					
					
					if ("flag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetFlag(value);
					}
					
					
					
					
					
					if ("values".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.product.AttributeValue> value;
						
						value = new List<com.vip.vop.cup.api.product.AttributeValue>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.product.AttributeValue elem1;
								
								elem1 = new com.vip.vop.cup.api.product.AttributeValue();
								com.vip.vop.cup.api.product.AttributeValueHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetValues(value);
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
		
		
		public void Write(Attribute structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAttribute_id() != null) {
				
				oprot.WriteFieldBegin("attribute_id");
				oprot.WriteI32((int)structs.GetAttribute_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAttribute_name() != null) {
				
				oprot.WriteFieldBegin("attribute_name");
				oprot.WriteString(structs.GetAttribute_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetForeign_name() != null) {
				
				oprot.WriteFieldBegin("foreign_name");
				oprot.WriteString(structs.GetForeign_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteString(structs.GetType().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetData_type() != null) {
				
				oprot.WriteFieldBegin("data_type");
				oprot.WriteString(structs.GetData_type().ToString());  
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFlag() != null) {
				
				oprot.WriteFieldBegin("flag");
				oprot.WriteByte((byte)structs.GetFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetValues() != null) {
				
				oprot.WriteFieldBegin("values");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.product.AttributeValue _item0 in structs.GetValues()){
					
					
					com.vip.vop.cup.api.product.AttributeValueHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Attribute bean){
			
			
		}
		
	}
	
}