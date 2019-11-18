using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class CheckCaptchaParamHelper : TBeanSerializer<CheckCaptchaParam>
	{
		
		public static CheckCaptchaParamHelper OBJ = new CheckCaptchaParamHelper();
		
		public static CheckCaptchaParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CheckCaptchaParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("captchaCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCaptchaCode(value);
					}
					
					
					
					
					
					if ("captchaType".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte value;
						value = iprot.ReadByte(); 
						
						structs.SetCaptchaType(value);
					}
					
					
					
					
					
					if ("ip".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetIp(value);
					}
					
					
					
					
					
					if ("cid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCid(value);
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
		
		
		public void Write(CheckCaptchaParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCaptchaCode() != null) {
				
				oprot.WriteFieldBegin("captchaCode");
				oprot.WriteString(structs.GetCaptchaCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("captchaCode can not be null!");
			}
			
			
			if(structs.GetCaptchaType() != null) {
				
				oprot.WriteFieldBegin("captchaType");
				oprot.WriteByte((byte)structs.GetCaptchaType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("captchaType can not be null!");
			}
			
			
			if(structs.GetIp() != null) {
				
				oprot.WriteFieldBegin("ip");
				oprot.WriteString(structs.GetIp());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("ip can not be null!");
			}
			
			
			if(structs.GetCid() != null) {
				
				oprot.WriteFieldBegin("cid");
				oprot.WriteString(structs.GetCid());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CheckCaptchaParam bean){
			
			
		}
		
	}
	
}