using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.oto{
	
	
	
	public class SpuHealthCheckHelper : TBeanSerializer<SpuHealthCheck>
	{
		
		public static SpuHealthCheckHelper OBJ = new SpuHealthCheckHelper();
		
		public static SpuHealthCheckHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SpuHealthCheck structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("v_spu_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetV_spu_id(value);
					}
					
					
					
					
					
					if ("health_check_percentage".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHealth_check_percentage(value);
					}
					
					
					
					
					
					if ("health_check_detail".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetHealth_check_detail(value);
					}
					
					
					
					
					
					if ("health_check".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetHealth_check(value);
					}
					
					
					
					
					
					if ("riskLevel".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetRiskLevel(value);
					}
					
					
					
					
					
					if ("error_code_message".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.oto.ErrorCodeMessage value;
						
						value = new com.vip.vop.cup.api.oto.ErrorCodeMessage();
						com.vip.vop.cup.api.oto.ErrorCodeMessageHelper.getInstance().Read(value, iprot);
						
						structs.SetError_code_message(value);
					}
					
					
					
					
					
					if ("health_check_detail_list".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.oto.HealthCheckDetail> value;
						
						value = new List<com.vip.vop.cup.api.oto.HealthCheckDetail>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.oto.HealthCheckDetail elem1;
								
								elem1 = new com.vip.vop.cup.api.oto.HealthCheckDetail();
								com.vip.vop.cup.api.oto.HealthCheckDetailHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetHealth_check_detail_list(value);
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
		
		
		public void Write(SpuHealthCheck structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetV_spu_id() != null) {
				
				oprot.WriteFieldBegin("v_spu_id");
				oprot.WriteI64((long)structs.GetV_spu_id()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHealth_check_percentage() != null) {
				
				oprot.WriteFieldBegin("health_check_percentage");
				oprot.WriteString(structs.GetHealth_check_percentage());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHealth_check_detail() != null) {
				
				oprot.WriteFieldBegin("health_check_detail");
				oprot.WriteString(structs.GetHealth_check_detail());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHealth_check() != null) {
				
				oprot.WriteFieldBegin("health_check");
				oprot.WriteI32((int)structs.GetHealth_check()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRiskLevel() != null) {
				
				oprot.WriteFieldBegin("riskLevel");
				oprot.WriteI32((int)structs.GetRiskLevel()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetError_code_message() != null) {
				
				oprot.WriteFieldBegin("error_code_message");
				
				com.vip.vop.cup.api.oto.ErrorCodeMessageHelper.getInstance().Write(structs.GetError_code_message(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetHealth_check_detail_list() != null) {
				
				oprot.WriteFieldBegin("health_check_detail_list");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.oto.HealthCheckDetail _item0 in structs.GetHealth_check_detail_list()){
					
					
					com.vip.vop.cup.api.oto.HealthCheckDetailHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SpuHealthCheck bean){
			
			
		}
		
	}
	
}