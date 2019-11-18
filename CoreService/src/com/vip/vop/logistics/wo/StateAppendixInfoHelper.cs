using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class StateAppendixInfoHelper : TBeanSerializer<StateAppendixInfo>
	{
		
		public static StateAppendixInfoHelper OBJ = new StateAppendixInfoHelper();
		
		public static StateAppendixInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(StateAppendixInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("is_punish".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_punish(value);
					}
					
					
					
					
					
					if ("is_expedited".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_expedited(value);
					}
					
					
					
					
					
					if ("is_contacted".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool? value;
						value = iprot.ReadBool();
						
						structs.SetIs_contacted(value);
					}
					
					
					
					
					
					if ("urges_cnt".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUrges_cnt(value);
					}
					
					
					
					
					
					if ("reason".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReason(value);
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
		
		
		public void Write(StateAppendixInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetIs_punish() != null) {
				
				oprot.WriteFieldBegin("is_punish");
				oprot.WriteBool((bool)structs.GetIs_punish());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_expedited() != null) {
				
				oprot.WriteFieldBegin("is_expedited");
				oprot.WriteBool((bool)structs.GetIs_expedited());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_contacted() != null) {
				
				oprot.WriteFieldBegin("is_contacted");
				oprot.WriteBool((bool)structs.GetIs_contacted());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUrges_cnt() != null) {
				
				oprot.WriteFieldBegin("urges_cnt");
				oprot.WriteI32((int)structs.GetUrges_cnt()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("urges_cnt can not be null!");
			}
			
			
			if(structs.GetReason() != null) {
				
				oprot.WriteFieldBegin("reason");
				oprot.WriteString(structs.GetReason());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(StateAppendixInfo bean){
			
			
		}
		
	}
	
}