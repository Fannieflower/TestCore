using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.model.sync{
	
	
	
	public class ActObjectRangeModelHelper : TBeanSerializer<ActObjectRangeModel>
	{
		
		public static ActObjectRangeModelHelper OBJ = new ActObjectRangeModelHelper();
		
		public static ActObjectRangeModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActObjectRangeModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("rangeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRangeId(value);
					}
					
					
					
					
					
					if ("rangeName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRangeName(value);
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
		
		
		public void Write(ActObjectRangeModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRangeId() != null) {
				
				oprot.WriteFieldBegin("rangeId");
				oprot.WriteString(structs.GetRangeId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("rangeId can not be null!");
			}
			
			
			if(structs.GetRangeName() != null) {
				
				oprot.WriteFieldBegin("rangeName");
				oprot.WriteString(structs.GetRangeName());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActObjectRangeModel bean){
			
			
		}
		
	}
	
}