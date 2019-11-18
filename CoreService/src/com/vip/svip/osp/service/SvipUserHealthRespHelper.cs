using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipUserHealthRespHelper : TBeanSerializer<SvipUserHealthResp>
	{
		
		public static SvipUserHealthRespHelper OBJ = new SvipUserHealthRespHelper();
		
		public static SvipUserHealthRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipUserHealthResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("highRiskSVIP".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHighRiskSVIP(value);
					}
					
					
					
					
					
					if ("hasHealthScore".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetHasHealthScore(value);
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
		
		
		public void Write(SvipUserHealthResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetHighRiskSVIP() != null) {
				
				oprot.WriteFieldBegin("highRiskSVIP");
				oprot.WriteBool((bool)structs.GetHighRiskSVIP());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("highRiskSVIP can not be null!");
			}
			
			
			if(structs.GetHasHealthScore() != null) {
				
				oprot.WriteFieldBegin("hasHealthScore");
				oprot.WriteBool((bool)structs.GetHasHealthScore());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("hasHealthScore can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipUserHealthResp bean){
			
			
		}
		
	}
	
}