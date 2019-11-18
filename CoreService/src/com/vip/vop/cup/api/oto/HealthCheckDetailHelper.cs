using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.oto{
	
	
	
	public class HealthCheckDetailHelper : TBeanSerializer<HealthCheckDetail>
	{
		
		public static HealthCheckDetailHelper OBJ = new HealthCheckDetailHelper();
		
		public static HealthCheckDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(HealthCheckDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("health_check_class".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHealth_check_class(value);
					}
					
					
					
					
					
					if ("health_check_detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHealth_check_detail(value);
					}
					
					
					
					
					
					if ("org_health_check_detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrg_health_check_detail(value);
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
		
		
		public void Write(HealthCheckDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI32((int)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHealth_check_class() != null) {
				
				oprot.WriteFieldBegin("health_check_class");
				oprot.WriteString(structs.GetHealth_check_class());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHealth_check_detail() != null) {
				
				oprot.WriteFieldBegin("health_check_detail");
				oprot.WriteString(structs.GetHealth_check_detail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOrg_health_check_detail() != null) {
				
				oprot.WriteFieldBegin("org_health_check_detail");
				oprot.WriteString(structs.GetOrg_health_check_detail());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(HealthCheckDetail bean){
			
			
		}
		
	}
	
}