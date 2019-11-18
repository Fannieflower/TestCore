using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.aftersale{
	
	
	
	public class ReturnApplyHelper : TBeanSerializer<ReturnApply>
	{
		
		public static ReturnApplyHelper OBJ = new ReturnApplyHelper();
		
		public static ReturnApplyHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ReturnApply structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("apply_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetApply_id(value);
					}
					
					
					
					
					
					if ("order_sn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrder_sn(value);
					}
					
					
					
					
					
					if ("user_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser_code(value);
					}
					
					
					
					
					
					if ("add_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAdd_time(value);
					}
					
					
					
					
					
					if ("reason_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetReason_id(value);
					}
					
					
					
					
					
					if ("reason".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReason(value);
					}
					
					
					
					
					
					if ("user_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUser_remark(value);
					}
					
					
					
					
					
					if ("admin_remark".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAdmin_remark(value);
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
		
		
		public void Write(ReturnApply structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetApply_id() != null) {
				
				oprot.WriteFieldBegin("apply_id");
				oprot.WriteString(structs.GetApply_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("apply_id can not be null!");
			}
			
			
			if(structs.GetOrder_sn() != null) {
				
				oprot.WriteFieldBegin("order_sn");
				oprot.WriteString(structs.GetOrder_sn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("order_sn can not be null!");
			}
			
			
			if(structs.GetUser_code() != null) {
				
				oprot.WriteFieldBegin("user_code");
				oprot.WriteString(structs.GetUser_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("user_code can not be null!");
			}
			
			
			if(structs.GetAdd_time() != null) {
				
				oprot.WriteFieldBegin("add_time");
				oprot.WriteString(structs.GetAdd_time());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("add_time can not be null!");
			}
			
			
			if(structs.GetReason_id() != null) {
				
				oprot.WriteFieldBegin("reason_id");
				oprot.WriteI32((int)structs.GetReason_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("reason_id can not be null!");
			}
			
			
			if(structs.GetReason() != null) {
				
				oprot.WriteFieldBegin("reason");
				oprot.WriteString(structs.GetReason());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("reason can not be null!");
			}
			
			
			if(structs.GetUser_remark() != null) {
				
				oprot.WriteFieldBegin("user_remark");
				oprot.WriteString(structs.GetUser_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAdmin_remark() != null) {
				
				oprot.WriteFieldBegin("admin_remark");
				oprot.WriteString(structs.GetAdmin_remark());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ReturnApply bean){
			
			
		}
		
	}
	
}