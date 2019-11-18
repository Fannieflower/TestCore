using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class SortFieldHelper : TBeanSerializer<SortField>
	{
		
		public static SortFieldHelper OBJ = new SortFieldHelper();
		
		public static SortFieldHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SortField structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("fieldName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFieldName(value);
					}
					
					
					
					
					
					if ("fieldDesc".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFieldDesc(value);
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
		
		
		public void Write(SortField structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetFieldName() != null) {
				
				oprot.WriteFieldBegin("fieldName");
				oprot.WriteString(structs.GetFieldName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFieldDesc() != null) {
				
				oprot.WriteFieldBegin("fieldDesc");
				oprot.WriteString(structs.GetFieldDesc());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SortField bean){
			
			
		}
		
	}
	
}