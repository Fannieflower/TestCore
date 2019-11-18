using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class InvoiceIssueResultMessageHelper : TBeanSerializer<InvoiceIssueResultMessage>
	{
		
		public static InvoiceIssueResultMessageHelper OBJ = new InvoiceIssueResultMessageHelper();
		
		public static InvoiceIssueResultMessageHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(InvoiceIssueResultMessage structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("errorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorCode(value);
					}
					
					
					
					
					
					if ("errorMessage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetErrorMessage(value);
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
		
		
		public void Write(InvoiceIssueResultMessage structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetErrorCode() != null) {
				
				oprot.WriteFieldBegin("errorCode");
				oprot.WriteString(structs.GetErrorCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("errorCode can not be null!");
			}
			
			
			if(structs.GetErrorMessage() != null) {
				
				oprot.WriteFieldBegin("errorMessage");
				oprot.WriteString(structs.GetErrorMessage());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("errorMessage can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(InvoiceIssueResultMessage bean){
			
			
		}
		
	}
	
}