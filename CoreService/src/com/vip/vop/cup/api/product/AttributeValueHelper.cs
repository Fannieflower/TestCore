using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.product{
	
	
	
	public class AttributeValueHelper : TBeanSerializer<AttributeValue>
	{
		
		public static AttributeValueHelper OBJ = new AttributeValueHelper();
		
		public static AttributeValueHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AttributeValue structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("option_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetOption_id(value);
					}
					
					
					
					
					
					if ("option_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOption_name(value);
					}
					
					
					
					
					
					if ("option_aliases".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOption_aliases(value);
					}
					
					
					
					
					
					if ("literal".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLiteral(value);
					}
					
					
					
					
					
					if ("flag".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetFlag(value);
					}
					
					
					
					
					
					if ("sort".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSort(value);
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
		
		
		public void Write(AttributeValue structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOption_id() != null) {
				
				oprot.WriteFieldBegin("option_id");
				oprot.WriteI32((int)structs.GetOption_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOption_name() != null) {
				
				oprot.WriteFieldBegin("option_name");
				oprot.WriteString(structs.GetOption_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOption_aliases() != null) {
				
				oprot.WriteFieldBegin("option_aliases");
				oprot.WriteString(structs.GetOption_aliases());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLiteral() != null) {
				
				oprot.WriteFieldBegin("literal");
				oprot.WriteString(structs.GetLiteral());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFlag() != null) {
				
				oprot.WriteFieldBegin("flag");
				oprot.WriteByte((byte)structs.GetFlag()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSort() != null) {
				
				oprot.WriteFieldBegin("sort");
				oprot.WriteI32((int)structs.GetSort()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AttributeValue bean){
			
			
		}
		
	}
	
}