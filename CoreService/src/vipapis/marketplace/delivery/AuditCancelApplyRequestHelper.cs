using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.delivery{
	
	
	
	public class AuditCancelApplyRequestHelper : TBeanSerializer<AuditCancelApplyRequest>
	{
		
		public static AuditCancelApplyRequestHelper OBJ = new AuditCancelApplyRequestHelper();
		
		public static AuditCancelApplyRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(AuditCancelApplyRequest structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("apply_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApply_sn(value);
					}
					
					
					
					
					
					if ("audit_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetAudit_status(value);
					}
					
					
					
					
					
					if ("opinion".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpinion(value);
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
		
		
		public void Write(AuditCancelApplyRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetApply_sn() != null) {
				
				oprot.WriteFieldBegin("apply_sn");
				oprot.WriteString(structs.GetApply_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("apply_sn can not be null!");
			}
			
			
			if(structs.GetAudit_status() != null) {
				
				oprot.WriteFieldBegin("audit_status");
				oprot.WriteI32((int)structs.GetAudit_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("audit_status can not be null!");
			}
			
			
			if(structs.GetOpinion() != null) {
				
				oprot.WriteFieldBegin("opinion");
				oprot.WriteString(structs.GetOpinion());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(AuditCancelApplyRequest bean){
			
			
		}
		
	}
	
}