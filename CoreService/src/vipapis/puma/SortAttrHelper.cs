using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.puma{
	
	
	
	public class SortAttrHelper : TBeanSerializer<SortAttr>
	{
		
		public static SortAttrHelper OBJ = new SortAttrHelper();
		
		public static SortAttrHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SortAttr structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("attr_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAttr_code(value);
					}
					
					
					
					
					
					if ("sort_rule".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSort_rule(value);
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
		
		
		public void Write(SortAttr structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAttr_code() != null) {
				
				oprot.WriteFieldBegin("attr_code");
				oprot.WriteI32((int)structs.GetAttr_code()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSort_rule() != null) {
				
				oprot.WriteFieldBegin("sort_rule");
				oprot.WriteI32((int)structs.GetSort_rule()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SortAttr bean){
			
			
		}
		
	}
	
}