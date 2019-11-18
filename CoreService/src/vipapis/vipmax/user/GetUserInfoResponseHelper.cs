using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.user{
	
	
	
	public class GetUserInfoResponseHelper : TBeanSerializer<GetUserInfoResponse>
	{
		
		public static GetUserInfoResponseHelper OBJ = new GetUserInfoResponseHelper();
		
		public static GetUserInfoResponseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetUserInfoResponse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("open_uid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOpen_uid(value);
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
		
		
		public void Write(GetUserInfoResponse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOpen_uid() != null) {
				
				oprot.WriteFieldBegin("open_uid");
				oprot.WriteString(structs.GetOpen_uid());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetUserInfoResponse bean){
			
			
		}
		
	}
	
}