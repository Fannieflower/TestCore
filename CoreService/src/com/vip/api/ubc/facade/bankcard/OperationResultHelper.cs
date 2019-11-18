using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.ubc.facade.bankcard{
	
	
	
	public class OperationResultHelper : TBeanSerializer<OperationResult>
	{
		
		public static OperationResultHelper OBJ = new OperationResultHelper();
		
		public static OperationResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OperationResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("serialNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSerialNumber(value);
					}
					
					
					
					
					
					if ("resultCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultCode(value);
					}
					
					
					
					
					
					if ("resultMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultMsg(value);
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
		
		
		public void Write(OperationResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSerialNumber() != null) {
				
				oprot.WriteFieldBegin("serialNumber");
				oprot.WriteString(structs.GetSerialNumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResultCode() != null) {
				
				oprot.WriteFieldBegin("resultCode");
				oprot.WriteString(structs.GetResultCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResultMsg() != null) {
				
				oprot.WriteFieldBegin("resultMsg");
				oprot.WriteString(structs.GetResultMsg());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OperationResult bean){
			
			
		}
		
	}
	
}