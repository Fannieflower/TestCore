using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	public class OutTpsResponseHelper : TBeanSerializer<OutTpsResponse>
	{
		
		public static OutTpsResponseHelper OBJ = new OutTpsResponseHelper();
		
		public static OutTpsResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OutTpsResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("resultCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetResultCode(value);
					}
					
					
					
					
					
					if ("resultMessage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultMessage(value);
					}
					
					
					
					
					
					if ("transactionId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransactionId(value);
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
		
		
		public void Write(OutTpsResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetResultCode() != null) {
				
				oprot.WriteFieldBegin("resultCode");
				oprot.WriteI32((int)structs.GetResultCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("resultCode can not be null!");
			}
			
			
			if(structs.GetResultMessage() != null) {
				
				oprot.WriteFieldBegin("resultMessage");
				oprot.WriteString(structs.GetResultMessage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("resultMessage can not be null!");
			}
			
			
			if(structs.GetTransactionId() != null) {
				
				oprot.WriteFieldBegin("transactionId");
				oprot.WriteString(structs.GetTransactionId());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OutTpsResponse bean){
			
			
		}
		
	}
	
}