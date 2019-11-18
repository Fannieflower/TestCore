using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.delivery{
	
	
	
	public class GetCancelInfoRequestHelper : TBeanSerializer<GetCancelInfoRequest>
	{
		
		public static GetCancelInfoRequestHelper OBJ = new GetCancelInfoRequestHelper();
		
		public static GetCancelInfoRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetCancelInfoRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("audit_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetAudit_status(value);
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
		
		
		public void Write(GetCancelInfoRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrder_id() != null) {
				
				oprot.WriteFieldBegin("order_id");
				oprot.WriteString(structs.GetOrder_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetApply_sn() != null) {
				
				oprot.WriteFieldBegin("apply_sn");
				oprot.WriteString(structs.GetApply_sn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAudit_status() != null) {
				
				oprot.WriteFieldBegin("audit_status");
				oprot.WriteI32((int)structs.GetAudit_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetCancelInfoRequest bean){
			
			
		}
		
	}
	
}