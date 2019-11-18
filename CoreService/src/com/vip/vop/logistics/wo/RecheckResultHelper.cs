using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.wo{
	
	
	
	public class RecheckResultHelper : TBeanSerializer<RecheckResult>
	{
		
		public static RecheckResultHelper OBJ = new RecheckResultHelper();
		
		public static RecheckResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(RecheckResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("work_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWork_order_no(value);
					}
					
					
					
					
					
					if ("recheck_state".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRecheck_state(value);
					}
					
					
					
					
					
					if ("is_new".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIs_new(value);
					}
					
					
					
					
					
					if ("recheck_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetRecheck_time(value);
					}
					
					
					
					
					
					if ("expire_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetExpire_time(value);
					}
					
					
					
					
					
					if ("recheck_problem".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRecheck_problem(value);
					}
					
					
					
					
					
					if ("recheck_process_content".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetRecheck_process_content(value);
					}
					
					
					
					
					
					if ("create_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetCreate_time(value);
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
		
		
		public void Write(RecheckResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWork_order_no() != null) {
				
				oprot.WriteFieldBegin("work_order_no");
				oprot.WriteString(structs.GetWork_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecheck_state() != null) {
				
				oprot.WriteFieldBegin("recheck_state");
				oprot.WriteI32((int)structs.GetRecheck_state()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIs_new() != null) {
				
				oprot.WriteFieldBegin("is_new");
				oprot.WriteI32((int)structs.GetIs_new()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecheck_time() != null) {
				
				oprot.WriteFieldBegin("recheck_time");
				oprot.WriteI64((long)structs.GetRecheck_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetExpire_time() != null) {
				
				oprot.WriteFieldBegin("expire_time");
				oprot.WriteI64((long)structs.GetExpire_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecheck_problem() != null) {
				
				oprot.WriteFieldBegin("recheck_problem");
				oprot.WriteString(structs.GetRecheck_problem());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRecheck_process_content() != null) {
				
				oprot.WriteFieldBegin("recheck_process_content");
				oprot.WriteString(structs.GetRecheck_process_content());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCreate_time() != null) {
				
				oprot.WriteFieldBegin("create_time");
				oprot.WriteI64((long)structs.GetCreate_time()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(RecheckResult bean){
			
			
		}
		
	}
	
}