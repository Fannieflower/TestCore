using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipUserOperateSignCheckHelper : TBeanSerializer<SvipUserOperateSignCheck>
	{
		
		public static SvipUserOperateSignCheckHelper OBJ = new SvipUserOperateSignCheckHelper();
		
		public static SvipUserOperateSignCheckHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipUserOperateSignCheck structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("appKey".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAppKey(value);
					}
					
					
					
					
					
					if ("sign".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSign(value);
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
		
		
		public void Write(SvipUserOperateSignCheck structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetAppKey() != null) {
				
				oprot.WriteFieldBegin("appKey");
				oprot.WriteString(structs.GetAppKey());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSign() != null) {
				
				oprot.WriteFieldBegin("sign");
				oprot.WriteString(structs.GetSign());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipUserOperateSignCheck bean){
			
			
		}
		
	}
	
}