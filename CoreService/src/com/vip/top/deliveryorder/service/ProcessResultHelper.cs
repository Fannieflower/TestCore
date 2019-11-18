using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.deliveryorder.service{
	
	
	
	public class ProcessResultHelper : TBeanSerializer<ProcessResult>
	{
		
		public static ProcessResultHelper OBJ = new ProcessResultHelper();
		
		public static ProcessResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProcessResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("tmsOrderId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTmsOrderId(value);
					}
					
					
					
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("needMatchCarrier".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetNeedMatchCarrier(value);
					}
					
					
					
					
					
					if ("isNew".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetIsNew(value);
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
		
		
		public void Write(ProcessResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTmsOrderId() != null) {
				
				oprot.WriteFieldBegin("tmsOrderId");
				oprot.WriteString(structs.GetTmsOrderId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetNeedMatchCarrier() != null) {
				
				oprot.WriteFieldBegin("needMatchCarrier");
				oprot.WriteBool((bool)structs.GetNeedMatchCarrier());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("needMatchCarrier can not be null!");
			}
			
			
			if(structs.GetIsNew() != null) {
				
				oprot.WriteFieldBegin("isNew");
				oprot.WriteBool((bool)structs.GetIsNew());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("isNew can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProcessResult bean){
			
			
		}
		
	}
	
}