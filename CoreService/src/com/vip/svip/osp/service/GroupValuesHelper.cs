using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GroupValuesHelper : TBeanSerializer<GroupValues>
	{
		
		public static GroupValuesHelper OBJ = new GroupValuesHelper();
		
		public static GroupValuesHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GroupValues structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("val".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVal(value);
					}
					
					
					
					
					
					if ("text".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetText(value);
					}
					
					
					
					
					
					if ("ext".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetExt(value);
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
		
		
		public void Write(GroupValues structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetVal() != null) {
				
				oprot.WriteFieldBegin("val");
				oprot.WriteString(structs.GetVal());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetText() != null) {
				
				oprot.WriteFieldBegin("text");
				oprot.WriteString(structs.GetText());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExt() != null) {
				
				oprot.WriteFieldBegin("ext");
				oprot.WriteString(structs.GetExt());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GroupValues bean){
			
			
		}
		
	}
	
}