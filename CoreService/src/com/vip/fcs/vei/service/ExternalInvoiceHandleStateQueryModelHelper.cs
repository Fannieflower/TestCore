using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class ExternalInvoiceHandleStateQueryModelHelper : TBeanSerializer<ExternalInvoiceHandleStateQueryModel>
	{
		
		public static ExternalInvoiceHandleStateQueryModelHelper OBJ = new ExternalInvoiceHandleStateQueryModelHelper();
		
		public static ExternalInvoiceHandleStateQueryModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ExternalInvoiceHandleStateQueryModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("seqNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSeqNo(value);
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
		
		
		public void Write(ExternalInvoiceHandleStateQueryModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSeqNo() != null) {
				
				oprot.WriteFieldBegin("seqNo");
				oprot.WriteString(structs.GetSeqNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("seqNo can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ExternalInvoiceHandleStateQueryModel bean){
			
			
		}
		
	}
	
}