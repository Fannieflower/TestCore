using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GetSvipInfo4AppClubResultHelper : TBeanSerializer<GetSvipInfo4AppClubResult>
	{
		
		public static GetSvipInfo4AppClubResultHelper OBJ = new GetSvipInfo4AppClubResultHelper();
		
		public static GetSvipInfo4AppClubResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetSvipInfo4AppClubResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("limit".Equals(schemeField.Trim())){
						
						needSkip = false;
						bool value;
						value = iprot.ReadBool();
						
						structs.SetLimit(value);
					}
					
					
					
					
					
					if ("limitCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetLimitCode(value);
					}
					
					
					
					
					
					if ("limitMsg".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetLimitMsg(value);
					}
					
					
					
					
					
					if ("userStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetUserStatus(value);
					}
					
					
					
					
					
					if ("expireTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetExpireTime(value);
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
		
		
		public void Write(GetSvipInfo4AppClubResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetLimit() != null) {
				
				oprot.WriteFieldBegin("limit");
				oprot.WriteBool((bool)structs.GetLimit());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("limit can not be null!");
			}
			
			
			if(structs.GetLimitCode() != null) {
				
				oprot.WriteFieldBegin("limitCode");
				oprot.WriteI32((int)structs.GetLimitCode()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("limitCode can not be null!");
			}
			
			
			if(structs.GetLimitMsg() != null) {
				
				oprot.WriteFieldBegin("limitMsg");
				oprot.WriteString(structs.GetLimitMsg());
				
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
			
			
			if(structs.GetExpireTime() != null) {
				
				oprot.WriteFieldBegin("expireTime");
				oprot.WriteI64((long)structs.GetExpireTime()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("expireTime can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetSvipInfo4AppClubResult bean){
			
			
		}
		
	}
	
}