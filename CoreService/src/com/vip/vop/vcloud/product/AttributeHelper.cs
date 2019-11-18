using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.product{
	
	
	
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
					
					
					if ("attrId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAttrId(value);
					}
					
					
					
					
					
					if ("attrValue".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAttrValue(value);
					}
					
					
					
					
					
					if ("attrDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAttrDesc(value);
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
			
			if(structs.GetAttrId() != null) {
				
				oprot.WriteFieldBegin("attrId");
				oprot.WriteString(structs.GetAttrId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAttrValue() != null) {
				
				oprot.WriteFieldBegin("attrValue");
				oprot.WriteString(structs.GetAttrValue());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAttrDesc() != null) {
				
				oprot.WriteFieldBegin("attrDesc");
				oprot.WriteString(structs.GetAttrDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Attribute bean){
			
			
		}
		
	}
	
}