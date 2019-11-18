using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.order{
	
	
	
	public class OfficialMemberHelper : TBeanSerializer<OfficialMember>
	{
		
		public static OfficialMemberHelper OBJ = new OfficialMemberHelper();
		
		public static OfficialMemberHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OfficialMember structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("memberId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetMemberId(value);
					}
					
					
					
					
					
					if ("account".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAccount(value);
					}
					
					
					
					
					
					if ("customerGroup".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCustomerGroup(value);
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
		
		
		public void Write(OfficialMember structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMemberId() != null) {
				
				oprot.WriteFieldBegin("memberId");
				oprot.WriteString(structs.GetMemberId());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAccount() != null) {
				
				oprot.WriteFieldBegin("account");
				oprot.WriteString(structs.GetAccount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCustomerGroup() != null) {
				
				oprot.WriteFieldBegin("customerGroup");
				oprot.WriteString(structs.GetCustomerGroup());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OfficialMember bean){
			
			
		}
		
	}
	
}