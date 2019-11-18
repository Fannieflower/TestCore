using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class MpInvoiceIssueResultRequestModelHelper : TBeanSerializer<MpInvoiceIssueResultRequestModel>
	{
		
		public static MpInvoiceIssueResultRequestModelHelper OBJ = new MpInvoiceIssueResultRequestModelHelper();
		
		public static MpInvoiceIssueResultRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(MpInvoiceIssueResultRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("serialNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSerialNo(value);
					}
					
					
					
					
					
					if ("trusteeshipPlatform".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTrusteeshipPlatform(value);
					}
					
					
					
					
					
					if ("resultType".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetResultType(value);
					}
					
					
					
					
					
					if ("mpInvoiceIssueResultModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.vei.service.MpInvoiceIssueResultModel value;
						
						value = new com.vip.fcs.vei.service.MpInvoiceIssueResultModel();
						com.vip.fcs.vei.service.MpInvoiceIssueResultModelHelper.getInstance().Read(value, iprot);
						
						structs.SetMpInvoiceIssueResultModel(value);
					}
					
					
					
					
					
					if ("invoiceIssueResultMessage".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.vei.service.InvoiceIssueResultMessage value;
						
						value = new com.vip.fcs.vei.service.InvoiceIssueResultMessage();
						com.vip.fcs.vei.service.InvoiceIssueResultMessageHelper.getInstance().Read(value, iprot);
						
						structs.SetInvoiceIssueResultMessage(value);
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
		
		
		public void Write(MpInvoiceIssueResultRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSerialNo() != null) {
				
				oprot.WriteFieldBegin("serialNo");
				oprot.WriteString(structs.GetSerialNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("serialNo can not be null!");
			}
			
			
			if(structs.GetTrusteeshipPlatform() != null) {
				
				oprot.WriteFieldBegin("trusteeshipPlatform");
				oprot.WriteString(structs.GetTrusteeshipPlatform());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("trusteeshipPlatform can not be null!");
			}
			
			
			if(structs.GetResultType() != null) {
				
				oprot.WriteFieldBegin("resultType");
				oprot.WriteString(structs.GetResultType());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("resultType can not be null!");
			}
			
			
			if(structs.GetMpInvoiceIssueResultModel() != null) {
				
				oprot.WriteFieldBegin("mpInvoiceIssueResultModel");
				
				com.vip.fcs.vei.service.MpInvoiceIssueResultModelHelper.getInstance().Write(structs.GetMpInvoiceIssueResultModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetInvoiceIssueResultMessage() != null) {
				
				oprot.WriteFieldBegin("invoiceIssueResultMessage");
				
				com.vip.fcs.vei.service.InvoiceIssueResultMessageHelper.getInstance().Write(structs.GetInvoiceIssueResultMessage(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(MpInvoiceIssueResultRequestModel bean){
			
			
		}
		
	}
	
}