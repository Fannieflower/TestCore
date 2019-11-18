using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.freight{
	
	
	
	public class FreightInfoHelper : TBeanSerializer<FreightInfo>
	{
		
		public static FreightInfoHelper OBJ = new FreightInfoHelper();
		
		public static FreightInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(FreightInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("key".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetKey(value);
					}
					
					
					
					
					
					if ("freight".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFreight(value);
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
		
		
		public void Write(FreightInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetKey() != null) {
				
				oprot.WriteFieldBegin("key");
				oprot.WriteString(structs.GetKey());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFreight() != null) {
				
				oprot.WriteFieldBegin("freight");
				oprot.WriteString(structs.GetFreight());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(FreightInfo bean){
			
			
		}
		
	}
	
}