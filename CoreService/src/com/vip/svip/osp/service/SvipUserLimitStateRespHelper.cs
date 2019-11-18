using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipUserLimitStateRespHelper : TBeanSerializer<SvipUserLimitStateResp>
	{
		
		public static SvipUserLimitStateRespHelper OBJ = new SvipUserLimitStateRespHelper();
		
		public static SvipUserLimitStateRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipUserLimitStateResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("formal".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.svip.osp.service.BaseResult value;
						
						value = new com.vip.svip.osp.service.BaseResult();
						com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
						
						structs.SetFormal(value);
					}
					
					
					
					
					
					if ("trial".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.svip.osp.service.BaseResult value;
						
						value = new com.vip.svip.osp.service.BaseResult();
						com.vip.svip.osp.service.BaseResultHelper.getInstance().Read(value, iprot);
						
						structs.SetTrial(value);
					}
					
					
					
					
					
					if ("userLv".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUserLv(value);
					}
					
					
					
					
					
					if ("userStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUserStatus(value);
					}
					
					
					
					
					
					if ("remainingDays".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRemainingDays(value);
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
		
		
		public void Write(SvipUserLimitStateResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetFormal() != null) {
				
				oprot.WriteFieldBegin("formal");
				
				com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetFormal(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTrial() != null) {
				
				oprot.WriteFieldBegin("trial");
				
				com.vip.svip.osp.service.BaseResultHelper.getInstance().Write(structs.GetTrial(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserLv() != null) {
				
				oprot.WriteFieldBegin("userLv");
				oprot.WriteString(structs.GetUserLv());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserStatus() != null) {
				
				oprot.WriteFieldBegin("userStatus");
				oprot.WriteI32((int)structs.GetUserStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("userStatus can not be null!");
			}
			
			
			if(structs.GetRemainingDays() != null) {
				
				oprot.WriteFieldBegin("remainingDays");
				oprot.WriteI32((int)structs.GetRemainingDays()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("remainingDays can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipUserLimitStateResp bean){
			
			
		}
		
	}
	
}