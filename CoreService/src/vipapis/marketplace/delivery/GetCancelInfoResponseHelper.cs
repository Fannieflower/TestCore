using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.delivery{
	
	
	
	public class GetCancelInfoResponseHelper : TBeanSerializer<GetCancelInfoResponse>
	{
		
		public static GetCancelInfoResponseHelper OBJ = new GetCancelInfoResponseHelper();
		
		public static GetCancelInfoResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetCancelInfoResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("order_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_id(value);
					}
					
					
					
					
					
					if ("apply_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApply_sn(value);
					}
					
					
					
					
					
					if ("reason_choice_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReason_choice_remark(value);
					}
					
					
					
					
					
					if ("reason_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReason_remark(value);
					}
					
					
					
					
					
					if ("operator_role_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator_role_name(value);
					}
					
					
					
					
					
					if ("audit_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAudit_status(value);
					}
					
					
					
					
					
					if ("audit_opinion".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAudit_opinion(value);
					}
					
					
					
					
					
					if ("order_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_status(value);
					}
					
					
					
					
					
					if ("is_system".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIs_system(value);
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
		
		
		public void Write(GetCancelInfoResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_id can not be null!");
			}
			
			
			if(structs.GetApply_sn() != null) {
				
				oprot.WriteFieldBegin("apply_sn");
				oprot.WriteString(structs.GetApply_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReason_choice_remark() != null) {
				
				oprot.WriteFieldBegin("reason_choice_remark");
				oprot.WriteString(structs.GetReason_choice_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReason_remark() != null) {
				
				oprot.WriteFieldBegin("reason_remark");
				oprot.WriteString(structs.GetReason_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator_role_name() != null) {
				
				oprot.WriteFieldBegin("operator_role_name");
				oprot.WriteString(structs.GetOperator_role_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAudit_status() != null) {
				
				oprot.WriteFieldBegin("audit_status");
				oprot.WriteI32((int)structs.GetAudit_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAudit_opinion() != null) {
				
				oprot.WriteFieldBegin("audit_opinion");
				oprot.WriteString(structs.GetAudit_opinion());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrder_status() != null) {
				
				oprot.WriteFieldBegin("order_status");
				oprot.WriteString(structs.GetOrder_status());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_system() != null) {
				
				oprot.WriteFieldBegin("is_system");
				oprot.WriteString(structs.GetIs_system());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetCancelInfoResponse bean){
			
			
		}
		
	}
	
}